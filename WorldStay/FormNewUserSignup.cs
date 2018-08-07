using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldStay
{
    public partial class FormNewUserSignup : Form
    {
        DatabaseAccess access = new DatabaseAccess();

        //List to store realtors from the DB.
        List<User> userList = null;
        //Color converter object
        ColorConverter colorConverter = new ColorConverter();

        public FormNewUserSignup()
        {
            InitializeComponent();
            FetchUserList();
            textBoxUsername.TextChanged += CheckValidUsername;
        }

        private void CheckValidUsername(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Length == 0)
            {
                textBoxUsername.BackColor = Color.Silver;
                textBoxUsername.ForeColor = Color.White;
            }
            else
            {
                if (UsernameExists(textBoxUsername.Text))
                {

                    Color colorRed = (Color)colorConverter.ConvertFromString("#fcbdbd");
                    textBoxUsername.BackColor = colorRed;
                    textBoxUsername.ForeColor = Color.Black;
                    labelInfoDisplay.Visible = true;
                }
                else
                {
                    Color colorGreen = (Color)colorConverter.ConvertFromString("#c0fcbd");
                    textBoxUsername.BackColor = colorGreen;
                    textBoxUsername.ForeColor = Color.Black;
                    labelInfoDisplay.Visible = false;
                }
            }
        }

        /// <summary>
        /// Checks if the username already exists in the userList
        /// </summary>
        /// <param name="username"></param>
        /// <returns>bool value</returns>
        public bool UsernameExists(String username)
        {
            bool usernameExists = false;

            //This needs to be fixed.
            var checkQuery = userList.Where(r => r.UserName.Trim().Equals(username, StringComparison.InvariantCultureIgnoreCase)).Select(r => r);
            if (checkQuery.Count() > 0)
                usernameExists = true;

            return usernameExists;
        }

        /// <summary>
        /// Fetches the list of users from the DB
        /// </summary>
        public void FetchUserList()
        {
            access.OpenConnection();
            userList = access.GetUsers();
            access.CloseConnection();
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNewUserSignup_Load(object sender, EventArgs e)
        {
            this.Height = 590;
            this.Width = 800;

            //additionl design specs
            buttonCloseForm.FlatAppearance.BorderSize = 0;
            buttonCreateAccount.FlatAppearance.BorderSize = 0;
            buttonClearForm.FlatAppearance.BorderSize = 0;
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            access.OpenConnection();
            try
            {
                if (textBoxUsername.TextLength == 0 || textBoxPassword.TextLength == 0)
                    throw new Exception();

                if (UsernameExists(textBoxUsername.Text))
                    throw new Exception();

                access.InsertUser(new User {
                    UserName = textBoxUsername.Text,
                    Password = textBoxPassword.Text,
                    LoyaltyPoints = 0
                });
                MessageBox.Show("Profile created successfully!!");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input, please try again!");
            }
            access.CloseConnection();
        }

        private void buttonClearForm_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }
    }
}
