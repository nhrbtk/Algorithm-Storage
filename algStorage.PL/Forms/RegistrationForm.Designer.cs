namespace algStorage.PL.Forms
{
    partial class RegistrationForm
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
            this.registration_btn = new System.Windows.Forms.Button();
            this.password_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.admin_checkbox = new System.Windows.Forms.CheckBox();
            this.ToLoginForm_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registration_btn
            // 
            this.registration_btn.Location = new System.Drawing.Point(111, 112);
            this.registration_btn.Name = "registration_btn";
            this.registration_btn.Size = new System.Drawing.Size(146, 23);
            this.registration_btn.TabIndex = 11;
            this.registration_btn.Text = "Зареєструватись";
            this.registration_btn.UseVisualStyleBackColor = true;
            this.registration_btn.Click += new System.EventHandler(this.registration_btn_Click);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(12, 66);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(45, 13);
            this.password_label.TabIndex = 9;
            this.password_label.Text = "Пароль";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(12, 40);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(92, 13);
            this.username_label.TabIndex = 8;
            this.username_label.Text = "Ім\'я користувача";
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(111, 63);
            this.password_tb.MaxLength = 32;
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(146, 20);
            this.password_tb.TabIndex = 7;
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(111, 37);
            this.username_tb.MaxLength = 32;
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(146, 20);
            this.username_tb.TabIndex = 6;
            // 
            // admin_checkbox
            // 
            this.admin_checkbox.AutoSize = true;
            this.admin_checkbox.Location = new System.Drawing.Point(111, 89);
            this.admin_checkbox.Name = "admin_checkbox";
            this.admin_checkbox.Size = new System.Drawing.Size(97, 17);
            this.admin_checkbox.TabIndex = 12;
            this.admin_checkbox.Text = "Адміністратор";
            this.admin_checkbox.UseVisualStyleBackColor = true;
            // 
            // ToLoginForm_btn
            // 
            this.ToLoginForm_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ToLoginForm_btn.Location = new System.Drawing.Point(111, 158);
            this.ToLoginForm_btn.Name = "ToLoginForm_btn";
            this.ToLoginForm_btn.Size = new System.Drawing.Size(146, 23);
            this.ToLoginForm_btn.TabIndex = 13;
            this.ToLoginForm_btn.Text = "Повернутись";
            this.ToLoginForm_btn.UseVisualStyleBackColor = true;
            this.ToLoginForm_btn.Click += new System.EventHandler(this.ToLoginForm_btn_Click);
            // 
            // RegistrationForm
            // 
            this.AcceptButton = this.registration_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ToLoginForm_btn;
            this.ClientSize = new System.Drawing.Size(284, 193);
            this.Controls.Add(this.ToLoginForm_btn);
            this.Controls.Add(this.admin_checkbox);
            this.Controls.Add(this.registration_btn);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.username_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реєстрація";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registration_btn;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.CheckBox admin_checkbox;
        private System.Windows.Forms.Button ToLoginForm_btn;
    }
}