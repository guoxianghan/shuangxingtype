namespace doublestartyre.AccountManagement
{

    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.cancelButton = new System.Windows.Forms.Button();
            this.txtPsw2 = new System.Windows.Forms.TextBox();
            this.txtPsw1 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(311, 352);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(116, 34);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.ClickCancelButton);
            // 
            // txtPsw2
            // 
            this.txtPsw2.Location = new System.Drawing.Point(251, 252);
            this.txtPsw2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPsw2.Name = "txtPsw2";
            this.txtPsw2.PasswordChar = '*';
            this.txtPsw2.Size = new System.Drawing.Size(175, 25);
            this.txtPsw2.TabIndex = 18;
            // 
            // txtPsw1
            // 
            this.txtPsw1.Location = new System.Drawing.Point(251, 184);
            this.txtPsw1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPsw1.Name = "txtPsw1";
            this.txtPsw1.PasswordChar = '*';
            this.txtPsw1.Size = new System.Drawing.Size(175, 25);
            this.txtPsw1.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(251, 125);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(175, 25);
            this.txtName.TabIndex = 16;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(251, 69);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(175, 25);
            this.txtId.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "确认新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "新密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "用户姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "用户编号：";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(115, 352);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(116, 34);
            this.confirmButton.TabIndex = 10;
            this.confirmButton.Text = "确认";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ClickConfirmButton);
            // 
            // frmSetpsw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 472);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.txtPsw2);
            this.Controls.Add(this.txtPsw1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetpsw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.frmSetpsw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox txtPsw2;
        private System.Windows.Forms.TextBox txtPsw1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmButton;
    }
}