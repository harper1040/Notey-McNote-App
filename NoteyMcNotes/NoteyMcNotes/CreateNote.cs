using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteyMcNotes
{
    public partial class CreateNote : Form
    {
        public bool Edit = false;
        public int Index = 0;
        /// <summary>
        /// This is the window to create notes. It has two overloads one for new notes and one for the editing of notes.
        /// </summary>
        public CreateNote()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This overload is for the editing of notes. It takes in the name, category, and note and allows the user to 
        /// make whatever changes are needed.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="note"></param>
        public CreateNote(string name, string category, string note)
        {
            foreach(var item in NoteClass.Notes)
            {
                if(item.Name == name)
                {
                    break;
                }
                Index += 1;
            }
            InitializeComponent();
            Edit = true;
            textBoxName.Text = name;
            textBoxNote.Text = note;
            
            comboBoxCat.SelectedValue = category;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// The save button saves the notes to the note list as well as the database when a user is logged in.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            int checks = 0;
            int nameCheckIndex = 0;

            if (NoteClass.Notes.Count > 0)
            {
                foreach (NoteClass nameNote in NoteClass.Notes)
                {

                    if (nameNote.Name == textBoxName.Text && nameCheckIndex != Index)
                    {
                        MessageBox.Show("This Note name already exists! Please choose a unique name!", "Already There", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                    else
                    {
                        checks += 1;
                    }

                }
            }
            else
            {
                checks += 1;

            }
            SQLiteConnection noteDB = dbconnect.GetConnection();
            SQLiteCommand dbCommand;
            string sql = "";
            string CatID = "";
            foreach (CategoryClass item in CategoryClass.Categories)
            {
                if (item.Name == comboBoxCat.Text)
                {
                    CatID = item.CatGuid;
                }
            }
            Debug.WriteLine($"This catty {CatID}");
            if (checks > 0 && Edit == false)
            {
                NoteClass note = new NoteClass(textBoxName.Text, comboBoxCat.Text, textBoxNote.Text);
                NoteClass.Notes.Add(note);

                if (UserClass.User.Count > 0)
                {
                    sql = $"INSERT INTO Notes VALUES('{note.NoteGuid}', '{note.Name}', '{CatID}', '{note.Note}', '{note.Date}', '{UserClass.User[0].UserId}')";
                    dbCommand = new SQLiteCommand(sql, noteDB);
                    dbCommand.ExecuteNonQuery();
                }
                this.Close();
            }
            else if (checks > 0 && Edit == true)
            {
                if (UserClass.User.Count > 0)
                {
                    sql = $"SELECT * FROM Notes WHERE ID = '{NoteClass.Notes[Index].NoteGuid}'";
                    dbCommand = new SQLiteCommand(sql, noteDB);
                    SQLiteDataReader reader = dbCommand.ExecuteReader();
                    if (reader.Read())
                    {

                        sql = $"UPDATE Notes SET Name = '{NoteClass.Notes[Index].Name}', CategoryID = '{CatID}', Note = '{NoteClass.Notes[Index].Note}' WHERE ID = '{NoteClass.Notes[Index].NoteGuid}'";
                        dbCommand = new SQLiteCommand(sql, noteDB);
                        reader = dbCommand.ExecuteReader();
                    }
                }

                NoteClass.Notes[Index].Name = textBoxName.Text;
                NoteClass.Notes[Index].Category = comboBoxCat.Text;
                NoteClass.Notes[Index].Note = textBoxNote.Text;
                this.Close();
                Edit = false;
            }
            
                   
        }

        private void CreateNote_Load(object sender, EventArgs e)
        {
            foreach(CategoryClass item in CategoryClass.Categories)
            {
                comboBoxCat.Items.Add(item.Name);
            }
        }
    }
}
