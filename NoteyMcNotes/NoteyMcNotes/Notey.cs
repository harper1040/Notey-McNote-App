using CsvHelper;
using System.Data.Common;
using System.Data.SQLite;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace NoteyMcNotes
{
    /// <summary>
    /// Welcome to the NoteyMcNotes app. 
    /// </summary>
    public partial class Notey : Form
    {

        public Notey()
        {
            //Check on existance on DB and/or create it.
            //Check_User();

            InitializeComponent();

        }
        /// <summary>
        /// This verifies that tables exist and start the base category.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Notey_Load(object sender, EventArgs e)
        {
            //User_Setting();
            Verify_Tables();
            CategoryClass defCat = new CategoryClass("Uncategorized");
            CategoryClass.Categories.Add(defCat);
            Fill_Category();
        }
        /// <summary>
        /// Here we check to see if the user is signing in. It launches the userLogin window which allows someone
        /// to log in or sign up. After that if a user is signed in it sets up the user settings.
        /// </summary>
        private void Check_User()
        {
            if (UserClass.User.Count == 0)
            {
                userLogin user = new userLogin();
                user.ShowDialog();
                if (UserClass.User.Count > 0)
                {
                    User_Setting();
                }
            }
            else
            {
                Debug.WriteLine("No");
                //Open a Dashboard Dialog
            }

        }
        /// <summary>
        /// This is the actual function that verifies the tables exist. It runs 3 queries to create the tables if they dont'
        /// exist already. It creates the user, Notes, and category tables.
        /// </summary>
        public void Verify_Tables()
        {
            SQLiteConnection noteDB = dbconnect.GetConnection();
            SQLiteCommand dbCommand;
            string sql = "";
            //Create table for Users
            sql = "CREATE TABLE IF NOT EXISTS Users(ID VARCHAR(40), UserName VARCHAR(30), PassHash VARCHAR(70), Setting VARCHAR(50))";
            dbCommand = new SQLiteCommand(sql, noteDB);
            dbCommand.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS Notes(ID VARCHAR(40), Name VARCHAR(30), CategoryID VARCHAR(40), Note VARCHAR(255), DateTime text, UserID VARCHAR(40))";
            dbCommand = new SQLiteCommand(sql, noteDB);
            dbCommand.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS Category(ID VARCHAR(40), Name VARCHAR(30))";
            dbCommand = new SQLiteCommand(sql, noteDB);
            dbCommand.ExecuteNonQuery();

            sql = $"SELECT * FROM Category WHERE ID = '0'";
            dbCommand = new SQLiteCommand(sql, noteDB);
            SQLiteDataReader reader = dbCommand.ExecuteReader();
            if (!reader.Read())
            {
                sql = $"INSERT INTO Category VALUES('0', 'Uncategorized')";
                dbCommand = new SQLiteCommand(sql, noteDB);
                dbCommand.ExecuteNonQuery();
            }
        }


        /// <summary>
        /// User settings is used to import any notes someone may have in there database. It would have also set the
        /// color mode option if i had gotten that far.
        /// </summary>
        private void User_Setting()
        {
            string name = UserClass.User[0].UserName;
            this.LoginItem.Text = name;
            CategoryClass.Categories.Clear();
            NoteClass.Notes.Clear();
            CategoryClass.Fill_Category();
            NoteClass.Load_Notes();
            listCategory.Items.Clear();
            Fill_Category();

            //Search database by user name then search for other variables and plug them into fields.
        }
        /// <summary>
        /// This launchs the CatAdd window which lets a user create a new category. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCat_Click(object sender, EventArgs e)
        {
            int CatLen = CategoryClass.Categories.Count;
            CatAdd cat = new CatAdd();
            DialogResult finalCat = cat.ShowDialog();
            if (CatLen < CategoryClass.Categories.Count)
            {
                listCategory.Items.Add(CategoryClass.Categories.Last().Name);
            }

        }
        /// <summary>
        /// This deletes a category by launching the DeleteCategory window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteCat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(listCategory.Text))
            {
                if (listCategory.SelectedItem.ToString() == "Uncategorized")
                {
                    MessageBox.Show("You cannot delete this category!", "No", MessageBoxButtons.OK);

                }
                else
                {

                    DeleteCategory DelCat = new DeleteCategory(listCategory.SelectedIndex);
                    DelCat.ShowDialog();
                    Debug.WriteLine(NoteClass.Notes.Count());

                    //Remove From DB
                }
                listNotes.Items.Clear();
                listCategory.Items.Clear();
                textBoxCat.Clear();
                textContent.Clear();
                textName.Clear();
                Fill_Category();

            }
        }
        /// <summary>
        /// Opens the CreateNote window to allow the user to make a new note.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewNote_Click(object sender, EventArgs e)
        {
            CreateNote note = new CreateNote();
            note.ShowDialog();
        }
        /// <summary>
        /// FillNotes is overloaded to fill in notes when a user clicks on a category. The second version fills
        /// in notes based on the sort control.
        /// </summary>
        private void Fill_Notes()
        {
            listNotes.Items.Clear();
            textBoxCat.Clear();
            textContent.Clear();
            textName.Clear();

            if (NoteClass.Notes.Count > 0)
            {
                foreach (NoteClass note in NoteClass.Notes)
                {
                    Debug.WriteLine($"a Note category {note.Category}");
                    if (listCategory.SelectedItem != null && note.Category == listCategory.SelectedItem.ToString())
                    {
                        listNotes.Items.Add(note.Name + "  " + note.Date);
                    }
                }
            }
        }
        /// <summary>
        /// Fills in notes base on the option selected by the sort list.
        /// </summary>
        /// <param name="order"></param>
        /// Either ASC ascending or DESC descending order.
        private void Fill_Notes(string order)
        {
            listNotes.Items.Clear();
            textBoxCat.Clear();
            textContent.Clear();
            textName.Clear();
            List<NoteClass> OrderNotes = new List<NoteClass>();

            if (NoteClass.Notes.Count > 0 && listCategory.SelectedIndex != -1)
            {
                foreach (NoteClass note in NoteClass.Notes)
                {
                    if (note.Category == listCategory.SelectedItem.ToString())
                    {
                        OrderNotes.Add(note);
                    }
                }
                if (order == "Date Asc")
                {
                    Debug.WriteLine(order + " Work");
                    var sortedList = OrderNotes.OrderBy(item => item.Date);
                    foreach (NoteClass note in sortedList)
                    {
                        listNotes.Items.Add(note.Name + "  " + note.Date);

                    }
                }
                else
                {
                    var sortedList = OrderNotes.OrderByDescending(e => e.Date);
                    //OrderNotes.Reverse();
                    //var sortedList = OrderNotes.OrderBy(item => item.DateTime).ToList();
                    foreach (NoteClass note in sortedList)
                    {
                        listNotes.Items.Add(note.Name + "  " + note.Date);

                    }
                }
            }
        }
        /// <summary>
        /// This fills in the category list. Whenever changes are made, adds or deletes, this is called to update the
        /// list of choosable categories.
        /// </summary>
        private void Fill_Category()
        {
            if (CategoryClass.Categories.Count > 0)
            {
                foreach (CategoryClass cat in CategoryClass.Categories)
                {
                    listCategory.Items.Add(cat.Name);
                }
            }
        }
        /// <summary>
        /// Calls FillNotes when a category gets clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Fill_Notes();
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
        }
        /// <summary>
        /// This populates the larger area with all the note information when the user selects a note from the note list,
        /// so the note can be read.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(listNotes.SelectedItem);
            try
            {
                foreach (NoteClass note in NoteClass.Notes)
                {
                    if (listNotes.SelectedItem != null)
                    {
                        if (note.Name + "  " + note.Date == listNotes.SelectedItem.ToString())
                        {
                            Debug.WriteLine(note.NoteGuid);
                            textContent.Text = note.Note;
                            textName.Text = note.Name;
                            textBoxCat.Text = note.Category;
                        }
                        else { Debug.WriteLine("Fuck a null!"); }
                    }
                }
            }
            catch (Exception error)
            {
                Debug.WriteLine(error.Message);
            }

        }
        /// <summary>
        /// This opens MoveNote window to allow the selected note to be moved to a different category.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveTo_Click(object sender, EventArgs e)
        {

            foreach (NoteClass note in NoteClass.Notes)
            {
                if (note.Name + "  " + note.Date == listNotes.SelectedItem.ToString())
                {
                    MoveNote MNoteSchyamalnn = new MoveNote(note.Name, note.Category, note.NoteGuid);
                    MNoteSchyamalnn.ShowDialog();
                    Fill_Notes();
                    //DB Remove
                }
            }


        }
        /// <summary>
        /// This will delte a selected note.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteNote_Click(object sender, EventArgs e)
        {
            DialogResult delCheck = MessageBox.Show("Are you sure you want to delete this Note?", "Really", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (delCheck == DialogResult.Yes)
            {
                List<NoteClass> DelNote = new List<NoteClass>();
                foreach (NoteClass note in NoteClass.Notes)
                {
                    if (note.Name + "  " + note.Date == listNotes.SelectedItem.ToString())
                    {
                        DelNote.Add(note);
                        //DB Remove
                    }
                }
                NoteClass.Notes.Remove(DelNote[0]);
                listNotes.Items.Clear();

                if (UserClass.User.Count > 0)
                {
                    SQLiteConnection noteDB = dbconnect.GetConnection();
                    SQLiteCommand dbCommand;
                    string sql = "";

                    try
                    {
                        sql = $"DELETE FROM Notes WHERE ID = {DelNote[0].NoteGuid}";
                        dbCommand = new SQLiteCommand(sql, noteDB);
                        dbCommand.ExecuteNonQuery();


                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                }
            }
        }
        /// <summary>
        /// This is the pulldown sort menu that allows the notes to be sorted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSort.SelectedItem.ToString() == "Date Asc")//Desc
            {
                Fill_Notes(comboSort.SelectedItem.ToString());
            }
            else
            {
                Fill_Notes(comboSort.SelectedItem.ToString());
            }
        }
        /// <summary>
        /// This opens an overloaded CreateNote window which takes the current note information and populates the window.
        /// The user can then go in and make changes and then save the note.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNote_Click(object sender, EventArgs e)
        {
            if (listCategory.SelectedIndex != -1 && listNotes.SelectedIndex != -1)
            {
                CreateNote editNote = new CreateNote(textName.Text, textBoxCat.Text, textContent.Text);
                editNote.Text = "Edit Note";
                editNote.ShowDialog();
                Fill_Notes();
            }
        }
        /// <summary>
        /// This is a debug button used to show all the notes in the list. It was used when working with the delete and
        /// database features to see what wasn't working. It should be invisible in final run.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShow_Click(object sender, EventArgs e)
        {
            listNotes.Items.Clear();
            if (NoteClass.Notes.Count > 0)
            {
                foreach (NoteClass note in NoteClass.Notes)
                {

                    listNotes.Items.Add(note.Name + "  " + note.Date);

                }
            }
            else
            {
                listNotes.Items.Add("No Notes At This Time!");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewNote_Click(sender, e);
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCat_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information about = new Information();
            about.ShowDialog();
        }
        /// <summary>
        /// This is the login function. If a user is logged in it will launch the Dashboard window. If noone is logged in
        /// it will run Check User which launches the userLogin window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginItem_Click(object sender, EventArgs e)
        {
            if (UserClass.User.Count > 0)
            {
                Dashboard UDB = new Dashboard();
                UDB.ShowDialog();
                this.LoginItem.Text = "Login";
                Fill_Category();
            }
            else
            {
                DialogResult login = MessageBox.Show("Logging in or signing up will clear current notes. Would yolu like to procede?", "Bye Bye Notey", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (login == DialogResult.Yes)
                {
                    Check_User();
                }
            }

        }
        /// <summary>
        /// This imports a csv.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportCSV_Click(object sender, EventArgs e)
        {
            //imprt csv, create category from, create notes, fill category
            OpenFileDialog ofd = new();
            DialogResult file = ofd.ShowDialog();
            try
            {
                string[] lines = File.ReadAllLines(ofd.FileName);
                
                int header = 0;
                foreach (string line in lines)
                {
                    int count = 0;
                    string[] value = line.Split(",");
                    //Name, Category, Note
                    if (value.Length == 3)
                    {
                        if (checkBoxHeader.Checked && header == 0)
                        {
                           
                        }
                        else
                        {
                            NoteClass noteGen = new NoteClass(value[0], value[1], value[2]);
                            NoteClass.Notes.Add(noteGen);
                            foreach (CategoryClass item in CategoryClass.Categories)
                            {
                                if (item.Name == noteGen.Name)
                                {
                                    //noteGen.NoteGuid = item.CatGuid;
                                    Debug.WriteLine($"Threes");
                                    count++;
                                }
                            }
                            if (count == 0)
                            {
                                CategoryClass cat = new CategoryClass(noteGen.Name);
                                CategoryClass.Categories.Add(cat);
                            }
                        }
                    }
                    else if (value.Length == 5)
                    {
                        if (checkBoxHeader.Checked && header == 0)
                        {
                            Debug.WriteLine("Passed");
                        }
                        else
                        {
                            //Id, Name, Note, Category, Date
                            
                            NoteClass noteUp = new NoteClass(value[0], value[1], value[2], value[3], value[4], true);
                            NoteClass.Notes.Add(noteUp);
                            foreach (CategoryClass item in CategoryClass.Categories)
                            {
                                Debug.WriteLine($"In cat {noteUp.Category},{item.Name} ");
                                if (item.Name == noteUp.Category)
                                {
                                    
                                    //noteUp.NoteGuid = item.CatGuid;
                                    count+=1;
                                }
                            }
                            if (count == 0)
                            {
                                Debug.WriteLine(noteUp.Category);
                                CategoryClass cat = new CategoryClass(noteUp.Category);
                                CategoryClass.Categories.Add(cat);
                            }
                        }
                    }
                    else
                    { 
                        MessageBox.Show("Your file seems to have an odd number of columns make sure it is set up correctly.", "Count Better", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    header += 1;

                }
                
            }
            catch (ArgumentException)
            {
                DialogResult NoFile = MessageBox.Show("You need to selet a file to use the viewer.", "No File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            listCategory.Items.Clear();
            Fill_Category();
            if(UserClass.User.Count > 0)
            {
                SQLiteConnection noteDB = dbconnect.GetConnection();
                SQLiteCommand dbCommand;
                string sql = "";

                sql = $"SELECT * FROM Notes";
                dbCommand = new SQLiteCommand(sql, noteDB);
                SQLiteDataReader reader = dbCommand.ExecuteReader();
                if (reader.Read())
                {
                    NoteClass note = new NoteClass(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
                    if (!NoteClass.Notes.Contains(note))
                    {
                        string catID = "";
                        foreach(var item in CategoryClass.Categories)
                        {
                            if(item.Name == note.Name)
                            {
                                catID = item.CatGuid;
                            }

                        }
                        sql = $"INSERT INTO Notes VALUES('{note.NoteGuid}', '{note.Name}', '{catID}', '{note.Note}', '{note.Date}', '{UserClass.User[0].UserId}')";
                        dbCommand = new SQLiteCommand(sql, noteDB);
                        dbCommand.ExecuteNonQuery();
                    }
                    
                }
            }

        }
        /// <summary>
        /// This exports a csv.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdlg = new();
            sfdlg.Filter = "Data Files (*.csv)|*.csv";
            sfdlg.DefaultExt = "csv";
            DialogResult dr = sfdlg.ShowDialog();

            if (dr == DialogResult.OK)
            {
                using (var writer = new StreamWriter(sfdlg.FileName, false, Encoding.UTF8))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(NoteClass.Notes);
                }
                

            }
        }
    }
}
