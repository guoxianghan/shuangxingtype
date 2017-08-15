using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Opc;
using OpcCom;
using Opc.Da;

namespace doublestartyre.hardware
{
    class rextoth
    {
        public Opc.Da.Server opcServer = null;
        public string[] writeOpcItem = new string[15];
        public string[] readOpcItem = new string[15];
        public rextoth()
        {
            setStringValue();
            if (opcServer == null)
                opcServer = GetOpcServer();
        }
        #region 设置opc通讯中的变量值
        private void setStringValue()
        {
            writeOpcItem[0] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_FrWCS_01";
            writeOpcItem[1] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_FrWCS_02";
            writeOpcItem[2] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_FrWCS_03";
            writeOpcItem[3] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_FrWCS_04";
            writeOpcItem[4] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_FrWCS_05";
            writeOpcItem[5] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_FrWCS_06";
            writeOpcItem[6] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_FrWCS_07";
            writeOpcItem[7] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_FrWCS_08";
            writeOpcItem[8] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_FrWCS_09";
            writeOpcItem[9] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_FrWCS_10";
            writeOpcItem[10] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_FrWCS_11";
            writeOpcItem[11] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_FrWCS_12";
            writeOpcItem[12] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_FrWCS_13";
            writeOpcItem[13] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_FrWCS_14";
            writeOpcItem[14] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_FrWCS_15";

            readOpcItem[0] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_ToWCS_01";
            readOpcItem[1] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_ToWCS_02";
            readOpcItem[2] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_ToWCS_03";
            readOpcItem[3] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_ToWCS_04";
            readOpcItem[4] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_ToWCS_05";
            readOpcItem[5] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_ToWCS_06";
            readOpcItem[6] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_ToWCS_07";
            readOpcItem[7] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_ToWCS_08";
            readOpcItem[8] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_ToWCS_09";
            readOpcItem[9] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_ToWCS_10";
            readOpcItem[10] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_ToWCS_11";
            readOpcItem[11] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_ToWCS_12";
            readOpcItem[12] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_ToWCS_13";
            readOpcItem[13] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_ToWCS_14";
            readOpcItem[14] = "!R4,HMS01.1,Plc.PVL,.rCommdCord_ToWCS_15";

        }

        #endregion


