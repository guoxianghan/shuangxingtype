using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace doublestartyre
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show("程序已经运行！");
                return;
            }
            
            Trace.Listeners.Clear();
            Trace.Listeners.Add(new Utils.TraceLogListener());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(/*new AccountManagement.frmLogin()*/new monitorForm.TyreConfiguration()/* new GantryClient.Form1()*/);
        }
    }
}