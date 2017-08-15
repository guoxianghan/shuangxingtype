using System;
using Opc;
using Opc.Da;
using System.Timers;
using doublestartyre.utils;
using System.Threading;
using System.Text;
using System.Diagnostics;
using System.Collections;
using OPCAutomation;

namespace doublestartyre.hardware
{

    class gantry
    {
        OPCServer KepServer;

        OPCGroups KepGroups;

        OPCGroup KepGroup;
        OPCGroup KepGroup2;
        OPCGroup KepGroup3;


        OPCItems KepItems;
        OPCItems KepItems2;
        OPCItems KepItems3;

        OPCItem KepItem;

        OPCItem[] MyItem;
        OPCItem[] MyItem2;
        OPCItem[] MyItem3;


        #region 打开龙门通讯
        public bool GantryConnect()
        {
            String serIp = "localhost";//服务器的IP地址
            String serverName = "OPC.IWSCP";//OPC服务器名称
            KepServer = new OPCServer();
            //连接OPC服务器,opc服务名,ip
            KepServer.Connect(serverName, serIp);
            //判断连接状态
            if (KepServer.ServerState == (int)OPCServerState.OPCRunning)
            {
                KepGroups = KepServer.OPCGroups;
                return true;
            }
            else
            {
                //这里你可以根据返回的状态来自定义显示信息，请查看自动化接口API文档

                return false;
            }

        }
        #endregion


        System.Timers.Timer time = new System.Timers.Timer();
        System.Timers.Timer time0 = new System.Timers.Timer();
        System.Timers.Timer time1 = new System.Timers.Timer();
        System.Timers.Timer time2 = new System.Timers.Timer();
        System.Timers.Timer time3 = new System.Timers.Timer();
        System.Timers.Timer time4 = new System.Timers.Timer();
        System.Timers.Timer time5 = new System.Timers.Timer();



        #region 龙门抓取轮胎进3个缓存区
        public void SetMove0(/*int s5, int s6, int Bead, int hang, int lie, double height*/double a1, double a2, double a3, double a4, double a5, double a6, double a7)
        {
            time2.Elapsed += new ElapsedEventHandler((s, e) => time2_Elapsed(s, e, a1, a2, a3, a4, a5, a6,a7));
            time2.Interval = 1000;
            time2.Start();


        }

