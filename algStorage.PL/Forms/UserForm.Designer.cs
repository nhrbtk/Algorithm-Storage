namespace algStorage.PL.Forms
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиЗФайлуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сховищеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиАлгоритмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.надатиДоступІншимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всіАлгоритмиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.користувачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокКористувачівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мійПрофільToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.вийтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_rtb = new System.Windows.Forms.RichTextBox();
            this.input_rtb = new System.Windows.Forms.RichTextBox();
            this.output_rtb = new System.Windows.Forms.RichTextBox();
            this.title_tb = new System.Windows.Forms.TextBox();
            this.title_label = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.log_label = new System.Windows.Forms.Label();
            this.log_timer = new System.Windows.Forms.Timer(this.components);
            this.алгоритмиІншихКористувачівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.сховищеToolStripMenuItem,
            this.користувачToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відкритиЗФайлуToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // відкритиЗФайлуToolStripMenuItem
            // 
            this.відкритиЗФайлуToolStripMenuItem.Name = "відкритиЗФайлуToolStripMenuItem";
            this.відкритиЗФайлуToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.відкритиЗФайлуToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.відкритиЗФайлуToolStripMenuItem.Text = "Відкрити з файлу";
            this.відкритиЗФайлуToolStripMenuItem.Click += new System.EventHandler(this.відкритиЗФайлуToolStripMenuItem_Click);
            // 
            // сховищеToolStripMenuItem
            // 
            this.сховищеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відкритиАлгоритмToolStripMenuItem,
            this.надатиДоступІншимToolStripMenuItem,
            this.алгоритмиІншихКористувачівToolStripMenuItem,
            this.всіАлгоритмиToolStripMenuItem,
            this.toolStripSeparator1,
            this.зберегтиToolStripMenuItem});
            this.сховищеToolStripMenuItem.Name = "сховищеToolStripMenuItem";
            this.сховищеToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.сховищеToolStripMenuItem.Text = "Сховище";
            // 
            // відкритиАлгоритмToolStripMenuItem
            // 
            this.відкритиАлгоритмToolStripMenuItem.Name = "відкритиАлгоритмToolStripMenuItem";
            this.відкритиАлгоритмToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.відкритиАлгоритмToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.відкритиАлгоритмToolStripMenuItem.Text = "Мої алгоритми";
            this.відкритиАлгоритмToolStripMenuItem.Click += new System.EventHandler(this.відкритиАлгоритмToolStripMenuItem_Click);
            // 
            // надатиДоступІншимToolStripMenuItem
            // 
            this.надатиДоступІншимToolStripMenuItem.Name = "надатиДоступІншимToolStripMenuItem";
            this.надатиДоступІншимToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.надатиДоступІншимToolStripMenuItem.Text = "Надати доступ іншим";
            this.надатиДоступІншимToolStripMenuItem.Click += new System.EventHandler(this.надатиДоступІншимToolStripMenuItem_Click);
            // 
            // всіАлгоритмиToolStripMenuItem
            // 
            this.всіАлгоритмиToolStripMenuItem.Name = "всіАлгоритмиToolStripMenuItem";
            this.всіАлгоритмиToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.всіАлгоритмиToolStripMenuItem.Text = "Всі алгоритми";
            this.всіАлгоритмиToolStripMenuItem.Click += new System.EventHandler(this.всіАлгоритмиToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(244, 6);
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.зберегтиToolStripMenuItem_Click);
            // 
            // користувачToolStripMenuItem
            // 
            this.користувачToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокКористувачівToolStripMenuItem,
            this.мійПрофільToolStripMenuItem,
            this.toolStripSeparator2,
            this.вийтиToolStripMenuItem,
            this.закритиToolStripMenuItem});
            this.користувачToolStripMenuItem.Name = "користувачToolStripMenuItem";
            this.користувачToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.користувачToolStripMenuItem.Text = "Користувач";
            // 
            // списокКористувачівToolStripMenuItem
            // 
            this.списокКористувачівToolStripMenuItem.Name = "списокКористувачівToolStripMenuItem";
            this.списокКористувачівToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.списокКористувачівToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.списокКористувачівToolStripMenuItem.Text = "Список користувачів";
            this.списокКористувачівToolStripMenuItem.Click += new System.EventHandler(this.списокКористувачівToolStripMenuItem_Click);
            // 
            // мійПрофільToolStripMenuItem
            // 
            this.мійПрофільToolStripMenuItem.Name = "мійПрофільToolStripMenuItem";
            this.мійПрофільToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.мійПрофільToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.мійПрофільToolStripMenuItem.Text = "Мій профіль";
            this.мійПрофільToolStripMenuItem.Click += new System.EventHandler(this.мійПрофільToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(229, 6);
            // 
            // вийтиToolStripMenuItem
            // 
            this.вийтиToolStripMenuItem.Name = "вийтиToolStripMenuItem";
            this.вийтиToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.вийтиToolStripMenuItem.Text = "Вийти з користувача";
            this.вийтиToolStripMenuItem.Click += new System.EventHandler(this.вийтиToolStripMenuItem_Click);
            // 
            // закритиToolStripMenuItem
            // 
            this.закритиToolStripMenuItem.Name = "закритиToolStripMenuItem";
            this.закритиToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.закритиToolStripMenuItem.Text = "Закрити програму";
            this.закритиToolStripMenuItem.Click += new System.EventHandler(this.закритипрограмуToolStripMenuItem_Click);
            // 
            // main_rtb
            // 
            this.main_rtb.Location = new System.Drawing.Point(0, 54);
            this.main_rtb.Name = "main_rtb";
            this.main_rtb.Size = new System.Drawing.Size(730, 373);
            this.main_rtb.TabIndex = 1;
            this.main_rtb.Text = "";
            // 
            // input_rtb
            // 
            this.input_rtb.Location = new System.Drawing.Point(736, 54);
            this.input_rtb.Name = "input_rtb";
            this.input_rtb.Size = new System.Drawing.Size(142, 96);
            this.input_rtb.TabIndex = 2;
            this.input_rtb.Text = "";
            // 
            // output_rtb
            // 
            this.output_rtb.Location = new System.Drawing.Point(736, 331);
            this.output_rtb.Name = "output_rtb";
            this.output_rtb.Size = new System.Drawing.Size(142, 96);
            this.output_rtb.TabIndex = 3;
            this.output_rtb.Text = "";
            // 
            // title_tb
            // 
            this.title_tb.Location = new System.Drawing.Point(57, 27);
            this.title_tb.Name = "title_tb";
            this.title_tb.Size = new System.Drawing.Size(222, 20);
            this.title_tb.TabIndex = 4;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Location = new System.Drawing.Point(12, 30);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(39, 13);
            this.title_label.TabIndex = 5;
            this.title_label.Text = "Назва";
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(12, 433);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 6;
            this.save_btn.Text = "Зберегти";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // log_label
            // 
            this.log_label.AutoSize = true;
            this.log_label.Location = new System.Drawing.Point(93, 438);
            this.log_label.Name = "log_label";
            this.log_label.Size = new System.Drawing.Size(87, 13);
            this.log_label.TabIndex = 7;
            this.log_label.Text = "Файл записано";
            this.log_label.Visible = false;
            // 
            // алгоритмиІншихКористувачівToolStripMenuItem
            // 
            this.алгоритмиІншихКористувачівToolStripMenuItem.Name = "алгоритмиІншихКористувачівToolStripMenuItem";
            this.алгоритмиІншихКористувачівToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.алгоритмиІншихКористувачівToolStripMenuItem.Text = "Алгоритми інших користувачів";
            this.алгоритмиІншихКористувачівToolStripMenuItem.Click += new System.EventHandler(this.алгоритмиІншихКористувачівToolStripMenuItem_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 465);
            this.Controls.Add(this.log_label);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.title_tb);
            this.Controls.Add(this.output_rtb);
            this.Controls.Add(this.input_rtb);
            this.Controls.Add(this.main_rtb);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сховище алгоритмів";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкритиЗФайлуToolStripMenuItem;
        private System.Windows.Forms.RichTextBox main_rtb;
        private System.Windows.Forms.RichTextBox input_rtb;
        private System.Windows.Forms.RichTextBox output_rtb;
        private System.Windows.Forms.TextBox title_tb;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label log_label;
        private System.Windows.Forms.Timer log_timer;
        private System.Windows.Forms.ToolStripMenuItem сховищеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкритиАлгоритмToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всіАлгоритмиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem користувачToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокКористувачівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мійПрофільToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem надатиДоступІншимToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem закритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вийтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem алгоритмиІншихКористувачівToolStripMenuItem;
    }
}