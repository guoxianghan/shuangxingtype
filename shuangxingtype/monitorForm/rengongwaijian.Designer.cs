namespace doublestartyre.monitorForm
{
    partial class rengongwaijian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rengongwaijian));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.BandC = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.isOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.classes = new System.Windows.Forms.ComboBox();
            this.staff = new System.Windows.Forms.ComboBox();
            this.team = new System.Windows.Forms.ComboBox();
            this.mima = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.station = new System.Windows.Forms.Label();
            this.qrcode = new System.Windows.Forms.Label();
            this.station1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(27, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "条码";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.F);
            this.groupBox1.Controls.Add(this.E);
            this.groupBox1.Controls.Add(this.D);
            this.groupBox1.Controls.Add(this.BandC);
            this.groupBox1.Controls.Add(this.A);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 13F);
            this.groupBox1.Location = new System.Drawing.Point(415, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 636);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "病疵区域";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(609, 234);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(172, 57);
            this.delete.TabIndex = 16;
            this.delete.Text = "删除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // F
            // 
            this.F.Location = new System.Drawing.Point(332, 234);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(172, 57);
            this.F.TabIndex = 18;
            this.F.Text = "其它";
            this.F.UseVisualStyleBackColor = true;
            this.F.Click += new System.EventHandler(this.F_Click);
            // 
            // E
            // 
            this.E.Location = new System.Drawing.Point(46, 234);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(172, 57);
            this.E.TabIndex = 17;
            this.E.Text = "子口";
            this.E.UseVisualStyleBackColor = true;
            this.E.Click += new System.EventHandler(this.E_Click);
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(609, 145);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(172, 57);
            this.D.TabIndex = 16;
            this.D.Text = "胎里";
            this.D.UseVisualStyleBackColor = true;
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // BandC
            // 
            this.BandC.Location = new System.Drawing.Point(332, 145);
            this.BandC.Name = "BandC";
            this.BandC.Size = new System.Drawing.Size(172, 57);
            this.BandC.TabIndex = 14;
            this.BandC.Text = "胎肩胎侧";
            this.BandC.UseVisualStyleBackColor = true;
            this.BandC.Click += new System.EventHandler(this.BandC_Click);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(46, 145);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(172, 57);
            this.A.TabIndex = 13;
            this.A.Text = "胎冠";
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(46, 297);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(735, 312);
            this.listBox1.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(609, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 54);
            this.button2.TabIndex = 10;
            this.button2.Text = "次品";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 57);
            this.button1.TabIndex = 9;
            this.button1.Text = "合格品";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // isOK
            // 
            this.isOK.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold);
            this.isOK.Location = new System.Drawing.Point(1024, 704);
            this.isOK.Name = "isOK";
            this.isOK.Size = new System.Drawing.Size(172, 57);
            this.isOK.TabIndex = 15;
            this.isOK.Text = "确定";
            this.isOK.UseVisualStyleBackColor = true;
            this.isOK.Click += new System.EventHandler(this.isOK_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(27, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "操作人员";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(36, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "班组";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(36, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "班次";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classes
            // 
            this.classes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classes.FormattingEnabled = true;
            this.classes.Location = new System.Drawing.Point(174, 278);
            this.classes.Name = "classes";
            this.classes.Size = new System.Drawing.Size(146, 23);
            this.classes.TabIndex = 9;
            this.classes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // staff
            // 
            this.staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.staff.FormattingEnabled = true;
            this.staff.Location = new System.Drawing.Point(174, 403);
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(146, 23);
            this.staff.TabIndex = 10;
            this.staff.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // team
            // 
            this.team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.team.FormattingEnabled = true;
            this.team.Location = new System.Drawing.Point(174, 334);
            this.team.Name = "team";
            this.team.Size = new System.Drawing.Size(146, 23);
            this.team.TabIndex = 11;
            this.team.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // mima
            // 
            this.mima.Location = new System.Drawing.Point(164, 462);
            this.mima.Name = "mima";
            this.mima.PasswordChar = '*';
            this.mima.ReadOnly = true;
            this.mima.Size = new System.Drawing.Size(205, 25);
            this.mima.TabIndex = 12;
            this.mima.UseSystemPasswordChar = true;
            this.mima.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(36, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "密码";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(164, 506);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 41);
            this.button4.TabIndex = 14;
            this.button4.Text = "登录";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(292, 506);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(102, 41);
            this.exit.TabIndex = 15;
            this.exit.Text = "退出";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // station
            // 
            this.station.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.station.Location = new System.Drawing.Point(27, 162);
            this.station.Name = "station";
            this.station.Size = new System.Drawing.Size(104, 32);
            this.station.TabIndex = 18;
            this.station.Text = "工位";
            this.station.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qrcode
            // 
            this.qrcode.Font = new System.Drawing.Font("宋体", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qrcode.Location = new System.Drawing.Point(150, 54);
            this.qrcode.Name = "qrcode";
            this.qrcode.Size = new System.Drawing.Size(205, 40);
            this.qrcode.TabIndex = 19;
            this.qrcode.Text = "ADC";
            this.qrcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.qrcode.Click += new System.EventHandler(this.label5_Click);
            // 
            // station1
            // 
            this.station1.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold);
            this.station1.Location = new System.Drawing.Point(150, 154);
            this.station1.Name = "station1";
            this.station1.Size = new System.Drawing.Size(205, 40);
            this.station1.TabIndex = 21;
            this.station1.Text = "1";
            this.station1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(34, 550);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(373, 106);
            this.label5.TabIndex = 22;
            // 
            // rengongwaijian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 783);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.station1);
            this.Controls.Add(this.qrcode);
            this.Controls.Add(this.station);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isOK);
            this.Controls.Add(this.mima);
            this.Controls.Add(this.team);
            this.Controls.Add(this.staff);
            this.Controls.Add(this.classes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "rengongwaijian";
            this.Text = "人工外检";
            this.Load += new System.EventHandler(this.rengongwaijian_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox classes;
        private System.Windows.Forms.ComboBox staff;
        private System.Windows.Forms.ComboBox team;
        private System.Windows.Forms.TextBox mima;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button exit;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button F;
        private System.Windows.Forms.Button E;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button isOK;
        private System.Windows.Forms.Button BandC;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label station;
        private System.Windows.Forms.Label qrcode;
        private System.Windows.Forms.Label station1;
        private System.Windows.Forms.Label label5;
    }
}