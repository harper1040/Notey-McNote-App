using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NoteyMcNotes
{
    [DataContract]
    internal class NoteClass
    {
        [DataMember]
        public string NoteGuid { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public string Note { get; set; }
        [DataMember]
        public string Date { get; set; }
        [DataMember]
        public static List<NoteClass> Notes = new List<NoteClass>();
        /// <summary>
        /// The note class is where the note objects are created. The Note Class is overloaded to help with new notes and 
        /// reaccuring ones. This first method generates the date and id for new notes.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="note"></param>
        public NoteClass(string name, string category, string note)
        {
            Name = name;
            Category = category;
            Note = note;
            NoteGuid = Guid.NewGuid().ToString();
            DateTime date = DateTime.Now;
            Date = date.ToString();
        }
        /// <summary>
        /// This overload takes 5 arguments which are all the note's data points minus the User ID. This is used to reintroduce
        /// notes that already exist and where in the users database. The database notes have a unique of the category and those 
        /// get converted to the category name here, because of this the category should be filled in first.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="note"></param>
        /// <param name="date"></param>
        public NoteClass(string id, string name, string category, string note, string date)
        {
            Name = name;
            Note = note;
            NoteGuid = id;
            Date = date;
            if (category == "Uncategorized")
            {
                Category = category;
            }
            else
            {
                foreach (CategoryClass c in CategoryClass.Categories)
                {
                    if (c.CatGuid == category)
                    {
                        Category = c.Name;
                    }

                }

            }
        }
        /// <summary>
        /// This final overload with 6 arguments is for loading from CSVs. The data should be a 1 to 1 upload. The sixth argument
        /// is an import bool and at this time is only there to allow this thrid overload.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="note"></param>
        /// <param name="date"></param>
        /// <param name="import"></param>
        public NoteClass(string id, string name, string category, string note, string date, bool import)
        {
            Name = name;
            Note = note;
            NoteGuid = id;
            Date = date;
            Category = category;

        }
        /// <summary>
        /// This deletes notes from the note list.
        /// </summary>
        /// <param name="indices"></param>
        public static void Delete_Notes(List<int> indices)
        {
            for (int i = 0; i < indices.Count - 1; i++)
            {
                indices.Reverse();
                Debug.WriteLine(Notes[indices[i]].Name);
                Notes.RemoveAt(indices[i]);
            }
        }
        /// <summary>
        /// This loads up the notes from a user's database.
        /// </summary>
        public static void Load_Notes()
        {
            try
            {
                SQLiteConnection noteDB = dbconnect.GetConnection();
                SQLiteCommand dbCommand;
                string sql = "";

                sql = $"SELECT * FROM Notes WHERE UserID = '{UserClass.User[0].UserId}'";
                dbCommand = new SQLiteCommand(sql, noteDB);
                SQLiteDataReader reader = dbCommand.ExecuteReader();
                while (reader.Read())
                {
                    NoteClass ntoe = new NoteClass(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
                    if (!Notes.Contains(ntoe))
                    {
                        Notes.Add(ntoe);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
