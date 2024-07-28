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
    public partial class FavoritesForm : Form
    {
        public FavoritesForm()
        {
            InitializeComponent();
        }

        // load favorites from user
        private void LoadFavorites()
        {
            foreach (Movie movie in User.users[User.loggedInUser].Favorites)
            {
                favoriteListBox.Items.Add(movie.Title);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FavoritesForm_Load(object sender, EventArgs e)
        {
            LoadFavorites();
        }

        // calculate Rating based on average of list of doubles
        private double CalculateAverageRating(Movie movie)
        {
            double rating = (movie.Rating.Sum() /
                             movie.Rating.Count);

            return rating;
        }

        // fill text boxes based on selection from list box
        private void favoriteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (favoriteListBox.SelectedIndex != -1)
            {
                int currentIndex = favoriteListBox.SelectedIndex;
                titleTB.Text = User.users[User.loggedInUser].Favorites[currentIndex].Title;
                genreTB.Text = User.users[User.loggedInUser].Favorites[currentIndex].Genre.ToString();
                yearTB.Text = User.users[User.loggedInUser].Favorites[currentIndex].Year.ToString();
                durationTB.Text = User.users[User.loggedInUser].Favorites[currentIndex].Duration;
                descriptionTB.Text = User.users[User.loggedInUser].Favorites[currentIndex].Description;
                ratingTB.Text = CalculateAverageRating(User.users[User.loggedInUser].Favorites[currentIndex]).ToString("N1");
            }
        }
    }
}
