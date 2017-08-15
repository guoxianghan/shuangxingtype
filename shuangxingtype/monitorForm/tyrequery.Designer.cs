namespace doublestartyre.monitorForm
{
    partial class tyrequery
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxQrcode = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxStandard = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBoxRim = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBoxFigure = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1147, 533);
            this.dataGridView1.TabIndex = 1;
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxDate.Location = new System.Drawing.Point(64, 47);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(148, 46);
            this.checkBoxDate.TabIndex = 2;
            this.checkBoxDate.Text = "入车间日期查询";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            this.checkBoxDate.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(218, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 25);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // checkBoxQrcode
            // 
            this.checkBoxQrcode.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxQrcode.Location = new System.Drawing.Point(64, 105);
            this.checkBoxQrcode.Name = "checkBoxQrcode";
            this.checkBoxQrcode.Size = new System.Drawing.Size(148, 46);
            this.checkBoxQrcode.TabIndex = 4;
            this.checkBoxQrcode.Text = "二维码查询";
            this.checkBoxQrcode.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 25);
            this.textBox1.TabIndex = 5;
            // 
            // checkBoxStandard
            // 
            this.checkBoxStandard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxStandard.Location = new System.Drawing.Point(425, 47);
            this.checkBoxStandard.Name = "checkBoxStandard";
            this.checkBoxStandard.Size = new System.Drawing.Size(148, 46);
            this.checkBoxStandard.TabIndex = 6;
            this.checkBoxStandard.Text = "轮胎规格查询";
            this.checkBoxStandard.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(605, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 25);
            this.textBox2.TabIndex = 7;
            // 
            // checkBoxRim
            // 
            this.checkBoxRim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxRim.Location = new System.Drawing.Point(425, 105);
            this.checkBoxRim.Name = "checkBoxRim";
            this.checkBoxRim.Size = new System.Drawing.Size(148, 46);
            this.checkBoxRim.TabIndex = 8;
            this.checkBoxRim.Text = "轮辋寸级查询";
            this.checkBoxRim.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(605, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 25);
            this.textBox3.TabIndex = 9;
            // 
            // checkBoxFigure
            // 
            this.checkBoxFigure.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxFigure.Location = new System.Drawing.Point(64, 157);
            this.checkBoxFigure.Name = "checkBoxFigure";
            this.checkBoxFigure.Size = new System.Drawing.Size(148, 46);
            this.checkBoxFigure.TabIndex = 10;
            this.checkBoxFigure.Text = "花纹查询";
            this.checkBoxFigure.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(218, 169);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(139, 25);
            this.textBox4.TabIndex = 11;
            // 
            // tyrequery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 760);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.checkBoxFigure);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.checkBoxRim);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkBoxStandard);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxQrcode);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBoxDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "tyrequery";
            this.Text = "tyrequery";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxQrcode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxStandard;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBoxRim;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBoxFigure;
        private System.Windows.Forms.TextBox textBox4;
    }
}