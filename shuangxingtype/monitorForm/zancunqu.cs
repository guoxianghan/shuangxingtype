using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using doublestartyre.utils;

namespace doublestartyre.monitorForm
{
    public partial class zancunqu : Form
    {


        public zancunqu()
        {
            InitializeComponent();
        }

        private void zancunqu_Load(object sender, EventArgs e)
        {
            DataSet myds = new DataSet();
            string dstr = "select id,idnumber from storage";
            myds = Utils.DatabaseUtils.GetDataSet(dstr, "id");
            
            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach (DataRow item in myds.Tables[0].Rows)
            {
                dic.Add(item["id"].ToString(), item["idnumber"].ToString());
            }
            foreach (var control in this.Controls)
            {
                TextBox t = control as TextBox;
                if (t != null && t.Name.Contains("id"))
                {
                    if (dic.ContainsKey(t.Name.Substring(2)))
                    t.Text = dic[t.Name.Substring(2)].ToString();
                }
            }


        }



        private void pictureBox28_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //更新暂存区界面
            DataSet myds = new DataSet();
            string dstr = "select id,idnumber from storage";
            myds = Utils.DatabaseUtils.GetDataSet(dstr, "id");

            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach (DataRow item in myds.Tables[0].Rows)
            {
                dic.Add(item["id"].ToString(), item["idnumber"].ToString());
            }
            foreach (var control in this.Controls)
            {
                TextBox t = control as TextBox;
                if (t != null && t.Name.Contains("id"))
                {
                    if (dic.ContainsKey(t.Name.Substring(2)))
                        t.Text = dic[t.Name.Substring(2)].ToString();
                }
            }

        }



        private void 轮胎查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monitorForm.storagetyrequery Fstoragequery = new monitorForm.storagetyrequery();
            Fstoragequery.ShowDialog();
        }


    }
}
