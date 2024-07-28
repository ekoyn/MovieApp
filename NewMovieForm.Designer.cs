namespace MovieListingApp
{
    partial class NewMovieForm
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
            addButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            titleLabel.Location = new Point(103, 84);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(170, 37);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Movie Title:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            genreLabel.Location = new Point(173, 159);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(100, 37);
            genreLabel.TabIndex = 1;
            genreLabel.Text = "Genre:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            yearLabel.Location = new Point(193, 234);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(80, 37);
            yearLabel.TabIndex = 2;
            yearLabel.Text = "Year:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            durationLabel.Location = new Point(135, 309);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(138, 37);
            durationLabel.TabIndex = 3;
            durationLabel.Text = "Duration:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            descriptionLabel.Location = new Point(101, 384);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(172, 37);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ratingLabel.Location = new Point(164, 565);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new Size(109, 37);
            ratingLabel.TabIndex = 5;
            ratingLabel.Text = "Rating:";
            // 
            // titleTB
            // 
            titleTB.Location = new Point(297, 81);
            titleTB.Name = "titleTB";
            titleTB.Size = new Size(417, 43);
            titleTB.TabIndex = 6;
            // 
            // genreTB
            // 
            genreTB.Location = new Point(297, 156);
            genreTB.Name = "genreTB";
            genreTB.Size = new Size(417, 43);
            genreTB.TabIndex = 7;
            // 
            // yearTB
            // 
            yearTB.Location = new Point(297, 231);
            yearTB.Name = "yearTB";
            yearTB.Size = new Size(417, 43);
            yearTB.TabIndex = 8;
            // 
            // durationTB
            // 
            durationTB.Location = new Point(297, 306);
            durationTB.Name = "durationTB";
            durationTB.Size = new Size(417, 43);
            durationTB.TabIndex = 9;
            // 
            // descriptionTB
            // 
            descriptionTB.Location = new Point(297, 381);
            descriptionTB.Multiline = true;
            descriptionTB.Name = "descriptionTB";
            descriptionTB.Size = new Size(417, 149);
            descriptionTB.TabIndex = 10;
            // 
            // ratingTB
            // 
            ratingTB.Location = new Point(297, 562);
            ratingTB.Name = "ratingTB";
            ratingTB.Size = new Size(417, 43);
            ratingTB.TabIndex = 11;
            // 
            // addButton
            // 
            addButton.Location = new Point(216, 674);
            addButton.Name = "addButton";
            addButton.Size = new Size(169, 52);
            addButton.TabIndex = 12;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(490, 674);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(169, 52);
            exitButton.TabIndex = 13;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // NewMovieForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 800);
            Controls.Add(exitButton);
            Controls.Add(addButton);
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
            Name = "NewMovieForm";
            Text = "Add New Movie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Button addButton;
        private Button exitButton;
    }
}