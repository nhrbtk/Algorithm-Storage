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
    public partial class OtherUsersAlgorithmsForm : Form
    {
        private GroupOperation GO;
        private UserOperation UO;
        private AlgorithmOperation AO;
        private int userId;
        public OtherUsersAlgorithmsForm(int _userId)
        {
            InitializeComponent();

            userId = _userId;
            GO = new GroupOperation();
            UO = new UserOperation();
            AO = new AlgorithmOperation();

            userList_cb.DataSource = UO.GetUsernames();
            
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            if (algorithmList_listbox.SelectedIndex != -1)
                DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Ви не вибрали файл", "Помилка", MessageBoxButtons.OK);
        }

        private void userList_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userList_cb.SelectedIndex != -1)
            {
                var AL = GO.GetAccessedAlgorithms(userId);
                var algs = AO.GetUserAlgoritms(UO.GetUserId(userList_cb.SelectedItem.ToString()));
                List<int> algorithmToShow = AO.GetAlgorithmsToShow(AL, algs);
                

                algorithmList_listbox.DataSource = AO.GetTitles(algorithmToShow);
            }
        }
    }
}
