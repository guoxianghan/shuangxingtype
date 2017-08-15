using System;
using ActProgTypeLib;
using Opc;

namespace doublestartyre.hardware
{
    abstract class DeviceBase : ActProgTypeClass
    {
        private String mDeviceName;
        private String mErrorInfo;
        private bool bConnectionFlag;
        private bool bDeviceRunningFlag;

        //0正常，1停止运行，2报警</returns>
        public const int RUNNING_STATUS_NORMAL = 0;
        public const int RUNNING_STATUS_STOP = 1;
        public const int RUNNING_STATUS_ALARM = 2;
        public const int RUNNING_STATUS_CONNECTION_ERROR = 3;


        private Opc.Da.Server m_server = null;//定义数据存取服务器
        private Opc.Da.Subscription subscription = null;//定义组对象（订阅者）
        private Opc.Da.SubscriptionState state = null;//定义组（订阅者）状态，相当于OPC规范中组的参数
        private Opc.IDiscovery m_discovery = new OpcCom.ServerEnumerator();//定义枚举基于COM服务器的接口，用来搜索所有的此类服务器。

        public DeviceBase(String hostAdress, String name, int cpuType, int protocolType, int unitType)
        {
            mDeviceName = name;
            ActHostAddress = hostAdress;
            ActCpuType = cpuType;
            ActProtocolType = protocolType;
            ActUnitType = unitType;
        }

        #region 打开线体通讯
        public bool ConnectPlc()
        {
             bool status = Open() == 0;
              bConnectionFlag = status;
              //bDeviceRunningFlag = status;
              initData();
              return status;
            
        }
        #endregion
        #region 打开龙门通讯
        public bool GantryConnect()
        {
            Opc.Server[] servers = m_discovery.GetAvailableServers(Specification.COM_DA_20, "1OPC.IWSCP", null);
            if (servers != null)
            {
                foreach (Opc.Da.Server server in servers)
                {
                    //server即为需要连接的OPC数据存取服务器。
                    if (String.Compare(server.Name, "192.168.0.117.Matrikon.OPC.Simulation", true) == 0)//为true忽略大小写
                    {
                        m_server = server;//建立连接。
                        break;
                    }
                }
            }
            if (m_server != null)//非空连接服务器
            {
                m_server.Connect();
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion


        #region 关闭线体通讯
        public bool DisconnectPlc()
        {
            // return Close() == 0;
            return true;
        }
        #endregion

        public String GetDeviceName()
        {
            return mDeviceName;
        }

       // public abstract int ReadRunningStatus();

        public abstract String ReadErrorInfo();

        public void setRunningFlag(bool flag)
        {
            bDeviceRunningFlag = flag;
        }

        public bool GetRunningFlag()
        {
            return bDeviceRunningFlag;
        }

        public bool GetConnectionFlag()
        {
            return bConnectionFlag;
        }

        public String GetErrorInfo()
        {
            return mErrorInfo;
        }

        public void SetErrorInfo(String errorInfo)
        {
            mErrorInfo = errorInfo;
        }

        public void SetCommunicationError(String info)
        {
            bDeviceRunningFlag = false;
            SetErrorInfo("通讯错误 : " + info);
        }

        public virtual void initData() { }

    }
}
