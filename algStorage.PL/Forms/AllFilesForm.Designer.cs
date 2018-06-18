namespace algStorage.PL.Forms
{
    partial class AllFilesForm
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
            this.usersList_listbox = new System.Windows.Forms.ListBox();
            this.algorithmList_listbox = new System.Windows.Forms.ListBox();
            this.open_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usersList_listbox
            // 
            this.usersList_listbox.FormattingEnabled = true;
            this.usersList_listbox.Location = new System.Drawing.Point(12, 25);
            this.usersList_listbox.Name = "usersList_listbox";
            this.usersList_listbox.Size = new System.Drawing.Size(120, 212);
            this.usersList_listbox.TabIndex = 0;
            this.usersList_listbox.SelectedIndexChanged += new System.EventHandler(this.usersList_listbox_SelectedIndexChanged);
            // 
            // algorithmList_listbox
            // 
            this.algorithmList_listbox.FormattingEnabled = true;
            this.algorithmList_listbox.Location = new System.Drawing.Point(150, 25);
            this.algorithmList_listbox.Name = "algorithmList_listbox";
            this.algorithmList_listbox.Size = new System.Drawing.Size(120, 212);
            this.algorithmList_listbox.TabIndex = 1;
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(276, 25);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(120, 23);
            this.open_btn.TabIndex = 2;
            this.open_btn.Text = "Відкрити";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(276, 54);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(120, 23);
            this.delete_btn.TabIndex = 3;
            this.delete_btn.Text = "Видалити";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Користувачі";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Алгоритми";
            // 
            // AllFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 247);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.algorithmList_listbox);
            this.Controls.Add(this.usersList_listbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AllFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Список усіх алгоритмів";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Button delete_btn;
        protected internal System.Windows.Forms.ListBox usersList_listbox;
        protected internal System.Windows.Forms.ListBox algorithmList_listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}