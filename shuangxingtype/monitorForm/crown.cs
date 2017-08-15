using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace doublestartyre.monitorForm
{
    public delegate void ChangeTextHandler(string str,string str1);
    

    public partial class crown : Form

    {
        public crown()
        {
            InitializeComponent();
        }
        public crown(ArrayList listbox)
        {
            InitializeComponent();
            
            li = listbox;
        }
        public event ChangeTextHandler ChangeText;
        ArrayList li = new ArrayList();
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        //string dstr = "insert into appearancedetection (qrcode,grade,team,classes,staff,";
        string dstr1 = "";
            foreach(var control in Controls)
            {
                CheckBox t = control as CheckBox;
                if (t!=null&&t.Checked)
                {
                    string name = t.Name.ToString();
                    dstr1 ="@" + name;
                    if (li != null)
                    {
                        foreach (var obj in li)
                        {
                            string bbb = obj.ToString();
                            if (t.Text.Trim() == bbb.Trim())
                            {
                                MessageBox.Show("选择了重复病疵！！");
                                this.Close();
                                return;
                            }
                        }
                    }
                    ChangeText(t.Text.Trim(),dstr1);
                }
            }
            this.Close();
        }
    }
}
