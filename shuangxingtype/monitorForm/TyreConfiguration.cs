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
    public partial class TyreConfiguration : Form
    {
        public TyreConfiguration()
        {
            InitializeComponent();
        }

        private void TyreConfiguration_Load(object sender, EventArgs e)
        {
            string dStr = "select * from lunwangdengji;";
            DataSet myds = Utils.DatabaseUtils.GetDataSet(dStr, "lunwangdengji");
            this.dataGridView1.DataSource = myds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "序号";
            dataGridView1.Columns[1].HeaderText = "轮辋等级最小值";
            dataGridView1.Columns[2].HeaderText = "轮辋等级最大值";
        }

        private void xiugai_Click(object sender, EventArgs e)
        {
            double aa;
            if (int.Parse(dongpinghengid.Text.Trim()) == 1 || int.Parse(dongpinghengid.Text.Trim()) == 2 || int.Parse(dongpinghengid.Text.Trim()) == 3)
            {
                if (!double.TryParse(min.Text.Trim(), out aa))
                {
                    MessageBox.Show("最小值输入的不是数字！");
                    min.Focus();
                    return;
                }
                if (!double.TryParse(max.Text.Trim(), out aa))
                {
                    MessageBox.Show("最大值输入的不是数字！");
                    max.Focus();
                    return;
                }
                if (double.Parse(min.Text.Trim())> double.Parse(max.Text.Trim()))
                {
                    MessageBox.Show("输入的数字不合法！");
                    min.Focus();
                    return;
                }
                string dStr1 = "update lunwangdengji set min = " + min.Text.Trim() + ",max = " + max.Text.Trim() + " where dongpinghengid = " + dongpinghengid.Text.Trim() + " ;";
                DataSet myds = Utils.DatabaseUtils.GetDataSet(dStr1, "shuru");
                dongpinghengid.Text = "";
                min.Text = "";
                max.Text = "";
                string dStr2 = "select * from lunwangdengji";
                DataSet myds2 = Utils.DatabaseUtils.GetDataSet(dStr2, "lunwangdengji1");
                this.dataGridView1.DataSource = myds2.Tables[0];

            }
            else
            {
                MessageBox.Show("动平衡序号输入错误！");
                dongpinghengid.Focus();
                return;
            }

        }
    }
}
