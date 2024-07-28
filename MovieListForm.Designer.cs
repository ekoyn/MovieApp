namespace MovieListingApp
{
    partial class MovieListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            movieListBox = new ListBox();
            titleLabel = new Label();
            genreLabel = new Label();
            yearLabel = new Label();
            durationLabel = new Label();
            descriptionLabel = new Label();
            ratingLabel = new Label();
            titleTB = new TextBox();
            genreTB = new TextBox();
            yearTB = new TextBox();
            durationTB = new TextBox();
            descriptionTB = new TextBox();
            ratingTB = new TextBox();
            rateButton = new Button();
            favoriteButton = new Button();
            addFavButton = new Button();
            newButton = new Button();
            exitButton = new Button();
            searchGroup = new GroupBox();
            searchButton = new Button();
            searchTB = new TextBox();
            filterGroup = new GroupBox();
            filterTB = new TextBox();
            filterButton = new Button();
            yearCheckBox = new CheckBox();
            genreCheckBox = new CheckBox();
            deleteButton = new Button();
            updateButton = new Button();
            searchGroup.SuspendLayout();
            filterGroup.SuspendLayout();
            SuspendLayout();
            // 
            // movieListBox
            // 
            movieListBox.FormattingEnabled = true;
            movieListBox.ItemHeight = 37;
            movieListBox.Items.AddRange(new object[] { "Bad Boys for Life", "Click", "Despicable Me", "Inception", "The Matrix" });
            movieListBox.Location = new Point(71, 70);
            movieListBox.Name = "movieListBox";
            movieListBox.Size = new Size(346, 485);
            movieListBox.TabIndex = 0;
            movieListBox.SelectedIndexChanged += movieListBox_SelectedIndexChanged;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            titleLabel.Location = new Point(474, 70);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(170, 37);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Movie Title:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            genreLabel.Location = new Point(474, 177);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(100, 37);
            genreLabel.TabIndex = 2;
            genreLabel.Text = "Genre:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            yearLabel.Location = new Point(712, 177);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(80, 37);
            yearLabel.TabIndex = 3;
            yearLabel.Text = "Year:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            durationLabel.Location = new Point(946, 177);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(138, 37);
            durationLabel.TabIndex = 4;
            durationLabel.Text = "Duration:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            descriptionLabel.Location = new Point(474, 288);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(172, 37);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ratingLabel.Location = new Point(474, 570);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new Size(109, 37);
            ratingLabel.TabIndex = 6;
            ratingLabel.Text = "Rating:";
            // 
            // titleTB
            // 
            titleTB.Location = new Point(474, 114);
            titleTB.Name = "titleTB";
            titleTB.ReadOnly = true;
            titleTB.Size = new Size(646, 43);
            titleTB.TabIndex = 7;
            // 
            // genreTB
            // 
            genreTB.Location = new Point(474, 218);
            genreTB.Name = "genreTB";
            genreTB.ReadOnly = true;
            genreTB.Size = new Size(174, 43);
            genreTB.TabIndex = 8;
            // 
            // yearTB
            // 
            yearTB.Location = new Point(712, 218);
            yearTB.Name = "yearTB";
            yearTB.ReadOnly = true;
            yearTB.Size = new Size(174, 43);
            yearTB.TabIndex = 9;
            // 
            // durationTB
            // 
            durationTB.Location = new Point(946, 218);
            durationTB.Name = "durationTB";
            durationTB.ReadOnly = true;
            durationTB.Size = new Size(174, 43);
            durationTB.TabIndex = 10;
            // 
            // descriptionTB
            // 
            descriptionTB.Location = new Point(474, 336);
            descriptionTB.Multiline = true;
            descriptionTB.Name = "descriptionTB";
            descriptionTB.ReadOnly = true;
            descriptionTB.Size = new Size(646, 219);
            descriptionTB.TabIndex = 11;
            // 
            // ratingTB
            // 
            ratingTB.Location = new Point(474, 620);
            ratingTB.Name = "ratingTB";
            ratingTB.ReadOnly = true;
            ratingTB.Size = new Size(100, 43);
            ratingTB.TabIndex = 12;
            // 
            // rateButton
            // 
            rateButton.Location = new Point(764, 595);
            rateButton.Name = "rateButton";
            rateButton.Size = new Size(356, 52);
            rateButton.TabIndex = 13;
            rateButton.Text = "Rate This Movie";
            rateButton.UseVisualStyleBackColor = true;
            rateButton.Click += rateButton_Click;
            // 
            // favoriteButton
            // 
            favoriteButton.Location = new Point(71, 688);
            favoriteButton.Name = "favoriteButton";
            favoriteButton.Size = new Size(356, 52);
            favoriteButton.TabIndex = 14;
            favoriteButton.Text = "View My Favorites";
            favoriteButton.UseVisualStyleBackColor = true;
            favoriteButton.Click += favoriteButton_Click;
            // 
            // addFavButton
            // 
            addFavButton.Location = new Point(71, 595);
            addFavButton.Name = "addFavButton";
            addFavButton.Size = new Size(356, 52);
            addFavButton.TabIndex = 15;
            addFavButton.Text = "Add to My Favorites";
            addFavButton.UseVisualStyleBackColor = true;
            addFavButton.Click += addFavButton_Click;
            // 
            // newButton
            // 
            newButton.Location = new Point(764, 781);
            newButton.Name = "newButton";
            newButton.Size = new Size(356, 52);
            newButton.TabIndex = 16;
            newButton.Text = "Add a New Movie";
            newButton.UseVisualStyleBackColor = true;
            newButton.Visible = false;
            newButton.Click += newButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(1218, 716);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(356, 52);
            exitButton.TabIndex = 17;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // searchGroup
            // 
            searchGroup.Controls.Add(searchButton);
            searchGroup.Controls.Add(searchTB);
            searchGroup.Location = new Point(1175, 70);
            searchGroup.Name = "searchGroup";
            searchGroup.Size = new Size(450, 255);
            searchGroup.TabIndex = 18;
            searchGroup.TabStop = false;
            searchGroup.Text = "Search for a Movie By Title";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(230, 169);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(169, 52);
            searchButton.TabIndex = 1;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchTB
            // 
            searchTB.Location = new Point(43, 77);
            searchTB.Name = "searchTB";
            searchTB.Size = new Size(356, 43);
            searchTB.TabIndex = 0;
            // 
            // filterGroup
            // 
            filterGroup.Controls.Add(filterTB);
            filterGroup.Controls.Add(filterButton);
            filterGroup.Controls.Add(yearCheckBox);
            filterGroup.Controls.Add(genreCheckBox);
            filterGroup.Location = new Point(1175, 379);
            filterGroup.Name = "filterGroup";
            filterGroup.Size = new Size(450, 259);
            filterGroup.TabIndex = 0;
            filterGroup.TabStop = false;
            filterGroup.Text = "Filter Movie By";
            // 
            // filterTB
            // 
            filterTB.Location = new Point(230, 84);
            filterTB.Name = "filterTB";
            filterTB.Size = new Size(169, 43);
            filterTB.TabIndex = 22;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(230, 146);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(169, 52);
            filterButton.TabIndex = 21;
            filterButton.Text = "Filter";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // yearCheckBox
            // 
            yearCheckBox.AutoSize = true;
            yearCheckBox.Location = new Point(53, 153);
            yearCheckBox.Name = "yearCheckBox";
            yearCheckBox.Size = new Size(99, 41);
            yearCheckBox.TabIndex = 1;
            yearCheckBox.Text = "Year";
            yearCheckBox.UseVisualStyleBackColor = true;
            // 
            // genreCheckBox
            // 
            genreCheckBox.AutoSize = true;
            genreCheckBox.Location = new Point(53, 86);
            genreCheckBox.Name = "genreCheckBox";
            genreCheckBox.Size = new Size(120, 41);
            genreCheckBox.TabIndex = 0;
            genreCheckBox.Text = "Genre";
            genreCheckBox.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(71, 781);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(356, 52);
            deleteButton.TabIndex = 19;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Visible = false;
            deleteButton.Click += button1_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(764, 688);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(356, 52);
            updateButton.TabIndex = 20;
            updateButton.Text = "Update Selected Movie";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Visible = false;
            updateButton.Click += updateButton_Click;
            // 
            // MovieListForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1686, 893);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(filterGroup);
            Controls.Add(searchGroup);
            Controls.Add(exitButton);
            Controls.Add(newButton);
            Controls.Add(addFavButton);
            Controls.Add(favoriteButton);
            Controls.Add(rateButton);
            Controls.Add(ratingTB);
            Controls.Add(descriptionTB);
            Controls.Add(durationTB);
            Controls.Add(yearTB);
            Controls.Add(genreTB);
            Controls.Add(titleTB);
            Controls.Add(ratingLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(durationLabel);
            Controls.Add(yearLabel);
            Controls.Add(genreLabel);
            Controls.Add(titleLabel);
            Controls.Add(movieListBox);
            Name = "MovieListForm";
            Text = "Movie Listing";
            Load += MovieListForm_Load;
            searchGroup.ResumeLayout(false);
            searchGroup.PerformLayout();
            filterGroup.ResumeLayout(false);
            filterGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox movieListBox;
        private Label titleLabel;
        private Label genreLabel;
        private Label yearLabel;
        private Label durationLabel;
        private Label descriptionLabel;
        private Label ratingLabel;
        private TextBox titleTB;
        private TextBox genreTB;
        private TextBox yearTB;
        private TextBox durationTB;
        private TextBox descriptionTB;
        private TextBox ratingTB;
        private Button rateButton;
        private Button favoriteButton;
        private Button addFavButton;
        private Button newButton;
        private Button exitButton;
        private GroupBox searchGroup;
        private Button searchButton;
        private TextBox searchTB;
        private GroupBox filterGroup;
        private CheckBox yearCheckBox;
        private CheckBox genreCheckBox;
        private Button deleteButton;
        private Button updateButton;
        private TextBox filterTB;
        private Button filterButton;
    }
}