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
    public partial class Coordinate : Form
    {
        public Coordinate()
        {
            InitializeComponent();
        }
        string dStr;
        bool flagConfirm;

        private void Coordinate_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;
            dStr = "select * from  coordinate";
            DataSet myds = new DataSet();
            myds = hardware.dbdoublestar.getDataSet(dStr, "coordinate");
            this.dataGridView1.DataSource = myds.Tables["coordinate"];
            this.dataGridView1.Columns[0].HeaderText = "库位号";
            this.dataGridView1.Columns[1].HeaderText = "X轴坐标";
            this.dataGridView1.Columns[2].HeaderText = "Y轴坐标";
            this.dataGridView1.Columns[3].HeaderText = "Z轴坐标";
            this.dataGridView1.Columns[4].HeaderText = "是否禁用";
            this.dataGridView1.Columns[5].HeaderText = "备注";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (flagConfirm)
            {
                this.txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txtXaxis.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txtYaxis.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.txtZaxis.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.txtMark.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()) == 0)
                {
                    this.comboBox1.SelectedIndex = 0;
                }
                else
                {
                    this.comboBox1.SelectedIndex = 1;
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            flagConfirm = true;
            buttonConfirm.Text = "添加";
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            flagConfirm = true;
            buttonConfirm.Text = "删除";
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            flagConfirm = true;
            buttonConfirm.Text = "修改";
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            int i;
            double j;
            if (!int.TryParse(txtID.Text.Trim(), out i))
            {
                MessageBox.Show("输入必须为整数！");
                return;
            }
            if (!double.TryParse(txtXaxis.Text.Trim(), out j) || (!double.TryParse(txtYaxis.Text.Trim(), out j)) ||
                (!double.TryParse(txtZaxis.Text.Trim(), out j)))
            {
                MessageBox.Show("输入必须为数字！");
                return;
            }
            if (buttonConfirm.Text == "添加")
            {
                dStr = "insert into  coordinate (id,x_axis,y_axis,z_axis,forbidden,extra) values " +
                    "(" + txtID.Text.Trim() + "," + txtXaxis.Text.Trim() + "," + txtYaxis.Text.Trim() + "," +
                    txtZaxis.Text.Trim() + ",'" + comboBox1.Text + "','" + txtMark.Text.Trim() + "')";
            }
            if (buttonConfirm.Text == "删除")
            {
                dStr = "delete  coordinate where id=" + txtID.Text.Trim();
            }
            if (buttonConfirm.Text == "修改")
            {
                dStr = "update  coordinate set id=" + txtID.Text.Trim() + ",x_axis=" + txtXaxis.Text.Trim() + ",y_axis=" +
                    txtYaxis.Text.Trim() + ",z_axis=" + txtZaxis.Text.Trim() + ",forbidden='" + comboBox1.Text +
                    "',extra='" + txtMark.Text.Trim() + "'";
            }
            hardware.dbdoublestar.getsqlcom(dStr);
            emptyText();
            dStr = "select * from  coordinate";
            DataSet myds = new DataSet();
            myds = hardware.dbdoublestar.getDataSet(dStr, "coordinate");
            dataGridView1.DataSource = myds.Tables["coordinate"];
        }
        /// <summary>
        /// 清空更新完成的数据
        /// </summary>
        private void emptyText()
        {
            this.txtID.Text = "";
            this.txtXaxis.Text = "";
            this.txtYaxis.Text = "";
            this.txtZaxis.Text = "";
            this.comboBox1.SelectedIndex = 0;
            this.txtMark.Text = "";
        }
    }
}
