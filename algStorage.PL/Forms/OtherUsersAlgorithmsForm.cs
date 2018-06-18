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

            var AL = GO.GetAccessedAlgorithms(userId);
            var UL = AO.GetAlgorithmsAuthors(AL);
            userList_cb.DataSource = UO.GetUsernames(UL);

            algorithmList_listbox.DataSource = AL;
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
