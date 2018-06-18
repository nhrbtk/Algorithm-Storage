namespace algStorage.PL.Forms
{
    partial class ChooseFileForm
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
            this.algList_listbox = new System.Windows.Forms.ListBox();
            this.choose_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // algList_listbox
            // 
            this.algList_listbox.FormattingEnabled = true;
            this.algList_listbox.Location = new System.Drawing.Point(12, 12);
            this.algList_listbox.Name = "algList_listbox";
            this.algList_listbox.Size = new System.Drawing.Size(120, 238);
            this.algList_listbox.TabIndex = 0;
            this.algList_listbox.SelectedIndexChanged += new System.EventHandler(this.algList_listbox_SelectedIndexChanged);
            // 
            // choose_btn
            // 
            this.choose_btn.Enabled = false;
            this.choose_btn.Location = new System.Drawing.Point(138, 12);
            this.choose_btn.Name = "choose_btn";
            this.choose_btn.Size = new System.Drawing.Size(134, 26);
            this.choose_btn.TabIndex = 1;
            this.choose_btn.Text = "Вибрати";
            this.choose_btn.UseVisualStyleBackColor = true;
            this.choose_btn.Click += new System.EventHandler(this.choose_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Enabled = false;
            this.delete_btn.Location = new System.Drawing.Point(138, 44);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(134, 26);
            this.delete_btn.TabIndex = 2;
            this.delete_btn.Text = "Видалити";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // ChooseFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.choose_btn);
            this.Controls.Add(this.algList_listbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChooseFileForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Список файлів";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button choose_btn;
        protected internal System.Windows.Forms.ListBox algList_listbox;
        private System.Windows.Forms.Button delete_btn;
    }
}