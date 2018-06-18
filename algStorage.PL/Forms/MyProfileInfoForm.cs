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
    public partial class MyProfileInfoForm : Form
    {
        private UserOperation UO;
        private AlgorithmOperation AO;
        private int userId;
        public MyProfileInfoForm(int _userId)
        {
            InitializeComponent();
            UO = new UserOperation();
            AO = new AlgorithmOperation();
            userId = _userId;

            username_label.Text = $"Ім'я користувача: {UO.GetUsername(userId)}";

            string type = UO.UserAuthorization(userId) ? "Адміністратор" : "Користувач";
            role_label.Text = $"Тип профілю: {type}";

            algorithmsCount_label.Text = $"Кількість алгоритмів у сховищі: {AO.GetUserAlgoritms(userId).Count().ToString()}";
        }

        private void ChangePassword_btn_Click(object sender, EventArgs e)
        {
            if (newPassword_tb.Text == "")
            {
                MessageBox.Show("Ви не ввели новий пароль", "Новий пароль", MessageBoxButtons.OK);
                return;
            }

            if (!IsMethods.IsPassword(newPassword_tb.Text))
            {
                MessageBox.Show("Довжина паролю має бути від 6 до 32 символів та складатись з латинських літер, цифр або спецсимволів", "Помилка!", MessageBoxButtons.OK);
                return;
            }

            if (!UO.UserAuthentication(UO.GetUsername(userId), oldPassword_tb.Text))
                MessageBox.Show("Теперішній пароль не співпадає", "Теперішній пароль", MessageBoxButtons.OK);
            else
            {
                if (!UO.UserChangePassword(userId, newPassword_tb.Text))
                    MessageBox.Show("Щось пішло не так", "Виникла проблема", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Пароль змінено!", "Успішно", MessageBoxButtons.OK);
            }
        }
    }
}
