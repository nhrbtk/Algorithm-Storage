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
    public partial class ChooseFileForm : Form
    {
        private AlgorithmOperation algorithmOperation;
        private GroupOperation groupOperation;
        private int USERID;
        public ChooseFileForm(int _userId, AlgorithmOperation _ao, GroupOperation _go)
        {
            InitializeComponent();
            algorithmOperation = _ao;
            groupOperation = _go;
            USERID = _userId;
            algList_listbox.DataSource = algorithmOperation.GetTitles(USERID);
        }

        private void choose_btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Ви впевнені, що хочете видалити алгоритм '{algList_listbox.SelectedItem.ToString()}'?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int algId = algorithmOperation.GetAlgorithmID(USERID, algList_listbox.SelectedItem.ToString());

                var links = groupOperation.GetUsersWithAccess(algId);

                foreach (var l in links)
                    groupOperation.DeleteAccess(l, algId);

                if (!algorithmOperation.DeleteAlgorithm(algId))
                    MessageBox.Show("Щось пішло не так", "Помилка", MessageBoxButtons.OK);
                else
                    algList_listbox.DataSource = algorithmOperation.GetTitles(USERID);
            }
        }

        private void algList_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            choose_btn.Enabled = delete_btn.Enabled = true;
        }
    }
}
