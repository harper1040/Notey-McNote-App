using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteyMcNotes
{
    /// <summary>
    /// This allows us to connect to our database.
    /// </summary>
    internal class dbconnect
    {
        private static SQLiteConnection? _connection;
        private static String _dbName = "noteDB.sqlite";
        public static SQLiteConnection GetConnection()
        {
            if (!File.Exists(_dbName))
            {
                SQLiteConnection.CreateFile(_dbName);
            }
            if (_connection == null)
            {
                _connection = new SQLiteConnection("Data Source=" + _dbName + ";Version=3; MultipleActiveResultSets=True;");
            }
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            return _connection;
        }
    }
}
