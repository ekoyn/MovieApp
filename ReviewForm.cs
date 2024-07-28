using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MovieListingApp
{
    public partial class ReviewForm : Form
    {
        string movieTitle;
        int movieIndex;

        // take in movie title and movie index on init
        public ReviewForm(string movieTitleIn, int index)
        {
            InitializeComponent();
            movieTitle = movieTitleIn;
            movieIndex = index;
        }

        // set label to movie title
        private void ReviewForm_Load(object sender, EventArgs e)
        {
            movieLabel.Text = movieTitle;
        }

        // add review to review list of doubles
        private void AddReview()
        {
            Movie.movies[movieIndex].Rating.Add(GetSelectedRating());
        }

        // get rating based on radio buttons
        private int GetSelectedRating()
        {
            if (oneRB.Checked) return 1;
            if (twoRB.Checked) return 2;
            if (threeRB.Checked) return 3;
            if (fourRB.Checked) return 4;
            if (fiveRB.Checked) return 5;
            if (sixRB.Checked) return 6;
            if (sevenRB.Checked) return 7;
            if (eightRB.Checked) return 8;
            if (nineRB.Checked) return 9;
            if (tenRB.Checked) return 10;

            return 0;
        }

        // if rating successful close
        private void rateMovieButton_Click(object sender, EventArgs e)
        {
            if (GetSelectedRating() > 0)
            {
                AddReview();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Select a rating");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
