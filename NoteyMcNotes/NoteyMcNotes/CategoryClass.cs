using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteyMcNotes
{
    
    internal class CategoryClass
    {
        public string Name { get; set; }
        public string CatGuid { get; set; }
        public static List<CategoryClass> Categories = new List<CategoryClass>();
        /// <summary>
        /// The category class has two overloads for new and existing categories.
        /// </summary>
        /// <param name="name"></param>
        public CategoryClass(string name) 
        { 
            Name = name;
            if(name == "Uncategorized")
            {
                CatGuid = "0";
            }
            else
            {
                CatGuid = Guid.NewGuid().ToString();
            }
        }
        /// <summary>
        /// This second overload takes in an existing category and adds it to the category list.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        public CategoryClass(string name, string id)
        {
            Name = name;
            CatGuid = id;
        }
        /// <summary>
        /// This function is used to fill the category list with the categories from the user's database.
        /// </summary>
        public static void Fill_Category()
        {

            var user = UserClass.User[0].UserId;
            List<CategoryClass> fullList = new List<CategoryClass>();
            SQLiteConnection noteDB = dbconnect.GetConnection();
            SQLiteCommand dbCommand;
            string sql = "";

            try
            {
                sql = $"SELECT * FROM Category";
                dbCommand = new SQLiteCommand(sql, noteDB);
                SQLiteDataReader reader = dbCommand.ExecuteReader();
                while (reader.Read())
                {
                    CategoryClass cat = new CategoryClass(reader[1].ToString(), reader[0].ToString());
                    Debug.WriteLine($"{reader[0]}    {reader[1]}");
                    fullList.Add(cat);
                }
            }
            catch(Exception ex)
            { 
                Debug.WriteLine(ex.Message); 
            }

            try
            {//fix!!!!
                sql = $"SELECT * FROM Notes WHERE UserID = '{user}'";
                dbCommand = new SQLiteCommand(sql, noteDB);
                SQLiteDataReader reader1 = dbCommand.ExecuteReader();
                while (reader1.Read())
                {
                    foreach (var item in fullList)
                    {
                        Debug.WriteLine($"{reader1[2]}  catguid {item.CatGuid}");
                        if (item.CatGuid == reader1[2].ToString())
                        {
                            
                            if (!Categories.Contains(item))
                            {
                                Categories.Add(item);
                            }
                        }
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
