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
using System.Xml.Linq;

namespace NoteyMcNotes
{
    public partial class Dashboard : Form
    {
        public string Mode { get; set; }
        public Dashboard()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Loads user info when the window loads.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dashboard_Load(object sender, EventArgs e)
        {
            groupDashboard.Text = UserClass.User[0].UserName;
            labelColor.Text = UserClass.User[0].ColorMode;
            switch (UserClass.User[0].ColorMode)
            {
                case "Base":
                    trackColorMode.Value = 0;
                    break;
                case "Dark":
                    trackColorMode.Value = 1;
                    break;
                case "Christmas":
                    trackColorMode.Value = 2;
                    break;
                case "Ouch":
                    trackColorMode.Value = 3;
                    break;
            }
        }
        /// <summary>
        /// This controls the track menu which is used to pick a color mode, which is not implemented at the moment.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackColorMode_Scroll(object sender, EventArgs e)
        {

            switch (trackColorMode.Value.ToString())
            {
                case "0":
                    labelColor.Text = "Base";
                    Mode = "Base";
                    break;
                case "1":
                    labelColor.Text = "Dark";
                    Mode = "Dark";
                    break;
                case "2":
                    labelColor.Text = "Christmas";
                    Mode = "Christmas";
                    break;
                case "3":
                    labelColor.Text = "Ouch";
                    Mode = "Ouch";
                    break;
            }
        }
        /// <summary>
        /// This sets the color mode the user chose in their database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonApply_Click(object sender, EventArgs e)
        {
            UserClass.User[0].ColorMode = Mode;
            SQLiteConnection noteDB = dbconnect.GetConnection();
            SQLiteCommand dbCommand;
            string sql = "";
            sql = $"UPDATE Users SET Setting = '{Mode}' WHERE UserName = '{UserClass.User[0].UserName}'";
            dbCommand = new SQLiteCommand(sql, noteDB);
            dbCommand.ExecuteNonQuery();
        }
        /// <summary>
        /// This logs the user out and clears their notes from the app.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult log = MessageBox.Show("Are you sure you want to logout?", "Bye Bye Bye", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (log == DialogResult.Yes)
            {
                UserClass.User.Clear();
                CategoryClass.Categories.Clear();
                CategoryClass cat = new CategoryClass("Uncategorized", "0");
                CategoryClass.Categories.Add(cat);
                NoteClass.Notes.Clear();
                Close();
            }
        }
    }
}
