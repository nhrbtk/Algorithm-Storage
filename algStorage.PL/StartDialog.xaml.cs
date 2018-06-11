using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using algStorage.BLL;

namespace algStorage.PL
{
    /// <summary>
    /// Логика взаимодействия для StartDialog.xaml
    /// </summary>
    public partial class StartDialog : Window
    {
        public StartDialog()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, RoutedEventArgs e)
        {
            UserOperation UO = new UserOperation();
            if (UO.UserAuthentication(username_tb.Text, password_tb.Password))
            {
                MessageBox.Show("ENTER ACCESS!");
            }
            else
            {
                MessageBox.Show("Неправильне ім'я користувача або пароль", "Помилка входу", MessageBoxButton.OK);
            }
        }

        private void registration_btn_Click(object sender, RoutedEventArgs e)
        {
            registrationWindow rw = new registrationWindow();
            Close();
            rw.ShowDialog();
        }
    }
}
