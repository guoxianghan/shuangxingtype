using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace doublestartyre.AccountManagement
{
    public partial class    frmLogin : Form
    {
        private Data.Account[] userAccounts;
        private static String DEFAULT_ACCOUNT_NUMBER = "A9999";
        private static String DEFAULT_ACCOUNT_NAME = "Administrator";
        private static String DEFAULT_ACCOUNT_PASSWORD = System.Configuration.ConfigurationManager.AppSettings["password_administrator"];
        private static Boolean isFirstLogin = false;
        private string currentAccountNumber, currentAccountName;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            currentAccountNumber = comboId.Text.Trim();

            DataSet accountDatas = Utils.DatabaseUtils.GetDataSet("select * from login", "login");
            if (accountDatas.Tables[0].Rows.Count == 0)
            {
                // It is the first time to login in.
                isFirstLogin = true;
                userAccounts = new Data.Account[1];
                userAccounts[0].id = 1;
                userAccounts[0].number = DEFAULT_ACCOUNT_NUMBER;
                userAccounts[0].name = DEFAULT_ACCOUNT_NAME;
                userAccounts[0].permission = Utils.Constants.ACCOUNT_PERMISSION_ADMINISTRATOR;
                userAccounts[0].status = Utils.Constants.ACCOUNT_STATUS_LOGOUT;

                comboId.Items.Add(userAccounts[0].number);
            }
            else
            {
                isFirstLogin = false;
                userAccounts = new Data.Account[accountDatas.Tables[0].Rows.Count];
                for (int i = 0; i < accountDatas.Tables[0].Rows.Count; i++)
                {
                    try
                    {
                        DataRow tmpAccount = accountDatas.Tables[0].Rows[i];
                        userAccounts[i].id = Int32.Parse(tmpAccount[0].ToString());
                        userAccounts[i].number = tmpAccount[1].ToString();
                        userAccounts[i].name = tmpAccount[2].ToString();
                        userAccounts[i].password = tmpAccount[3].ToString();
                        userAccounts[i].permission = Int32.Parse(tmpAccount[4].ToString());
                        userAccounts[i].status = Int32.Parse(tmpAccount[5].ToString());

                        comboId.Items.Add(userAccounts[i].number);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void ButLogin_Click(object sender, EventArgs e)
        {
            if (comboId.Text != "" & TxtPsw.Text != "")
            {
                currentAccountNumber = comboId.Text.Trim(); // 用户编号
                Boolean found = false;
                // Check the password
                if (isFirstLogin)
                {
                    if (DEFAULT_ACCOUNT_PASSWORD.Equals(TxtPsw.Text.Trim()))
                    {
                        found = true;
                        currentAccountName = userAccounts[0].name;
                        // Insert to the database
                        String dStr = "insert into login(ID,code,name,password,permission,status) values ('"
                            + "1" + "','" + userAccounts[0].number + "','" + userAccounts[0].name + "','"
                            + DEFAULT_ACCOUNT_PASSWORD + "','" + userAccounts[0].permission.ToString() + "','"
                            + Utils.Constants.ACCOUNT_STATUS_LOGIN.ToString() + "')";
                        Utils.DatabaseUtils.ExecuteSqlCommand(dStr);
                    }
                }
                else
                {
                    foreach (Data.Account account in userAccounts)
                    {
                        if (account.number.Equals(comboId.Text.Trim()) && account.password.Equals(TxtPsw.Text.Trim()))
                        {
                            found = true;
                            currentAccountName = account.name;
                            String dStr = null;

                            // Find the last login account and update the status in database.
                            foreach (Data.Account account1 in userAccounts)
                            {
                                if (account1.status == Utils.Constants.ACCOUNT_STATUS_LOGIN)
                                {
                                    dStr = "Update login set status='" + Utils.Constants.ACCOUNT_STATUS_LOGOUT.ToString()
                                        + "'" + " where code='" + account1.number + "'";
                                    Utils.DatabaseUtils.ExecuteSqlCommand(dStr);

                                    break;
                                }
                            }

                            // Update the account status in database.
                            dStr = "Update login set status='" + Utils.Constants.ACCOUNT_STATUS_LOGIN.ToString()
                                + "'" + " where code='" + account.number + "'";
                            Utils.DatabaseUtils.ExecuteSqlCommand(dStr);

                            break;
                        }
                    }
                }

                if (found)
                {
                    // 登录日志
                    string dStr = "insert into operationlog (code,name,operationtime,hardware,details) values ('"
                        + currentAccountNumber + "','" + currentAccountName + "','" + DateTime.Now.ToString() + "','成品包装系统','系统登录')";
                    Utils.DatabaseUtils.ExecuteSqlCommand(dStr);
                    // TODO: Close this form.
                    this.Hide();
                    // this.Close();

                    frmMain frmMain1 = new frmMain(currentAccountNumber, currentAccountName);
                    frmMain1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("输入的用户名或者密码不正确！");
                    TxtPsw.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("输入不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string namepsw = "";
            SqlDataReader temDR = Utils.DatabaseUtils.GetSqlDataReader("select * from login where code='" + comboId.Text.Trim() + "'");
            bool ifcom = temDR.Read();
            if (ifcom)
            {
                namepsw = temDR.GetString(3); // 用户密码
            }
            TxtPsw.Text = namepsw;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmChangePassword changePasswordForm = new frmChangePassword();
            changePasswordForm.Show();
        }
    }
}
