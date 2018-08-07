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
    public partial class FormUserLogin : Form
    {
        DatabaseAccess access = new DatabaseAccess();
        
        //List to store realtors from the DB.
        List<User> userList = null;

        public FormUserLogin()
        {
            InitializeComponent();
            FetchUserList();
        }

        private void FormUserLogin_Load(object sender, EventArgs e)
        {
            this.Height = 590;
            this.Width = 800;

            //additionl design specs
            buttonCloseForm.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonSignUp.FlatAppearance.BorderSize = 0;

            //additional startup code
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
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

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            FormNewUserSignup signUpForm = new FormNewUserSignup();
            signUpForm.Show();
        }

        /// <summary>
        /// Resets the text inputs on the form
        /// </summary>
        private void ClearFields()
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var queryLoginCheck = userList
                .Where(r => r.UserName.Trim().Equals(textBoxUsername.Text) && r.Password.Trim().Equals(textBoxPassword.Text))
                .Select(r => r);

            if (queryLoginCheck.Count() > 0)
            {
                //insert userId here
                FormMainUI formMainUI = new FormMainUI();
                formMainUI.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
                ClearFields();
            }
        }
    }
}
