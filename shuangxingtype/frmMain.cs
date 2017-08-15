using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Collections;
using doublestartyre.Utils;
using doublestartyre.monitorForm;
using doublestartyre.utils;
using Opc.Da;
using System.Timers;
using System.Drawing.Imaging;

namespace doublestartyre
{
    public partial class frmMain : Form
    {


        string dStr, dStr1, dStr2;
        static double a1, a2, a3, a4, a5, a6, a7, a8;
        //double[][] information = new double[10][];            

        //public delegate void lineEventHandler(int s5);
        //public event lineEventHandler backEvent;

        hardware.lineDevice myLine = new hardware.lineDevice(utils.PlcUtils.mAddressProLine);


        static string mAddressQr1 = System.Configuration.ConfigurationManager.AppSettings["qr_scan1_address"];
        static int mPortQr1 = int.Parse(System.Configuration.ConfigurationManager.AppSettings["qr_scan1_port"]);

        static string mAddressQr2 = System.Configuration.ConfigurationManager.AppSettings["qr_scan2_address"];
        static int mPortQr2 = int.Parse(System.Configuration.ConfigurationManager.AppSettings["qr_scan2_port"]);

        static string mAddressQr3 = System.Configuration.ConfigurationManager.AppSettings["qr_scan3_address"];
        static int mPortQr3 = int.Parse(System.Configuration.ConfigurationManager.AppSettings["qr_scan3_port"]);

        private static String imagesDirectory = System.Windows.Forms.Application.StartupPath + "\\resources" + "\\images\\";
        private String currentAccountNumber;
        private String currentAccountName;

        hardware.QrCode myCode1 = new hardware.QrCode(mAddressQr1, mPortQr1);
        hardware.QrCode myCode2 = new hardware.QrCode(mAddressQr2, mPortQr2);
        hardware.QrCode myCode3 = new hardware.QrCode(mAddressQr3, mPortQr3);
        hardware.gantry MyGantry = new hardware.gantry();

        //EventWaitHandle wait = new AutoResetEvent(false);
        private NiThread t1, t2, t3,t4,t5;


        static int s6 = 0;
        static int ss6 = 0;
        public static void beforebackflag()//动均前分线反馈
        {
            //int s6 = 0;
            //hardware.lineDevice myLine = new hardware.lineDevice(utils.PlcUtils.mAddressProLine);
            //myLine.linefeedback(out s5,s6);
            DataSet myds1 = new DataSet();
            string dstr1 = "select * from flag where id = 1";
            myds1 = Utils.DatabaseUtils.GetDataSet(dstr1, "full");
            int flag = int.Parse(myds1.Tables[0].Rows[0]["flag"].ToString());
            if (flag == 1)
            {
                s6 = s6 + 1;
                beforedynamoic(s6);
                string dstr2 = "update flag set flag = 0 where id = 1;";
                DatabaseUtils.ExecuteSqlCommand(dstr2);

            }

            /*if (myLine.linefeedback(out s5,s6))
            {
                beforedynamoic(s5,s6);
                //分别让三个龙门抓取
                
            }*/


        }

