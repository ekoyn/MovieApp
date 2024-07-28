namespace MovieListingApp
{
    partial class FavoritesForm
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
            favoriteListBox = new ListBox();
            ratingTB = new TextBox();
            descriptionTB = new TextBox();
            durationTB = new TextBox();
            yearTB = new TextBox();
            genreTB = new TextBox();
            titleTB = new TextBox();
            ratingLabel = new Label();
            descriptionLabel = new Label();
            durationLabel = new Label();
            yearLabel = new Label();
            genreLabel = new Label();
            titleLabel = new Label();
            exitButton = new Button();
            SuspendLayout();
            // 
            // favoriteListBox
            // 
            favoriteListBox.FormattingEnabled = true;
            favoriteListBox.ItemHeight = 37;
            favoriteListBox.Location = new Point(65, 62);
            favoriteListBox.Name = "favoriteListBox";
            favoriteListBox.Size = new Size(362, 485);
            favoriteListBox.TabIndex = 0;
            favoriteListBox.SelectedIndexChanged += favoriteListBox_SelectedIndexChanged;
            // 
            // ratingTB
            // 
            ratingTB.Location = new Point(464, 553);
            ratingTB.Name = "ratingTB";
            ratingTB.ReadOnly = true;
            ratingTB.Size = new Size(100, 43);
            ratingTB.TabIndex = 24;
            ratingTB.TabStop = false;
            // 
            // descriptionTB
            // 
            descriptionTB.Location = new Point(464, 328);
            descriptionTB.Multiline = true;
            descriptionTB.Name = "descriptionTB";
            descriptionTB.ReadOnly = true;
            descriptionTB.Size = new Size(646, 145);
            descriptionTB.TabIndex = 23;
            descriptionTB.TabStop = false;
            // 
            // durationTB
            // 
            durationTB.Location = new Point(936, 210);
            durationTB.Name = "durationTB";
            durationTB.ReadOnly = true;
            durationTB.Size = new Size(174, 43);
            durationTB.TabIndex = 22;
            durationTB.TabStop = false;
            // 
            // yearTB
            // 
            yearTB.Location = new Point(702, 210);
            yearTB.Name = "yearTB";
            yearTB.ReadOnly = true;
            yearTB.Size = new Size(174, 43);
            yearTB.TabIndex = 21;
            yearTB.TabStop = false;
            // 
            // genreTB
            // 
            genreTB.Location = new Point(464, 210);
            genreTB.Name = "genreTB";
            genreTB.ReadOnly = true;
            genreTB.Size = new Size(174, 43);
            genreTB.TabIndex = 20;
            genreTB.TabStop = false;
            // 
            // titleTB
            // 
            titleTB.Location = new Point(464, 106);
            titleTB.Name = "titleTB";
            titleTB.ReadOnly = true;
            titleTB.Size = new Size(646, 43);
            titleTB.TabIndex = 19;
            titleTB.TabStop = false;
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ratingLabel.Location = new Point(464, 503);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new Size(109, 37);
            ratingLabel.TabIndex = 18;
            ratingLabel.Text = "Rating:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            descriptionLabel.Location = new Point(464, 280);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(172, 37);
            descriptionLabel.TabIndex = 17;
            descriptionLabel.Text = "Description:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            durationLabel.Location = new Point(936, 169);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(138, 37);
            durationLabel.TabIndex = 16;
            durationLabel.Text = "Duration:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            yearLabel.Location = new Point(702, 169);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(80, 37);
            yearLabel.TabIndex = 15;
            yearLabel.Text = "Year:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            genreLabel.Location = new Point(464, 169);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(100, 37);
            genreLabel.TabIndex = 14;
            genreLabel.Text = "Genre:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            titleLabel.Location = new Point(464, 62);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(170, 37);
            titleLabel.TabIndex = 13;
            titleLabel.Text = "Movie Title:";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(702, 544);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(298, 52);
            exitButton.TabIndex = 25;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // FavoritesForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 722);
            Controls.Add(exitButton);
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
            Controls.Add(favoriteListBox);
            Name = "FavoritesForm";
            Text = "My Movie Favorites";
            Load += FavoritesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox favoriteListBox;
        private TextBox ratingTB;
        private TextBox descriptionTB;
        private TextBox durationTB;
        private TextBox yearTB;
        private TextBox genreTB;
        private TextBox titleTB;
        private Label ratingLabel;
        private Label descriptionLabel;
        private Label durationLabel;
        private Label yearLabel;
        private Label genreLabel;
        private Label titleLabel;
        private Button exitButton;
    }
}