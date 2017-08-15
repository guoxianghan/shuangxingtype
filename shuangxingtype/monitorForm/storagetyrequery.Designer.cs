namespace doublestartyre.monitorForm
{
    partial class storagetyrequery
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBoxQrcode = new System.Windows.Forms.CheckBox();
            this.checkBoxgrade = new System.Windows.Forms.CheckBox();
            this.checkBoxtyre = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1281, 562);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // checkBoxQrcode
            // 
            this.checkBoxQrcode.Location = new System.Drawing.Point(33, 85);
            this.checkBoxQrcode.Name = "checkBoxQrcode";
            this.checkBoxQrcode.Size = new System.Drawing.Size(146, 55);
            this.checkBoxQrcode.TabIndex = 1;
            this.checkBoxQrcode.Text = "二维码查询";
            this.checkBoxQrcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxQrcode.UseVisualStyleBackColor = true;
            // 
            // checkBoxgrade
            // 
            this.checkBoxgrade.Location = new System.Drawing.Point(736, 84);
            this.checkBoxgrade.Name = "checkBoxgrade";
            this.checkBoxgrade.Size = new System.Drawing.Size(146, 55);
            this.checkBoxgrade.TabIndex = 2;
            this.checkBoxgrade.Text = "动均等级查询";
            this.checkBoxgrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxgrade.UseVisualStyleBackColor = true;
            // 
            // checkBoxtyre
            // 
            this.checkBoxtyre.Location = new System.Drawing.Point(372, 85);
            this.checkBoxtyre.Name = "checkBoxtyre";
            this.checkBoxtyre.Size = new System.Drawing.Size(146, 55);
            this.checkBoxtyre.TabIndex = 3;
            this.checkBoxtyre.Text = "轮胎规格查询";
            this.checkBoxtyre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxtyre.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1121, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 25);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(549, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 25);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(910, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 25);
            this.textBox3.TabIndex = 7;
            // 
            // storagetyrequery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 766);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxtyre);
            this.Controls.Add(this.checkBoxgrade);
            this.Controls.Add(this.checkBoxQrcode);
            this.Controls.Add(this.dataGridView1);
            this.Name = "storagetyrequery";
            this.Text = "storagetyrequery";
            this.Load += new System.EventHandler(this.storagetyrequery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBoxQrcode;
        private System.Windows.Forms.CheckBox checkBoxgrade;
        private System.Windows.Forms.CheckBox checkBoxtyre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}