namespace Сoursework
{
    partial class LoginForm
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
            loginFormTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            loginBtn = new Button();
            registerBtn = new Button();
            adminBtn = new Button();
            loginTextBox = new TextBox();
            passwordTextBox = new TextBox();
            SuspendLayout();
            // 
            // loginFormTitle
            // 
            loginFormTitle.AutoSize = true;
            loginFormTitle.Font = new Font("Belwe Bd BT", 24F, FontStyle.Regular, GraphicsUnit.Point);
            loginFormTitle.Location = new Point(116, 20);
            loginFormTitle.Name = "loginFormTitle";
            loginFormTitle.Size = new Size(231, 39);
            loginFormTitle.TabIndex = 0;
            loginFormTitle.Text = "Movie Library";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Belwe Bd BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(116, 79);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 1;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Belwe Bd BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(81, 130);
            label2.Name = "label2";
            label2.Size = new Size(98, 23);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Gainsboro;
            loginBtn.FlatAppearance.BorderColor = Color.Black;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Belwe Bd BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.Location = new Point(156, 174);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(142, 23);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Log In";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.Transparent;
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Belwe Bd BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            registerBtn.Location = new Point(156, 203);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(142, 23);
            registerBtn.TabIndex = 3;
            registerBtn.Text = "Sign Up";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // adminBtn
            // 
            adminBtn.BackColor = Color.Transparent;
            adminBtn.FlatAppearance.BorderSize = 0;
            adminBtn.FlatStyle = FlatStyle.Flat;
            adminBtn.Font = new Font("Belwe Bd BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            adminBtn.Location = new Point(141, 232);
            adminBtn.Name = "adminBtn";
            adminBtn.Size = new Size(177, 23);
            adminBtn.TabIndex = 4;
            adminBtn.Text = "Log in as administrator";
            adminBtn.UseVisualStyleBackColor = false;
            adminBtn.Click += adminBtn_Click;
            // 
            // loginTextBox
            // 
            loginTextBox.Font = new Font("Belwe Bd BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginTextBox.Location = new Point(185, 76);
            loginTextBox.MaxLength = 20;
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(162, 26);
            loginTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Belwe Bd BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(185, 127);
            passwordTextBox.MaxLength = 32;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(162, 26);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(457, 273);
            Controls.Add(passwordTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(adminBtn);
            Controls.Add(registerBtn);
            Controls.Add(loginBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginFormTitle);
            MaximumSize = new Size(473, 312);
            MinimumSize = new Size(473, 312);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginFormTitle;
        private Label label1;
        private Label label2;
        private Button loginBtn;
        private Button registerBtn;
        private Button adminBtn;
        private TextBox loginTextBox;
        private TextBox passwordTextBox;
    }
}