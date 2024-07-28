namespace MovieListingApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginLabel = new Label();
            usernameLabel = new Label();
            passwordLabel = new Label();
            usernameTB = new TextBox();
            passwordTB = new TextBox();
            loginButton = new Button();
            resetButton = new Button();
            registerButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 16F);
            loginLabel.Location = new Point(167, 41);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(832, 65);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "Login to the Movie Listing Application";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(207, 174);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(142, 37);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(215, 254);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(134, 37);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password:";
            // 
            // usernameTB
            // 
            usernameTB.Location = new Point(402, 171);
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(524, 43);
            usernameTB.TabIndex = 3;
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(402, 251);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(524, 43);
            passwordTB.TabIndex = 4;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(326, 365);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(169, 52);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(624, 365);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(169, 52);
            resetButton.TabIndex = 6;
            resetButton.Text = "Reset Form";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(927, 508);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(129, 52);
            registerButton.TabIndex = 7;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(927, 606);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(129, 52);
            exitButton.TabIndex = 8;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // LoginForm
            // 
            AcceptButton = loginButton;
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(1130, 708);
            Controls.Add(exitButton);
            Controls.Add(registerButton);
            Controls.Add(resetButton);
            Controls.Add(loginButton);
            Controls.Add(passwordTB);
            Controls.Add(usernameTB);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(loginLabel);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox usernameTB;
        private TextBox passwordTB;
        private Button loginButton;
        private Button resetButton;
        private Button registerButton;
        private Button exitButton;
    }
}
