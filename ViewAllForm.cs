using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieListingApp
{
    public partial class ViewAllForm : Form
    {
        // string array to hold usernames
        string[] userKeys = new string[User.users.Count];

        public ViewAllForm()
        {
            InitializeComponent();
        }

        // load both list boxes on form load
        private void ViewAllForm_Load(object sender, EventArgs e)
        {

            allMoviesListBox.Items.Clear();

            foreach (Movie movie in Movie.movies)
            {
                allMoviesListBox.Items.Add(movie.Title);
            }

            // load users
            LoadUsers();
        }

        // separate method so it can be called after user delete
        private void LoadUsers()
        {
            allUsersListBox.Items.Clear();

            int counter = 0;
            foreach (string user in User.users.Keys)
            {
                string userAdmin;
                if (User.users[user].Admin)
                {
                    userAdmin = "admin";
                }
                else
                {
                    userAdmin = "user";
                }
                allUsersListBox.Items.Add($"{User.users[user].Username} - {User.users[user].FirstName} {User.users[user].LastName} - {userAdmin}");

                userKeys[counter] = user;
                counter++;
            }
        }

        // ensure user isn't deleting their own account and update user list and listbox accordingly
        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (allUsersListBox.SelectedIndex != -1)
            {
                int currentIndex = allUsersListBox.SelectedIndex;
                allUsersListBox.SelectedIndex = -1;
                if (User.users[userKeys[currentIndex]] != User.users[User.loggedInUser])
                {
                    allUsersListBox.Items.RemoveAt(currentIndex);
                    User.users.Remove(userKeys[currentIndex]);
                    LoadUsers();

                }
                else
                {
                    MessageBox.Show("Cannot delete logged in user");
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
