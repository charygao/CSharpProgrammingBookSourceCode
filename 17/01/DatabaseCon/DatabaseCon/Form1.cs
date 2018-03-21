using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;

namespace DatabaseCon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string strCon = "";//记录数据库连接语句
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox6.Text = "(local)";//默认服务器设置为本地
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.mdb(Access数据库文件)|*.mdb|*.xls(Excel文件)|*.xls|*.*(所有文件)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;//显示选择的数据库文件
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (textBox1.Text != "")
                {
                    FileInfo FInfo = new FileInfo(textBox1.Text);//实例化FileInfo类对象
                    string strExtention = FInfo.Extension;//获取文件扩展名
                    if (strExtention.ToLower() == ".mdb")//判断是不是Access数据库文件
                    {
                        if (textBox2.Text != "")
                        {
                            strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + textBox1.Text + ";UID=" + textBox2.Text + ";PWD=" + textBox3.Text + ";";//组合Access数据库连接字符串
                        }
                        else
                        {
                            strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + textBox1.Text + ";";
                        }
                    }
                    else if (strExtention.ToLower() == ".xls")//判断是不是Excel数据库文件
                    {
                        strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + textBox1.Text + ";Extended Properties=Excel 8.0;";//组合Excel数据库连接字符串
                    }
                }
                OleDbConnection oledbcon = new OleDbConnection(strCon);//使用OLEDB连接对象连接数据库
                try
                {
                    oledbcon.Open();//打开数据库连接
                    richTextBox1.Clear();
                    richTextBox1.Text = strCon + "\n连接成功……";
                }
                catch
                {
                    richTextBox1.Text = "连接失败";
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    strCon = "Data Source=" + textBox6.Text + ";Initial Catalog =" + comboBox1.Text + ";Integrated Security=SSPI;";//使用Windows身份验证连接SQL数据库
                }
                else if (checkBox2.Checked == true)
                {
                    strCon = "Data Source=" + textBox6.Text + ";Database=" + comboBox1.Text + ";Uid=" + textBox5.Text + ";Pwd=" + textBox4.Text + ";";//使用SQL Server身份验证连接SQL数据库
                }
                SqlConnection sqlcon = new SqlConnection(strCon);//使用SqlConnection连接数据库
                try
                {
                    sqlcon.Open();//打开数据库连接
                    richTextBox1.Clear();
                    richTextBox1.Text = strCon + "\n连接成功……";
                }
                catch
                {
                    richTextBox1.Text = "连接失败";
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Enabled = textBox2.Enabled = textBox3.Enabled=button1.Enabled  = true;
                radioButton2.Checked = false;
                textBox4.Enabled = textBox5.Enabled = textBox6.Enabled 
                    = checkBox1.Enabled = checkBox2.Enabled = comboBox1.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
                textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = button1.Enabled = textBox4.Enabled = textBox5.Enabled = false;
                textBox6.Enabled = checkBox1.Enabled = checkBox2.Enabled = comboBox1.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                textBox4.Enabled = textBox5.Enabled = false;
                string str = "server=" + textBox6.Text + ";database=master;Integrated Security=SSPI;";
                comboBox1.DataSource = getTable(str);//显示数据库列表
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "name";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            textBox4.Enabled = textBox5.Enabled = true;
            textBox5.Focus();
        }

        private DataTable getTable(string str)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(str);//实例化数据库连接对象
                SqlDataAdapter da = new SqlDataAdapter("select name from sysdatabases ", sqlcon);
                DataTable dt = new DataTable("sysdatabases");//实例化DataTable对象
                da.Fill(dt);//填充DataTable数据表
                return dt;
            }
            catch
            {
                return null;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                textBox4.Focus();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button4_Click(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = "server=" + textBox6.Text + ";database=master;Uid=" + textBox5.Text + ";Pwd=" + textBox4.Text + ";";
            comboBox1.DataSource = getTable(str);//刷新数据库列表
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "name";
        }
    }
}
