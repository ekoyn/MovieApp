using System.Diagnostics.Eventing.Reader;

namespace MovieListingApp
{
    public partial class LoginForm : Form
    {
        // during initialization create test users
        public LoginForm()
        {
            InitializeComponent();
            if (!User.userDatabase.ContainsKey("movieUser"))
            {
                User.userDatabase.Add("movieUser", new User
                (
                    "movieUser",
                    "user0123",
                    "John",
                    "Smith",
                    "movie@user.com",
                    false
                ));
            }
            if (!User.userDatabase.ContainsKey("admin"))
            {
                User.userDatabase.Add("admin", new User
                (
                    "admin",
                    "admin0123",
                    "Rebecca",
                    "Johnson",
                    "admin@movie.com",
                    true
                ));
            }

        }


        // reset logged in user on load, handled elsewhere now since login is main
        // and this will only run once
        private void LoginForm_Load(object sender, EventArgs e)
        {
            User.loggedInUser = "";
        }


        private bool LoginUser()
        {
            // UserData.role = "";
            User.loggedInUser = "";

            // get strings from text boxes
            string userName = usernameTB.Text;
            string password = passwordTB.Text;

            // credential check
            // checks against admin data first
            if (User.userDatabase.ContainsKey(userName))
            {
                if (password == User.userDatabase[userName].Password)
                {
                    User.loggedInUser = userName;
                    // loads movies into movie list
                    MovieListForm.LoadMoviesFromFile();
                    return true;
                }
                else
                {
                    MessageBox.Show("The Password entered is incorrect");
                    passwordTB.Text = "";
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Either your username or password was entered incorrectly; please try again.");
                usernameTB.Text = "";
                passwordTB.Text = "";
                return false;
            }
        }

        // clear form
        private void ClearForm()
        {
            usernameTB.Text = "";
            passwordTB.Text = "";
        }

        // load appropriate form based on user credentials
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (LoginUser())
            {
                if (User.userDatabase[User.loggedInUser].Admin)
                {
                    ClearForm();
                    // this.Hide();
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
                else
                {
                    ClearForm();
                    // this.Hide();
                    MovieListForm movieListForm = new MovieListForm();
                    movieListForm.Show();
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // call registration form (modal)
        private void registerButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
