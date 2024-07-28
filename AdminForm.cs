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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        // call new movie form (modal)
        private void newButton_Click(object sender, EventArgs e)
        {
            NewMovieForm newMovieForm = new NewMovieForm();
            newMovieForm.ShowDialog();
        }

        // call main form with editing capablities
        private void updateButton_Click(object sender, EventArgs e)
        {
            MovieListForm movieListForm = new MovieListForm();
            movieListForm.Show();
        }

        // call form to view all movies and users
        private void viewButton_Click(object sender, EventArgs e)
        {
            ViewAllForm viewAllForm = new ViewAllForm();
            viewAllForm.ShowDialog();
        }

        // call registration form with ability to create other admin users
        private void newuserButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            // only login button return DialogResult.OK, so user is returned to login form
            if( registrationForm.ShowDialog() == DialogResult.OK )
            {
                this.Close();
            }
        }
    }
}
