using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doublestartyre.hardware
{
    class lineDevice : DeviceBase
    {
        private string lineError;

        public lineDevice(String hostAdress,
            String name = utils.PlcUtils.mNameProLine,
            int cpuType = utils.PlcUtils.mCpuTypeProLine,
            int protocolType = utils.PlcUtils.mProtocolType,
            int unitType = utils.PlcUtils.mUnitTypeProLine)
            : base(hostAdress, name, cpuType, protocolType, unitType)
        {
        }
        public delegate void lineEventHandler(string qrcode);
        public event lineEventHandler LineEvent;
        public override string ReadErrorInfo()
        {

            string errText = "";
            string[] errorText = new string[32];
            #region 报警信息列表

            errorText[0] = "";
            errorText[1] = "";
            errorText[2] = "";
            errorText[3] = "";
            errorText[4] = "";
            errorText[5] = "";
            errorText[6] = "";
            errorText[7] = "";
            errorText[8] = "";
            errorText[9] = "";
            errorText[10] = "";
            errorText[11] = "";
            errorText[12] = "";
            errorText[13] = "";
            errorText[14] = "";
            errorText[15] = "";
            errorText[16] = "";
            errorText[17] = "";
            errorText[18] = "";
            errorText[19] = "";
            errorText[20] = "";
            errorText[21] = "";
            errorText[22] = "";
            errorText[23] = "";
            errorText[24] = "";
            errorText[25] = "";
            errorText[26] = "";
            errorText[27] = "";
            errorText[28] = "";
            errorText[29] = "";
            errorText[30] = "";
            errorText[31] = "";

            #endregion
            short[] readPlc2 = new short[9];
            if (ReadDeviceBlock2("D1420", 9, out readPlc2[0]) == 0)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (readPlc2[j] != 0)
                    {
                        errText = "线体报警！";
                        break;
                    }
                }
                return errText;
            }
            else
            {
                SetCommunicationError(GetDeviceName() + "called ReadErrorInfo()");
                for (int i = 0; i < 32; i++)
                {
                    errorText[i] = "";
                }
                return lineError;
            }
        }

        /* public override int ReadRunningStatus()
         {
             throw new NotImplementedException();
         }*/
        #region 扫描失败
            public void fail()
        {
            ushort[] readByte = new ushort[2];
            readByte[0] = 5;
            readByte[1] = 1;
            short[] checkplc = new short[1];
            int i;
            for (i = 0; i < 5; i++)
            {
                if (WriteDeviceBlock2("D1102", 2, ref readByte[0]) == 0)
                {
                    Trace.WriteLine("传入扫描失败线体成功！");
                    System.Threading.Thread.Sleep(100);
                    ReadDeviceBlock2("D1103", 1, out checkplc[0]);
                    if (checkplc[0] == 0)
                    {
                        Trace.WriteLine("扫描失败线体接受到信息！");
                        break;
                    }
                }
            }
            if (i > 5)
            
            {
                Trace.WriteLine("扫描失败线体未接受到信息！");
                //return false;
            }

        }
        #endregion
        #region 剃毛分线
        public bool SetMove1(int s1, ushort s2)
        {
            ushort h_s1 = (ushort)((s1 & 0xffff0000) >> 16);
            ushort l_s1 = (ushort)(s1 & 0xffff);
            ushort[] readByte = new ushort[4];
            readByte[0] = h_s1;
            readByte[1] = l_s1;
            readByte[2] = s2;
            readByte[3] = 1;
            short[] checkplc = new short[1];
            int i;
            for (i = 0; i < 5; i++)
            {
                if (WriteDeviceBlock2("D1000", 4, ref readByte[0]) == 0)
                {
                    Trace.WriteLine("传入线体1成功！");
                    System.Threading.Thread.Sleep(100);
                    ReadDeviceBlock2("D1003", 1, out checkplc[0]);
                    if (checkplc[0] == 0)
                    {
                        Trace.WriteLine("线体1接受到信息！");
                        break;
                    }
                }
            }
            if (i < 5)
            {
                return true;

            }
            else
            {
                Trace.WriteLine("线体1未接受到信息！");
                return false;
            }
        }

        #endregion
        #region 动均前分线
        public bool SetMove2(int s1, ushort s2)
        {
            ushort h_s1 = (ushort)((s1 & 0xffff0000) >> 16);
            ushort l_s1 = (ushort)(s1 & 0xffff);
            ushort[] readByte = new ushort[3];
            readByte[0] = h_s1;
            readByte[1] = l_s1;
            readByte[2] = s2;
            readByte[3] = 1;
            short[] checkplc = new short[1];
            int i;
            for (i = 0; i < 5; i++)
            {
                if (WriteDeviceBlock2("D1100", 4, ref readByte[0]) == 0)
                {
                    Trace.WriteLine("传入线体2成功！");
                    System.Threading.Thread.Sleep(100);
                    ReadDeviceBlock2("D1103", 1, out checkplc[0]);
                    if (checkplc[0] == 0)
                    {
                        Trace.WriteLine("线体2接受到信息！");
                        break;
                    }
                }
            }
            if (i < 5)
            {
                return true;

            }
            else
            {
                return false;
            }




        }
        #endregion

        #region 动均后分线
        public bool SetMove3(int s1, ushort s2)
        {
            ushort h_s1 = (ushort)((s1 & 0xffff0000) >> 16);
            ushort l_s1 = (ushort)(s1 & 0xffff);
            ushort[] readByte = new ushort[3];
            readByte[0] = h_s1;
            readByte[1] = l_s1;
            readByte[2] = s2;
            readByte[3] = 1;
            short[] checkplc = new short[1];
            int i;
            for (i = 0; i < 5; i++) {
                if (WriteDeviceBlock2("D1200", 4, ref readByte[0]) == 0)
                {
                    Trace.WriteLine("传入线体3成功！");
                    System.Threading.Thread.Sleep(100);
                    ReadDeviceBlock2("D1203", 1, out checkplc[0]);
                    if (checkplc[0] == 0)
                    {
                        Trace.WriteLine("线体3接受到信息！");
                        break;
                    }
                }
            }
            if (i < 5)
            {
                return true;

            }
            else
            {
                return false;
            }




        }
        #endregion
