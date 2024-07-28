namespace MovieListingApp
{
    partial class RegistrationForm
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
            exitButton = new Button();
            loginButton = new Button();
            resetButton = new Button();
            registerButton = new Button();
            passwordTB = new TextBox();
            usernameTB = new TextBox();
            passwordLabel = new Label();
            usernameLabel = new Label();
            registerLabel = new Label();
            firstnameLabel = new Label();
            lastnameLabel = new Label();
            emailLabel = new Label();
            lastnameTB = new TextBox();
            firstnameTB = new TextBox();
            emailTB = new TextBox();
            adminCB = new CheckBox();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Location = new Point(905, 733);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(129, 52);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(905, 635);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(129, 52);
            loginButton.TabIndex = 16;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(569, 636);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(169, 52);
            resetButton.TabIndex = 15;
            resetButton.Text = "Reset Form";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(271, 636);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(169, 52);
            registerButton.TabIndex = 5;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(347, 473);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(524, 43);
            passwordTB.TabIndex = 4;
            // 
            // usernameTB
            // 
            usernameTB.Location = new Point(347, 395);
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(524, 43);
            usernameTB.TabIndex = 3;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(160, 476);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(134, 37);
            passwordLabel.TabIndex = 11;
            passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(152, 401);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(142, 37);
            usernameLabel.TabIndex = 10;
            usernameLabel.Text = "Username:";
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Segoe UI", 16F);
            registerLabel.Location = new Point(112, 74);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(901, 65);
            registerLabel.TabIndex = 9;
            registerLabel.Text = "Register for the Movie Listing Application";
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new Point(173, 186);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new Size(144, 37);
            firstnameLabel.TabIndex = 20;
            firstnameLabel.Text = "First Name";
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new Point(525, 186);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new Size(142, 37);
            lastnameLabel.TabIndex = 19;
            lastnameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(206, 320);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(88, 37);
            emailLabel.TabIndex = 20;
            emailLabel.Text = "Email:";
            // 
            // lastnameTB
            // 
            lastnameTB.Location = new Point(525, 233);
            lastnameTB.Name = "lastnameTB";
            lastnameTB.Size = new Size(346, 43);
            lastnameTB.TabIndex = 1;
            // 
            // firstnameTB
            // 
            firstnameTB.Location = new Point(173, 233);
            firstnameTB.Name = "firstnameTB";
            firstnameTB.Size = new Size(346, 43);
            firstnameTB.TabIndex = 0;
            // 
            // emailTB
            // 
            emailTB.Location = new Point(347, 317);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(524, 43);
            emailTB.TabIndex = 2;
            // 
            // adminCB
            // 
            adminCB.AutoSize = true;
            adminCB.Location = new Point(347, 552);
            adminCB.Name = "adminCB";
            adminCB.Size = new Size(127, 41);
            adminCB.TabIndex = 22;
            adminCB.Text = "Admin";
            adminCB.UseVisualStyleBackColor = true;
            adminCB.Visible = false;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 844);
            Controls.Add(adminCB);
            Controls.Add(emailTB);
            Controls.Add(firstnameTB);
            Controls.Add(lastnameTB);
            Controls.Add(emailLabel);
            Controls.Add(lastnameLabel);
            Controls.Add(firstnameLabel);
            Controls.Add(exitButton);
            Controls.Add(loginButton);
            Controls.Add(resetButton);
            Controls.Add(registerButton);
            Controls.Add(passwordTB);
            Controls.Add(usernameTB);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(registerLabel);
            Name = "RegistrationForm";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitButton;
        private Button loginButton;
        private Button resetButton;
        private Button registerButton;
        private TextBox passwordTB;
        private TextBox usernameTB;
        private Label passwordLabel;
        private Label usernameLabel;
        private Label registerLabel;
        private Label firstnameLabel;
        private Label lastnameLabel;
        private Label emailLabel;
        private TextBox lastnameTB;
        private TextBox firstnameTB;
        private TextBox emailTB;
        private CheckBox adminCB;
    }
}