        private void time2_Elapsed(object s, ElapsedEventArgs e, double a1, double a2, double a3, double a4, double a5, double a6, double a7)
        {
            KepGroup = KepGroups.Add("Group0");
            /*KepGroup2 = KepGroups.Add("Group2");
            KepGroup3 = KepGroups.Add("Group3");*/
            KepGroup.UpdateRate = 250;
           /* KepGroup2.UpdateRate = 250;
            KepGroup3.UpdateRate = 250;*/
            KepGroup.IsActive = true;
           /* KepGroup2.IsActive = true;
            KepGroup3.IsActive = true;*/
            KepGroup.IsSubscribed = true;
           /* KepGroup2.IsSubscribed = true;
            KepGroup3.IsSubscribed = true;*/
            //当KepGroup中数据发生改变的触发事件
            KepGroup.DataChange += new DIOPCGroupEvent_DataChangeEventHandler(KepGroup_DataChange);
           // KepGroup2.DataChange += new DIOPCGroupEvent_DataChangeEventHandler(KepGroup_DataChange2);
            //  KepGroup3.DataChange += new DIOPCGroupEvent_DataChangeEventHandler(KepGroup_DataChange3);

            KepItems = KepGroup.OPCItems;
            //KepItems2 = KepGroup2.OPCItems;
            //KepItems3 = KepGroup3.OPCItems;
            /*int[] temp = new int[3];
            temp[0] = 0;
            KepItems.AddItem("123456:OPCAE", 1);
            KepItems.AddItem("123456:lishile", 2);*/
            //OPCItem bItem = KepItems.Item(2);
           /* MyItem = new OPCItem[27];
            MyItem[0] = KepItems.AddItem("!UI4,PCR_LM1,Plc.PVL,Application.USERVARGLOBAL.JXSStatus", 1);
            MyItem[1] = KepItems.AddItem("!UI4,PCR_LM1,Plc.PVL,Application.USERVARGLOBAL.r_id", 2);
            MyItem[2] = KepItems.AddItem("!UI4,PCR_LM1,Plc.PVL,Application.USERVARGLOBAL.r_id_back", 3);
            MyItem[3] = KepItems.AddItem("!UI4,PCR_LM1,Plc.PVL,Application.USERVARGLOBAL.r_typeid", 4);
            MyItem[4] = KepItems.AddItem("!UI4,PCR_LM1,Plc.PVL,Application.USERVARGLOBAL.r_cpzik", 5);
            MyItem[5] = KepItems.AddItem("!UI4,PCR_LM1,Plc.PVL,Application.USERVARGLOBAL.r_cphigh", 6);
            MyItem[6] = KepItems.AddItem("!UI4,PCR_LM1,Plc.PVL,Application.USERVARGLOBAL.r_hang", 7);
            MyItem[7] = KepItems.AddItem("!UI4,PCR_LM1,Plc.PVL,Application.USERVARGLOBAL.r_lie", 8);
            MyItem[8] = KepItems.AddItem("!UI4,PCR_LM1,Plc.PVL,Application.USERVARGLOBAL.r_high", 9);
            MyItem[9] = KepItems.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.JXSStatus", 10);
            MyItem[10] = KepItems.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.r_id", 11);
            MyItem[11] = KepItems.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.r_id_back", 12);
            MyItem[12] = KepItems.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.r_typeid", 13);
            MyItem[13] = KepItems.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.r_cpzik", 14);
            MyItem[14] = KepItems.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.r_cphigh", 15);
            MyItem[15] = KepItems.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.r_hang", 16);
            MyItem[16] = KepItems.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.r_lie", 17);
            MyItem[17] = KepItems.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.r_high", 18);
            MyItem[18] = KepItems.AddItem("!UI4,PCR_LM3,Plc.PVL,Application.USERVARGLOBAL.JXSStatus", 19);
            MyItem[19] = KepItems.AddItem("!UI4,PCR_LM3,Plc.PVL,Application.USERVARGLOBAL.r_id", 20);
            MyItem[20] = KepItems.AddItem("!UI4,PCR_LM3,Plc.PVL,Application.USERVARGLOBAL.r_id_back", 21);
            MyItem[21] = KepItems.AddItem("!UI4,PCR_LM3,Plc.PVL,Application.USERVARGLOBAL.r_typeid", 22);
            MyItem[22] = KepItems.AddItem("!UI4,PCR_LM3,Plc.PVL,Application.USERVARGLOBAL.r_cpzik", 23);
            MyItem[23] = KepItems.AddItem("!UI4,PCR_LM3,Plc.PVL,Application.USERVARGLOBAL.r_cphigh", 24);
            MyItem[24] = KepItems.AddItem("!UI4,PCR_LM3,Plc.PVL,Application.USERVARGLOBAL.r_hang", 25);
            MyItem[25] = KepItems.AddItem("!UI4,PCR_LM3,Plc.PVL,Application.USERVARGLOBAL.r_lie", 26);
            MyItem[26] = KepItems.AddItem("!UI4,PCR_LM3,Plc.PVL,Application.USERVARGLOBAL.r_high", 27);
            
            /*double[] items1 = new double[28];
            items1[0] = 0;

            for (int i = 1; i < items1.Length; i++)
            {
                items1[i] = MyItem[i - 1].Value;
                if(items1[i] == null)
                {

                }
            }
            Array serverHandles = (Array)items1;
            Array Errors;
            int cancelID;
            KepGroup.AsyncRead(2, ref serverHandles, out Errors, 1, out cancelID);*/



           /* if (s6 == 1)
            {*/
                MyItem = new OPCItem[9];
                MyItem[0] = KepItems.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.JXSStatus", 1);
                MyItem[1] = KepItems.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.r_id", 2);
                MyItem[2] = KepItems.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.r_id_back", 3);
                MyItem[3] = KepItems.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.r_typeid", 4);
                MyItem[4] = KepItems.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.r_cpzik", 5);
                MyItem[5] = KepItems.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.r_cphigh", 6);
                MyItem[6] = KepItems.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.r_hang", 7);
                MyItem[7] = KepItems.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.r_lie", 8);
                MyItem[8] = KepItems.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.r_high", 9);
                double[] items1 = new double[10];
                items1[0] = 0;
                for (int i = 1; i < items1.Length; i++)
                    items1[i] = MyItem[i - 1].Value;

                Array serverHandles = (Array)items1;
                Array Errors;
                int cancelID;
                int JXSStatus = Int32.Parse(items1[1].ToString()); //机械手状态
                //KepGroup.AsyncRead(9, ref serverHandles, out Errors, 1, out cancelID);


                //龙门未动作时
                if (JXSStatus == 1)
                {
                    int[] tmp = new int[] { 0, MyItem[1].ServerHandle, MyItem[3].ServerHandle, MyItem[4].ServerHandle, MyItem[5].ServerHandle, MyItem[6].ServerHandle, MyItem[7].ServerHandle };
                    Array ServerHandles = (Array)tmp;
                    object[] valuetemp = new object[7] { "", /*s5, Bead, hang, lie, height*/ a1,a2,a3,a4,a5,a6};
                    Array values = (Array)valuetemp;
                    KepGroup.AsyncWrite(6, ref serverHandles, ref values, out Errors, 1, out cancelID);
                    Thread.Sleep(500);
                }
                if (JXSStatus == 3)
                {
                    int idback = int.Parse(items1[2].ToString());
                    if (idback != 0)
                    {
                        Trace.WriteLine("轮胎放置完成！");
                        MyItem[2].Write(0);//置零
                        time2.Stop();
                    }
                }
           /* }*/
            /*if (s6 == 2)
            {
                MyItem2 = new OPCItem[9];
                MyItem2[0] = KepItems2.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.JXSStatus", 1);
                MyItem2[1] = KepItems2.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.r_id", 2);
                MyItem2[2] = KepItems2.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.r_id_back", 3);
                MyItem2[3] = KepItems2.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.r_typeid", 4);
                MyItem2[4] = KepItems2.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.r_cpzik", 5);
                MyItem2[5] = KepItems2.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.r_cphigh", 6);
                MyItem2[6] = KepItems2.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.r_hang", 7);
                MyItem2[7] = KepItems2.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.r_lie", 8);
                MyItem2[8] = KepItems2.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.r_high", 9);
                double[] items2 = new double[10];
                items2[0] = 0;
                for (int i = 1; i < items2.Length; i++)
                    items2[i] = MyItem2[i - 1].Value;

                Array serverHandles = (Array)items2;
                Array Errors;
                int cancelID;
                int JXSStatus = Int32.Parse(items2[1].ToString()); //机械手状态
                //KepGroup.AsyncRead(9, ref serverHandles, out Errors, 1, out cancelID);


                //龙门未动作时
                if (JXSStatus == 1)
                {
                    int[] tmp = new int[] { 0, MyItem2[1].ServerHandle, MyItem2[4].ServerHandle, MyItem2[6].ServerHandle, MyItem2[7].ServerHandle, MyItem2[8].ServerHandle };
                    Array ServerHandles = (Array)tmp;
                    object[] valuetemp = new object[6] { "", s5, Bead, hang, lie, height };
                    Array values = (Array)valuetemp;
                    KepGroup.AsyncWrite(5, ref serverHandles, ref values, out Errors, 1, out cancelID);
                    Thread.Sleep(500);
                }
                if (JXSStatus == 3)
                {
                    int idback = int.Parse(items2[2].ToString());
                    if (idback != 0)
                    {
                        Trace.WriteLine("轮胎放置完成！");
                        MyItem2[2].Write(0);//置零
                        time2.Stop();
                    }
                }
            }
            if (s6 == 3)
            {
                MyItem3 = new OPCItem[9];
                MyItem3[0] = KepItems3.AddItem("!UI4,PCR_LM3,Plc.PVL,Application.USERVARGLOBAL.JXSStatus", 1);
                MyItem3[1] = KepItems3.AddItem("!UI4,PCR_LM3,Plc.PVL,Application.USERVARGLOBAL.r_id", 2);
                MyItem3[2] = KepItems3.AddItem("!UI4,PCR_LM3,Plc.PVL,Application.USERVARGLOBAL.r_id_back", 3);
                MyItem3[3] = KepItems3.AddItem("!UI4,PCR_LM3,Plc.PVL,Application.USERVARGLOBAL.r_typeid", 4);
                MyItem3[4] = KepItems3.AddItem("!UI4,PCR_LM3,Plc.PVL,Application.USERVARGLOBAL.r_cpzik", 5);
                MyItem3[5] = KepItems3.AddItem("!UI4,PCR_LM3,Plc.PVL,Application.USERVARGLOBAL.r_cphigh", 6);
                MyItem3[6] = KepItems3.AddItem("!UI4,PCR_LM3,Plc.PVL,Application.USERVARGLOBAL.r_hang", 7);
                MyItem3[7] = KepItems3.AddItem("!UI4,PCR_LM3,Plc.PVL,Application.USERVARGLOBAL.r_lie", 8);
                MyItem3[8] = KepItems3.AddItem("!UI4,PCR_LM3,Plc.PVL,Application.USERVARGLOBAL.r_high", 9);
                double[] items3 = new double[10];
                items3[0] = 0;
                for (int i = 1; i < items3.Length; i++)
                    items3[i] = MyItem3[i - 1].Value;

                Array serverHandles = (Array)items3;
                Array Errors;
                int cancelID;
                int JXSStatus = Int32.Parse(items3[1].ToString()); //机械手状态
                //KepGroup.AsyncRead(9, ref serverHandles, out Errors, 1, out cancelID);


                //龙门未动作时
                if (JXSStatus == 1)
                {
                    int[] tmp = new int[] { 0, MyItem3[1].ServerHandle, MyItem3[4].ServerHandle, MyItem3[6].ServerHandle, MyItem3[7].ServerHandle, MyItem3[8].ServerHandle };
                    Array ServerHandles = (Array)tmp;
                    object[] valuetemp = new object[6] { "", s5, Bead, hang, lie, height };
                    Array values = (Array)valuetemp;
                    KepGroup.AsyncWrite(5, ref serverHandles, ref values, out Errors, 1, out cancelID);
                    Thread.Sleep(500);
                }
                if (JXSStatus == 3)
                {
                    int idback = int.Parse(items3[2].ToString());
                    if (idback != 0)
                    {
                        Trace.WriteLine("轮胎放置完成！");
                        MyItem3[2].Write(0);//置零
                        time2.Stop();
                    }
                }
            }*/
        }

