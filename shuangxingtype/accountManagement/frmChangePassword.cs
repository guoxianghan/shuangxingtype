using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace doublestartyre.AccountManagement
{
    public partial class frmChangePassword : Form
    {
        public string Yid;
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmSetpsw_Load(object sender, EventArgs e)
        {

        }

        private void ClickConfirmButton(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "")
            {
                MessageBox.Show("用户编号不能为空！");
                txtId.Focus();
                return;
            }
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("用户姓名不能为空！");
                txtName.Focus();
                return;
            }
            if (txtPsw1.Text.Trim() == "")
            {
                MessageBox.Show("新密码不能为空！");
                txtPsw1.Focus();
                return;
            }
            if (txtPsw2.Text.Trim() != txtPsw1.Text.Trim())
            {
                MessageBox.Show("两次密码输入不一致！");
                txtPsw2.Focus();
                return;
            }

            SqlDataReader temDR = Utils.DatabaseUtils.GetSqlDataReader("select * from login where code='" + txtId.Text.Trim() + "' and name='" + txtName.Text.Trim() + "'");
            bool ifcom = temDR.Read();
            if (ifcom)
            {
                string dStr;
                dStr = "update login set password='" + txtPsw1.Text.Trim() + "' where code='" +
                    txtId.Text.Trim() + "' and name='" + txtName.Text.Trim() + "'";
                Utils.DatabaseUtils.ExecuteSqlCommand(dStr);
                MessageBox.Show("密码重置完成，请重新登录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("输入的用户编号或者用户姓名错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClickCancelButton(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
