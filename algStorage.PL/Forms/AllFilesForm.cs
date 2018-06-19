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
    public partial class AllFilesForm : Form
    {
        private UserOperation userOperation;
        private AlgorithmOperation algorithmOperation;
        public AllFilesForm(UserOperation _uo, AlgorithmOperation _ao)
        {
            InitializeComponent();

            userOperation = _uo;
            algorithmOperation = _ao;

            usersList_listbox.DataSource = userOperation.GetUsernames();
        }

        private void usersList_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            algorithmList_listbox.DataSource = algorithmOperation.GetUserAlgorithmTitles(userOperation.GetUserId(usersList_listbox.SelectedItem.ToString()));
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (algorithmList_listbox.SelectedIndex == -1)
            {
                MessageBox.Show("Алгоритм не вибрано", "Помилка", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (MessageBox.Show("Ви впевнені, що хочете видалити цей алгоритм?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (!algorithmOperation.DeleteAlgorithm(algorithmOperation.GetAlgorithmID(userOperation.GetUserId(usersList_listbox.SelectedItem.ToString()), algorithmList_listbox.SelectedItem.ToString())))
                        MessageBox.Show("Не вдалось видалити файл", "Невдача", MessageBoxButtons.OK);
                    else
                        algorithmList_listbox.DataSource = algorithmOperation.GetUserAlgorithmTitles(userOperation.GetUserId(usersList_listbox.SelectedItem.ToString()));
                }
            }
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