        private void KepGroup_DataChange3(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            int JXSStatusBack = int.Parse(ItemValues.GetValue(1).ToString());
            if (JXSStatusBack == 2 || JXSStatusBack == 3)
            {
                Trace.WriteLine("龙门3接收到数据！");
            }
        }

        private void KepGroup_DataChange2(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            int idBack = int.Parse(ItemValues.GetValue(2).ToString());
            if (idBack != 0)
            {
                Trace.WriteLine("龙门接收到出库数据！");
                MyItem2[2].Write(0);
            }
            /*  int JXSStatusBack = int.Parse(ItemValues.GetValue(1).ToString());
              if (JXSStatusBack == 2 || JXSStatusBack == 3)
              {
                  Trace.WriteLine("龙门2接收到数据！");
              }*/
        }

        private void KepGroup_DataChange(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            int JXSStatusBack = int.Parse(ItemValues.GetValue(1).ToString());
            if (JXSStatusBack == 2 || JXSStatusBack == 3)
            {
                Trace.WriteLine("龙门1接收到数据！");
            }

        }

        #endregion
        #region 从三个缓存区出库
        public bool outhuancunquflag(int Bead, int minnumber, int a1, int a2, int a3, int a4)
        {
            KepGroup2 = KepGroups.Add("Group0");
            KepGroup2.UpdateRate = 250;
            KepGroup2.IsActive = true;
            KepGroup2.IsSubscribed = true;
            KepGroup2.DataChange += new DIOPCGroupEvent_DataChangeEventHandler(KepGroup_DataChange2);
            KepItems2 = KepGroup2.OPCItems;
            MyItem2 = new OPCItem[11];
            MyItem2[0] = KepItems2.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.JXSStatus", 1);
            MyItem2[1] = KepItems2.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.c_orderid", 2);
            MyItem2[2] = KepItems2.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.c_orderid_back", 3);
            MyItem2[3] = KepItems2.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.c_typeid", 4);
            MyItem2[4] = KepItems2.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.c_cpzik", 5);
            MyItem2[5] = KepItems2.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.c_cphigh", 6);
            MyItem2[6] = KepItems2.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.c_hang", 7);
            MyItem2[7] = KepItems2.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.c_lie", 8);
            MyItem2[8] = KepItems2.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.c_high", 9);
            MyItem2[9] = KepItems2.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.c_cpnum", 10);
            MyItem2[10] = KepItems2.AddItem("!UI4,PCR_LM2,Plc.PVL,Application.USERVARGLOBAL.isChuK_LK", 11);
            double[] items2 = new double[11];
            items2[0] = 0;
            for (int i = 1; i < items2.Length; i++)
                items2[i] = MyItem2[i - 1].Value;

            Array serverHandles = (Array)items2;
            Array Errors;
            int cancelID;
            int JXSStatus = Int32.Parse(items2[1].ToString()); //机械手状态
            int ischuk_lk = Int32.Parse(items2[10].ToString());//
            if (JXSStatus== 1 && ischuk_lk == 1)
            {
                int[] tmp = new int[] { 0, MyItem2[1].ServerHandle, MyItem2[3].ServerHandle, MyItem2[4].ServerHandle, MyItem2[5].ServerHandle, MyItem2[6].ServerHandle, MyItem2[7].ServerHandle , MyItem2[9].ServerHandle };
                Array ServerHandles = (Array)tmp;
               // object[] valuetemp = new object[8] { "", s5, Bead, hang, lie, height a1, a2};
               // Array values = (Array)valuetemp;
               // KepGroup.AsyncWrite(7, ref serverHandles, ref values, out Errors, 1, out cancelID);
                Thread.Sleep(500);
                //outhuancunqu1(Bead, minnumber, a1, a2, a3, a4);
                return true;
            }

            /* state3 = new Opc.Da.SubscriptionState();//组（订阅者）状态，相当于OPC规范中组的参数
             state3.Name = "group2";//组名
             state3.ServerHandle = null;//服务器给该组分配的句柄。
             state3.ClientHandle = Guid.NewGuid().ToString();//客户端给该组分配的句柄。
             state3.Active = true;//激活该组。
             state3.UpdateRate = 1000;//刷新频率为1秒。
             state3.Deadband = 0;// 死区值，设为0时，服务器端该组内任何数据变化都通知组。
             state3.Locale = null;//不设置地区值。
                                  //添加组
             subscription3 = (Opc.Da.Subscription)m_server.CreateSubscription(state3);//创建组
                                                                                      //定义Item列表                                                                         

             string[] itemName3 = {
             "gantry1.isRuk",
             "gantry1.JXSStatus",
             "gantry1.C_typeID",
             "gantry1.C_CpNoID",
             "gantry1.C_CpZik",
             "gantry1.C_CpHigh",
             "gantry1.C_Hang",
             "gantry1.C_Lie",
             "gantry1.C_High",
             "gantry1.C_CpNoID_back",
             "gantry1.C_CpNum",
             "gantry1.isChuk_LK",
             "gantry2.isRuk",
             "gantry2.JXSStatus",
             "gantry2.C_typeID",
             "gantry2.C_CpNoID",
             "gantry2.C_CpZik",
             "gantry2.C_CpHigh",
             "gantry2.C_Hang",
             "gantry2.C_Lie",
             "gantry2.C_High",
             "gantry2.C_CpNoID_back",
             "gantry2.C_CpNum",
             "gantry2.isChuk_LK",
             "gantry3.isRuk",
             "gantry3.JXSStatus",
             "gantry3" +
             ".C_typeID",
             "gantry3.C_CpNoID",
             "gantry3.C_CpZik",
             "gantry3.C_CpHigh",
             "gantry3.C_Hang",
             "gantry3.C_Lie",
             "gantry3.C_High",
             "gantry3.C_CpNoID_back",
             "gantry3.C_CpNum",
             "gantry3.isChuk_LK"
             };
             if (a4 == 1)
             {
                 ItemValueResult[] values = subscription3.Read(subscription3.Items);//获取组所有值
                 int JXSStatus = Int32.Parse(values[1].Value.ToString()); //机械手状态
                 int isChuK_LK = Int32.Parse(values[11].Value.ToString());//是否可以出库
                 if (JXSStatus == 1 && isChuK_LK == 1)
                 {
                     outhuancunqu1(Bead, minnumber, a1, a2, a3,a4);
                     return true;
                 }

                 return false;
             }
             if(a4 == 2)
             {
                 ItemValueResult[] values = subscription3.Read(subscription3.Items);//获取组所有值
                 int JXSStatus = Int32.Parse(values[13].Value.ToString()); //机械手状态
                 int isChuK_LK = Int32.Parse(values[23].Value.ToString());//是否可以出库
                 if (JXSStatus == 1 && isChuK_LK == 1)
                 {
                     outhuancunqu2(Bead, minnumber, a1, a2, a3,a4);
                     return true;
                 }

                 return false;
             }
             if (a4 == 3)
             {
                 ItemValueResult[] values = subscription3.Read(subscription3.Items);//获取组所有值
                 int JXSStatus = Int32.Parse(values[1].Value.ToString()); //机械手状态
                 int isChuK_LK = Int32.Parse(values[11].Value.ToString());//是否可以出库
                 if (JXSStatus == 1 && isChuK_LK == 1)
                 {
                     outhuancunqu3(Bead, minnumber, a1, a2, a3,a4);
                     return true;
                 }

                 return false;
             }*/
            return false;

        }

