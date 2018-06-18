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
        private UserOperation UO;
        private AlgorithmOperation AO;
        public AllFilesForm()
        {
            InitializeComponent();

            UO = new UserOperation();
            AO = new AlgorithmOperation();

            usersList_listbox.DataSource = UO.GetUsernames();
        }

        private void usersList_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            algorithmList_listbox.DataSource = AO.GetUserAlgorithmTitles(UO.GetUserId(usersList_listbox.SelectedItem.ToString()));
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
                    if (!AO.DeleteAlgorithm(AO.GetAlgorithmID(UO.GetUserId(usersList_listbox.SelectedItem.ToString()), algorithmList_listbox.SelectedItem.ToString())))
                        MessageBox.Show("Не вдалось видалити файл", "Невдача", MessageBoxButtons.OK);
                    else
                        algorithmList_listbox.DataSource = AO.GetUserAlgorithmTitles(UO.GetUserId(usersList_listbox.SelectedItem.ToString()));
                }
            }
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
