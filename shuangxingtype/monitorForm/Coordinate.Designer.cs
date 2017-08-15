namespace doublestartyre.monitorForm
{
    partial class Coordinate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtZaxis = new System.Windows.Forms.TextBox();
            this.txtYaxis = new System.Windows.Forms.TextBox();
            this.txtXaxis = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(558, 292);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMark);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtZaxis);
            this.panel1.Controls.Add(this.txtYaxis);
            this.panel1.Controls.Add(this.txtXaxis);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.buttonConfirm);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 93);
            this.panel1.TabIndex = 1;
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(196, 55);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(139, 21);
            this.txtMark.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "否",
            "是"});
            this.comboBox1.Location = new System.Drawing.Point(77, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(61, 20);
            this.comboBox1.TabIndex = 10;
            // 
            // txtZaxis
            // 
            this.txtZaxis.Location = new System.Drawing.Point(379, 15);
            this.txtZaxis.Name = "txtZaxis";
            this.txtZaxis.Size = new System.Drawing.Size(65, 21);
            this.txtZaxis.TabIndex = 9;
            // 
            // txtYaxis
            // 
            this.txtYaxis.Location = new System.Drawing.Point(270, 15);
            this.txtYaxis.Name = "txtYaxis";
            this.txtYaxis.Size = new System.Drawing.Size(65, 21);
            this.txtYaxis.TabIndex = 8;
            // 
            // txtXaxis
            // 
            this.txtXaxis.Location = new System.Drawing.Point(162, 13);
            this.txtXaxis.Name = "txtXaxis";
            this.txtXaxis.Size = new System.Drawing.Size(65, 21);
            this.txtXaxis.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(64, 13);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(46, 21);
            this.txtID.TabIndex = 6;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(369, 55);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 5;
            this.buttonConfirm.Text = "确认";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "备注：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "是否禁用：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Z轴：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y轴：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "X轴：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "库位号：";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(510, 320);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "添加";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(510, 350);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "删除";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(510, 380);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 23);
            this.buttonModify.TabIndex = 4;
            this.buttonModify.Text = "修改";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // frmCoordinate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 425);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmCoordinate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置坐标";
            this.Load += new System.EventHandler(this.Coordinate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtZaxis;
        private System.Windows.Forms.TextBox txtYaxis;
        private System.Windows.Forms.TextBox txtXaxis;
        private System.Windows.Forms.TextBox txtID;
    }
}