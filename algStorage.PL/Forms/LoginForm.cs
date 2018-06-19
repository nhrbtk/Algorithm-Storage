using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using algStorage.DAL_ADO.Repositories;
using algStorage.DAL.Repositories;

using algStorage.BLL;

namespace algStorage.PL.Forms
{
    public partial class LoginForm : Form
    {
        UserOperation userOperation;
        AlgorithmOperation algorithmOperation;
        GroupOperation groupOperation;
        public LoginForm()
        {
            InitializeComponent();
            userOperation = new UserOperation(new UserRepository());
            algorithmOperation = new AlgorithmOperation(new AlgorithmRepository());
            groupOperation = new GroupOperation(new AccessGroupRepository());
        }

        private void CheckUser_btn_Click(object sender, EventArgs e)
        {
            if (userOperation.UserAuthentication(username_tb.Text, password_tb.Text))
            {
                MessageBox.Show("Вхід виконано!", "Вітаємо!", MessageBoxButtons.OK);

                int userId = userOperation.GetUserId(username_tb.Text);
                bool r = userOperation.UserAuthorization(userOperation.GetUserId(username_tb.Text));


                UserForm UF = new UserForm(userId, r, userOperation, algorithmOperation, groupOperation);
                Hide();
                if (UF.ShowDialog() == DialogResult.Cancel)
                    Show();
                else
                    Close();
            }
            else
                MessageBox.Show("Невірне ім'я користувача або пароль!\nСпробуйте знову.", "Помилка!", MessageBoxButtons.OK);
        }

        private void registration_btn_Click(object sender, EventArgs e)
        {
            RegistrationForm RF = new RegistrationForm(userOperation);
            Hide();
            RF.ShowDialog();
            Show();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ado_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (ef_rb.Checked)
            {
                userOperation = new UserOperation(new UserRepository());
                algorithmOperation = new AlgorithmOperation(new AlgorithmRepository());
                groupOperation = new GroupOperation(new AccessGroupRepository());
            }
        }

        private void ef_rb_CheckedChanged(object sender, EventArgs e)
        {
            if(ef_rb.Checked)
            {
                userOperation = new UserOperation(new UserRepositoryEF());
                algorithmOperation = new AlgorithmOperation(new AlgorithmRepositoryEF());
                groupOperation = new GroupOperation(new AccessGroupRepositoryEF());
            }
        }
    }
}
