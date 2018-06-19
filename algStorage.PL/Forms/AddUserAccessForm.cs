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
    public partial class AddUserAccessForm : Form
    {
        private AlgorithmOperation algorithmOperation;
        private UserOperation userOperation;
        private GroupOperation groupOperation;
        private int algorithmId;
        private int userId;
        public AddUserAccessForm(int _userId, UserOperation _uo, AlgorithmOperation _ao, GroupOperation _go)
        {
            InitializeComponent();
            userId = _userId;

            userOperation = _uo;
            algorithmOperation = _ao;
            groupOperation = _go;

            algorithm_cb.DataSource = algorithmOperation.GetUserAlgorithmTitles(userId);
           
        }

        private void RebootLists()
        {
            algorithmId = algorithmOperation.GetAlgorithmID(userId, algorithm_cb.SelectedItem.ToString());

            usersAccessedList_listbox.DataSource = userOperation.GetUsernames(groupOperation.GetUsersWithAccess(algorithmId));
            usersDeniedList_listbox.DataSource = userOperation.GetUsernames().Except(userOperation.GetUsernames(groupOperation.GetUsersWithAccess(algorithmId))).ToList();
        }

        private void algorithm_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            RebootLists();
        }

        private void giveAccess_btn_Click(object sender, EventArgs e)
        {
            giveAccess();
        }
        private void closeAccess_btn_Click(object sender, EventArgs e)
        {
            closeAccess();
        }
        private void giveAccess()
        {
            int uId, aId;
            try
            {
                uId = userOperation.GetUserId(usersDeniedList_listbox.SelectedItem.ToString());
                aId = algorithmOperation.GetAlgorithmID(userId, algorithm_cb.SelectedItem.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Не вибраний елемент", "Помилка", MessageBoxButtons.OK);
                return;
            }

            if (groupOperation.AddAccess(uId, aId))
            {
                LogGiveAccess_label.Text = "Доступ надано";
                usersDeniedList_listbox.BackColor = Color.FromArgb(192, 255, 192);
            }
            else
            {
                LogGiveAccess_label.Text = "Доступ не надано";
                usersDeniedList_listbox.BackColor = Color.FromArgb(255, 192, 192);
            }
            RebootLists();
            LogGiveAccess_label.Show();

            log_timer.Start();
            color_timer.Start();
        }

        private void closeAccess()
        {
            int uId, aId;
            try
            {
                uId = userOperation.GetUserId(usersAccessedList_listbox.SelectedItem.ToString());
                aId = algorithmOperation.GetAlgorithmID(userId, algorithm_cb.SelectedItem.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Не вибраний елемент", "Помилка", MessageBoxButtons.OK);
                return;
            }

            if (groupOperation.DeleteAccess(uId, aId))
            {
                LogCloseAccess_label.Text = "Доступ закрито";
                usersAccessedList_listbox.BackColor = Color.FromArgb(192, 255, 192);
            }
            else
            {
                LogCloseAccess_label.Text = "Доступ не закрито";
                usersAccessedList_listbox.BackColor = Color.FromArgb(255, 192, 192);
            }
            RebootLists();
            LogCloseAccess_label.Show();

            log_timer.Start();
            color_timer.Start();
        }

        private void usersDeniedList_listbox_DoubleClick(object sender, EventArgs e)
        {
            giveAccess();
        }

        private void usersAccessedList_listbox_DoubleClick(object sender, EventArgs e)
        {
            closeAccess();
        }

        private void color_timer_Tick(object sender, EventArgs e)
        {
            usersAccessedList_listbox.BackColor = SystemColors.Window;
            usersDeniedList_listbox.BackColor = SystemColors.Window;
            color_timer.Stop();
        }

        private void log_timer_Tick(object sender, EventArgs e)
        {
            LogGiveAccess_label.Hide();
            LogCloseAccess_label.Hide();
            log_timer.Stop();
        }
    }
}
