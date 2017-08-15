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
using doublestartyre.Utils;
using System.Collections;


namespace doublestartyre.monitorForm
{
    
    public partial class rengongwaijian : Form
    {
        string dStr,dStr1;
        public rengongwaijian()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (qrcode.Text == "")
            {
                MessageBox.Show("缺失轮胎条码！");
                return;
            }
                DialogResult dr = MessageBox.Show("确定为合格品吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                dStr = "insert into appearancedetection (qrcode,grade,team,classes,staff,station,classtime,mesflag)values('" + qrcode.Text.ToString() + "',"+
                    "'合格品'," + team.Text + ",'" + classes.Text + "','" + staff.Text.ToString().Trim() + "'," + station1.Text + ",'" + DateTime.Now + "',1);";
                string dstr = "update tyre set tyrestatus = 3,tyregrade = '合格品' where qrcode = '" + qrcode.Text.Trim() + "';";
                DatabaseUtils.ExecuteSqlCommand(dStr);
                DatabaseUtils.ExecuteSqlCommand(dstr);
                qrcode.Text = "";
            }
        
    }

        private void A_Click(object sender, EventArgs e)
        {
            ArrayList listbox = new ArrayList();
            if (listBox1.Items.Count!= 0)
            {
               for(int i = 0; i < listBox1.Items.Count; i++)
                {
                    listbox.Add(listBox1.Items[i].ToString());
                }
            }
            monitorForm.crown Fcrown = new crown(listbox);
            Fcrown.ChangeText += new ChangeTextHandler(Change_Text);
            Fcrown.ShowDialog();
        }

