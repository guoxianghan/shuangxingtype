namespace doublestartyre.monitorForm
{
    partial class tyremaintenance
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.luntaiguige = new System.Windows.Forms.TextBox();
            this.singleheight = new System.Windows.Forms.TextBox();
            this.reduction = new System.Windows.Forms.TextBox();
            this.Bead = new System.Windows.Forms.TextBox();
            this.maxheight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.minnumber = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.jitaihao = new System.Windows.Forms.Label();
            this.jitaihaozhi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1295, 439);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 631);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(628, 631);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(994, 631);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "物料编码";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 575);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "单个轮胎高度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 574);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "轮胎形变量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(640, 574);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "子口";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(873, 575);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "最大库位高度";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // luntaiguige
            // 
            this.luntaiguige.Location = new System.Drawing.Point(344, 499);
            this.luntaiguige.Name = "luntaiguige";
            this.luntaiguige.Size = new System.Drawing.Size(239, 25);
            this.luntaiguige.TabIndex = 9;
            this.luntaiguige.TextChanged += new System.EventHandler(this.luntaiguige_TextChanged);
            // 
            // singleheight
            // 
            this.singleheight.Location = new System.Drawing.Point(204, 569);
            this.singleheight.Name = "singleheight";
            this.singleheight.Size = new System.Drawing.Size(178, 25);
            this.singleheight.TabIndex = 10;
            this.singleheight.TextChanged += new System.EventHandler(this.singleheight_TextChanged);
            // 
            // reduction
            // 
            this.reduction.Location = new System.Drawing.Point(490, 569);
            this.reduction.Name = "reduction";
            this.reduction.Size = new System.Drawing.Size(117, 25);
            this.reduction.TabIndex = 11;
            this.reduction.TextChanged += new System.EventHandler(this.reduction_TextChanged);
            // 
            // Bead
            // 
            this.Bead.Location = new System.Drawing.Point(692, 569);
            this.Bead.Name = "Bead";
            this.Bead.Size = new System.Drawing.Size(175, 25);
            this.Bead.TabIndex = 12;
            this.Bead.TextChanged += new System.EventHandler(this.Bead_TextChanged);
            // 
            // maxheight
            // 
            this.maxheight.Location = new System.Drawing.Point(976, 571);
            this.maxheight.Name = "maxheight";
            this.maxheight.Size = new System.Drawing.Size(121, 25);
            this.maxheight.TabIndex = 13;
            this.maxheight.TextChanged += new System.EventHandler(this.maxheight_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1114, 574);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "最小出库数量";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // minnumber
            // 
            this.minnumber.Location = new System.Drawing.Point(1226, 571);
            this.minnumber.Name = "minnumber";
            this.minnumber.Size = new System.Drawing.Size(100, 25);
            this.minnumber.TabIndex = 15;
            this.minnumber.TextChanged += new System.EventHandler(this.minnumber_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1089, 486);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 31);
            this.button4.TabIndex = 16;
            this.button4.Text = "确定";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // jitaihao
            // 
            this.jitaihao.AutoSize = true;
            this.jitaihao.Location = new System.Drawing.Point(675, 502);
            this.jitaihao.Name = "jitaihao";
            this.jitaihao.Size = new System.Drawing.Size(52, 15);
            this.jitaihao.TabIndex = 17;
            this.jitaihao.Text = "机台号";
            // 
            // jitaihaozhi
            // 
            this.jitaihaozhi.Location = new System.Drawing.Point(750, 496);
            this.jitaihaozhi.Name = "jitaihaozhi";
            this.jitaihaozhi.Size = new System.Drawing.Size(239, 25);
            this.jitaihaozhi.TabIndex = 18;
            // 
            // tyremaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 767);
            this.Controls.Add(this.jitaihaozhi);
            this.Controls.Add(this.jitaihao);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.minnumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maxheight);
            this.Controls.Add(this.Bead);
            this.Controls.Add(this.reduction);
            this.Controls.Add(this.singleheight);
            this.Controls.Add(this.luntaiguige);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "tyremaintenance";
            this.Text = "轮胎信息维护";
            this.Load += new System.EventHandler(this.tyremaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox luntaiguige;
        private System.Windows.Forms.TextBox singleheight;
        private System.Windows.Forms.TextBox reduction;
        private System.Windows.Forms.TextBox Bead;
        private System.Windows.Forms.TextBox maxheight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox minnumber;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label jitaihao;
        private System.Windows.Forms.TextBox jitaihaozhi;
    }
}