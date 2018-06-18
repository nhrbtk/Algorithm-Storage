using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using algStorage.BLL;

namespace algStorage.PL.Forms
{
    public partial class UserForm : Form
    {
        private int USERID;
        private int ALGORITHMID;
        private bool admin;
        private bool IsActive = false;
        private AlgorithmOperation AO;
        private UserOperation UO;
        public UserForm(int _userId, bool _admin)
        {
            InitializeComponent();

            USERID = _userId;

            admin = _admin;

            списокКористувачівToolStripMenuItem.Visible = всіАлгоритмиToolStripMenuItem.Visible = admin;
            списокКористувачівToolStripMenuItem.Enabled = всіАлгоритмиToolStripMenuItem.Enabled = admin;

            AO = new AlgorithmOperation();
            UO = new UserOperation();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (title_tb.Text == "")
            {
                MessageBox.Show("Введіть назву", "Помилка", MessageBoxButtons.OK);
                return;
            }

            if (AO.TitleExists(USERID, title_tb.Text))
            {
                if (MessageBox.Show("Файл з такою назвою вже існує.\nПерезаписати?", "Помилка", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (!AO.AddAlgorithm(USERID, title_tb.Text, main_rtb.Text, input_rtb.Text, output_rtb.Text))
                        MessageBox.Show("Проблема запису файлу", "Помилка", MessageBoxButtons.OK);
                    else
                    {
                        log_label.Text = "Файл записано";
                        ALGORITHMID = AO.GetAlgorithmID(USERID, title_tb.Text);
                        log_timer.Interval = 3000;
                        log_label.Show();
                        log_timer.Tick += (s, ea) =>
                        {
                            log_label.Hide();
                            log_timer.Stop();
                        };
                        log_timer.Start();
                    }
                }
            }
            else
            {
                if (!AO.AddAlgorithm(USERID, title_tb.Text, main_rtb.Text, input_rtb.Text, output_rtb.Text))
                    MessageBox.Show("Проблема запису файлу", "Помилка", MessageBoxButtons.OK);
                else
                {
                    log_label.Text = "Файл записано";
                    ALGORITHMID = AO.GetAlgorithmID(USERID, title_tb.Text);
                    log_timer.Interval = 3000;
                    log_label.Show();
                    log_timer.Tick += (s, ea) =>
                    {
                        log_label.Hide();
                        log_timer.Stop();
                    };
                    log_timer.Start();
                }
            }
        }

        private void відкритиЗФайлуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                IsActive = true;
                main_rtb.Text = File.ReadAllText(OFD.FileName, Encoding.Unicode);
                title_tb.Text = Path.GetFileNameWithoutExtension(OFD.FileName);
            }
        }

        private void відкритиАлгоритмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsActive)
            {
                if (MessageBox.Show("Хочете зберегти попередній файл?","Зачекайте", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    save_btn.PerformClick();
                }
            }
            

            ChooseFileForm CFF = new ChooseFileForm(USERID);

            if (CFF.ShowDialog() == DialogResult.OK)
            {
                IsActive = true;
                
                string selected = CFF.algList_listbox.SelectedItem.ToString();
                ALGORITHMID = AO.GetAlgorithmID(USERID, selected);
                main_rtb.Text = AO.GetAlgoritmCode(ALGORITHMID);
                input_rtb.Text = AO.GetAlgoritmInput(ALGORITHMID);
                output_rtb.Text = AO.GetAlgoritmOutput(ALGORITHMID);
                title_tb.Text = selected;
            }

        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save_btn.PerformClick();
        }

        private void всіАлгоритмиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllFilesForm AFL = new AllFilesForm();
            if (AFL.ShowDialog() == DialogResult.OK & AFL.algorithmList_listbox.SelectedIndex != -1)
            {
                ALGORITHMID = AO.GetAlgorithmID(UO.GetUserId(AFL.usersList_listbox.SelectedItem.ToString()), AFL.algorithmList_listbox.SelectedItem.ToString());
                main_rtb.Text = AO.GetAlgoritmCode(ALGORITHMID);
                input_rtb.Text = AO.GetAlgoritmInput(ALGORITHMID);
                output_rtb.Text = AO.GetAlgoritmOutput(ALGORITHMID);
            }
        }

        private void мійПрофільToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyProfileInfoForm MPIF = new MyProfileInfoForm(USERID);
            MPIF.ShowDialog();
        }

        private void списокКористувачівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllUsersForm AUF = new AllUsersForm();
            AUF.ShowDialog();
        }

        private void надатиДоступІншимToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserAccessForm AUAF = new AddUserAccessForm(USERID);
            AUAF.ShowDialog();
        }

        private void закритипрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете закрити програму?", "Закрити", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DialogResult = DialogResult.Abort;
                Close();
            }
        }

        private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете вийти з користувача?", "Вийти", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void алгоритмиІншихКористувачівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtherUsersAlgorithmsForm OUALF = new OtherUsersAlgorithmsForm(USERID);
            
            if(OUALF.ShowDialog()==DialogResult.OK)
            {
                IsActive = true;
                int uId = UO.GetUserId(OUALF.userList_cb.SelectedItem.ToString());
                string selected = OUALF.algorithmList_listbox.SelectedItem.ToString();
                ALGORITHMID = AO.GetAlgorithmID(uId, selected);
                main_rtb.Text = AO.GetAlgoritmCode(ALGORITHMID);
                input_rtb.Text = AO.GetAlgoritmInput(ALGORITHMID);
                output_rtb.Text = AO.GetAlgoritmOutput(ALGORITHMID);
                title_tb.Text = selected;
            }
        }
    }
}
