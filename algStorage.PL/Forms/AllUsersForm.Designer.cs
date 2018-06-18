namespace algStorage.PL.Forms
{
    partial class AllUsersForm
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
            this.delete_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usersList_listbox
            // 
            this.usersList_listbox.FormattingEnabled = true;
            this.usersList_listbox.Location = new System.Drawing.Point(12, 12);
            this.usersList_listbox.Name = "usersList_listbox";
            this.usersList_listbox.Size = new System.Drawing.Size(184, 238);
            this.usersList_listbox.TabIndex = 0;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(13, 257);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(183, 23);
            this.delete_btn.TabIndex = 1;
            this.delete_btn.Text = "Видалити користувача";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // AllUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 289);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.usersList_listbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AllUsersForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Список користувачів";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox usersList_listbox;
        private System.Windows.Forms.Button delete_btn;
    }
}