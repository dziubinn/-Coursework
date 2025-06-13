namespace Сoursework
{
    partial class RegisterForm
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
            passwordTextBox = new TextBox();
            loginTextBox = new TextBox();
            adminBtn = new Button();
            registerBtn = new Button();
            loginBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            loginFormTitle = new Label();
            surnameTextBox = new TextBox();
            nameTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            emailTextBox = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Belwe Bd BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(200, 126);
            passwordTextBox.MaxLength = 32;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(162, 26);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginTextBox
            // 
            loginTextBox.Font = new Font("Belwe Bd BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginTextBox.Location = new Point(200, 75);
            loginTextBox.MaxLength = 20;
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(162, 26);
            loginTextBox.TabIndex = 0;
            // 
            // adminBtn
            // 
            adminBtn.BackColor = Color.Transparent;
            adminBtn.FlatAppearance.BorderSize = 0;
            adminBtn.FlatStyle = FlatStyle.Flat;
            adminBtn.Font = new Font("Belwe Bd BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            adminBtn.Location = new Point(159, 388);
            adminBtn.Name = "adminBtn";
            adminBtn.Size = new Size(177, 23);
            adminBtn.TabIndex = 7;
            adminBtn.Text = "Log in as administrator";
            adminBtn.UseVisualStyleBackColor = false;
            adminBtn.Click += adminBtn_Click;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.Gainsboro;
            registerBtn.FlatAppearance.BorderColor = Color.Black;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Belwe Bd BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            registerBtn.Location = new Point(173, 321);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(142, 23);
            registerBtn.TabIndex = 5;
            registerBtn.Text = "Sign Up";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Transparent;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Belwe Bd BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.Location = new Point(173, 359);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(142, 23);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "Log In";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Belwe Bd BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(96, 129);
            label2.Name = "label2";
            label2.Size = new Size(98, 23);
            label2.TabIndex = 10;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Belwe Bd BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(131, 78);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 9;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // loginFormTitle
            // 
            loginFormTitle.AutoSize = true;
            loginFormTitle.Font = new Font("Belwe Bd BT", 24F, FontStyle.Regular, GraphicsUnit.Point);
            loginFormTitle.Location = new Point(131, 19);
            loginFormTitle.Name = "loginFormTitle";
            loginFormTitle.Size = new Size(231, 39);
            loginFormTitle.TabIndex = 8;
            loginFormTitle.Text = "Movie Library";
            // 
            // surnameTextBox
            // 
            surnameTextBox.Font = new Font("Belwe Bd BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            surnameTextBox.Location = new Point(200, 222);
            surnameTextBox.MaxLength = 20;
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(162, 26);
            surnameTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Belwe Bd BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.Location = new Point(200, 172);
            nameTextBox.MaxLength = 20;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(162, 26);
            nameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Belwe Bd BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(96, 225);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 17;
            label3.Text = "Surname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Belwe Bd BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(130, 175);
            label4.Name = "label4";
            label4.Size = new Size(63, 23);
            label4.TabIndex = 16;
            label4.Text = "Name";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Belwe Bd BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.Location = new Point(200, 271);
            emailTextBox.MaxLength = 20;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(162, 26);
            emailTextBox.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Belwe Bd BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(126, 274);
            label5.Name = "label5";
            label5.Size = new Size(65, 23);
            label5.TabIndex = 20;
            label5.Text = "Email";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(457, 436);
            Controls.Add(emailTextBox);
            Controls.Add(label5);
            Controls.Add(surnameTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(passwordTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(adminBtn);
            Controls.Add(registerBtn);
            Controls.Add(loginBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginFormTitle);
            MaximumSize = new Size(473, 475);
            MinimumSize = new Size(473, 475);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwordTextBox;
        private TextBox loginTextBox;
        private Button adminBtn;
        private Button registerBtn;
        private Button loginBtn;
        private Label label2;
        private Label label1;
        private Label loginFormTitle;
        private TextBox surnameTextBox;
        private TextBox nameTextBox;
        private Label label3;
        private Label label4;
        private TextBox emailTextBox;
        private Label label5;
    }
}