        private void outhuancunqu1(int Bead, int minnumber, int a1, int a2, int a3, int a4)//缓存区龙门执行出库动作
        {
            
            /* ItemValue[] itemvalues = new ItemValue[subscription3.Items.Length];//subscription.Items.Length
             for (int i = 0; i < subscription3.Items.Length; i++)
             { itemvalues[i] = new ItemValue(subscription3.Items[i]); }

             itemva
             lues[3].Value = a1;
             itemvalues[4].Value = Bead;
             itemvalues[6].Value = a2;
             itemvalues[7].Value = a3;
             itemvalues[10].Value = minnumber;
             subscription3.Write(itemvalues);
             Thread.Sleep(500);
             ItemValueResult[] values1 = subscription3.Read(subscription3.Items);//再次读取
             int BackStatus = Int32.Parse(values1[1].Value.ToString());//反馈机械手状态
             if (BackStatus == 2 || BackStatus == 3)
             {
                 Trace.WriteLine("龙门" + a4.ToString() + "接收到出库数据！");
             }
             time3.Elapsed += Time3_Elapsed;
             time3.Interval = 500;
             time3.Start();*/

        }

        private void Time3_Elapsed(object sender, ElapsedEventArgs e)//龙门反馈
        {
            /*ItemValueResult[] values = subscription3.Read(subscription3.Items);
            int BackStatus = Int32.Parse(values[1].Value.ToString());//反馈状态
            int C_OrderID_back = Int32.Parse(values[9].Value.ToString());
            if (BackStatus == 3 && C_OrderID_back != 0)
            {
                Trace.WriteLine("龙门1成功出库！");
                ItemValue[] values1 = new ItemValue[1];
                values1[0] = new ItemValue(subscription3.Items[9]);
                values1[0].Value = 0;//置0
                subscription3.Write(values1);
                time3.Stop();
            }*/

        }
        private void outhuancunqu2(int Bead, int minnumber, int a1, int a2, int a3, int a4)//缓存区龙门执行出库动作
        {
            /*
                        ItemValue[] itemvalues = new ItemValue[subscription3.Items.Length];//subscription.Items.Length
                        for (int i = 0; i < subscription3.Items.Length; i++)
                        { itemvalues[i] = new ItemValue(subscription3.Items[i]); }

                        itemvalues[15].Value = a1;
                        itemvalues[16].Value = Bead;
                        itemvalues[18].Value = a2;
                        itemvalues[19].Value = a3;
                        itemvalues[22].Value = minnumber;
                        subscription3.Write(itemvalues);
                        Thread.Sleep(500);
                        ItemValueResult[] values1 = subscription3.Read(subscription3.Items);//再次读取
                        int BackStatus = Int32.Parse(values1[13].Value.ToString());//反馈机械手状态
                        if (BackStatus == 2 || BackStatus == 3)
                        {
                            Trace.WriteLine("龙门" + a4.ToString() + "接收到出库数据！");
                        }
                        time4.Elapsed += Time4_Elapsed;
                        time4.Interval = 500;
                        time4.Start();*/

        }