        /// <summary>
        /// 获取OpcServer
        /// </summary>
        /// <returns></returns>
        private Opc.Da.Server GetOpcServer()
        {
            try
            {
                //"OPC.IwSCP/{108fb1cf-f509-4d86-b1da-54bf1dd67a8d}"
                IDiscovery opcDiscovery = new ServerEnumerator();
                Opc.Server[] opcServers = opcDiscovery.GetAvailableServers(Specification.COM_DA_20);
                return new Opc.Da.Server(new OpcCom.Factory(), new Opc.URL(Opc.UrlScheme.DA + "://localhost/" + opcServers[0].Url.Path));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 打开OPC
        /// </summary>
        public void Open()
        {
            try
            {
                opcServer.Connect();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 创建组
        /// </summary>
        /// <param name="_subscriptionname"></param>
        public void CreateMySubscription(string _subscriptionname)
        {
            Opc.Da.SubscriptionState subScriptionState = new Opc.Da.SubscriptionState();
            subScriptionState.Active = true;    // activate cyclic communication
            subScriptionState.ClientHandle = System.Guid.NewGuid().ToString();
            subScriptionState.Deadband = 0.0F;
            subScriptionState.Name = _subscriptionname;
            subScriptionState.UpdateRate = 1000;
            opcServer.CreateSubscription(subScriptionState);
        }

        /// <summary>
        /// 增加变量
        /// </summary>
        public void addItems()
        {
            Opc.Da.Item[] opcItem = new Opc.Da.Item[1];
            opcItem[0] = new Opc.Da.Item();
            opcItem[0].ClientHandle = 0;
            opcItem[0].Active = true;
            opcItem[0].ActiveSpecified = true;
            opcItem[0].ItemName = writeOpcItem[0];
            opcItem[0].ItemPath = "";
            opcItem[0].MaxAge = -1;

            opcServer.Subscriptions[0].AddItems(opcItem);//第一组为是否运行写

            Opc.Da.Item[] opcItems = new Opc.Da.Item[15];
            for (Int32 index = 0; index < 15; index++)
            {
                // Step: 9.1
                //
                // creating new item
                opcItems[index] = new Opc.Da.Item();
                // set item properties
                opcItems[index].ClientHandle = index;
                opcItems[index].Active = true;
                opcItems[index].ActiveSpecified = true;
                opcItems[index].ItemName = writeOpcItem[index];
                opcItems[index].ItemPath = "";
                opcItems[index].MaxAge = -1;
                //opcItems[index].MaxAgeSpecified = false;	// read from device
                opcItems[index].MaxAgeSpecified = true;     // read from cache
            }
            opcServer.Subscriptions[1].AddItems(opcItems);//第二组为写入组

            opcItems = new Opc.Da.Item[15];
            for (Int32 index = 0; index < 15; index++)
            {
                // Step: 9.1
                //
                // creating new item
                opcItems[index] = new Opc.Da.Item();
                // set item properties
                opcItems[index].ClientHandle = index;
                opcItems[index].Active = true;
                opcItems[index].ActiveSpecified = true;
                opcItems[index].ItemName = readOpcItem[index];
                opcItems[index].ItemPath = "";
                opcItems[index].MaxAge = -1;
                //opcItems[index].MaxAgeSpecified = false;	// read from device
                opcItems[index].MaxAgeSpecified = true;     // read from cache
            }

            opcServer.Subscriptions[2].AddItems(opcItems); ///第三组为读取反馈组
        }

        /// <summary>
        /// 指定组别，添加变量
        /// </summary>
        /// <param name="itemNames"></param>
        /// <param name="index"></param>
        public void addItems(string[] itemNames, int index)
        {
            Opc.Da.Item[] opcItems = new Opc.Da.Item[itemNames.Length];
            for (Int32 i = 15; i < itemNames.Length; i++)
            {
                // Step: 9.1
                //
                // creating new item
                opcItems[i] = new Opc.Da.Item();
                // set item properties
                opcItems[i].ClientHandle = index;
                opcItems[i].Active = true;
                opcItems[i].ActiveSpecified = true;
                opcItems[i].ItemName = itemNames[i];
                opcItems[i].ItemPath = "";
                opcItems[i].MaxAge = -1;
                //opcItems[index].MaxAgeSpecified = false;	// read from device
                opcItems[i].MaxAgeSpecified = true;     // read from cache
            }

            Opc.Da.ItemResult[] itemResults = opcServer.Subscriptions[index].AddItems(opcItems);
        }


        /// <summary>
        /// 读取指定组别内的数据
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string[] readOpc(int index)
        {
            Opc.Da.ItemValueResult[] opcValueResults = opcServer.Subscriptions[index].Read(opcServer.Subscriptions[index].Items);
            string[] myResult = new string[opcValueResults.Length];
            for (int i = 0; i < myResult.Length; i++)
            {
                myResult[i] = opcValueResults[i].Value.ToString();
            }
            return myResult;
        }


        /// <summary>
        /// 向指定单个变量写入值
        /// </summary>
        /// <param name="index"></param>
        /// <param name="itemName"></param>
        /// <param name="value"></param>
        public void writeOpc(int index, string itemName, string value)
        {
            Opc.Da.ItemValue[] opcItemValues = new Opc.Da.ItemValue[1];
            foreach (Opc.Da.Item opcItem in opcServer.Subscriptions[index].Items)
            {
                if (opcItem.ItemName.Equals(itemName))
                {
                    opcItemValues[0] = new Opc.Da.ItemValue(opcItem);
                    break;
                }
            }
            if (opcItemValues == null)
            {
                return;
            }
            opcItemValues[0].Value = value;

            opcServer.Write(opcItemValues);

        }
        /// <summary>
        /// 写入整组的数据
        /// </summary>
        /// <param name="index"></param>
        /// <param name="itemNames"></param>
        /// <param name="values"></param>
        public void writeOpc(int index, string[] itemNames, string[] values)
        {
            if (itemNames.Length != values.Length)
            {
                throw new Exception("变量数组和赋值数组必须长度相同");
            }
            Opc.Da.ItemValue[] opcItemValues = new Opc.Da.ItemValue[itemNames.Length];
            int m = 0;
            foreach (Opc.Da.Item opcItem in opcServer.Subscriptions[index].Items)
            {
                for (int i = 0; i < itemNames.Length; i++)
                {
                    if (opcItem.ItemName.Equals(itemNames[i]))
                    {
                        opcItemValues[m] = new Opc.Da.ItemValue(opcItem);
                        opcItemValues[m].Value = values[i];
                        m++;
                        break;
                    }
                }
            }
            if (opcItemValues == null)
            {
                throw new Exception("该组中没有相应的变量！");
            }

            opcServer.Write(opcItemValues);

        }


        public bool isWriteOk()
        {
            string[] myValue = readOpc(0);
            int k;
            if (int.TryParse(myValue[0], out k))
            {
                if (k == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new Exception("读取是否上位机可写时通讯失败！");
            }
        }
        public void setMove(double[] moveValue)
        {
            if (moveValue.Length != 15)
            {
                throw new Exception("参数必须为15个");
            }
            if (isWriteOk())
            {
                for (int i = 0; i < 15; i++)
                {
                    writeOpc(1, writeOpcItem[i], moveValue[i].ToString());
                }
            }
        }

        public double[] getMoveValue()
        {
            string[] myValue = readOpc(2);
            if (myValue.Length != 15)
            {
                throw new Exception("读取反馈数据时通讯错误！");
            }
            else
            {
                double[] value = new double[15];
                for (int i = 0; i < 15; i++)
                {
                    value[i] = double.Parse(myValue[i]);
                }
                return value;
            }
        }
    }
}