#region 剃毛反馈信息
        public bool shavingback(out int s5)
        {
            
            short[] shavingback = new short[4];
            shavingback[2] = shavingback[3] = 0;
            if (ReadDeviceBlock2("D1300", 2, out shavingback[0]) == 0)
            {
                if(shavingback[0] !=0 && shavingback[1] !=0)
                {
                    int backs0 = shavingback[0] * 65536 + shavingback[1];
                    s5 = backs0;
                    WriteDeviceBlock2("D1300", 2, ref shavingback[2]);
                    return true;
                }
                else
                {
                    s5 = 0;
                    return false;
                }
            }
            else
            {
                s5 = 0;
                return false;
            }
        
        }
        #endregion
        #region 动均前线体反馈信息
        public bool linefeedback(out int s5,int s6)
        {
            short[] linefeedback = new short[4];
            linefeedback[2] = linefeedback[3] = 0;
            if (ReadDeviceBlock2("D1322", 2, out linefeedback[0]) == 0)
            {
                if (linefeedback[0] != 0 && linefeedback[1] != 0)
                {
                    int backs0 = linefeedback[0] * 65536 + linefeedback[1];
                    s5 = backs0;
                    s6 = 1;
                    
                    WriteDeviceBlock2("D1322", 2, ref linefeedback[2]);
                    return true;
                }


            }
            if(ReadDeviceBlock2("D1342", 2, out linefeedback[0]) == 0)
            {
                if (linefeedback[0] != 0 && linefeedback[1] != 0)
                {
                    int backs0 = linefeedback[0] * 65536 + linefeedback[1];
                    s5 = backs0;
                    s6 = 2;                    
                    WriteDeviceBlock2("D1342", 2, ref linefeedback[2]);
                    return true;
                }
            }
            if(ReadDeviceBlock2("D1362", 2, out linefeedback[0]) == 0)
            {
                if (linefeedback[0] != 0 && linefeedback[1] != 0)
                {
                    int backs0 = linefeedback[0] * 65536 + linefeedback[1];
                    s5 = backs0;
                    s6 = 3;
                    WriteDeviceBlock2("D1362", 2, ref linefeedback[2]);
                    return true;
                }
            }
            s5 = 0;
            s6 = 0;
            return false;
        }
        #endregion
        #region 动均后分线反馈
        public bool laterlineback(out int s5,int s6,int GantryID)
        {
            
            short[] laterlineback = new short[4];
            laterlineback[2] = laterlineback[3] = 0;
            if (ReadDeviceBlock2("D1382", 2, out laterlineback[0]) == 0)
            {
                if (laterlineback[0] != 0 && laterlineback[1] != 0)
                {
                    int backs0 = laterlineback[0] * 65536 + laterlineback[1];
                    s5 = backs0;
                    s6 = 1;
                    GantryID = 4;
                    WriteDeviceBlock2("D1382", 2, ref laterlineback[2]);
                    return true;
                }
            }
            if (ReadDeviceBlock2("D1402", 2, out laterlineback[0]) == 0)
            {
                if (laterlineback[0] != 0 && laterlineback[1] != 0)
                {
                    int backs0 = laterlineback[0] * 65536 + laterlineback[1];
                    s5 = backs0;
                    s6 = 2;
                    GantryID = 5;
                    WriteDeviceBlock2("D1402", 2, ref laterlineback[2]);
                    return true;
                }
            }
            s5 = 0;
            s6 = 0;
            GantryID = 0;
            return false;
        }
        #endregion


        private int WriteDeviceBlock2(string v1, int v2, ref ushort v3)
        {
            throw new NotImplementedException();
        }
    }
}
