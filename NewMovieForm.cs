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
    public partial class NewMovieForm : Form
    {
        public NewMovieForm()
        {
            InitializeComponent();
        }

        // add movie based on text boxes
        private bool AddMovie()
        {
            // ensure movie doesn't already exist
            if (!Movie.movies.Any(m => m.Title.Equals(titleTB.Text, StringComparison.OrdinalIgnoreCase)))
            {
                if (titleTB.Text != "" &&
                    genreTB.Text != "" &&
                    yearTB.Text != "" &&
                    durationTB.Text != "" &&
                    descriptionTB.Text != "" &&
                    ratingTB.Text != "")
                {
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

                    // create instance and add to movies list
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

                    return true;
                }
                else
                {
                    MessageBox.Show("Please fill all fields");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Movie already exists");
                return false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(AddMovie())
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Movie added");
                this.Close();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
