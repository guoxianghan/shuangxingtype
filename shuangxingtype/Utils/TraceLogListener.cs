using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace doublestartyre.Utils
{
    class TraceLogListener : System.Diagnostics.TraceListener
    {
        public override void Write(string message)
        {
            File.AppendAllText("d:\\1.log", message);
        }

        public override void WriteLine(string message)
        {
            File.AppendAllText(System.Windows.Forms.Application.StartupPath + "\\resources" + "\\log\\" + DateTime.Now.Date.ToString("yyyy-MM-dd") + ".log",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss    ") + message + Environment.NewLine);
        }
    }
}
