using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteyMcNotes
{
    public partial class DeleteCategory : Form
    {
        public int Index { get; set; }
        public DeleteCategory(int index)
        {
            InitializeComponent();
            Index = index;
            labelCatName.Text = CategoryClass.Categories[Index].Name;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// This is the button to delete a category from the app. This window gives the user the option to delete all the notes
        /// in the category or to move them to uncategorized. Uncategorized, for this reason, cannot be deleted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteCat_Click(object sender, EventArgs e)
        {
            List<NoteClass> NoteAction = new List<NoteClass>();
            List<int> NoteIndy = new List<int>();
            int noteIndex = 0;
            DialogResult delCheck = MessageBox.Show("Are you sure you want to delete this Category?", "Really", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (checkDeleteCat.Checked && delCheck == DialogResult.Yes)
            {
                string CatName = CategoryClass.Categories[Index].Name;
                string CatID = CategoryClass.Categories[Index].CatGuid;
                string NewCatID = "";
                foreach (CategoryClass catitem in CategoryClass.Categories)
                {
                    if (catitem.Name == "Uncategorized")
                    {
                        NewCatID = catitem.CatGuid;
                        break;
                    }
                }
                SQLiteConnection noteDB = dbconnect.GetConnection();
                SQLiteCommand dbCommand;
                string sql = "";
                if (radioDeleteNote.Checked)
                {

                    foreach (var note in NoteClass.Notes)
                    {
                        if (note.Category == CatName)
                        {
                            NoteIndy.Add(noteIndex);
                        }
                        noteIndex += 1;
                    }

                    for (int i = 0; i <= NoteIndy.Count - 1; i++)
                    {

                        NoteClass.Notes.RemoveAt(NoteIndy[i]);
                    }
                    if (UserClass.User.Count > 0)
                    {
                        sql = $"DELETE FROM Notes WHERE CategoryID = '{CatID}'";
                        dbCommand = new SQLiteCommand(sql, noteDB);
                        dbCommand.ExecuteNonQuery();
                    }
                }
                else if (radioMoveNote.Checked)
                {
                    List<CategoryClass> catList = new List<CategoryClass>();

                    foreach (var note in NoteClass.Notes)
                    {
                        if (note.Category == CatName)
                        {
                            NoteIndy.Add(noteIndex);
                        }
                        noteIndex += 1;
                    }

                    for (int i = 0; i <= NoteIndy.Count - 1; i++)
                    {
                        NoteClass.Notes[NoteIndy[i]].Category = "Uncategorized";
                    }
                    if (UserClass.User.Count > 0)
                    {
                        sql = $"SELECT * FROM Notes WHERE CategoryID = '{CatID}'";
                        dbCommand = new SQLiteCommand(sql, noteDB);
                        SQLiteDataReader reader = dbCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            sql = $"UPDATE Notes SET CategoryID = '{NewCatID}' WHERE CategoryID = '{CatID}'";
                            dbCommand = new SQLiteCommand(sql, noteDB);
                            dbCommand.ExecuteNonQuery();
                        }


                        sql = $"DELETE FROM Category WHERE ID = '{CatID}'";
                        dbCommand = new SQLiteCommand(sql, noteDB);
                        dbCommand.ExecuteNonQuery();
                        
                    }
                    
                }
                CategoryClass.Categories.RemoveAt(Index);
                this.Close();
            }
            else
            {

            }
        }

        private void checkDeleteCat_CheckedChanged(object sender, EventArgs e)
        {
            groupRadios.Enabled = checkDeleteCat.Checked;
            
        }
    }
}
