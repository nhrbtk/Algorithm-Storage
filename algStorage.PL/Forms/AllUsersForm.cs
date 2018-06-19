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
    public partial class AllUsersForm : Form
    {
        private AlgorithmOperation algorithmOperation;
        private UserOperation userOperation;
        private GroupOperation groupOperation;
        public AllUsersForm(UserOperation _uo, AlgorithmOperation _ao, GroupOperation _go)
        {
            InitializeComponent();
            userOperation = _uo;
            algorithmOperation = _ao;
            groupOperation = _go;
            usersList_listbox.DataSource = userOperation.GetUsernames();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ви впевнені, що хочете видалити цього користувача та всі його алгоритми?", "Попередження", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int uId = userOperation.GetUserId(usersList_listbox.SelectedItem.ToString());
                var algs = algorithmOperation.GetUserAlgoritms(uId);
                var accessedAlgorithms = groupOperation.GetAccessedAlgorithms(uId);
                foreach (var a in accessedAlgorithms)
                    groupOperation.DeleteAccess(uId, a);
                foreach (var a in algs)
                    algorithmOperation.DeleteAlgorithm(a);
                userOperation.UserDelete(uId);
                algorithmOperation.DeleteDirectory(uId);
                usersList_listbox.DataSource = userOperation.GetUsernames();
            }
        }
    }
}
