using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сoursework
{
    public partial class RegisterForm: Form
    {
        private string usersFile = "";

        public RegisterForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;
            this.KeyDown += RegisterForm_KeyDown;
        }
        private void RegisterForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                registerBtn.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                var result = MessageBox.Show("Are you sure you want to exit?", "Exit confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show("To sign up, enter your username, password, name, surname and email. If you already have an account, click the button 'Log in'\nSign Up - Enter\nEscape - Esc\nHelp - F1", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            string name = nameTextBox.Text.Trim();
            string surname = surnameTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();

            if(string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!email.Contains("@"))
            {
                MessageBox.Show("Email must contain '@'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UserManager.IsLoginTaken(login))
            {
                MessageBox.Show("User with this login already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User newUser = new User
            {
                Login = login,
                Password = password,
                Name = name,
                Surname = surname,
                Email = email
            };

            UserManager.AddUser(newUser);

            UserForm userForm = new UserForm(login);
            userForm.Show();
            this.Hide();
        }
        private void adminBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