        private void BandC_Click(object sender, EventArgs e)
        {
            ArrayList listbox = new ArrayList();
            if (listBox1.Items.Count != 0)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listbox.Add(listBox1.Items[i].ToString());
                }
            }
            monitorForm.tyreshoulderandside Ftyreshoulderandside = new tyreshoulderandside(listbox);
            Ftyreshoulderandside.ChangeText += new ChangeTextHandler(Change_Text);
            Ftyreshoulderandside.ShowDialog();
        }

        private void D_Click(object sender, EventArgs e)
        {
            ArrayList listbox = new ArrayList();
            if (listBox1.Items.Count != 0)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listbox.Add(listBox1.Items[i].ToString());
                }
            }

            monitorForm.tyrecavity Ftyrecavity = new tyrecavity(listbox);
            Ftyrecavity.ChangeText += new ChangeTextHandler(Change_Text);
            Ftyrecavity.ShowDialog();
        }

        private void E_Click(object sender, EventArgs e)
        {
            ArrayList listbox = new ArrayList();
            if (listBox1.Items.Count != 0)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listbox.Add(listBox1.Items[i].ToString());
                }
            }
            monitorForm.bead Fbead = new bead(listbox);
            Fbead.ChangeText += new ChangeTextHandler(Change_Text);
            Fbead.ShowDialog();
        }

        private void F_Click(object sender, EventArgs e)
        {
            ArrayList listbox = new ArrayList();
            if (listBox1.Items.Count != 0)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listbox.Add(listBox1.Items[i].ToString());
                }
            }
            monitorForm.elsedefects Felsedefects = new elsedefects(listbox);
            Felsedefects.ChangeText += new ChangeTextHandler(Change_Text);
            Felsedefects.ShowDialog();
        }

        private void Change_Text(string str,string str1)
        {
            listBox1.Items.Add(str+"\r\n");
            if(dStr1 == "")
            {
                str1 = str1.Replace("@", "");
            }
            dStr1 = dStr1 + str1.Trim();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (qrcode.Text == "")
            {
                MessageBox.Show("缺失轮胎条码！");
                return;
            }
            DialogResult dr = MessageBox.Show("确定为次品吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                dStr = "insert into appearancedetection (qrcode,grade,team,classes,staff,station,classtime,mesflag)values('" + qrcode.Text.ToString() + "'," +
                    "'次品'," + team.Text + ",'" + classes.Text + "','" + staff.Text.ToString().Trim() + "'," + station1.Text + ",'" + DateTime.Now + "',1);";
                string dstr = "update tyre set tyrestatus = 3,tyregrade = '次品' where qrcode = '"+qrcode.Text.Trim()+"';";
                DatabaseUtils.ExecuteSqlCommand(dStr);
                DatabaseUtils.ExecuteSqlCommand(dstr);
                qrcode.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rengongwaijian_Load(object sender, EventArgs e)
        {
            dStr1 = "";
            classes.Items.Add("早班");
            classes.Items.Add("中班");
            classes.Items.Add("晚班");
            classes.SelectedIndex = 0;
            button1.Enabled = false;
            button2.Enabled = false;
            A.Enabled = false;
            BandC.Enabled = false;
            D.Enabled = false;
            E.Enabled = false;
            F.Enabled = false;
            isOK.Enabled = false;
            delete.Enabled = false;
            listBox1.ScrollAlwaysVisible = true;

            DataSet myds = new DataSet();
            string dstr0 = "select teamid from team ;";
            myds = Utils.DatabaseUtils.GetDataSet(dstr0, "teamid");
            for(int i = 0; i < myds.Tables[0].Rows.Count; i++)
            {
                team.Items.Add(myds.Tables[0].Rows[i][0].ToString());
            }
             

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            staff.Items.Clear();
            string teamid = team.Text.ToString();

            DataSet myds = new DataSet();
            string dstr = "select * from team where teamid ="+ teamid +";";
            myds = Utils.DatabaseUtils.GetDataSet(dstr, "teamid");
            for (int i = 1; i <8; i++)
            {
                staff.Items.Add(myds.Tables[0].Rows[0][i].ToString());
            }
            if (staff.Text.ToString() != null)
            {
                this.staff.SelectedIndex = 0;
                mima.ReadOnly = false;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (mima.ReadOnly)
            {
                MessageBox.Show("请输入正确的信息！！");
                return;
            }
            string name = staff.Text.ToString();
            DataSet myds = new DataSet();
            string dstr = "select password from password where name = '" + name + "';";
            myds = Utils.DatabaseUtils.GetDataSet(dstr, "name");
            string password = myds.Tables[0].Rows[0][0].ToString();
            if (mima.Text.ToString() == "")
            {
                MessageBox.Show("输入不能为空！");
                return;
            } 
            if(mima.Text.ToString() != password.Trim())
            {
                MessageBox.Show("密码输入错误！");
            }
            else
            {

                string dstr1 = "insert into stafflog (name,teamid,classes,time,status) values ('" + name.Trim() + "', " + team.Text.ToString() +
                    ", '" + classes.Text.ToString() + "', '" + DateTime.Now + " ', '上班');";
                DatabaseUtils.ExecuteSqlCommand(dstr1);
                classes.Enabled = false;
                staff.Enabled = false;
                team.Enabled = false;
                mima.ReadOnly = true;
                button1.Enabled = true;
                button2.Enabled = true;
                A.Enabled = true;
                BandC.Enabled = true;
                D.Enabled = true;
                E.Enabled = true;
                F.Enabled = true;
                isOK.Enabled = true;
                delete.Enabled = true;
                MessageBox.Show("登陆成功！"+"\r\n"+"操作人员：" + name.Trim()+ "\r\n" + "班组： " + team.Text.ToString() +"\r\n" + " 班次： " + classes.Text.ToString() + "");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void isOK_Click(object sender, EventArgs e)
        {
            if (qrcode.Text == "")
            {
                MessageBox.Show("缺失轮胎条码！");
                dStr1 = "";
                listBox1.Items.Clear();
                return;
            }
            if(listBox1.Items.Count == 0)
            {
                MessageBox.Show("未选择病疵！");
                return;
            }
            DialogResult dr = MessageBox.Show("确认提交吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                dStr = "insert into appearancedetection (qrcode,disease,grade,team,classes,staff,station,classtime,mesflag)values('" + qrcode.Text.ToString() + "',";
                dStr = dStr + "'" + dStr1 + "','不合格品'," + team.Text + ",'" + classes.Text + "','" + staff.Text.ToString().Trim() + "'," + station1.Text + ",'" + DateTime.Now + "',1);";
                string dstr = "delete from tyre where qrcode = '" + qrcode.Text.Trim()+"';";
                DatabaseUtils.ExecuteSqlCommand(dStr);
                DatabaseUtils.ExecuteSqlCommand(dstr);
                dStr1 = "";
                qrcode.Text = "";
                listBox1.Items.Clear();
            }

                }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认删除所有的病疵信息？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(dr == DialogResult.OK)
            {
                listBox1.Items.Clear();
                dStr1 = "";
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (!(mima.ReadOnly && mima.Text.ToString()!= ""))
            {
                MessageBox.Show("你还未登录，请登录！");
                return;
            }
            string dstr1 = "insert into stafflog (name,teamid,classes,time,status) values ('" + staff.Text.ToString().Trim() + "', " + team.Text.ToString() +
                   ", '" + classes.Text.ToString() + "', '" + DateTime.Now + " ', '下班');";
            DatabaseUtils.ExecuteSqlCommand(dstr1);
            classes.Enabled = true;
            staff.Enabled = true;
            team.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            A.Enabled = false;
            BandC.Enabled = false;
            D.Enabled = false;
            E.Enabled = false;
            F.Enabled = false;
            isOK.Enabled = false;
            delete.Enabled = false;
            listBox1.Items.Clear();

            staff.Items.Clear();
            mima.Clear();
            MessageBox.Show("退出成功！");

        }

 
    }
}
