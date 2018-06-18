namespace algStorage.PL.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.username_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.CheckUser_btn = new System.Windows.Forms.Button();
            this.registration_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(117, 36);
            this.username_tb.MaxLength = 32;
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(146, 20);
            this.username_tb.TabIndex = 0;
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(117, 62);
            this.password_tb.MaxLength = 32;
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(146, 20);
            this.password_tb.TabIndex = 1;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(18, 39);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(92, 13);
            this.username_label.TabIndex = 2;
            this.username_label.Text = "Ім\'я користувача";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(18, 65);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(45, 13);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "Пароль";
            // 
            // CheckUser_btn
            // 
            this.CheckUser_btn.Location = new System.Drawing.Point(117, 88);
            this.CheckUser_btn.Name = "CheckUser_btn";
            this.CheckUser_btn.Size = new System.Drawing.Size(146, 23);
            this.CheckUser_btn.TabIndex = 4;
            this.CheckUser_btn.Text = "Увійти";
            this.CheckUser_btn.UseVisualStyleBackColor = true;
            this.CheckUser_btn.Click += new System.EventHandler(this.CheckUser_btn_Click);
            // 
            // registration_btn
            // 
            this.registration_btn.Location = new System.Drawing.Point(117, 145);
            this.registration_btn.Name = "registration_btn";
            this.registration_btn.Size = new System.Drawing.Size(146, 23);
            this.registration_btn.TabIndex = 5;
            this.registration_btn.Text = "Зареєструватись";
            this.registration_btn.UseVisualStyleBackColor = true;
            this.registration_btn.Click += new System.EventHandler(this.registration_btn_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.CheckUser_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.Controls.Add(this.registration_btn);
            this.Controls.Add(this.CheckUser_btn);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.username_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вхід";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button CheckUser_btn;
        private System.Windows.Forms.Button registration_btn;
    }
}

