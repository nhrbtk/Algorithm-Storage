namespace algStorage.PL.Forms
{
    partial class OtherUsersAlgorithmsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.open_btn = new System.Windows.Forms.Button();
            this.algorithmList_listbox = new System.Windows.Forms.ListBox();
            this.userList_cb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Доступні алгоритми";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Користувач";
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(12, 250);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(221, 23);
            this.open_btn.TabIndex = 8;
            this.open_btn.Text = "Відкрити";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // algorithmList_listbox
            // 
            this.algorithmList_listbox.FormattingEnabled = true;
            this.algorithmList_listbox.Location = new System.Drawing.Point(12, 71);
            this.algorithmList_listbox.Name = "algorithmList_listbox";
            this.algorithmList_listbox.Size = new System.Drawing.Size(221, 173);
            this.algorithmList_listbox.TabIndex = 7;
            // 
            // userList_cb
            // 
            this.userList_cb.FormattingEnabled = true;
            this.userList_cb.Location = new System.Drawing.Point(12, 25);
            this.userList_cb.Name = "userList_cb";
            this.userList_cb.Size = new System.Drawing.Size(222, 21);
            this.userList_cb.TabIndex = 11;
            this.userList_cb.SelectedIndexChanged += new System.EventHandler(this.userList_cb_SelectedIndexChanged);
            // 
            // OtherUsersAlgorithmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 281);
            this.Controls.Add(this.userList_cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.algorithmList_listbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OtherUsersAlgorithmsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Доступні алгоритми";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button open_btn;
        protected internal System.Windows.Forms.ListBox algorithmList_listbox;
        protected internal System.Windows.Forms.ComboBox userList_cb;
    }
}