        private void Time4_Elapsed(object sender, ElapsedEventArgs e)//龙门反馈
        {
            /*ItemValueResult[] values = subscription3.Read(subscription3.Items);
            int BackStatus = Int32.Parse(values[13].Value.ToString());//反馈机械手状态
            int C_OrderID_back = Int32.Parse(values[21].Value.ToString());
            if (BackStatus == 3 && C_OrderID_back != 0)
            {
                Trace.WriteLine("龙门1成功出库！");
                ItemValue[] values1 = new ItemValue[1];
                values1[0] = new ItemValue(subscription3.Items[21]);
                values1[0].Value = 0;//置0
                subscription3.Write(values1);
                time3.Stop();
            }*/

        }
        private void outhuancunqu3(int Bead, int minnumber, int a1, int a2, int a3, int a4)//缓存区龙门执行出库动作
        {

            /*  ItemValue[] itemvalues = new ItemValue[subscription3.Items.Length];//subscription.Items.Length
              for (int i = 0; i < subscription3.Items.Length; i++)
              { itemvalues[i] = new ItemValue(subscription3.Items[i]); }

              itemvalues[27].Value = a1;
              itemvalues[28].Value = Bead;
              itemvalues[30].Value = a2;
              itemvalues[31].Value = a3;
              itemvalues[34].Value = minnumber;
              subscription3.Write(itemvalues);
              Thread.Sleep(500);
              ItemValueResult[] values1 = subscription3.Read(subscription3.Items);//再次读取
              int BackStatus = Int32.Parse(values1[25].Value.ToString());//反馈机械手状态
              if (BackStatus == 2 || BackStatus == 3)
              {
                  Trace.WriteLine("龙门" + a4.ToString() + "接收到出库数据！");
              }
              time5.Elapsed += Time5_Elapsed;
              time5.Interval = 500;
              time5.Start();*/

        }