        private static void beforedynamoic(/*int s5, */int s6)//s5 流水号id，s6 龙门id
        {
            

            //MyGantry.SetMove0(/*s5, s6, Bead, hang, lie, height*/a1,a2,a3,a4,a5,a6,a7);
            /*hardware.gantry MyGantry = new hardware.gantry();
            string dstr, dstr1, dstr2;
            DataSet myds = new DataSet();
            dstr = "select qrcode,productstandard from tyre where id = " + s5 + " ;";
            myds = Utils.DatabaseUtils.GetDataSet(dstr, "productstandard");
            string qrcode = myds.Tables[0].Rows[0]["qrcode"].ToString();
            string productstandard = myds.Tables[0].Rows[0]["productstandard"].ToString();
            DataSet myds1 = new DataSet();
            dstr1 = "select * from tyremaintenance where luntaiguige = '" + productstandard + "';";
            myds1 = Utils.DatabaseUtils.GetDataSet(dstr1, "productstandard1");
            double singleheight = double.Parse(myds1.Tables[0].Rows[0]["singleheight"].ToString());//单个轮胎高度
            double reduction = double.Parse(myds1.Tables[0].Rows[0]["reduction"].ToString());//形变量
            int Bead = int.Parse(myds1.Tables[0].Rows[0]["Bead"].ToString());//子口
            int minnumber = int.Parse(myds1.Tables[0].Rows[0]["minnumber"].ToString());//最小出库数量
            int maxheight = int.Parse(myds1.Tables[0].Rows[0]["maxheight"].ToString());//最大出库高度
            
            DataSet myds2 = new DataSet();
            dstr2 = "select * from cache"+s6.ToString()+" where productstandard = '" + productstandard + "' and status = '有';";
            myds2 = Utils.DatabaseUtils.GetDataSet(dstr2, "cache1");
            
            if (myds2.Tables[0].Rows.Count != 0)//暂存区里有相同规格的没满的轮子
            {
                int locationid = int.Parse(myds2.Tables[0].Rows[0]["id"].ToString());
                int number = int.Parse(myds2.Tables[0].Rows[0]["tyrenumber"].ToString());
                double height = singleheight * number - reduction * (number - 1);//库位高度
                int hang = locationid / 100;//行
                int lie = locationid % 100;//列
                MyGantry.SetMove0(s5, s6, Bead, hang, lie, height);//id，龙门id，子口，行，列，库位高度
                dstr = "update cache" + s6.ToString() + " set tyrenumber = " + (number+1)+" where id = "+ locationid +" ;";
                DatabaseUtils.ExecuteSqlCommand(dstr);
                if(minnumber == (number + 1))
                {
                    dstr1 = "update cache" + s6.ToString() + " set status = '满';";
                    DatabaseUtils.ExecuteSqlCommand(dstr1);

                }
            }
            else//库里没有此型号的轮子
            {
                DataSet myds3 = new DataSet();
                dstr = "select * from cache" + s6.ToString() + " where status = '空' order by id ;";
                myds3 = Utils.DatabaseUtils.GetDataSet(dstr, "tyrestatus");
                int addid = int.Parse(myds3.Tables[0].Rows[0]["id"].ToString());
                double height = singleheight;//库位高度
                int hang = addid / 100;//行
                int lie = addid % 100;//列
                MyGantry.SetMove0(s5, s6, Bead, hang, lie, height);//id，龙门id，子口，行，列，库位高度
                dstr1 = "update cache" + s6.ToString() + " set status = '有',productstandard = '" + productstandard + "',tyrenumber = 1 ;";//更新暂存区数据
                DatabaseUtils.ExecuteSqlCommand(dstr1);

            }*/
        }

