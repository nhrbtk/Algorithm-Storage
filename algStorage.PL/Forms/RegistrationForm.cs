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
    public partial class RegistrationForm : Form
    {
        private UserOperation UO;
        public RegistrationForm()
        {
            InitializeComponent();
            UO = new UserOperation();
        }

        private void registration_btn_Click(object sender, EventArgs e)
        {
            if (!IsMethods.IsUsername(username_tb.Text))
            {
                MessageBox.Show("Довжина ім'я користувача має бути від 6 до 20 символів та складатись з латинських літер, цифр або символів -_.", "Помилка!", MessageBoxButtons.OK);
                return;
            }
                
            if (!IsMethods.IsPassword(password_tb.Text))
            {
                MessageBox.Show("Довжина паролю має бути від 6 до 32 символів та складатись з латинських літер, цифр або спецсимволів", "Помилка!", MessageBoxButtons.OK);
                return;
            }
                

            if (UO.UserAdd(username_tb.Text, password_tb.Text, admin_checkbox.Checked))
            {
                MessageBox.Show("Користувача створено!", "Вітаємо!", MessageBoxButtons.OK);
                Close();
            }
            else
                MessageBox.Show("Користувач з таким ім'ям вже існує!", "Спробуйте ще", MessageBoxButtons.OK);
        }

        private void ToLoginForm_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
