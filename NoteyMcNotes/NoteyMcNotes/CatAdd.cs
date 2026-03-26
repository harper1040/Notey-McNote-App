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
    public partial class CatAdd : Form
    {
        public string Category;
        public CatAdd()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                this.buttonAddCat_Click(sender, e);
            }

        }


        /// <summary>
        /// This button checks the category name against the list and then sends the category to be made. It then places the
        /// category in the list and the databasr if a user is logged in.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonAddCat_Click(object sender, EventArgs e)
        {
            int check = 0;
            foreach (CategoryClass item in CategoryClass.Categories)
            {
                if (item.Name == textCat.Text)
                {
                    check += 1;
                    
                }

            }
            if (check == 0)
            {
                CategoryClass cat = new CategoryClass(textCat.Text);
                CategoryClass.Categories.Add(cat);
                if (UserClass.User.Count > 0)
                {
                    SQLiteConnection noteDB = dbconnect.GetConnection();
                    SQLiteCommand dbCommand;
                    string sql = "";

                    sql = $"SELECT * FROM Category WHERE Name = '{textCat.Text}'";
                    dbCommand = new SQLiteCommand(sql, noteDB);
                    SQLiteDataReader reader = dbCommand.ExecuteReader();
                    if (!reader.Read())
                    {
                        Debug.WriteLine("Worked");
                        sql = $"INSERT INTO Category VALUES('{cat.CatGuid}', '{cat.Name}')";
                        dbCommand = new SQLiteCommand(sql, noteDB);
                        dbCommand.ExecuteNonQuery();
                    }
                }

                this.Close();
            }
            else 
            { 
                MessageBox.Show("This Category already exists!", "Look", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
