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
    public partial class UserForm : Form
    {
        private int userId;
        private AlgorithmOperation AO;
        public UserForm(int _userId)
        {
            InitializeComponent();

            userId = _userId;
            AO = new AlgorithmOperation();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (title_tb.Text == "")
            {
                MessageBox.Show("Введіть назву", "Помилка", MessageBoxButtons.OK);
                return;
            }

            
        }
    }
}
