using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MovieListingApp
{
    public partial class MovieListForm : Form
    {
        public MovieListForm()
        {
            InitializeComponent();
        }

        // on load
        private void MovieListForm_Load(object sender, EventArgs e)
        {
            // clear list box and load with movie list titles
            movieListBox.Items.Clear();
            LoadMovies();

            // set buttons and field status based on user status
            if (User.users[User.loggedInUser].Admin)
            {
                deleteButton.Visible = true;
                titleTB.ReadOnly = false;
                genreTB.ReadOnly = false;
                yearTB.ReadOnly = false;
                durationTB.ReadOnly = false;
                descriptionTB.ReadOnly = false;
                ratingTB.ReadOnly = false;
                newButton.Visible = true;
                updateButton.Visible = true;
            }
            else
            {
                deleteButton.Visible = false;
                titleTB.ReadOnly = true;
                genreTB.ReadOnly = true;
                yearTB.ReadOnly = true;
                durationTB.ReadOnly = true;
                descriptionTB.ReadOnly = true;
                ratingTB.ReadOnly = true;
                newButton.Visible = false;
                updateButton.Visible = false;
            }
        }

        // load/Reload movies in list box
        private void LoadMovies()
        {
            movieListBox.Items.Clear();

            foreach (Movie movie in Movie.movies)
            {
                movieListBox.Items.Add(movie.Title);
            }
        }

        // load in movies to list from stored file
        public static void LoadMoviesFromFile()
        {
            Movie.movies.Clear();

            StreamReader movieFile;
            movieFile = File.OpenText("Movies.txt");


            while (!movieFile.EndOfStream)
            {
                string movieRead = movieFile.ReadLine();
                // split each line into array
                string[] movieData = movieRead.Split(new string[] { "," }, StringSplitOptions.None);
                
                // ensure correct data structure
                if (movieData.Length == 6)
                {
                    string title = movieData[0];
                    if (!Enum.TryParse(movieData[1], out Genre genre))
                    {
                        genre = Genre.Undefined;
                    }
                    if (!int.TryParse(movieData[2], out int year))
                    {
                        year = 0;
                    }
                    string duration = movieData[3];
                    string description = movieData[4];
                    if (!double.TryParse(movieData[5], out double rating))
                    {
                        rating = 0;
                    }

                    // create movie instance and add to movies
                    Movie movie = new Movie
                    (
                        title,
                        genre,
                        year,
                        duration,
                        description,
                        rating
                    );

                    Movie.movies.Add(movie);
                }

            }

            movieFile.Close();
        }

        // delete selected movie from listbox, movie list, and favorites if exists
        private void DeleteMovie()
        {
            if (movieListBox.SelectedIndex != -1)
            {
                int currentIndex = movieListBox.SelectedIndex;
                movieListBox.SelectedIndex = -1;
                titleTB.Text = "";
                genreTB.Text = "";
                yearTB.Text = "";
                durationTB.Text = "";
                descriptionTB.Text = "";
                ratingTB.Text = "";
                Movie movieToDelete = Movie.movies[currentIndex];
                if (User.users[User.loggedInUser].Favorites.Contains(movieToDelete))
                {
                    User.users[User.loggedInUser].Favorites.Remove(movieToDelete);
                }
                movieListBox.Items.RemoveAt(currentIndex);
                Movie.movies.RemoveAt(currentIndex);
            }
        }

        // admin users can update movies by directly changing text boxes
        private void UpdateMovie()
        {
            if (movieListBox.SelectedIndex != -1)
            {
                int currentIndex = movieListBox.SelectedIndex;
                Movie movie = Movie.movies[currentIndex];
                string title = titleTB.Text;
                if (!Enum.TryParse(genreTB.Text, out Genre genre))
                {
                    genre = Genre.Undefined;
                }
                if (!int.TryParse(yearTB.Text, out int year))
                {
                    year = 0;
                }
                string duration = durationTB.Text;
                string description = descriptionTB.Text;
                if (!double.TryParse(ratingTB.Text, out double rating))
                {
                    rating = 0;
                }

                Movie updateMovie = Movie.movies[currentIndex];

                updateMovie.Title = title;
                updateMovie.Genre = genre;
                updateMovie.Year = year;
                updateMovie.Duration = duration;
                updateMovie.Description = description;
                updateMovie.Rating.Clear();
                updateMovie.Rating.Add(rating);

                MessageBox.Show($"{updateMovie.Title} has been updated");

                LoadMovies();
                movieListBox.SelectedIndex = currentIndex;
            }
        }

        private void SearchMovies()
        {
            // put titles into an array
            string[] titles = new string[Movie.movies.Count];
            for (int i = 0; i < Movie.movies.Count; i++)
            {
                titles[i] = Movie.movies[i].Title.ToLower();
            }

            string search = searchTB.Text.ToLower();

            // create result list
            List<string> results = new List<string>();

            int counter = 0;

            // loop to fill results list and select the first item found in listbox
            foreach (string title in titles)
            {
                if (title.Contains(search))
                {
                    results.Add(char.ToUpper(title[0]) + title.Substring(1));
                }
                counter++;
            }

            // join with newline after each and show in message box
            string resultString = string.Join(Environment.NewLine, results);

            MessageBox.Show("Results:" + Environment.NewLine + resultString);

            // set selected index to a search result item
            for (int i = 0; i < movieListBox.Items.Count; i++)
            {
                if (movieListBox.Items[i].ToString().Equals(results[0], StringComparison.OrdinalIgnoreCase))
                {
                    movieListBox.SelectedIndex = i;
                    break;
                }
            }

        }
        private void FilterMovies()
        {
            // check for appropriate checkbox use
            if (genreCheckBox.Checked && yearCheckBox.Checked)
            {
                MessageBox.Show("Please select only one filter");
            }
            else if (genreCheckBox.Checked)
            {
                // Search by genre
                List<string> results = new List<string>();
                string search = filterTB.Text.ToLower();

                // compare search to genres and add to results list
                foreach (Movie movie in Movie.movies)
                {
                    if (movie.Genre.ToString().ToLower() == search)
                    {
                        results.Add(movie.Title);
                    }
                }

                // if results found add newline characters and show user
                if (results.Count > 0)
                {
                    string resultString = string.Join(Environment.NewLine, results);

                    MessageBox.Show("Results:" + Environment.NewLine + resultString);
                }
                else
                {
                    MessageBox.Show("No results for genre");
                }
                genreCheckBox.Checked = false;
                filterTB.Text = "";
                
            }
            else if (yearCheckBox.Checked)
            {
                // Search by year
                List<string> results = new List<string>();
                string search = filterTB.Text;

                // compare search to year and add to results list
                foreach (Movie movie in Movie.movies)
                {
                    if (movie.Year.ToString() == search)
                    {
                        results.Add(movie.Title);
                    }
                }

                // if results found add newline characters and show user
                if (results.Count > 0)
                {
                    string resultString = string.Join(Environment.NewLine, results);

                    MessageBox.Show("Results:" + Environment.NewLine + resultString);
                }
                else
                {
                    MessageBox.Show("No results for year");
                }
                yearCheckBox.Checked = false;
                filterTB.Text = "";

            }
        }
        
        // add movie based on text box entries
        private void AddMovie()
        {
            // ensure movie title doesn't already exist
            if (!Movie.movies.Any(m => m.Title.Equals(titleTB.Text, StringComparison.OrdinalIgnoreCase)))
            {
                if (titleTB.Text != "" &&
                    genreTB.Text != "" &&
                    yearTB.Text != "" &&
                    durationTB.Text != "" &&
                    descriptionTB.Text != "" &&
                    ratingTB.Text != "")
                {
                    // get textbox entries and ensure able to parse
                    string title = titleTB.Text;

                    if (!Enum.TryParse(genreTB.Text, out Genre genre))
                    {
                        genre = Genre.Undefined;
                    }

                    if (!int.TryParse(yearTB.Text, out int year))
                    {
                        year = 0;
                    }

                    string duration = durationTB.Text;
                    string description = descriptionTB.Text;
                    if (!double.TryParse(ratingTB.Text, out double rating))
                    {
                        rating = 0;
                    }

                    // create new movie instance and add to movie list
                    Movie newMovie = new Movie
                    (
                        title,
                        genre,
                        year,
                        duration,
                        description,
                        rating
                    );

                    Movie.movies.Add(newMovie);
                    LoadMovies();
                }
                else
                {
                    MessageBox.Show("Please fill all fields");
                }
            }
            else
            {
                MessageBox.Show("Movie already exists");
            }
        }

        // add movie to user favorite list
        private void AddToFavorites()
        {
            if (movieListBox.SelectedIndex != -1)
            {
                int index = movieListBox.SelectedIndex;
                string movieTitle = movieListBox.SelectedItem.ToString();

                // ensure movie isn't already in favorites
                if (!User.users[User.loggedInUser].Favorites.Any(m => m.Title.Equals(movieTitle)))
                {
                    User.users[User.loggedInUser].AddFavoriteMovie(Movie.movies[index]);
                    MessageBox.Show($"{movieTitle} added to favorites");
                }
                else
                {
                    MessageBox.Show("Movie already in favorites");
                }
            }
        }

        // calculate rating based on average of list of doubles
        private double CalculateAverageRating(Movie movie)
        {
            double rating = (movie.Rating.Sum() /
                             movie.Rating.Count);

            return rating;
        }

        // show data in textboxes based on listbox selection
        private void movieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (movieListBox.SelectedIndex != -1)
            {
                int currentIndex = movieListBox.SelectedIndex;
                titleTB.Text = Movie.movies[currentIndex].Title;
                genreTB.Text = Movie.movies[currentIndex].Genre.ToString();
                yearTB.Text = Movie.movies[currentIndex].Year.ToString();
                durationTB.Text = Movie.movies[currentIndex].Duration;
                descriptionTB.Text = Movie.movies[currentIndex].Description;
                ratingTB.Text = CalculateAverageRating(Movie.movies[currentIndex]).ToString("N1");
            }
        }

        // logout user by setting loggedInUser to an empty string
        private void LogoutUser()
        {
            User.loggedInUser = "";
            // LoginForm loginForm = new LoginForm();
            // loginForm.Show();
            this.Close();
        }

        // call favorites form
        private void favoriteButton_Click(object sender, EventArgs e)
        {
            FavoritesForm favoritesForm = new FavoritesForm();
            favoritesForm.Show();
        }

        // add rating to movie list of rating doubles
        private void rateButton_Click(object sender, EventArgs e)
        {
            int currentIndex = movieListBox.SelectedIndex;
            if (movieListBox.SelectedIndex != -1)
            {
                ReviewForm reviewForm = new ReviewForm(movieListBox.SelectedItem.ToString(), movieListBox.SelectedIndex);
                if (reviewForm.ShowDialog() == DialogResult.OK)
                {
                    LoadMovies();
                    movieListBox.SelectedIndex = currentIndex;
                }
            }
        }

        private void addFavButton_Click(object sender, EventArgs e)
        {
            AddToFavorites();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            AddMovie();
        }

        // only logout if regular user
        private void exitButton_Click(object sender, EventArgs e)
        {
            if (User.users[User.loggedInUser].Admin)
            {
                this.Close();
            }
            else
            {
                LogoutUser();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteMovie();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchMovies();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateMovie();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            FilterMovies();
        }
    }
}
