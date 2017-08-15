using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace doublestartyre.monitorForm
{
    public partial class storagetyrequery : Form
    {
        String dstr;
        public storagetyrequery()
        {
            InitializeComponent();
        }

        private void storagetyrequery_Load(object sender, EventArgs e)
        {
            dstr = "select qrcode as 二维码, inzancuntime as 入暂存区时间, dynamicbalancegrade as 动均检测等级, " +
                "productstandard as 轮胎规格, locationid as 存放位置,locationidnumber as 具体位置 from tyre where tyrestatus = 7";
            DataSet myds = new DataSet();
            myds = Utils.DatabaseUtils.GetDataSet(dstr, "storagetyrequery");
            this.dataGridView1.DataSource = myds.Tables[0]; 
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region 按条件查询轮胎
            //bool Clickflag = false;
            dstr = "select qrcode as 二维码, inzancuntime as 入暂存区时间, dynamicbalancegrade as 动均检测等级, " +
                "productstandard as 轮胎规格, locationid as 存放位置,locationidnumber as 具体位置 from tyre where tyrestatus = 7 ";
             if(checkBoxQrcode.Checked)
             {
                /* if (Clickflag)
                 {
                      dstr +=" and qrcode like '%" + textBox1.Text.Trim() + "%'";
                 }
                 else
                 {
                     dstr += "where tyrestatus = 7 and qrcode like '%" + textBox1.Text.Trim() + "%'";
                     Clickflag = true;
                 }*/
                 dstr += " and qrcode like '%" + textBox1.Text.Trim() + "%'";
             }
                 if(checkBoxtyre.Checked)
                 {                   
                     dstr += "and productstandard = '" + textBox2.Text.Trim() + "'";
                 }
                 if (checkBoxgrade.Checked)
                 {
                   
                     dstr += "and dynamicbalancegrade = '" + textBox3.Text.Trim() + "';";
                 }

                  #endregion
             DataSet myds = new DataSet();
             myds = Utils.DatabaseUtils.GetDataSet(dstr , "query");
             this.dataGridView1.DataSource = myds.Tables["query"];
             myds.Dispose();
        }
    }

}
