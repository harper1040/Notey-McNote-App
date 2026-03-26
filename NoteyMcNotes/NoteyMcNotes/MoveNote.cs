using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteyMcNotes
{
    public partial class MoveNote : Form
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string NoteGuid { get; set; }
        public MoveNote(string name, string category, string noteGuid)
        {
            Name = name;
            Category = category;
            NoteGuid = noteGuid;
            InitializeComponent();
            textBoxCurNote.Text = Name;
            textBoxCurCat.Text = Category;
            foreach (CategoryClass cat in CategoryClass.Categories)
            {
                comboBoxNewCat.Items.Add(cat.Name);
            }
        }
        /// <summary>
        /// This window allows the user to pick a new category to move their note to.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            List<NoteClass> NewNoteCat = new List<NoteClass>();
            if(comboBoxNewCat.SelectedIndex != -1)
            {
                var NewCat = "";
                foreach(CategoryClass cat in CategoryClass.Categories)
                {
                    if(comboBoxNewCat.Text == cat.Name)
                    {
                        NewCat = cat.CatGuid;
                    }
                }
                foreach (NoteClass note in NoteClass.Notes)
                {
                    if (note.NoteGuid == NoteGuid)
                    {
                        note.Category = comboBoxNewCat.SelectedItem.ToString();
                        if (UserClass.User.Count > 0)
                        {
                            SQLiteConnection noteDB = dbconnect.GetConnection();
                            SQLiteCommand dbCommand;
                            string sql = "";


                            sql = $"UPDATE Notes SET CategoryID = '{NewCat}' WHERE ID = '{note.NoteGuid}'";
                            dbCommand = new SQLiteCommand(sql, noteDB);
                            dbCommand.ExecuteNonQuery();


                        }
                    }
                }
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Select a New Category!", "None", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
