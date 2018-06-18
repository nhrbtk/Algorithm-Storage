namespace algStorage.PL.Forms
{
    partial class AddUserAccessForm
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
            this.giveAccess_btn = new System.Windows.Forms.Button();
            this.usersDeniedList_listbox = new System.Windows.Forms.ListBox();
            this.LogGiveAccess_label = new System.Windows.Forms.Label();
            this.usersAccessedList_listbox = new System.Windows.Forms.ListBox();
            this.LogCloseAccess_label = new System.Windows.Forms.Label();
            this.closeAccess_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.algorithm_cb = new System.Windows.Forms.ComboBox();
            this.log_timer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.color_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // giveAccess_btn
            // 
            this.giveAccess_btn.Location = new System.Drawing.Point(13, 305);
            this.giveAccess_btn.Name = "giveAccess_btn";
            this.giveAccess_btn.Size = new System.Drawing.Size(183, 23);
            this.giveAccess_btn.TabIndex = 3;
            this.giveAccess_btn.Text = "Надати доступ";
            this.giveAccess_btn.UseVisualStyleBackColor = true;
            this.giveAccess_btn.Click += new System.EventHandler(this.giveAccess_btn_Click);
            // 
            // usersDeniedList_listbox
            // 
            this.usersDeniedList_listbox.BackColor = System.Drawing.SystemColors.Window;
            this.usersDeniedList_listbox.FormattingEnabled = true;
            this.usersDeniedList_listbox.Location = new System.Drawing.Point(12, 61);
            this.usersDeniedList_listbox.Name = "usersDeniedList_listbox";
            this.usersDeniedList_listbox.Size = new System.Drawing.Size(184, 238);
            this.usersDeniedList_listbox.TabIndex = 2;
            this.usersDeniedList_listbox.DoubleClick += new System.EventHandler(this.usersDeniedList_listbox_DoubleClick);
            // 
            // LogGiveAccess_label
            // 
            this.LogGiveAccess_label.AutoSize = true;
            this.LogGiveAccess_label.Location = new System.Drawing.Point(12, 331);
            this.LogGiveAccess_label.Name = "LogGiveAccess_label";
            this.LogGiveAccess_label.Size = new System.Drawing.Size(35, 13);
            this.LogGiveAccess_label.TabIndex = 4;
            this.LogGiveAccess_label.Text = "label1";
            this.LogGiveAccess_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogGiveAccess_label.Visible = false;
            // 
            // usersAccessedList_listbox
            // 
            this.usersAccessedList_listbox.FormattingEnabled = true;
            this.usersAccessedList_listbox.Location = new System.Drawing.Point(202, 61);
            this.usersAccessedList_listbox.Name = "usersAccessedList_listbox";
            this.usersAccessedList_listbox.Size = new System.Drawing.Size(184, 238);
            this.usersAccessedList_listbox.TabIndex = 5;
            this.usersAccessedList_listbox.DoubleClick += new System.EventHandler(this.usersAccessedList_listbox_DoubleClick);
            // 
            // LogCloseAccess_label
            // 
            this.LogCloseAccess_label.AutoSize = true;
            this.LogCloseAccess_label.Location = new System.Drawing.Point(199, 331);
            this.LogCloseAccess_label.Name = "LogCloseAccess_label";
            this.LogCloseAccess_label.Size = new System.Drawing.Size(35, 13);
            this.LogCloseAccess_label.TabIndex = 7;
            this.LogCloseAccess_label.Text = "label1";
            this.LogCloseAccess_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogCloseAccess_label.Visible = false;
            // 
            // closeAccess_btn
            // 
            this.closeAccess_btn.Location = new System.Drawing.Point(202, 305);
            this.closeAccess_btn.Name = "closeAccess_btn";
            this.closeAccess_btn.Size = new System.Drawing.Size(183, 23);
            this.closeAccess_btn.TabIndex = 6;
            this.closeAccess_btn.Text = "Закрити доступ";
            this.closeAccess_btn.UseVisualStyleBackColor = true;
            this.closeAccess_btn.Click += new System.EventHandler(this.closeAccess_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Мають доступ до алгоритму";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Не мають доступу до алгоритму";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // algorithm_cb
            // 
            this.algorithm_cb.FormattingEnabled = true;
            this.algorithm_cb.Location = new System.Drawing.Point(73, 10);
            this.algorithm_cb.Name = "algorithm_cb";
            this.algorithm_cb.Size = new System.Drawing.Size(313, 21);
            this.algorithm_cb.TabIndex = 10;
            this.algorithm_cb.SelectedIndexChanged += new System.EventHandler(this.algorithm_cb_SelectedIndexChanged);
            // 
            // log_timer
            // 
            this.log_timer.Interval = 3000;
            this.log_timer.Tick += new System.EventHandler(this.log_timer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Алгоритм";
            // 
            // color_timer
            // 
            this.color_timer.Interval = 500;
            this.color_timer.Tick += new System.EventHandler(this.color_timer_Tick);
            // 
            // AddUserAccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 349);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.algorithm_cb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogCloseAccess_label);
            this.Controls.Add(this.closeAccess_btn);
            this.Controls.Add(this.usersAccessedList_listbox);
            this.Controls.Add(this.LogGiveAccess_label);
            this.Controls.Add(this.giveAccess_btn);
            this.Controls.Add(this.usersDeniedList_listbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddUserAccessForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Надати доступ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giveAccess_btn;
        private System.Windows.Forms.ListBox usersDeniedList_listbox;
        private System.Windows.Forms.Label LogGiveAccess_label;
        private System.Windows.Forms.ListBox usersAccessedList_listbox;
        private System.Windows.Forms.Label LogCloseAccess_label;
        private System.Windows.Forms.Button closeAccess_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox algorithm_cb;
        private System.Windows.Forms.Timer log_timer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer color_timer;
    }
}