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
        private GroupOperation groupOperation;
        private UserOperation userOperation;
        private AlgorithmOperation algorithmOperation;
        private int userId;
        public OtherUsersAlgorithmsForm(int _userId, UserOperation _uo, AlgorithmOperation _ao, GroupOperation _go)
        {
            InitializeComponent();

            userId = _userId;
            userOperation = _uo;
            algorithmOperation = _ao;
            groupOperation = _go;

            userList_cb.DataSource = userOperation.GetUsernames();
            
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
                var AL = groupOperation.GetAccessedAlgorithms(userId);
                var algs = algorithmOperation.GetUserAlgoritms(userOperation.GetUserId(userList_cb.SelectedItem.ToString()));
                List<int> algorithmToShow = algorithmOperation.GetAlgorithmsToShow(AL, algs);
                

                algorithmList_listbox.DataSource = algorithmOperation.GetTitles(algorithmToShow);
            }
        }
    }
}
