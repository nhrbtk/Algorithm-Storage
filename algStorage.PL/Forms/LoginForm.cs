using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using algStorage.BLL;

namespace algStorage.PL.Forms
{
    public partial class LoginForm : Form
    {
        UserOperation userOperation;
        public LoginForm()
        {
            InitializeComponent();
            userOperation = new UserOperation();
        }

        private void CheckUser_btn_Click(object sender, EventArgs e)
        {
            if (userOperation.UserAuthentication(username_tb.Text, password_tb.Text))
            {
                MessageBox.Show("Вхід виконано!", "Вітаємо!", MessageBoxButtons.OK);
                if (userOperation.UserAuthorization(username_tb.Text))
                {
                    AdminForm AF = new AdminForm();
                    Hide();
                    AF.Show();
                }
                else
                {
                    UserForm UF = new UserForm(userOperation.GetUserId(username_tb.Text));
                    Hide();
                    UF.Show();
                }
            }
            else
                MessageBox.Show("Невірне ім'я користувача або пароль!\nСпробуйте знову.", "Помилка!", MessageBoxButtons.OK);
        }

        private void registration_btn_Click(object sender, EventArgs e)
        {
            RegistrationForm RF = new RegistrationForm();
            Hide();
            RF.ShowDialog();
            Show();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
