namespace MovieListingApp
{
    partial class AdminForm
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
            newButton = new Button();
            updateButton = new Button();
            viewButton = new Button();
            newuserButton = new Button();
            SuspendLayout();
            // 
            // newButton
            // 
            newButton.Location = new Point(152, 87);
            newButton.Name = "newButton";
            newButton.Size = new Size(404, 90);
            newButton.TabIndex = 0;
            newButton.Text = "Add a New Movie";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(152, 211);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(404, 90);
            updateButton.TabIndex = 1;
            updateButton.Text = "Update/Edit Existing Movie";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // viewButton
            // 
            viewButton.Location = new Point(152, 335);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(404, 90);
            viewButton.TabIndex = 2;
            viewButton.Text = "View All Movies and Users";
            viewButton.UseVisualStyleBackColor = true;
            viewButton.Click += viewButton_Click;
            // 
            // newuserButton
            // 
            newuserButton.Location = new Point(152, 459);
            newuserButton.Name = "newuserButton";
            newuserButton.Size = new Size(404, 90);
            newuserButton.TabIndex = 3;
            newuserButton.Text = "Add a New User Account";
            newuserButton.UseVisualStyleBackColor = true;
            newuserButton.Click += newuserButton_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 664);
            Controls.Add(newuserButton);
            Controls.Add(viewButton);
            Controls.Add(updateButton);
            Controls.Add(newButton);
            Name = "AdminForm";
            Text = "Administrator View";
            ResumeLayout(false);
        }

        #endregion

        private Button newButton;
        private Button updateButton;
        private Button viewButton;
        private Button newuserButton;
    }
}