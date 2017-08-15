namespace doublestartyre.monitorForm
{
    partial class TyreConfiguration
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
            this.label2 = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.TextBox();
            this.xiugai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dongpinghengid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1182, 477);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(92, 579);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "轮辋等级：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(215, 580);
            this.min.Multiline = true;
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(97, 25);
            this.min.TabIndex = 4;
            // 
            // xiugai
            // 
            this.xiugai.Location = new System.Drawing.Point(631, 574);
            this.xiugai.Name = "xiugai";
            this.xiugai.Size = new System.Drawing.Size(102, 35);
            this.xiugai.TabIndex = 7;
            this.xiugai.Text = "修改";
            this.xiugai.UseVisualStyleBackColor = true;
            this.xiugai.Click += new System.EventHandler(this.xiugai_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(92, 529);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "动平衡序号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dongpinghengid
            // 
            this.dongpinghengid.Location = new System.Drawing.Point(215, 527);
            this.dongpinghengid.Multiline = true;
            this.dongpinghengid.Name = "dongpinghengid";
            this.dongpinghengid.Size = new System.Drawing.Size(138, 25);
            this.dongpinghengid.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(318, 582);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "——";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(424, 582);
            this.max.Multiline = true;
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(97, 25);
            this.max.TabIndex = 11;
            // 
            // TyreConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 704);
            this.Controls.Add(this.max);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dongpinghengid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xiugai);
            this.Controls.Add(this.min);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TyreConfiguration";
            this.Text = "TyreConfiguration";
            this.Load += new System.EventHandler(this.TyreConfiguration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox min;
        private System.Windows.Forms.Button xiugai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dongpinghengid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox max;
    }
}