        public static void laterbackflag()//动均后分线反馈
        {
            int s5,GantryID = 0;
            int s6 = 0;
            hardware.lineDevice myLine = new hardware.lineDevice(utils.PlcUtils.mAddressProLine);
            if(myLine.laterlineback(out s5,s6,GantryID))
            { 
                beforezancunqu(s5,GantryID);
            }
         
        }
#region 控制龙门抓取进入最后暂存区
        private static void beforezancunqu(int s5,int GantryID)
        {

            string dstr, dstr1, dstr2;
            DataSet myds = new DataSet();
            dstr = "select * from tyre where id =  " + s5 + ";";
            myds = Utils.DatabaseUtils.GetDataSet(dstr, "inzancunqu1");
            
            int dynamicbalancegrade = int.Parse(myds.Tables[0].Rows[0]["dynamicbalancegrade"].ToString());//动均等级
            string productstandard = myds.Tables[0].Rows[0]["productstandard"].ToString();//产品规格
            int rimgrade = int.Parse(myds.Tables[0].Rows[0]["rimgrade"].ToString());//轮辋等级（轮胎内经）
            string tyregrade = myds.Tables[0].Rows[0]["tyregrade"].ToString();//合格品还是次品
            DataSet myds1 = new DataSet();
            dstr1 = "select * from tyre where productstandard = '" + productstandard + "' and tyrestatus = 7 and dynamicbalancegrade = "
                + dynamicbalancegrade +" and tyregrade = '"+tyregrade+ "';";//搜索暂存区里面同样型号同样动均等级的同样等级的轮胎
            myds1 = Utils.DatabaseUtils.GetDataSet(dstr1, "zancunqu");
            if (myds1.Tables[0].Rows.Count == 0 || myds1.Tables[0].Rows.Count % 6 == 0)//暂存区里没有此型号的轮胎或者正好装了6个
            {
                DataSet myds2 = new DataSet();
                //dStr2 = "select * from storage where idnumber = 0 and isavailable = 1 order by id asc ";
                dstr2 = "select * from storage t where t.id not in " +
                    "(select  distinct locationid from tyre r where r.tyrestatus = 7) order by t.id asc";
                myds2 = Utils.DatabaseUtils.GetDataSet(dstr2, "idnumber");
                int storageid = int.Parse(myds2.Tables[0].Rows[0][0].ToString());//暂存区里的主键
                                                                                 //int storageidnumber = int.Parse(myds.Tables[0].Rows[0][4].ToString());
                int empty = myds2.Tables[0].Rows.Count;
                int flag = GantryID;//龙门ID
                int a1 = s5;//id
                int a2 = rimgrade;//轮胎内经
                int a3 = 0;//单个轮胎高度
                int a4 = storageid / 100;//行
                int a5 = storageid % 100;//列
                int a6 = 0;//库位高度
                //控制龙门机械手将轮子抓入storageid位置
                hardware.gantry MyGantry = new hardware.gantry();
                MyGantry.SetMove1(flag,a1, a2, a3, a4, a5, a6);
                string datetime = DateTime.Now.ToString();
                //storageidnumber= storageidnumber+1;
                

                string dStr3 = "Update tyre set locationid = " + storageid + ",locationidnumber = 1,Inzancuntime = " + datetime +
                    ",tyrestatus = 7 where id = '" + s5 + "'";//添加了轮胎在暂存区的位置以及具体位置和轮胎的状态
                                                                      //dStr1 = "Update tyre set tyrestatus = 7 where qrcode = ";//修改了轮胎状态
                                                                      //dStr2 = "Update storage set idnumber = 1 where id = "+storageid+";";//修改了个数                     

            }
            for (int j = 0; j < myds1.Tables[0].Rows.Count; j++)//暂存区里有此型号的，需要遍历不同动均等级的轮胎
            {
                int dynamicbalancegrade1 = int.Parse(myds1.Tables[0].Rows[j]["dynamicbalancegrade"].ToString());//暂存区里面同型号轮胎的动均等级
                if (dynamicbalancegrade == dynamicbalancegrade1)
                {
                    DataSet myds4 = new DataSet();
                    string dStr4 = "select locationid,isfull,locationidnumber from tyre where id in (select min(id) from tyre group by locationid) " +
                        "and tyrestatus = 7 and dynamicbalancegrade = " + dynamicbalancegrade + " and productstandard = "
                         + productstandard + ";";
                    myds4 = Utils.DatabaseUtils.GetDataSet(dStr4, "locationid");
                    for (int k = 0; k < myds4.Tables[0].Rows.Count; k++)
                    {
                        int locationid = int.Parse(myds4.Tables[0].Rows[k][0].ToString());
                        int isfull = int.Parse(myds4.Tables[0].Rows[k]["isfull"].ToString());
                        int locationidnumber = int.Parse(myds4.Tables[0].Rows[k]["locationidnumber"].ToString());
                        if (isfull == 0)
                        {
                            int flag = GantryID;
                            int a1 = s5;//id
                            int a2 = rimgrade;//轮胎内经
                            int a3 = 0;//单个轮胎高度
                            int a4 = locationid / 100;//行
                            int a5 = locationid % 100;//列
                            int a6 = 0;//库位高度
                                       //控制龙门机械手将轮子抓入storageid位置
                            hardware.gantry MyGantry = new hardware.gantry();
                            MyGantry.SetMove1(flag,a1, a2, a3, a4, a5, a6);
                            string datetime = DateTime.Now.ToString();
                            locationidnumber = locationidnumber + 1;
                            string dStr5 = "Update tyre set locationid = " + locationid +
                                 ",locationidnumber = " + locationidnumber + " ,tyrestatus = 7,Inzancuntime = " + datetime + " where id = '" + s5 + "'";//添加了轮胎在暂存区的位置以及具体位置和轮胎的状态
                            if (locationidnumber == 6)//判断此位置是否装满
                            {
                                string dStr6 = "Update tyre set isfull = 1 where locationid = " + locationid + ";";    
                            }
                            break;
                           
                        }                       
                    }
                    break;
                }
            }
        }
#endregion
        public frmMain(String accountNumber, String accountName)
        {
            InitializeComponent();
            currentAccountNumber = accountNumber;
            currentAccountName = accountName;

        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            setwindows();//窗口初始化
            #region 打开硬件通讯
            if (!openhardware())
            {
                MessageBox.Show("通讯异常！请检查设备！");
            }
            myCode1.CodeArrivalEvent += scannerHadling1;
            myCode2.CodeArrivalEvent += scannerHadling2;
            myCode3.CodeArrivalEvent += scannerHadling3;

            #endregion

            //backEvent += backflaging;
            t1 = new NiThread(backchiremoving, null, "backchiremoving", 500);//剃毛反馈
            t2 = new NiThread(beforebackflag, null, "beforebackflag", 500);//动均前分线反馈
            t3 = new NiThread(laterbackflag, null, "laterbackflag", 500);//动均后分线
            t4 = new NiThread(output, null, "output", 1000);//暂存区出库
            t5 = new NiThread(outhuancunqu, null, "outhuancunqu", 1000);//缓存区出库 
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            Trace.WriteLine("系统启动成功!");
        }
       
       
       
        

