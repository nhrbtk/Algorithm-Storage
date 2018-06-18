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
        private AlgorithmOperation AO;
        private int USERID;
        public ChooseFileForm(int _userId)
        {
            InitializeComponent();
            AO = new AlgorithmOperation();
            USERID = _userId;
            algList_listbox.DataSource = AO.GetTitles(USERID);
        }

        private void choose_btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Ви впевнені, що хочете видалити алгоритм '{algList_listbox.SelectedItem.ToString()}'?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!AO.DeleteAlgorithm(AO.GetAlgorithmID(USERID, algList_listbox.SelectedItem.ToString())))
                    MessageBox.Show("Щось пішло не так", "Помилка", MessageBoxButtons.OK);
                else
                    algList_listbox.DataSource = AO.GetTitles(USERID);
            }
        }

        private void algList_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            choose_btn.Enabled = delete_btn.Enabled = true;
        }
    }
}
