﻿using System;
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
        private AlgorithmOperation AO;
        private UserOperation UO;
        private GroupOperation GO;
        public AllUsersForm()
        {
            InitializeComponent();
            UO = new UserOperation();
            AO = new AlgorithmOperation();
            GO = new GroupOperation();
            usersList_listbox.DataSource = UO.GetUsernames();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ви впевнені, що хочете видалити цього користувача та всі його алгоритми?", "Попередження", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int uId = UO.GetUserId(usersList_listbox.SelectedItem.ToString());
                var algs = AO.GetUserAlgoritms(uId);
                var accessedAlgorithms = GO.GetAccessedAlgorithms(uId);
                foreach (var a in accessedAlgorithms)
                    GO.DeleteAccess(uId, a);
                foreach (var a in algs)
                    AO.DeleteAlgorithm(a);
                UO.UserDelete(uId);
                AO.DeleteDirectory(uId);
                usersList_listbox.DataSource = UO.GetUsernames();
            }
        }
    }
}
