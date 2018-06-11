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
    /// Логика взаимодействия для registrationWindow.xaml
    /// </summary>
    public partial class registrationWindow : Window
    {
        public registrationWindow()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, RoutedEventArgs e)
        {
            UserOperation UO = new UserOperation();
            if(UO.UserAdd(username_tb.Text, password_tb.Password, (bool)admin_checkbox.IsChecked))
            {
                MessageBox.Show("Користувач успішно створений!", "Реєстрація завершена!", MessageBoxButton.OK);
                StartDialog sd = new StartDialog();
                Close();
                sd.Show();
            }
            else
            {
                MessageBox.Show("Такий користувач уже існує!", "Спробуйте знову");
            }
        }

        private void backtoLoginWindow_Click(object sender, RoutedEventArgs e)
        {
            StartDialog sd = new StartDialog();
            Close();
            sd.Show();
        }
    }
}
