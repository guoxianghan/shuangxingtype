using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace doublestartyre.hardware
{
    class SocketServer
    {
        public Socket sever1;
        Dictionary<string, Socket> dict = new Dictionary<string, Socket>();
        //Dictionary<string, Thread> dictThread = new Dictionary<string, Thread>();

        //启动服务器
        public SocketServer(string text)
        {
            sever1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress address   = IPAddress.Parse("192.168.0.1");
            IPEndPoint endpoint = new IPEndPoint(address, 1000);
            try
            {
                sever1.Bind(endpoint);
            }
            catch (SocketException se)
            {
                MessageBox.Show("异常：" + se.Message);
                return;
            }
            sever1.Listen(10);//最大侦听长度
            Thread myThread = new Thread(WatchConnecting);
            myThread.IsBackground = true;
            myThread.Start();
            

            
        }
        //服务器监听
       public void WatchConnecting()
        {
            while (true)
            {
                Socket sokConnection = sever1.Accept(); // 一旦监听到一个客户端的请求，就返回一个与该客户端通信的 套接字；
                dict.Add(sokConnection.RemoteEndPoint.ToString(), sokConnection);
                //string text = "C@0@2@1@12334@1500@2@1@1@3.5@0";
                //byte[] arrtest = System.Text.Encoding.UTF8.GetBytes(text);
                //sokConnection.Send(arrtest);
            }
        }

    }
}
