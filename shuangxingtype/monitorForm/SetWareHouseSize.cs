using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace doublestartyre.monitorForm
{
    public partial class SetWareHouseSize : Form
    {
        public SetWareHouseSize()
        {
            InitializeComponent();
        }
        string dStr;
        private void SetWareHouseSize_Load(object sender, EventArgs e)
        {
            txtcolumns.Enabled = false;
            txtHeight.Enabled = false;
            txtrows.Enabled = false;
            txtWidth.Enabled = false;

            dStr = "select * from initialize";
            DataSet myds = hardware.dbdoublestar.getDataSet(dStr, "initialize");

            txtHeight.Text = myds.Tables["initialize"].Rows[0][2].ToString();
            txtWidth.Text = myds.Tables["initialize"].Rows[0][1].ToString();
            txtcolumns.Text = myds.Tables["initialize"].Rows[0][3].ToString();
            txtrows.Text = myds.Tables["initialize"].Rows[0][4].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请先修改数据，然后点击确认按钮完成修改！");
            txtWidth.Enabled = true;
            txtrows.Enabled = true;
            txtHeight.Enabled = true;
            txtcolumns.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ss;
            if (!double.TryParse(txtHeight.Text.Trim(), out ss))
            {
                txtHeight.Text = "";
                txtHeight.Focus();
                return;
            }
            dStr = "update initialize set width=" + txtWidth.Text.Trim() + ",height=" + txtHeight.Text.Trim() +
                ",icolumns=" + txtcolumns.Text.Trim() + ",irows=" + txtrows.Text.Trim();
            hardware.dbdoublestar.getsqlcom(dStr);
        }
    }
}