        private void scannerHadling1(byte[] data)
        {

            parsecode(data, out string qrcode);
            MesLink(qrcode);



        }
        private void scannerHadling2(byte[] data)
        {

            parsecode(data, out string qrcode);
            balancestorage(qrcode);



        }
        private void scannerHadling3(byte[] data)
        {

            parsecode(data, out string qrcode);
            zancunqu(qrcode);



        }
        private void parsecode(byte[] data, out string qrcode)
        {
           
           /* int i = -1;
            int Start = -1;
            int End = -1;
            foreach (byte bt in data)
            {
                i++;
                if (bt == 2 && Start == -1)
                {
                    Start = i;
                }
                if (bt == 13 && data[i + 1] == 10)
                {
                    End = i - 1;
                }
            }
            byte[] Newdata = new byte[End];
            Array.Copy(data, Start, Newdata, 0, End);*/
            qrcode = System.Text.Encoding.ASCII.GetString(data)/*.ToString().Trim('\r','\n')*/;
            if(qrcode == "NOREAD")
            {
                myLine.fail();

            }
        }
        private void MesLink(string qrcode)
        {
            if(qrcode == "NOREAD")
            {
                return;
            }
            DataSet myds = new DataSet();
            string aaaa = qrcode;
            
            string DStr = "select * from DJK4FDSBoxDB where TIRECODE ='" + qrcode + "'";
            myds = Utils.MES.GetDataSet(dStr, "MES");
            string TIREDARD = myds.Tables[0].Rows[0]["TIREDARD"].ToString();//规格
            string TIREPATTERN = myds.Tables[0].Rows[0]["TIREPATTERN"].ToString();//花纹
            string Measurement = myds.Tables[0].Rows[0]["Measurement"].ToString();//实验胎
            DateTime Nowdatetime = DateTime.Now;
            DataSet myds1 = new DataSet();
            string DStr1 = " insert into tyre (qrcode,productstandardset,tyrefigure,IsDevelopment ,InDetectionlineTime,tyrestatus) values('" +
                 qrcode + "','" + TIREDARD + "','" + TIREPATTERN + "','" + Measurement + "','" + Nowdatetime.ToString() + "','1'; ";
            myds1 = Utils.DatabaseUtils.GetDataSet(dStr, "inserttyre");
            chiremoving(qrcode);




        }
        #region 打开所有连接
        private bool openhardware()
        {
            try
            {
                /*if (!myCode1.socket_create_connect())
                {
                    MessageBox.Show("二维码扫描1通讯异常！");
                    pictureBox1.Image = Image.FromFile(imagesDirectory + "red.png");
                    return false;
                }*/
                /*if (!myCode2.socket_create_connect())
                {
                    MessageBox.Show("二维码扫描2通讯异常！");
                    return false;
                }*/
                if (!myCode3.socket_create_connect())
                {
                    MessageBox.Show("二维码扫描3通讯异常！");
                    return false;
                }
                /*if (!MyGantry.GantryConnect())
                {
                    MessageBox.Show("与龙门通讯异常！");
                    return false;
                }*/
                /*if (!myLine.ConnectPlc())
                {
                    MessageBox.Show("与线体通讯异常！");
                    return false;
                }*/
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        #endregion
        /*#region 龙门状态
        bool status =  MyGantry.ReadRunningStatus();

        #endregion*/

        private void codefail(string qrcode)
        {

        }
        #region 硫化后分线
        private void chiremoving(string qrcode)
        {
            if (qrcode == "NOREAD")
            {
                return;
            }
            ushort s2;
            DataSet myds = new DataSet();
            dStr = "select id,tyrefigure from tyre where qrcode =  " + qrcode + ";";
            myds = Utils.DatabaseUtils.GetDataSet(dStr, "ichiremoving");
            int s1 = int.Parse(myds.Tables[0].Rows[0]["id"].ToString());
            string tyrefigure = myds.Tables[0].Rows[0]["tyrefigure"].ToString();//花纹
            if (tyrefigure == "")//根据花纹来分线
            {
                s2 = 1;
            }
            else
            {
                s2 = 2;

            }
            myLine.SetMove1(s1, s2);
            


        }



        #endregion
       
        #region 进暂存区前逻辑
        private void zancunqu(string qrcode)
        {
            ushort s2;//s1 流水号，s2 道口号
           
            DataSet myds = new DataSet();
            dStr = "select * from tyre where qrcode =  " + qrcode + ";";
            myds = Utils.DatabaseUtils.GetDataSet(dStr, "inzancunqu");

            int IsDevelopment = int.Parse(myds.Tables[0].Rows[0]["IsDevelopment"].ToString());//是否是实验胎
            int dynamicbalancegrade = int.Parse(myds.Tables[0].Rows[0]["dynamicbalancegrade"].ToString());//动均等级
            string productstandard = myds.Tables[0].Rows[0]["productstandard"].ToString();//产品规格

            int rimgrade = int.Parse(myds.Tables[0].Rows[0]["rimgrade"].ToString());//轮辋等级（轮胎内经）
            int s1 = int.Parse(myds.Tables[0].Rows[0]["id"].ToString());//id
            //string qrcode = myds.Tables[0].Rows[0][1].ToString();//二维码
            if (IsDevelopment == 1)
            {
                //实验胎下线
                Trace.WriteLine("实验胎： " + qrcode + "下线");
                s2 = 2;
                return;
            }           
            DataSet myds7 = new DataSet();
            String dstr = "(select count(id) from storage where productstandard = '" + productstandard + "' union all select count(id) from storage2 where productstandard = '" + productstandard + "')" +
                " union all(select count(id) from tyre where storagenum = 1 union all select count(id) from tyre where storagenum = 2)";
            myds7 = Utils.DatabaseUtils.GetDataSet(dStr, "zancunqufangxiang");
            int num1 = int.Parse(myds.Tables[0].Rows[0][0].ToString());//暂存区1里面相同规格的数量
            int num2 = int.Parse(myds.Tables[0].Rows[1][0].ToString());//暂存区2里面相同规格的数量
            int num3 = int.Parse(myds.Tables[0].Rows[2][0].ToString());//暂存区1总轮胎数量
            int num4 = int.Parse(myds.Tables[0].Rows[3][0].ToString());//暂存区2总轮胎数量
            if (num1 == num2)//都没有此规格的轮胎或者在某特殊情况下同规格轮胎数量相同
            {
                if (num3 > num4)//优先往轮胎数量少的放
                {
                    //进入暂存区2
                    s2 = 4;
                    
                }
                else
                {
                    //进入暂存区1
                    s2 = 3;
                    
                }
            }
            else
            {
                if (num1 > num2)//优先放有此规格的暂存区
                {
                    //进入暂存区1
                    s2 = 3;
                   
                }
                else
                {
                    //进入暂存区2
                    s2 = 4;
                  
                }
            }
            if (!myLine.SetMove3(s1, s2))
            {
                MessageBox.Show("与线体通讯失败，请检查通讯链接！");
            }
        }
        #region 动平衡后暂存区出库
        private void output()
        {
            String DSTR, DSTR0,DSTR1, DSTR2;
            DataSet myds = new DataSet();
            DSTR = "select id,productstandard from storage where status = '满';";
            myds = Utils.DatabaseUtils.GetDataSet(DSTR, "fullone");
            DataSet myds2 = new DataSet();
            DSTR0 = "select id,productstandard from storage2 where status = '满';";
            myds2 = Utils.DatabaseUtils.GetDataSet(DSTR0, "fulltwo");


            if (myds.Tables[0].Rows.Count != 0)
            {
                int idnumber = int.Parse(myds.Tables[0].Rows[0][0].ToString());//位置id
                String outproductstandard = myds.Tables[0].Rows[0][2].ToString();//轮胎规格
                DataSet myds1 = new DataSet();
                DSTR1 = "select * from tyremaintenance where luntaiguige = '" +outproductstandard+"';";
                myds1 = Utils.DatabaseUtils.GetDataSet(DSTR1, "outproductstandard");
                int Bead = int.Parse(myds1.Tables[0].Rows[0]["Bead"].ToString());//子口
                int minnumber = int.Parse(myds1.Tables[0].Rows[0]["minnumber"].ToString());//最小出库数量
                Random ram = new Random();
                ram.Next();
                int a1 = ram.Next(); //流水号
                int a2 = idnumber / 100;//行
                int a3 = idnumber % 100;//列
                int a4 = 4;//暂存区4
                if (MyGantry.outzancunquflag(Bead,minnumber,a1,a2,a3,a4))
                {  
                    DSTR2 = "update storage set status = '空',productstandard = null,dynamicbalancegrade =null,tyregrade = null where id = " + idnumber+" ;";//清空此满垛在暂存区是数据
                    DatabaseUtils.ExecuteSqlCommand(DSTR2);
                    DSTR2 = "update tyre set tyrestatus = 8 where locationid = " + idnumber + " and storagenum = 1";//将出库的轮胎状态改成“已装箱”
                    DatabaseUtils.ExecuteSqlCommand(DSTR2);

                }
            }
            if (myds2.Tables[0].Rows.Count != 0)
            {
                int idnumber = int.Parse(myds.Tables[0].Rows[0][0].ToString());
                String outproductstandard = myds.Tables[0].Rows[0][1].ToString();
                DataSet myds1 = new DataSet();
                DSTR1 = "select * from tyremaintenance where luntaiguige = '" + outproductstandard + "';";
                myds1 = Utils.DatabaseUtils.GetDataSet(DSTR1, "outproductstandard");
                int Bead = int.Parse(myds1.Tables[0].Rows[0]["Bead"].ToString());//子口
                int minnumber = int.Parse(myds1.Tables[0].Rows[0]["minnumber"].ToString());//最小出库数量
                Random ram = new Random();
                ram.Next();
                int a1 = ram.Next(); //流水号
                int a2 = idnumber / 100;//行
                int a3 = idnumber % 100;//列
                int a4 = 5;//暂存区5
                if (MyGantry.outzancunquflag(Bead, minnumber, a1, a2, a3, a4))
                {
                    DSTR2 = "update storage2 set status = '空',productstandard = null,dynamicbalancegrade =null,tyregrade = null where id = " + idnumber + " ;";//清空此满垛在暂存区数据
                    DatabaseUtils.ExecuteSqlCommand(DSTR2);
                    DSTR2 = "update tyre set tyrestatus = 8 where locationid = " + idnumber + " and storagenum = 2";//将出库的轮胎状态改成“已装箱”
                    DatabaseUtils.ExecuteSqlCommand(DSTR2);

                }
            }




            } 
        #endregion
        #region 动均前暂存区出库
        private void outhuancunqu()
        {
                
              
            
            string dstr1, dstr2, dstr3;
            for (int i =1;i<4;i++) { 
                DataSet myds1 = new DataSet();
                dstr1 = "select * from cache"+i.ToString()+" where status = '满';";
                myds1 = DatabaseUtils.GetDataSet(dstr1, "full");
                if (myds1.Tables[0].Rows.Count != 0)
                {
                    int idnumber = int.Parse(myds1.Tables[0].Rows[0][0].ToString());//暂存区id
                    String outproductstandard = myds1.Tables[0].Rows[0]["productstandard"].ToString();//轮胎规格
                    DataSet myds2 = new DataSet();
                    dstr2 = "select * from tyremaintenance where luntaiguige = '" + outproductstandard + "';";
                    myds1 = Utils.DatabaseUtils.GetDataSet(dstr2, "outproductstandard");
                    int Bead = int.Parse(myds1.Tables[0].Rows[0]["Bead"].ToString());//子口
                    int minnumber = int.Parse(myds1.Tables[0].Rows[0]["minnumber"].ToString());//最小出库数量
                    Random ram = new Random();
                    ram.Next();
                    int a1 = ram.Next(); //流水号
                    int a2 = idnumber / 100;//行
                    int a3 = idnumber % 100;//列
                    int a4 = i;//暂存区i
                    if (MyGantry.outhuancunquflag(Bead, minnumber, a1, a2, a3, a4))
                    {
                        dstr3 = "update cache" + i.ToString() + " set status = '空',productstandard = null,tyregrade = null where id = " + idnumber + " ;";//清空此满垛在缓存区的数据
                        DatabaseUtils.ExecuteSqlCommand(dstr3);
                    }







                }
            }
        }
        #endregion 
        
        #endregion
        #region 动平衡前暂存区
        private void balancestorage(string qrcode)
        {
            if (qrcode == "NOREAD")
            {
                return;
            }
            ushort s2;
            string dstr = "select jitaiid from barcodelog where qrcode = '" + qrcode.ToString() + "';";
            DataSet myds = MES.GetDataSet(dstr, "barcodelog");
            string jitaiid = myds.Tables[0].Rows[0]["jitaiid"].ToString();
            string dstr2 = "select * from tyremaintenance where jitaiid = '" + jitaiid + "';";
            DataSet myds2 = MES.GetDataSet(dstr2, "luntaiguige");
            string luntaiguige = myds2.Tables[0].Rows[0]["luntaiguige"].ToString();
            string singleheight = myds2.Tables[0].Rows[0]["singleheight"].ToString();


            

               
           /* DataSet myds = new DataSet();
            dStr = " select id,rimgrade from tyre where qrcode = '" + qrcode + "';";
            myds = Utils.DatabaseUtils.GetDataSet(dStr, "rimgrade");
            int rimgrade = int.Parse(myds.Tables[0].Rows[0]["rimgrade"].ToString());//轮辋等级
            int s1 = int.Parse(myds.Tables[0].Rows[0]["id"].ToString());*/
            if (rimgrade < 1000)
            {
                //让去动平衡前暂存区1
                s2 = 1;
                
            }
            if (rimgrade > 1000 && rimgrade < 2000)
            {
                //让去动平衡前暂存区2
                s2 = 2;
                
            }
            else
            {
                //让去动平衡前暂存区3
                s2 = 3;
                
            }
            if (myLine.SetMove2(s1, s2))
            {
                DataSet myds1 = new DataSet();
                dStr1 = "update tyre set tyrestatus = 4 where qrcode = '" + qrcode + "';";
            }
            else
            {
                Trace.WriteLine("通讯失败！");
            }
        }
        #endregion
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DataSet myds = new DataSet();
            dStr = "select A.id,A.qrcode,B.myvalue,A.InDetectionlineTime,A.Inzancuntime,A.Packagetime,A.PackageNumber,A.locationid,A.isfull,A.rimgrade, A.tyrefigure"
                 + "  from tyre A inner join keyValue B on A.tyrestatus = B.mykey inner join storage C on A.locationid = C.id  where tyrestatus = 1 or tyrestatus = 2 or tyrestatus = 3 " +
                  "or tyrestatus = 4 or tyrestatus = 5 or tyrestatus = 6 or tyrestatus = 7 or tyrestatus = 8 order by id desc ";
            myds = Utils.DatabaseUtils.GetDataSet(dStr, "tyre");
            //myds = Utils.DatabaseUtils.getDataSet(dStr, "hwheel");
            this.dataGridView.DataSource = myds.Tables["tyre"];
            myds.Dispose();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
        }
     
            private void setwindows()//设置窗体
        {
            #region  设置窗体外观和内部控件布局
            // 窗体title
            String windowTitle = System.Configuration.ConfigurationManager.AppSettings["customer_window_title"];
            this.Text = windowTitle;

            // 设置窗体最大化，并且不被任务栏遮挡。
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            #endregion
            #region 初始化显示的数据
            DataSet myds = new DataSet();
            dStr = "select A.id,A.qrcode,B.myvalue,A.InDetectionlineTime,A.Inzancuntime,A.Packagetime,A.PackageNumber,A.locationid,A.isfull,A.rimgrade,A.tyrefigure"
                + "  from tyre A inner join keyValue B on A.tyrestatus = B.mykey  where tyrestatus = 1 or tyrestatus = 2 or tyrestatus = 3 " +
                 "or tyrestatus = 4 or tyrestatus = 5 or tyrestatus = 6 or tyrestatus = 7 or tyrestatus = 8 order by id desc ";
            myds = Utils.DatabaseUtils.GetDataSet(dStr, "tyre");
            this.dataGridView.DataSource = myds.Tables["tyre"];
            myds.Dispose();
            dataGridView.Columns[0].HeaderText = "序号";
            dataGridView.Columns[0].Width = 50;
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].HeaderText = "二维码";
            dataGridView.Columns[1].Width = 80;
            dataGridView.Columns[2].HeaderText = "状态";
            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[3].HeaderText = "入车间时间";
            dataGridView.Columns[3].Width = 200;
            dataGridView.Columns[4].HeaderText = "入暂存区时间";
            dataGridView.Columns[4].Width = 200;
            //dataGridView.Columns[5].HeaderText = "出暂存区时间";
            //dataGridView.Columns[5].Width = 200;
            dataGridView.Columns[5].HeaderText = "包装时间";
            dataGridView.Columns[5].Width = 100;
            dataGridView.Columns[6].HeaderText = "包装序号";
            dataGridView.Columns[6].Width = 100;
            dataGridView.Columns[7].HeaderText = "位置信息";
            dataGridView.Columns[7].Width = 100;
            //dataGridView.Columns[8].HeaderText = "具体位置";
            //dataGridView.Columns[8].Width = 100;
            dataGridView.Columns[8].HeaderText = "是否装满";
            dataGridView.Columns[8].Width = 100;
            dataGridView.Columns[9].HeaderText = "轮辋寸级";
            dataGridView.Columns[9].Width = 100;
            dataGridView.Columns[10].HeaderText = "轮胎花纹";
            dataGridView.Columns[10].Width = 100;
            //dataGridView.Columns[11].HeaderText = "判级";
           // dataGridView.Columns[11].Width = 100;


            /*dataGridView.Columns[8].HeaderText = "弓高";
            dataGridView.Columns[8].Width = 55;
            dataGridView.Columns[9].HeaderText = "重量";
            dataGridView.Columns[9].Width = 55;
            dataGridView.Columns[10].HeaderText = "焊点";
            dataGridView.Columns[10].Width = 55;*/
            dataGridView.Font = new Font("宋体", 9, FontStyle.Regular);
            #endregion
        }
       // private bool lineDataReady = false;
       // private object locker = new object();
        public void backchiremoving()
        {           
            int s5 = 0;
            hardware.lineDevice myLine = new hardware.lineDevice(utils.PlcUtils.mAddressProLine);
            myLine.shavingback(out s5);
            if (s5 != 0)
            {
                DataSet myds = new DataSet();
                string DStr0 = "update tyre set tyrestatus = 1 where id = " + s5 + " ;";//修改轮胎状态
                myds = Utils.DatabaseUtils.GetDataSet(DStr0, "shavingback");
                myds.Dispose();
            }

        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void frmmain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否关闭系统？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void 用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 添加用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountManagement.frmCreateAccount createAccountForm = new AccountManagement.frmCreateAccount();
            createAccountForm.Show();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountManagement.frmChangePassword changePasswordForm = new AccountManagement.frmChangePassword();
            changePasswordForm.Show();
        }

