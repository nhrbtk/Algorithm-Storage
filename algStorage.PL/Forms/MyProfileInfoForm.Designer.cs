namespace algStorage.PL.Forms
{
    partial class MyProfileInfoForm
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
            this.username_label = new System.Windows.Forms.Label();
            this.role_label = new System.Windows.Forms.Label();
            this.algorithmsCount_label = new System.Windows.Forms.Label();
            this.ChangePassword_btn = new System.Windows.Forms.Button();
            this.newPassword_tb = new System.Windows.Forms.TextBox();
            this.oldPassword_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(12, 15);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(35, 13);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "label1";
            // 
            // role_label
            // 
            this.role_label.AutoSize = true;
            this.role_label.Location = new System.Drawing.Point(12, 95);
            this.role_label.Name = "role_label";
            this.role_label.Size = new System.Drawing.Size(35, 13);
            this.role_label.TabIndex = 1;
            this.role_label.Text = "label1";
            // 
            // algorithmsCount_label
            // 
            this.algorithmsCount_label.AutoSize = true;
            this.algorithmsCount_label.Location = new System.Drawing.Point(12, 122);
            this.algorithmsCount_label.Name = "algorithmsCount_label";
            this.algorithmsCount_label.Size = new System.Drawing.Size(35, 13);
            this.algorithmsCount_label.TabIndex = 2;
            this.algorithmsCount_label.Text = "label1";
            // 
            // ChangePassword_btn
            // 
            this.ChangePassword_btn.Location = new System.Drawing.Point(293, 62);
            this.ChangePassword_btn.Name = "ChangePassword_btn";
            this.ChangePassword_btn.Size = new System.Drawing.Size(148, 23);
            this.ChangePassword_btn.TabIndex = 3;
            this.ChangePassword_btn.Text = "Змінити пароль";
            this.ChangePassword_btn.UseVisualStyleBackColor = true;
            this.ChangePassword_btn.Click += new System.EventHandler(this.ChangePassword_btn_Click);
            // 
            // newPassword_tb
            // 
            this.newPassword_tb.Location = new System.Drawing.Point(139, 64);
            this.newPassword_tb.Name = "newPassword_tb";
            this.newPassword_tb.Size = new System.Drawing.Size(148, 20);
            this.newPassword_tb.TabIndex = 5;
            // 
            // oldPassword_tb
            // 
            this.oldPassword_tb.Location = new System.Drawing.Point(139, 38);
            this.oldPassword_tb.Name = "oldPassword_tb";
            this.oldPassword_tb.Size = new System.Drawing.Size(148, 20);
            this.oldPassword_tb.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Теперішній пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Новий пароль";
            // 
            // MyProfileInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 144);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oldPassword_tb);
            this.Controls.Add(this.newPassword_tb);
            this.Controls.Add(this.ChangePassword_btn);
            this.Controls.Add(this.algorithmsCount_label);
            this.Controls.Add(this.role_label);
            this.Controls.Add(this.username_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MyProfileInfoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Мій профіль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label role_label;
        private System.Windows.Forms.Label algorithmsCount_label;
        private System.Windows.Forms.Button ChangePassword_btn;
        private System.Windows.Forms.TextBox newPassword_tb;
        private System.Windows.Forms.TextBox oldPassword_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}