        private void Time5_Elapsed(object sender, ElapsedEventArgs e)//龙门反馈
        {
            /* ItemValueResult[] values = subscription3.Read(subscription3.Items);
             int BackStatus = Int32.Parse(values[25].Value.ToString());//反馈状态
             int C_OrderID_back = Int32.Parse(values[33].Value.ToString());
             if (BackStatus == 3 && C_OrderID_back != 0)
             {
                 Trace.WriteLine("龙门1成功出库！");
                 ItemValue[] values1 = new ItemValue[1];
                 values1[0] = new ItemValue(subscription3.Items[33]);
                 values1[0].Value = 0;//置0
                 subscription3.Write(values1);
                 time3.Stop();
             }*/

        }

        #endregion

        #region 龙门抓取轮胎进暂存区
        public void SetMove1(int flag, int a1, int a2, int a3, int a4, int a5, int a6)
        {
            /* time.Elapsed += new ElapsedEventHandler((s, e) => time_Elapsed(s, e,flag, a1, a2, a3, a4, a5, a6));
             time.Interval = 1000;
             time.Start();
         }
         private void time_Elapsed (object sender , ElapsedEventArgs e, int flag,int a1, int a2, int a3, int a4, int a5, int a6)
         {

             state2 = new Opc.Da.SubscriptionState();//组（订阅者）状态，相当于OPC规范中组的参数
             state2.Name = "group1";//组名
             state2.ServerHandle = null;//服务器给该组分配的句柄。
             state2.ClientHandle = Guid.NewGuid().ToString();//客户端给该组分配的句柄。
             state2.Active = true;//激活该组。
             state2.UpdateRate = 1000;//刷新频率为1秒。
             state2.Deadband = 0;// 死区值，设为0时，服务器端该组内任何数据变化都通知组。
             state2.Locale = null;//不设置地区值。
                                  //添加组
             subscription2 = (Opc.Da.Subscription)m_server.CreateSubscription(state2);//创建组
             string[] itemName2 = {
             "gantry4.isRuk",
             "gantry4.JXSStatus",
             "gantry4.R_typeID",
             "gantry4.R_CpNoID",
             "gantry4.R_CpZik",
             "gantry4.R_CpHigh",
             "gantry4.R_Hang",
             "gantry4.R_Lie",
             "gantry4.R_High",
             "gantry4.R_CpNoID_back",
             "gantry5.isRuk",
             "gantry5.JXSStatus",
             "gantry5.R_typeID",
             "gantry5.R_CpNoID",
             "gantry5.R_CpZik",
             "gantry5.R_CpHigh",
             "gantry5.R_Hang",
             "gantry5.R_Lie",
             "gantry5.R_High",
             "gantry5.R_CpNoID_back"};

             //定义item列表
             Item[] items2 = new Item[20];//定义数据项，即item
             int i;
             for (i = 0; i < items2.Length; i++)//item初始化赋值
             {
                 items2[i] = new Item();//创建一个项Item对象。
                 items2[i].ClientHandle = Guid.NewGuid().ToString();//客户端给该数据项分配的句柄。
                 items2[i].ItemPath = null; //该数据项在服务器中的路径。
                 items2[i].ItemName = itemName2[i]; //该数据项在服务器中的名字。
             }
             //添加Item
             subscription2.AddItems(items2);



             if (flag == 4)
             {
                 ItemValueResult[] values2 = subscription2.Read(subscription2.Items);
                 int JXSStatus = Int32.Parse(values2[1].Value.ToString()); //机械手状态

                 //龙门未动作时
                 if (JXSStatus == 1)
                 {
                     ItemValue[] itemvalues2 = new ItemValue[subscription2.Items.Length];//subscription.Items.Length
                     for (i = 0; i < subscription2.Items.Length; i++)
                     {

                         itemvalues2[i] = new ItemValue(subscription2.Items[i]);
                     }

                     itemvalues2[3].Value = a1;
                     itemvalues2[4].Value = a2;
                     itemvalues2[5].Value = a3;
                     itemvalues2[6].Value = a4;
                     itemvalues2[7].Value = a5;
                     itemvalues2[8].Value = a6;
                     subscription1.Write(itemvalues2);
                     Thread.Sleep(500);
                     ItemValueResult[] values0 = subscription2.Read(subscription2.Items);//再次读取
                     int BackStatus = Int32.Parse(values0[1].Value.ToString());//反馈机械手状态
                     if (BackStatus == 2 || BackStatus == 3)
                     {
                         Trace.WriteLine("龙门" + flag.ToString() + "接收到数据！");
                     }
                 }
                 if (JXSStatus == 3)
                 {
                     ItemValueResult[] values0 = subscription2.Read(subscription2.Items);
                     int idback = Int32.Parse(values0[9].Value.ToString()); //反馈机械手指令
                     if (idback != 0)
                     {
                         Trace.WriteLine("轮胎放置完成！");
                         ItemValue[] value1 = new ItemValue[1];
                         value1[0] = new ItemValue(subscription2.Items[9]);
                         value1[0].Value = 0;//置0
                         subscription2.Write(value1);
                         time2.Stop();
                     }
                 }
             }

                 if (flag == 5)
                 {
                 ItemValueResult[] values2 = subscription2.Read(subscription2.Items);
                 int JXSStatus = Int32.Parse(values2[1].Value.ToString()); //机械手状态

                 //龙门未动作时
                 if (JXSStatus == 1)
         {
                     ItemValue[] itemvalues2 = new ItemValue[subscription2.Items.Length];//subscription.Items.Length
                     for (i = 0; i < subscription2.Items.Length; i++)
                     { itemvalues2[i] = new ItemValue(subscription2.Items[i]); }

                     itemvalues2[3].Value = a1;
                     itemvalues2[4].Value = a2;
                     itemvalues2[5].Value = a3;
                     itemvalues2[6].Value = a4;
                     itemvalues2[7].Value = a5;
                     itemvalues2[8].Value = a6;
                     subscription1.Write(itemvalues2);
                     Thread.Sleep(500);
                     ItemValueResult[] values0 = subscription2.Read(subscription2.Items);//再次读取
                     int BackStatus = Int32.Parse(values0[1].Value.ToString());//反馈机械手状态
                     if (BackStatus == 2 || BackStatus == 3)
                     {
                         Trace.WriteLine("龙门" + flag.ToString() + "接收到数据！");
                     }
                 }
                 if (JXSStatus == 3)
                 {
                     ItemValueResult[] values0 = subscription2.Read(subscription2.Items);
                     int idback = Int32.Parse(values0[9].Value.ToString()); //反馈机械手指令
                     if (idback != 0)
                     {
                         Trace.WriteLine("轮胎放置完成！");
                         ItemValue[] value1 = new ItemValue[1];
                         value1[0] = new ItemValue(subscription2.Items[9]);
                         value1[0].Value = 0;//置0
                         subscription2.Write(value1);
                         time2.Stop();
                     }
                 }
         }*/

        }
        #endregion
        #region 从暂存区出库
        public bool outzancunquflag(int Bead, int minnumber, int a1, int a2, int a3, int a4)
        {
            /*  state4 = new Opc.Da.SubscriptionState();//组（订阅者）状态，相当于OPC规范中组的参数
              state4.Name = "group3";//组名
              state4.ServerHandle = null;//服务器给该组分配的句柄。
              state4.ClientHandle = Guid.NewGuid().ToString();//客户端给该组分配的句柄。
              state4.Active = true;//激活该组。
              state4.UpdateRate = 1000;//刷新频率为1秒。
              state4.Deadband = 0;// 死区值，设为0时，服务器端该组内任何数据变化都通知组。
              state4.Locale = null;//不设置地区值。
                                   //添加组
              subscription4 = (Opc.Da.Subscription)m_server.CreateSubscription(state4);//创建组
                                                                                       //定义Item列表                                                                         

              string[] itemName4 = {
              "gantry4.isRuk",
              "gantry4.JXSStatus",
              "gantry4.C_typeID",
              "gantry4.C_CpNoID",
              "gantry4.C_CpZik",
              "gantry4.C_CpHigh",
              "gantry4.C_Hang",
              "gantry4.C_Lie",
              "gantry4.C_High",
              "gantry4.C_CpNoID_back",
              "gantry4.C_CpNum",
              "gantry4.isChuk_LK",
              "gantry5.isRuk",
              "gantry5.JXSStatus",
              "gantry5.C_typeID",
              "gantry5.C_CpNoID",
              "gantry5.C_CpZik",
              "gantry5.C_CpHigh",
              "gantry5.C_Hang",
              "gantry5.C_Lie",
              "gantry5.C_High",
              "gantry5.C_CpNoID_back",
              "gantry5.C_CpNum",
              "gantry5.isChuk_LK" 
              };
              if (a4 == 4)
              {
                  ItemValueResult[] values = subscription4.Read(subscription4.Items);//获取组所有值
                  int JXSStatus = Int32.Parse(values[1].Value.ToString()); //机械手状态
                  int isChuK_LK = Int32.Parse(values[11].Value.ToString());//是否可以出库
                  if (JXSStatus == 1 && isChuK_LK == 1)
                  {
                      outzancunqu1(Bead, minnumber, a1, a2, a3, a4);
                      return true;
                  }
                  return false;
              }
              if (a4 == 5)
              {
                  ItemValueResult[] values = subscription4.Read(subscription4.Items);//获取组所有值
                  int JXSStatus = Int32.Parse(values[13].Value.ToString()); //机械手状态
                  int isChuK_LK = Int32.Parse(values[23].Value.ToString());//是否可以出库
                  if (JXSStatus == 1 && isChuK_LK == 1)
                  {
                      outzancunqu2(Bead, minnumber, a1, a2, a3, a4);
                      return true;
                  }
                  return false;
              }*/
            return false;
        }

