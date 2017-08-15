namespace doublestartyre.AccountManagement
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.comboId = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtPsw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboId
            // 
            this.comboId.FormattingEnabled = true;
            this.comboId.Location = new System.Drawing.Point(209, 71);
            this.comboId.Name = "comboId";
            this.comboId.Size = new System.Drawing.Size(195, 20);
            this.comboId.TabIndex = 14;
            this.comboId.SelectedIndexChanged += new System.EventHandler(this.comboId_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(221, 181);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "记住密码";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "忘记密码";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtPsw
            // 
            this.TxtPsw.Location = new System.Drawing.Point(209, 137);
            this.TxtPsw.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPsw.Name = "TxtPsw";
            this.TxtPsw.PasswordChar = '*';
            this.TxtPsw.Size = new System.Drawing.Size(195, 21);
            this.TxtPsw.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "用户密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "用户编号:";
            // 
            // ButLogin
            // 
            this.ButLogin.Location = new System.Drawing.Point(126, 226);
            this.ButLogin.Margin = new System.Windows.Forms.Padding(4);
            this.ButLogin.Name = "ButLogin";
            this.ButLogin.Size = new System.Drawing.Size(100, 31);
            this.ButLogin.TabIndex = 8;
            this.ButLogin.Text = "登录";
            this.ButLogin.UseVisualStyleBackColor = true;
            this.ButLogin.Click += new System.EventHandler(this.ButLogin_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 325);
            this.Controls.Add(this.comboId);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtPsw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButLogin);
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统登录";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.ComboBox comboId;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtPsw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButLogin;
    }
}