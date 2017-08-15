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
    public partial class huancunqu2 : Form
    {


        public huancunqu2()
        {
            InitializeComponent();
        }

        private void huancunqu2_Load(object sender, EventArgs e)
        {
            DataSet myds = new DataSet();
            string dstr = "select id,tyrenumber from cache2";
            myds = Utils.DatabaseUtils.GetDataSet(dstr, "id");
            
            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach (DataRow item in myds.Tables[0].Rows)
            {
                dic.Add(item["id"].ToString(), item["tyrenumber"].ToString());
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
            string dstr = "select id,tyrenumber from cache2";
            myds = Utils.DatabaseUtils.GetDataSet(dstr, "id");

            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach (DataRow item in myds.Tables[0].Rows)
            {
                dic.Add(item["id"].ToString(), item["tyrenumber"].ToString());
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



       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