        private void outzancunqu1(int Bead, int minnumber, int a1, int a2, int a3, int a4)//龙门执行出库动作
        {

            /* ItemValue[] itemvalues = new ItemValue[subscription4.Items.Length];//subscription.Items.Length
             for (int i = 0; i < subscription4.Items.Length; i++)
             { itemvalues[i] = new ItemValue(subscription4.Items[i]); }

             itemvalues[3].Value = a1;
             itemvalues[4].Value = Bead;
             itemvalues[6].Value = a2;
             itemvalues[7].Value = a3;
             itemvalues[10].Value = minnumber;
             subscription4.Write(itemvalues);
             Thread.Sleep(500);
             ItemValueResult[] values1 = subscription4.Read(subscription4.Items);//再次读取
             int BackStatus = Int32.Parse(values1[1].Value.ToString());//反馈机械手状态
             if (BackStatus == 2 || BackStatus == 3)
             {
                 Trace.WriteLine("龙门" + a4.ToString() + "接收到出库数据！");
             }
             time0.Elapsed += Time0_Elapsed;
             time0.Interval = 500;
             time0.Start();*/

        }

        private void Time0_Elapsed(object sender, ElapsedEventArgs e)//龙门反馈
        {
            /* ItemValueResult[] values = subscription4.Read(subscription4.Items);
             int BackStatus = Int32.Parse(values[1].Value.ToString());//反馈id
             int C_OrderID_back = Int32.Parse(values[10].Value.ToString());
             if (BackStatus == 3&& C_OrderID_back != 0)
             {
                 Trace.WriteLine("成功出库！");
                 ItemValue[] values1 = new ItemValue[1];
                 values1[0] = new ItemValue(subscription4.Items[10]);
                 values1[0].Value = 0;//置0
                 subscription4.Write(values1);
                 time1.Stop();
             }*/

        }
        private void outzancunqu2(int Bead, int minnumber, int a1, int a2, int a3, int a4)//龙门执行出库动作
        {

            /*  ItemValue[] itemvalues = new ItemValue[subscription4.Items.Length];//subscription.Items.Length
               for (int i = 0; i < subscription4.Items.Length; i++)
               { itemvalues[i] = new ItemValue(subscription4.Items[i]); }

               itemvalues[15].Value = a1;
               itemvalues[16].Value = Bead;
               itemvalues[18].Value = a2;
               itemvalues[19].Value = a3;
               itemvalues[22].Value = minnumber;
               subscription4.Write(itemvalues);
               Thread.Sleep(500);
               ItemValueResult[] values1 = subscription4.Read(subscription4.Items);//再次读取
               int BackStatus = Int32.Parse(values1[13].Value.ToString());//反馈机械手状态
               if (BackStatus == 2 || BackStatus == 3)
               {
                   Trace.WriteLine("龙门" + a4.ToString() + "接收到出库数据！");
               }
               time1.Elapsed += Time1_Elapsed;
               time1.Interval = 500;
               time1.Start();*/

        }

