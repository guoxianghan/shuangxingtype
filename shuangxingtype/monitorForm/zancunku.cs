using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace doublestartyre.monitorForm
{
    public partial class zancunku : Form
    {
        public zancunku()
        {
            InitializeComponent();
        }
        #region 变量定义

        public doublestartyre.utils.AutoSize formAutoSize = new doublestartyre.utils.AutoSize();
        //public hardware.rextoth myRextoth=new hardware.rextoth();
        /// <summary>
        /// 记录库位的列数和行数
        /// </summary>
        public int iColumns, iRows;
        /// <summary>
        /// 记录仓库的宽度和长度
        /// </summary>
        public double wareHouseWidth, wareHouseHeight;
        /// <summary>
        /// 记录是否是第一次调用sizechange
        /// </summary>
        public bool flagSizeChange = true;

        public System.Timers.Timer myTime = new System.Timers.Timer();

        string dStr;
        PictureBox[] myPic;

        /// <summary>
        /// 记录给力士乐plc下发的指令
        /// </summary>
        double[] moveValue = new double[15];

        bool flagMoveing = false;
        #endregion
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.getColumnRows();
            this.setControls();
            this.setPicture();
            this.getMeterialMessage(-1);

            formAutoSize.controllInitializeSize(this);


            myTime.Interval = 1000;
            myTime.Elapsed += new System.Timers.ElapsedEventHandler(this.myTime_Elapsed);
            myTime.AutoReset = true;   //设置是执行一次（false）还是一直执行(true)；   
            myTime.Enabled = true;     //是否执行System.Timers.Timer.Elapsed事件；

            //myRextoth.Open();
            //myRextoth.CreateMySubscription("isWriteOk");
            //myRextoth.CreateMySubscription("setMove");
            //myRextoth.CreateMySubscription("getMoveValue");
            //myRextoth.addItems();
        }

        private void myTime_Elapsed(object source, System.Timers.ElapsedEventArgs e)
        {
            if (flagMoveing == false)
            {
                //setMove(myRextoth);
            }
            else
            {
                flagMoveing = getMoveValue();
            }

        }

        private void setMove(hardware.rextoth _myRextoth)
        {
            moveValue[0] = 1;//1下位机可读，2上位机可写。
            moveValue[1] = 4;//动作1入库，2出库，3柴垛，4移栽
            moveValue[2] = 34.34;//轮胎外径
            moveValue[3] = 12.12;//轮胎内径
            moveValue[4] = 1234;//取胎X轴坐标
            moveValue[5] = 2345;//取胎Y轴坐标
            moveValue[6] = 1234;//取胎高度
            moveValue[7] = 2234;//放胎X轴坐标
            moveValue[8] = 2234;//放胎Y轴坐标
            moveValue[9] = 2222;//放胎高度
            moveValue[10] = 1;//流水号
            moveValue[11] = 0;//串胎标志
            moveValue[12] = 0;//串胎高度
            moveValue[13] = 1;//下抓标志，1下抓开始，2下抓完成
            moveValue[14] = 0;//备用

            //myRextoth.setMove(moveValue);
        }

        private bool getMoveValue()
        {
            //double[] myGetValue = myRextoth.getMoveValue();
            double[] myGetValue = new double[15];
            for (int i = 0; i < 15; i++)
            {
                if (myGetValue[i] != moveValue[i])
                {
                    return false;
                }
            }
            return true;
        }

        #region 获取库内行列的初始值

        /// <summary>
        /// 获取库内行列的初始值
        /// </summary>
        private void getColumnRows()
        {
            dStr = "select * from initialize";
            DataSet myds = hardware.dbdoublestar.getDataSet(dStr, "initialize");
            iColumns = int.Parse(myds.Tables["initialize"].Rows[0][1].ToString());
            iRows = int.Parse(myds.Tables["initialize"].Rows[0][2].ToString());
            wareHouseHeight = double.Parse(myds.Tables["initialize"].Rows[0][3].ToString());
            wareHouseWidth = double.Parse(myds.Tables["initialize"].Rows[0][4].ToString());
        }

        #endregion

        /// <summary>
        /// 初始化仓库内图形化显示的控件
        /// </summary>
        private void setControls()
        {
            #region 其它控件设置

            groupBox1.Text = "";
            groupBox1.Top = 100;
            groupBox1.Height = 400;
            double groupWidth = groupBox1.Height * wareHouseWidth / wareHouseHeight;
            if (groupWidth >= this.Width - 50)
            {
                groupBox1.Width = this.Width - 50;
                groupBox1.Left = 20;
            }
            else
            {
                groupBox1.Width = (int)groupWidth;
                groupBox1.Left = (this.Width - groupBox1.Width) / 2;
            }
            this.toolStripStatusLabel1.Text = "新智远";

            this.dataGridView1.Top = this.groupBox1.Top + this.groupBox1.Height + 10;
            this.dataGridView1.Left = this.groupBox1.Left;
            this.dataGridView1.Width = this.groupBox1.Width;

            #endregion

            #region 初始化库内库位图片

            int row = 0;
            int initialSize;
            if ((this.groupBox1.Height - 100) / iRows > (this.groupBox1.Width - 100) / iColumns)
            {
                initialSize = (this.groupBox1.Width - 100) / iColumns;
            }
            else
            {
                initialSize = (this.groupBox1.Height - 100) / iRows;
            }
            int initialLeft = (this.groupBox1.Width - initialSize * iColumns) / 2;
            int initialTop = (this.groupBox1.Height - initialSize * iRows) / 2;
            myPic = new PictureBox[iColumns * iRows];
            for (int i = 0; i < iColumns * iRows; i++)
            {
                if (i % iColumns == 0 && i != 0)
                {
                    row++;
                }
                PictureBox _picturebox = new PictureBox();
                _picturebox.Name = "myPicture" + i.ToString();
                _picturebox.Size = new Size(initialSize, initialSize);
                _picturebox.Location = new Point(initialLeft + i % iColumns * initialSize, initialTop + row * initialSize);
                _picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
                _picturebox.Image = Image.FromFile(Application.StartupPath + "\\image\\gantry\\00.png");
                this.groupBox1.Controls.Add(_picturebox);
                _picturebox.Click += new EventHandler(picture_click);
                myPic[i] = _picturebox;
            }

            #endregion
        }


        #region picture的公用click方法

        /// <summary>
        /// picture的公用click方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picture_click(object sender, EventArgs e)
        {
            PictureBox myPicture = (PictureBox)sender;
            string myName = myPicture.Name;
            int m;
            if (int.TryParse(myName.Substring(9), out m))
            {
                getMeterialMessage(m);
            }
        }

        #endregion

        #region 获取每个库位的物料数量

        /// <summary>
        /// 获取每个库位的物料数量
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private int getNumber(int index)
        {
            DataSet myDs = new DataSet();
            dStr = "select * from  WareHouseLocation where id=" + (index + 1).ToString();
            int mynumber;
            myDs = hardware.dbdoublestar.getDataSet(dStr, "warehouselocation");
            if (myDs.Tables["warehouselocation"].Rows.Count > 0)
            {
                mynumber = int.Parse(myDs.Tables["warehouselocation"].Rows[0][1].ToString());
                return mynumber;
            }
            else
            {
                return 0;
            }
        }

        #endregion

        #region 获取每个库位的物流二维码(条形码)

        /// <summary>
        /// 获取每个库位的物流二维码
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private string[] getCodes(int index)
        {
            DataSet myDs = new DataSet();
            dStr = "select * from  WareHouseLocation where id=" + (index + 1).ToString();
            string[] code = new string[8];
            myDs = hardware.dbdoublestar.getDataSet(dStr, "warehouselocation");
            for (int i = 0; i < 8; i++)
            {
                code[i] = myDs.Tables["warehouselocation"].Rows[0][2 + i].ToString();
            }
            return code;
        }

        #endregion

        #region 根据实际情况更新控件图片
        /// <summary>
        /// 根据实际情况更新控件图片
        /// </summary>
        private void setPicture()
        {
            for (int i = 0; i < iColumns * iRows; i++)
            {
                myPic[i].Image = Image.FromFile(Application.StartupPath + "\\image\\gantry\\0" + getNumber(i).ToString() + ".png");
            }
        }

        #endregion

        #region 获取物流的详细信息并显示

        /// <summary>
        /// 获取物流的详细信息并显示
        /// </summary>
        /// <param name="index"></param>
        private void getMeterialMessage(int index)
        {
            int mynumber = getNumber(index);

            if (mynumber > 0)
            {
                string[] code = getCodes(index);
                dStr = "select * from  MaterialDetails where qrcode='" + code[0] + "'";
                for (int i = 1; i < mynumber; i++)
                {
                    dStr = dStr + " or qrcode='" + code[i] + "'";
                }
                DataSet myds1 = hardware.dbdoublestar.getDataSet(dStr, "materialdetails");
                this.dataGridView1.DataSource = myds1.Tables["materialdetails"];
            }
            else
            {
                dStr = "select * from  MaterialDetails where qrcode='-1'";
                DataSet myds1 = hardware.dbdoublestar.getDataSet(dStr, "materialdetails");
                this.dataGridView1.DataSource = myds1.Tables["materialdetails"];
            }
            this.dataGridView1.Columns[0].HeaderText = "二维码";
            this.dataGridView1.Columns[1].HeaderText = "物料型号";
            this.dataGridView1.Columns[2].HeaderText = "高度";
            this.dataGridView1.Columns[3].HeaderText = "内径";
            this.dataGridView1.Columns[4].HeaderText = "外径";
            this.dataGridView1.Columns[5].HeaderText = "入库日期";
            this.dataGridView1.Columns[6].HeaderText = "出库日期";
            this.dataGridView1.Columns[7].HeaderText = "库位号";
            this.dataGridView1.Columns[8].HeaderText = "备注";
        }

        #endregion

        #region 入库总方法
        private void inWareHouse(int wareHouseID, material myMaterial)
        {

        }

        #endregion

        #region 出库总方法

        private void outWareHouse()
        {

        }

        #endregion
        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            if (flagSizeChange)
            {
                flagSizeChange = false;
            }
            else
            {
                formAutoSize.controlAutoSize(this);
            }
        }
        private void 库位数量设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetWareHouseSize setwarehousesize = new SetWareHouseSize();
            setwarehousesize.Show();
        }

        private void 库位坐标设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monitorForm.Coordinate frmcoordinare = new monitorForm.Coordinate();
            frmcoordinare.ShowDialog();
        }
    }
}
