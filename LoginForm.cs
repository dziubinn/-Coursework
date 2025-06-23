using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сoursework
{
    /// <summary>
    /// Форма авторизації користувача, що дозволяє увійти як звичайний користувач, зареєструвати новий акаунт або увійти як адміністратор.
    /// Підтримує клавіатурні скорочення для зручної навігації.
    /// </summary>
    public partial class LoginForm : Form
    {
        /// <summary>Ініціалізує форму авторизації та встановлює позицію на екрані, а також обробку клавіш.</summary>
        public LoginForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += LoginForm_KeyDown;
        }

        /// <summary>
        /// Обробляє натискання клавіш Enter, Escape і F1:
        /// — Enter: виконує спробу входу;
        /// — Escape: запитує підтвердження на вихід;
        /// — F1: виводить довідкове повідомлення.
        /// </summary>
        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                loginBtn.PerformClick();
                e.Handled = true;
            }
            else if(e.KeyCode == Keys.Escape)
            {
                var result = MessageBox.Show("Are you sure you want to exit?", "Exit confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                e.Handled = true;
            }
            else if(e.KeyCode == Keys.F1)
            {
                MessageBox.Show("To log in, enter your username and password. If you are not yet registered, click the button 'Sign up'\nLog In - Enter\nEscape - Esc\nHelp - F1", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>Обробник кнопки входу: перевіряє логін і пароль, виконує авторизацію або виводить повідомлення про помилку.</summary>
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string enteredLogin = loginTextBox.Text.Trim();
            string enteredPassword = passwordTextBox.Text;

            if (string.IsNullOrEmpty(enteredLogin) || string.IsNullOrEmpty(enteredPassword))
            {
                MessageBox.Show("Please enter both login and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (enteredPassword.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = UserManager.FindUser(enteredLogin, enteredPassword);
            if(user != null)
            {
                UserForm userForm = new UserForm(enteredLogin);
                userForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Відкриває форму реєстрації нового користувача.</summary>
        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        /// <summary>Відкриває головну форму в режимі адміністратора.</summary>
        private void adminBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

    }
}
