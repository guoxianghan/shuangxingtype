using System;

namespace doublestartyre
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolBarPanel = new System.Windows.Forms.Panel();
            this.tollBarMenuStrip = new System.Windows.Forms.MenuStrip();
            this.用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂存区ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.动均后暂存区1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.动均后暂存区2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.动均前暂存区1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.动均前暂存区2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.动均前暂存区3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.轮胎数据查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.轮胎信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mainFramPanel = new System.Windows.Forms.Panel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.toolBarPanel.SuspendLayout();
            this.tollBarMenuStrip.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.mainFramPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolBarPanel
            // 
            this.toolBarPanel.Controls.Add(this.label4);
            this.toolBarPanel.Controls.Add(this.tollBarMenuStrip);
            this.toolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBarPanel.Location = new System.Drawing.Point(0, 0);
            this.toolBarPanel.Name = "toolBarPanel";
            this.toolBarPanel.Size = new System.Drawing.Size(1418, 57);
            this.toolBarPanel.TabIndex = 0;
            // 
            // tollBarMenuStrip
            // 
            this.tollBarMenuStrip.AutoSize = false;
            this.tollBarMenuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tollBarMenuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tollBarMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tollBarMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户ToolStripMenuItem,
            this.暂存区ToolStripMenuItem,
            this.轮胎数据查询ToolStripMenuItem,
            this.信息维护ToolStripMenuItem,
            this.系统退出ToolStripMenuItem});
            this.tollBarMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.tollBarMenuStrip.Name = "tollBarMenuStrip";
            this.tollBarMenuStrip.Size = new System.Drawing.Size(1418, 57);
            this.tollBarMenuStrip.Stretch = false;
            this.tollBarMenuStrip.TabIndex = 2;
            this.tollBarMenuStrip.Text = "menuStrip1";
            this.tollBarMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tollBarMenuStrip_ItemClicked);
            // 
            // 用户ToolStripMenuItem
            // 
            this.用户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加用户ToolStripMenuItem,
            this.修改密码ToolStripMenuItem});
            this.用户ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.用户ToolStripMenuItem.Name = "用户ToolStripMenuItem";
            this.用户ToolStripMenuItem.Size = new System.Drawing.Size(104, 53);
            this.用户ToolStripMenuItem.Text = "用户管理";
            this.用户ToolStripMenuItem.Click += new System.EventHandler(this.用户ToolStripMenuItem_Click);
            // 
            // 添加用户ToolStripMenuItem
            // 
            this.添加用户ToolStripMenuItem.Name = "添加用户ToolStripMenuItem";
            this.添加用户ToolStripMenuItem.Size = new System.Drawing.Size(170, 32);
            this.添加用户ToolStripMenuItem.Text = "添加用户";
            this.添加用户ToolStripMenuItem.Click += new System.EventHandler(this.添加用户ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(170, 32);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 暂存区ToolStripMenuItem
            // 
            this.暂存区ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.动均后暂存区1ToolStripMenuItem,
            this.动均后暂存区2ToolStripMenuItem,
            this.动均前暂存区1ToolStripMenuItem,
            this.动均前暂存区2ToolStripMenuItem,
            this.动均前暂存区3ToolStripMenuItem});
            this.暂存区ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.暂存区ToolStripMenuItem.Name = "暂存区ToolStripMenuItem";
            this.暂存区ToolStripMenuItem.Size = new System.Drawing.Size(84, 53);
            this.暂存区ToolStripMenuItem.Text = "暂存区";
            this.暂存区ToolStripMenuItem.Click += new System.EventHandler(this.暂存区ToolStripMenuItem_Click);
            // 
            // 动均后暂存区1ToolStripMenuItem
            // 
            this.动均后暂存区1ToolStripMenuItem.Name = "动均后暂存区1ToolStripMenuItem";
            this.动均后暂存区1ToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.动均后暂存区1ToolStripMenuItem.Text = "动均后暂存区1";
            this.动均后暂存区1ToolStripMenuItem.Click += new System.EventHandler(this.动均后暂存区1ToolStripMenuItem_Click);
            // 
            // 动均后暂存区2ToolStripMenuItem
            // 
            this.动均后暂存区2ToolStripMenuItem.Name = "动均后暂存区2ToolStripMenuItem";
            this.动均后暂存区2ToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.动均后暂存区2ToolStripMenuItem.Text = "动均后暂存区2";
            this.动均后暂存区2ToolStripMenuItem.Click += new System.EventHandler(this.动均后暂存区2ToolStripMenuItem_Click);
            // 
            // 动均前暂存区1ToolStripMenuItem
            // 
            this.动均前暂存区1ToolStripMenuItem.Name = "动均前暂存区1ToolStripMenuItem";
            this.动均前暂存区1ToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.动均前暂存区1ToolStripMenuItem.Text = "动均前暂存区1";
            this.动均前暂存区1ToolStripMenuItem.Click += new System.EventHandler(this.动均前暂存区1ToolStripMenuItem_Click);
            // 
            // 动均前暂存区2ToolStripMenuItem
            // 
            this.动均前暂存区2ToolStripMenuItem.Name = "动均前暂存区2ToolStripMenuItem";
            this.动均前暂存区2ToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.动均前暂存区2ToolStripMenuItem.Text = "动均前暂存区2";
            this.动均前暂存区2ToolStripMenuItem.Click += new System.EventHandler(this.动均前暂存区2ToolStripMenuItem_Click_1);
            // 
            // 动均前暂存区3ToolStripMenuItem
            // 
            this.动均前暂存区3ToolStripMenuItem.Name = "动均前暂存区3ToolStripMenuItem";
            this.动均前暂存区3ToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.动均前暂存区3ToolStripMenuItem.Text = "动均前暂存区3";
            this.动均前暂存区3ToolStripMenuItem.Click += new System.EventHandler(this.动均前暂存区3ToolStripMenuItem_Click);
            // 
            // 轮胎数据查询ToolStripMenuItem
            // 
            this.轮胎数据查询ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.轮胎数据查询ToolStripMenuItem.Name = "轮胎数据查询ToolStripMenuItem";
            this.轮胎数据查询ToolStripMenuItem.Size = new System.Drawing.Size(144, 53);
            this.轮胎数据查询ToolStripMenuItem.Text = "轮胎数据查询";
            this.轮胎数据查询ToolStripMenuItem.Click += new System.EventHandler(this.轮胎数据查询ToolStripMenuItem_Click);
            // 
            // 信息维护ToolStripMenuItem
            // 
            this.信息维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.轮胎信息维护ToolStripMenuItem});
            this.信息维护ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.信息维护ToolStripMenuItem.Name = "信息维护ToolStripMenuItem";
            this.信息维护ToolStripMenuItem.Size = new System.Drawing.Size(104, 53);
            this.信息维护ToolStripMenuItem.Text = "信息维护";
            // 
            // 轮胎信息维护ToolStripMenuItem
            // 
            this.轮胎信息维护ToolStripMenuItem.Name = "轮胎信息维护ToolStripMenuItem";
            this.轮胎信息维护ToolStripMenuItem.Size = new System.Drawing.Size(210, 32);
            this.轮胎信息维护ToolStripMenuItem.Text = "轮胎信息维护";
            this.轮胎信息维护ToolStripMenuItem.Click += new System.EventHandler(this.轮胎信息维护ToolStripMenuItem_Click);
            // 
            // 系统退出ToolStripMenuItem
            // 
            this.系统退出ToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.系统退出ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.系统退出ToolStripMenuItem.Name = "系统退出ToolStripMenuItem";
            this.系统退出ToolStripMenuItem.Size = new System.Drawing.Size(104, 53);
            this.系统退出ToolStripMenuItem.Text = "系统退出";
            this.系统退出ToolStripMenuItem.Click += new System.EventHandler(this.系统退出ToolStripMenuItem_Click);
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.AutoSize = true;
            this.groupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox.Controls.Add(this.pictureBox6);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.pictureBox1);
            this.groupBox.Controls.Add(this.pictureBox4);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.pictureBox5);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.pictureBox3);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.label8);
            this.groupBox.Controls.Add(this.pictureBox2);
            this.groupBox.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox.Location = new System.Drawing.Point(3, 63);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1415, 123);
            this.groupBox.TabIndex = 50;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "通讯状态";
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(755, 54);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(38, 36);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 50;
            this.pictureBox6.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(540, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "---扫描3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1215, 55);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 48;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(53, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "---扫描1";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(985, 54);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(38, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 47;
            this.pictureBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Location = new System.Drawing.Point(307, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "---扫描2";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Location = new System.Drawing.Point(799, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 26);
            this.label3.TabIndex = 40;
            this.label3.Text = "---人工外检";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(480, 55);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Location = new System.Drawing.Point(1029, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "---缓存区";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Location = new System.Drawing.Point(1265, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "---暂存区";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(240, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // mainFramPanel
            // 
            this.mainFramPanel.Controls.Add(this.richTextBox);
            this.mainFramPanel.Controls.Add(this.dataGridView);
            this.mainFramPanel.Controls.Add(this.groupBox);
            this.mainFramPanel.Controls.Add(this.toolBarPanel);
            this.mainFramPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFramPanel.Location = new System.Drawing.Point(0, 0);
            this.mainFramPanel.Name = "mainFramPanel";
            this.mainFramPanel.Size = new System.Drawing.Size(1418, 771);
            this.mainFramPanel.TabIndex = 0;
            this.mainFramPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainFramPanel_Paint);
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.richTextBox.Location = new System.Drawing.Point(0, 704);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(1415, 39);
            this.richTextBox.TabIndex = 52;
            this.richTextBox.Text = "";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(-15, 185);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(1430, 513);
            this.dataGridView.TabIndex = 51;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 746);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(1418, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(174, 22);
            this.toolStripLabel3.Text = "青岛新智远科技有限公司";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("宋体", 13F);
            this.label4.Location = new System.Drawing.Point(1061, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(357, 60);
            this.label4.TabIndex = 2;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 771);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mainFramPanel);
            this.Name = "frmMain";
            this.Text = "双星轮胎分拣系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmmain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolBarPanel.ResumeLayout(false);
            this.tollBarMenuStrip.ResumeLayout(false);
            this.tollBarMenuStrip.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.mainFramPanel.ResumeLayout(false);
            this.mainFramPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
 

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel toolBarPanel;
        private System.Windows.Forms.MenuStrip tollBarMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂存区ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 轮胎数据查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统退出ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel mainFramPanel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripMenuItem 信息维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 轮胎信息维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 动均后暂存区1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 动均后暂存区2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 动均前暂存区1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 动均前暂存区2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 动均前暂存区3ToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label4;
    }
}

