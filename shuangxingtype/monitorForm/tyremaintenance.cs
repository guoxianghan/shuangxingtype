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
    public partial class tyremaintenance : Form
    {
        public tyremaintenance()
        {
            InitializeComponent();
        }
        int myid;


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tyremaintenance_Load(object sender, EventArgs e)
        {
            string dStr = "select * from tyremaintenance;";
            DataSet myds = Utils.DatabaseUtils.GetDataSet(dStr, "tyremaintenance");
            this.dataGridView1.DataSource = myds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "序号";
            dataGridView1.Columns[1].HeaderText = "物料编码";
            dataGridView1.Columns[2].HeaderText = "单个轮胎高度";
            dataGridView1.Columns[3].HeaderText = "轮胎形变量";
            dataGridView1.Columns[4].HeaderText = "子口";
            dataGridView1.Columns[5].HeaderText = "最大库位高度";
            dataGridView1.Columns[6].HeaderText = "最小出库数量";
            dataGridView1.Columns[7].HeaderText = "机台号";
            button4.Enabled = false;
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            #region 判断输入是否合法
            if (luntaiguige.Text.Trim() == "")
            {
                MessageBox.Show("输入不能为空！");
                luntaiguige.Focus();
                return;
            }
            if (singleheight.Text.Trim() == "")
            {
                MessageBox.Show("输入不能为空！");
                singleheight.Focus();
                return;
            }
            if (reduction.Text.Trim() == "")
            {
                MessageBox.Show("输入不能为空！");
                reduction.Focus();
                return;
            }
            if (Bead.Text.Trim() == "")
            {
                MessageBox.Show("输入不能为空！");
                Bead.Focus();
                return;
            }
            if (minnumber.Text.Trim() == "")
            {
                MessageBox.Show("输入不能为空！");
                minnumber.Focus();
                return;
            }
            if (maxheight.Text.Trim() == "")
            {
                MessageBox.Show("输入不能为空！");
                maxheight.Focus();
                return;
            }
            double aa;
            int i;
            if (!double.TryParse(singleheight.Text.Trim(), out aa))
            {
                MessageBox.Show("单个高度输入的不是数字！");
                singleheight.Focus();
                return;
            }
            if (!double.TryParse(reduction.Text.Trim(), out aa))
            {
                MessageBox.Show("形变量输入的不是数字！");
                reduction.Focus();
                return;
            }
            if (!int.TryParse(Bead.Text.Trim(), out i))
            {
                MessageBox.Show("子口输入的不是整数！");
                Bead.Focus();
                return;
            }
            if (!double.TryParse(maxheight.Text.Trim(), out aa))
            {
                MessageBox.Show("最大库位高度输入的不是数字！");
                maxheight.Focus();
                return;
            }
            if (!int.TryParse(minnumber.Text.Trim(), out i))
            {
                MessageBox.Show("最小出库数量输入的不是整数！");
                minnumber.Focus();
                return;
            }
            #endregion
            if (button4.Text == "添加")
            {
                string dStr = "insert into tyremaintenance(luntaiguige,singleheight,reduction,Bead,minnumber,maxheight,jitaiid) " +
                    "values('" + luntaiguige.Text.Trim() + "'," + singleheight.Text.Trim() + "," + reduction.Text.Trim() +
                    "," + Bead.Text.Trim() + "," + minnumber.Text.Trim() + "," + maxheight.Text.Trim() + "," + jitaihaozhi.Text.Trim() + ");";
                Utils.DatabaseUtils.ExecuteSqlCommand(dStr);

            }
            if (button4.Text == "修改")
            {
                string dStr = "update tyremaintenance set luntaiguige = '" + luntaiguige.Text.Trim() + "',singleheight = "
                    + singleheight.Text.Trim() + ",reduction = " + reduction.Text.Trim() + ",Bead = " + Bead.Text.Trim() +
                    ",minnumber = " + minnumber.Text.Trim() + ",maxheight =" + maxheight.Text.Trim() + ",jitaiid =" + jitaihaozhi.Text.Trim() + " where id = "
                    + myid.ToString()+";";
                Utils.DatabaseUtils.ExecuteSqlCommand(dStr);
            }
            if (button4.Text == "删除")
            {
                DialogResult dr = MessageBox.Show("删除后数据将无法修复，是否删除？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    string dStr = "delete from tyremaintenance where id=" + myid.ToString();
                    Utils.DatabaseUtils.ExecuteSqlCommand(dStr);
                }

            }
            luntaiguige.Text = "";
            singleheight.Text = "";
            reduction.Text = "";
            Bead.Text = "";
            minnumber.Text = "";
            maxheight.Text = "";
            jitaihaozhi.Text = "";
            string dStr1 = "select * from tyremaintenance";
            DataSet myds = Utils.DatabaseUtils.GetDataSet(dStr1, "tyremaintenance");
            this.dataGridView1.DataSource = myds.Tables[0];
            button4.Enabled = false;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.RowIndex >= dataGridView1.Rows.Count - 1)
            {
                return;
            }
            if (button4.Text == "修改" || button4.Text == "删除")
            {
                int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), out myid);
                luntaiguige.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                singleheight.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                reduction.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                Bead.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                maxheight.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                minnumber.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                jitaihaozhi.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                button4.Enabled = true;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            button4.Text = "添加";
            button4.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button4.Text = "修改";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button4.Text = "删除";
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void luntaiguige_TextChanged(object sender, EventArgs e)
        {

        }

        private void singleheight_TextChanged(object sender, EventArgs e)
        {

        }

        private void reduction_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bead_TextChanged(object sender, EventArgs e)
        {

        }

        private void maxheight_TextChanged(object sender, EventArgs e)
        {

        }

        private void minnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
