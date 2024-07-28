namespace MovieListingApp
{
    partial class ViewAllForm
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
            allMoviesListBox = new ListBox();
            allUsersListBox = new ListBox();
            allMoviesLabel = new Label();
            allUsersLabel = new Label();
            deleteUserButton = new Button();
            closeButton = new Button();
            SuspendLayout();
            // 
            // allMoviesListBox
            // 
            allMoviesListBox.FormattingEnabled = true;
            allMoviesListBox.ItemHeight = 37;
            allMoviesListBox.Location = new Point(101, 100);
            allMoviesListBox.Name = "allMoviesListBox";
            allMoviesListBox.SelectionMode = SelectionMode.None;
            allMoviesListBox.Size = new Size(270, 633);
            allMoviesListBox.TabIndex = 0;
            // 
            // allUsersListBox
            // 
            allUsersListBox.FormattingEnabled = true;
            allUsersListBox.ItemHeight = 37;
            allUsersListBox.Location = new Point(463, 100);
            allUsersListBox.Name = "allUsersListBox";
            allUsersListBox.Size = new Size(609, 485);
            allUsersListBox.TabIndex = 1;
            // 
            // allMoviesLabel
            // 
            allMoviesLabel.AutoSize = true;
            allMoviesLabel.Location = new Point(101, 60);
            allMoviesLabel.Name = "allMoviesLabel";
            allMoviesLabel.Size = new Size(102, 37);
            allMoviesLabel.TabIndex = 2;
            allMoviesLabel.Text = "Movies";
            // 
            // allUsersLabel
            // 
            allUsersLabel.AutoSize = true;
            allUsersLabel.Location = new Point(463, 60);
            allUsersLabel.Name = "allUsersLabel";
            allUsersLabel.Size = new Size(468, 37);
            allUsersLabel.TabIndex = 3;
            allUsersLabel.Text = "Users (Username - Name(F/L) - Status)";
            // 
            // deleteUserButton
            // 
            deleteUserButton.Location = new Point(802, 611);
            deleteUserButton.Name = "deleteUserButton";
            deleteUserButton.Size = new Size(270, 52);
            deleteUserButton.TabIndex = 4;
            deleteUserButton.Text = "Delete User";
            deleteUserButton.UseVisualStyleBackColor = true;
            deleteUserButton.Click += deleteUserButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(802, 685);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(270, 52);
            closeButton.TabIndex = 5;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // ViewAllForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 799);
            Controls.Add(closeButton);
            Controls.Add(deleteUserButton);
            Controls.Add(allUsersLabel);
            Controls.Add(allMoviesLabel);
            Controls.Add(allUsersListBox);
            Controls.Add(allMoviesListBox);
            Name = "ViewAllForm";
            Text = "All Movies and Users";
            Load += ViewAllForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox allMoviesListBox;
        private ListBox allUsersListBox;
        private Label allMoviesLabel;
        private Label allUsersLabel;
        private Button deleteUserButton;
        private Button closeButton;
    }
}