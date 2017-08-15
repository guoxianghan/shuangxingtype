using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace doublestartyre.AccountManagement
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void frmadduser_Load(object sender, EventArgs e)
        {
            String dbCommandString = "select code as 用户编号,name as 用户姓名,permission as 权限 from login";
            DataSet myds = Utils.DatabaseUtils.GetDataSet(dbCommandString, "yonghu");
            dataGridView.DataSource = myds.Tables["yonghu"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "")
            {
                MessageBox.Show("用户编号不能为空!");
                txtId.Focus();
                return;
            }
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("用户姓名不能为空!");
                txtName.Focus();
                return;
            }
            if (txtPsw1.Text.Trim() == "")
            {
                MessageBox.Show("用户密码不能为空!");
                txtPsw1.Focus();
                return;
            }
            if (txtPsw2.Text.Trim() != txtPsw1.Text.Trim())
            {
                MessageBox.Show("两次密码输入不一致!");
                txtPsw2.Focus();
                return;
            }

            // Insert to the database
            /* Use 1 as the ID for workflow.
            String dbCommandString = "insert into  login(ID,code,name,password,permission,status) values ('"
                + "1" + "','" + txtId.Text.Trim() + "','" + txtName.Text.Trim() + "','"
                + txtPsw1.Text.Trim() + "','" + numericUpDown1.Value.ToString() + "','" + "0" + "')";
             */
            String dbCommandString = "insert into login(code,name,password,permission,status) values ('"
                + txtId.Text.Trim() + "','" + txtName.Text.Trim() + "','"
                + txtPsw1.Text.Trim() + "','" + numericUpDown1.Value.ToString() + "','" + "0" + "')";
            Utils.DatabaseUtils.ExecuteSqlCommand(dbCommandString);
            MessageBox.Show("新添加用户成功!");

            dbCommandString = "select code as 用户编号,name as 用户姓名,permission as 权限 from login";
            DataSet myds = Utils.DatabaseUtils.GetDataSet(dbCommandString, "yonghu");
            dataGridView.DataSource = myds.Tables["yonghu"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