        private void Time1_Elapsed(object sender, ElapsedEventArgs e)//龙门反馈
        {
            /* ItemValueResult[] values = subscription4.Read(subscription4.Items);
             int BackStatus = Int32.Parse(values[13].Value.ToString());//反馈id
             int C_OrderID_back = Int32.Parse(values[22].Value.ToString());
             if (BackStatus == 3 && C_OrderID_back != 0)
             {
                 Trace.WriteLine("成功出库！");
                 ItemValue[] values1 = new ItemValue[1];
                 values1[0] = new ItemValue(subscription4.Items[22]);
                 values1[0].Value = 0;//置0
                 subscription4.Write(values1);
                 time1.Stop();
             }

         }*/
        }
        #endregion
        /* private void setgroup()
{
    //设定组状态
    state = new Opc.Da.SubscriptionState();//组（订阅者）状态，相当于OPC规范中组的参数
    state.Name = "group0";//组名
    state.ServerHandle = null;//服务器给该组分配的句柄。
    state.ClientHandle = Guid.NewGuid().ToString();//客户端给该组分配的句柄。
    state.Active = true;//激活该组。
    state.UpdateRate = 100;//刷新频率为1秒。
    state.Deadband = 0;// 死区值，设为0时，服务器端该组内任何数据变化都通知组。
    state.Locale = null;//不设置地区值。
                        //添加组
    subscription = (Opc.Da.Subscription)m_server.CreateSubscription(state);//创建组
                                                                           //定义Item列表                                                                         
    string[] itemName = new string[19];
    itemName[0] = "Bucket Brigade.isRuk";//是否可以入库，0可以，1不可以
    itemName[1] = "Bucket Brigade.JXSStatus";//机械手状态 0待机 1入库状态 2出库状态 3报警
    itemName[2] = "Bucket Brigade.R_typeID";//指令码 1入库 3出库 
    itemName[3] = "Bucket Brigade.R_CpNoID";//条码代号
    itemName[4] = "Bucket Brigade.R_CpZik";//子口
    itemName[5] = "Bucket Brigade.R_CpHigh";//单个轮胎高度
    itemName[6] = "Bucket Brigade.R_Hang";//库区第几行
    itemName[7] = "Bucket Brigade.R_Lie";//库区第几列
    itemName[8] = "Bucket Brigade.R_High";//库位高度
    itemName[9] = "Bucket Brigade.R_CpNoID_back";//入库指令反馈
    itemName[10] = "Bucket Brigade.C_typeID";//指令码 1 入库 3 出库
    itemName[11] = "Bucket Brigade.C_OrderID";//出库任务代号
    itemName[12] = "Bucket Brigade.C_CpZik";//子口
    itemName[13] = "Bucket Brigade.C_CpHigh";//单个轮胎高度
    itemName[14] = "Bucket Brigade.C_CpNum";//轮胎数量
    itemName[15] = "Bucket Brigade.C_Hang";//库区第几行
    itemName[16] = "Bucket Brigade.C_Lie";//库区第几列
    itemName[17] = "Bucket Brigade.C_High";//库位高度
    itemName[18] = "Bucket Brigade.C_OrderID_back";//出库指令反馈
                                                   //定义item列表
    Item[] items = new Item[19];//定义数据项，即item
    //添加Item
    subscription.AddItems(items);



}*/
        // public abstract int ReadRunningStatus()
    }
}



