using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieListingApp
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            // ensure admin checkbox is only visible to an admin user
            if (User.loggedInUser != "")
            {
                if (User.userDatabase[User.loggedInUser].Admin)
                {
                    adminCB.Visible = true;
                }
                else
                {
                    adminCB.Visible = false;
                }
            }
            else
            {
                adminCB.Visible = false;
            }
        }

        // clear form
        private void FormClear()
        {
            firstnameTB.Text = "";
            lastnameTB.Text = "";
            emailTB.Text = "";
            usernameTB.Text = "";
            passwordTB.Text = "";
            adminCB.Checked = false;
        }
        
        // ensure all fields are filled
        private bool ValidateInput()
        {
            if (firstnameTB.Text != "" &&
                lastnameTB.Text != "" &&
                emailTB.Text != "" &&
                usernameTB.Text != "" &&
                passwordTB.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        // register new user
        private void RegisterUser()
        {
            // get data from text boxes
            string firstNameReg = firstnameTB.Text;
            string lastNameReg = lastnameTB.Text;
            string emailReg = emailTB.Text;
            string usernameReg = usernameTB.Text;
            string passwordReg = passwordTB.Text;

            // ensure validation and set admin based on user choice or ability to create another admin
            if (ValidateInput() && User.loggedInUser != "")
            {
                if (User.userDatabase[User.loggedInUser].Admin)
                {
                    // create new user
                    User.userDatabase.Add(usernameReg, new User
                    (
                        usernameReg,
                        passwordReg,
                        firstNameReg,
                        lastNameReg,
                        emailReg,
                        adminCB.Checked
                    ));

                    firstnameTB.Text = "";
                    lastnameTB.Text = "";
                    emailTB.Text = "";
                    usernameTB.Text = "";
                    passwordTB.Text = "";

                    MessageBox.Show($"User {usernameReg} added");
                }
                else
                {
                    // create new user
                    User.userDatabase.Add(usernameReg, new User
                    (
                        usernameReg,
                        passwordReg,
                        firstNameReg,
                        lastNameReg,
                        emailReg,
                        false
                    ));

                    firstnameTB.Text = "";
                    lastnameTB.Text = "";
                    emailTB.Text = "";
                    usernameTB.Text = "";
                    passwordTB.Text = "";

                    MessageBox.Show($"User {usernameReg} added");
                }
            }
            else if (ValidateInput())
            {
                // create new user
                User.userDatabase.Add(usernameReg, new User
                (
                    usernameReg,
                    passwordReg,
                    firstNameReg,
                    lastNameReg,
                    emailReg,
                    false
                ));

                firstnameTB.Text = "";
                lastnameTB.Text = "";
                emailTB.Text = "";
                usernameTB.Text = "";
                passwordTB.Text = "";

                MessageBox.Show($"User {usernameReg} added");
            }
            else
            {
                FormClear();
                MessageBox.Show("One or more entries are invalid");
            }


        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterUser();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            FormClear();

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
