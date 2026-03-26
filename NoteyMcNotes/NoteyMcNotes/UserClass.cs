using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NoteyMcNotes
{
    /// <summary>
    /// The UserClass creates the user account.
    /// </summary>
    internal class UserClass
    {
        SQLiteConnection noteDB = dbconnect.GetConnection();
        SQLiteCommand dbCommand;
        string sql = "";
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserId { get; set; }
        public string ColorMode { get; set; }
        public static List<UserClass> User = new List<UserClass>();
        /// <summary>
        /// The constructor is overloaded to work with new users and returning users. This is the first method which
        /// hashes the password and generates a user id.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public UserClass(string username, string password)
        {
            UserName = username;
            Password = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 13);
            UserId = Guid.NewGuid().ToString();

            

            sql = $"INSERT INTO Users VALUES ('{UserId}','{UserName}', '{Password}', 'Base')";
            dbCommand = new SQLiteCommand(sql, noteDB);
            dbCommand.ExecuteNonQuery();
            /*SQLiteDataReader reader2 = dbCommand.ExecuteReader();
            reader2 = dbCommand.ExecuteReader();*/
        }
        /// <summary>
        /// This overload is for the returning user. The User Verify function checks the password hash and calls this
        /// constructor to make the user object logging them in.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="guid"></param>
        public UserClass(string username, string password, string guid)
        {
            UserName = username;
            Password = password;
            UserId = guid;
        }
        /// <summary>
        /// This grabs the user data from the database based on their username and checks the password hash against
        /// the newly input passwords hash. If the hashes match the user is logged in.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool User_Verify(string name, string password)
        {
            SQLiteConnection noteDB = dbconnect.GetConnection();
            SQLiteCommand dbCommand;
            string sql = "";

            sql = $"SELECT * FROM Users WHERE UserName = '{name}'";
            dbCommand = new SQLiteCommand(sql, noteDB);
            SQLiteDataReader reader = dbCommand.ExecuteReader();

            if (reader.Read())
            {
                //var passHash = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 13);
                if(BCrypt.Net.BCrypt.EnhancedVerify(password, reader[2].ToString()))
                {
                    UserClass user = new UserClass(reader[1].ToString(), reader[2].ToString(), reader[0].ToString());
                    user.ColorMode = reader[3].ToString();
                    User.Add(user);
                    return true;
                }

                
            }
            return false;
        }
        /// <summary>
        /// This checks the database to make sure the user name a new user is trying to use isn't taken.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool UserName_Check(string name)
        {
            SQLiteConnection noteDB = dbconnect.GetConnection();
            SQLiteCommand dbCommand;
            string sql = "";
            sql = $"SELECT * FROM Users WHERE UserName = '{name}'";
            dbCommand = new SQLiteCommand(sql, noteDB);
            SQLiteDataReader reader = dbCommand.ExecuteReader();

            if (reader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
