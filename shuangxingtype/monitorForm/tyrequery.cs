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
    public partial class tyrequery : Form
    {

        string dStr;
        public tyrequery()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void frmQuery_Load(object sender, EventArgs e)
        {
            this.checkBoxDate.Checked = true;
            DataSet myds = new DataSet();
            dStr = "select * from tyre where outtime>'" + DateTime.Now.ToShortDateString() + " 00:00:00.000' order by id desc";
            myds = Utils.DatabaseUtils.GetDataSet(dStr, "hwheel");
            this.dataGridView1.DataSource = myds.Tables[0];
            myds.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dStr = "select * from tyre ";
            bool Qflag = false;
            if (checkBoxDate.Checked)
            {
                if (Qflag)
                {
                    dStr += "and InDetectionlineTime>= ' " + dateTimePicker1.Value.ToShortDateString() + " 00:00:00.000' and InDetectionlineTime<= '" +
                         dateTimePicker1.Value.ToShortDateString() + " 23:59:59.999'";

                }
                else
                {
                    dStr += "where InDetectionlineTime>= ' " + dateTimePicker1.Value.ToShortDateString() + " 00:00:00.000' and InDetectionlineTime<= '" +
                       dateTimePicker1.Value.ToShortDateString() + " 23:59:59.999'";
                    Qflag = true;
                }
            }
            if (checkBoxQrcode.Checked)
            {
                if (Qflag)
                {
                    dStr += " and qrcode like '%" + textBox1.Text.Trim() + "%'";
                }
                else
                {
                    dStr += "where qrcode like '%" + textBox1.Text.Trim() + "%'";
                    Qflag = true;
                }
            }
            if (checkBoxFigure.Checked)
            {
                if (Qflag)
                {
                    dStr += "and tyrefigure = '" + textBox4.Text.Trim() + "' ";

                }
                else
                {
                    dStr += "where tyrefigure = '" + textBox4.Text.Trim() + "' ";
                    Qflag = true;
                }
            }
            if (checkBoxStandard.Checked)
            {
                if (Qflag)
                {
                    dStr += "and productstandard = '" + textBox2.Text.Trim() + "' ";

                }
                else
                {
                    dStr += "where productstandard = '" + textBox2.Text.Trim() + "' ";
                    Qflag = true;
                }
            }
            if (checkBoxRim.Checked)
            {
                if (Qflag)
                {
                    dStr += "and rimgrade = '" + textBox3.Text.Trim() + "'";

                }
                else
                {
                    dStr += "where rimgrade = '" + textBox3.Text.Trim() + "'";
                    Qflag = true;
                }
            }
            dStr += " order by id desc";           
            DataSet myds = new DataSet();
            myds =Utils.DatabaseUtils.GetDataSet(dStr, "tyrequery");
            this.dataGridView1.DataSource = myds.Tables["tyrequery"];
            myds.Dispose();
        }


    }
}
