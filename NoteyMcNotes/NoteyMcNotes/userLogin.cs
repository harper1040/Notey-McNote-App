using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteyMcNotes
{
    public partial class userLogin : Form
    {
        public userLogin()
        {
            InitializeComponent();
            groupBoxCreate.Visible = false;
        }

        /// <summary>
        /// A button used to toggle from the Create User panel to the Login panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateLog_Click(object sender, EventArgs e)
        {
            groupBoxCreate.Visible = true;
            groupBoxLog.Visible = false;

        }
        /// <summary>
        /// A button used as a toggle between the Login to the Create User panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            groupBoxLog.Visible = true;
            groupBoxCreate.Visible = false;
        }

        /// <summary>
        /// This is the button that loads all the functions to create the user account. It launches User Check and if it
        /// comes back with no issue check the passwords and creates the user object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if(UserClass.UserName_Check(textUserCreate.Text))
            {
                MessageBox.Show("That user already exists.", "No Catfishin'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textPassCreate.Text.Length > 8 && textPassCreate.Text.Length < 16)
            {
                if (textPassCreate.Text == textPassVerify.Text)
                {
                    UserClass user = new UserClass(textUserCreate.Text, textPassCreate.Text);
                    UserClass.User.Add(user);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Those passwords did not match.", "You Shall Not Pass", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Your password has to be between 8 and 16 characters.", "You Shall Not Pass", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// This is the button that launchs User Verify which tests the users entered password against the hash on file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoginLog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textUserLog.Text) && string.IsNullOrEmpty(textPassLog.Text))
            {
                
                MessageBox.Show("Please fill in Username and Password.", "You Shall Not Pass", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(UserClass.User_Verify(textUserLog.Text, textPassLog.Text))
                {
                    MessageBox.Show($"Welcome {textUserLog.Text}", "Welcome", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please verify that your information is correct and try again.", "Failed Loign", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                    
                
            }
            
        }
    }
}
