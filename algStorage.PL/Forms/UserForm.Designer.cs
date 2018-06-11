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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиЗФайлуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_rtb = new System.Windows.Forms.RichTextBox();
            this.input_rtb = new System.Windows.Forms.RichTextBox();
            this.output_rtb = new System.Windows.Forms.RichTextBox();
            this.title_tb = new System.Windows.Forms.TextBox();
            this.title_label = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
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
            this.відкритиЗФайлуToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.відкритиЗФайлуToolStripMenuItem.Text = "Відкрити з файлу";
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
            this.title_tb.Size = new System.Drawing.Size(100, 20);
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
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 591);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.title_tb);
            this.Controls.Add(this.output_rtb);
            this.Controls.Add(this.input_rtb);
            this.Controls.Add(this.main_rtb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserForm";
            this.Text = "UserForm";
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
    }
}