        private void tollBarMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void 轮胎数据查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monitorForm.tyrequery Ftyrequery = new tyrequery();
            Ftyrequery.ShowDialog();
        }

        private void 系统退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否关闭系统？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 动均后暂存区1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //monitorForm.zancunku Fzancunku = new monitorForm.zancunku();
            //Fzancunku.ShowDialog();
            monitorForm.zancunqu Fzancunqu = new monitorForm.zancunqu();
            Fzancunqu.ShowDialog();
        }



        private void 暂存区ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 动均后暂存区2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monitorForm.zancunqu2 Fzancunqu2 = new monitorForm.zancunqu2();
            Fzancunqu2.ShowDialog();
        }

        private void 动均前暂存区1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monitorForm.huancunqu Fhuancunqu = new monitorForm.huancunqu();
            Fhuancunqu.ShowDialog();
        }

        private void 动均前暂存区2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            monitorForm.huancunqu2 Fhuancunqu2 = new monitorForm.huancunqu2();
            Fhuancunqu2.ShowDialog();
        }

        private void 动均前暂存区3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monitorForm.huancunqu3 Fhuancunqu3 = new monitorForm.huancunqu3();
            Fhuancunqu3.ShowDialog();

        }



        private void comstatusGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void 轮胎信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monitorForm.tyremaintenance Ftyremaintenance = new tyremaintenance();
            Ftyremaintenance.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mainFramPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}

