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
    class opc
    {
        private Opc.Da.Server m_Server = null;
        private Opc.Da.Subscription subscription = null;
        private Opc.Da.SubscriptionState state = null;
        private Opc.IDiscovery m_discovery = new OpcCom.ServerEnumerator();


        private void Work() 
        {
            //Opc.Server[] opcServers = opcDiscovery.GetAvailableServers( Opc.Specification.COM_DA_20);
            Opc.Server[] servers = m_discovery.GetAvailableServers(Specification.COM_DA_20, "", null);
            if (servers != null)
            {
                foreach (Opc.Da.Server server in servers)
                {
                    if (String.Compare(server.Name, "192.168.1.108",true) == 0)
                    {
                        m_Server = server;
                        break;
                    }
                }
            }
            if(m_Server != null)
            {
                m_Server.Connect();
            }
            else
            {
                return;
            }

        }
    }
}
