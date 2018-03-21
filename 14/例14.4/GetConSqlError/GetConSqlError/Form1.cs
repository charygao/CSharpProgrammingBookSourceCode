using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GetConSqlError
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=WRET-MOSY688YVW\\MRGLL;Database=master;uid=sa;pwd=;");//实例化数据库连接对象
            try
            {
                sqlcon.Open();//打开数据库连接
                MessageBox.Show("连接成功");
            }
            catch (SqlException ex)//捕获SQL异常信息
            {
                MessageBox.Show(ex.Message);//输出SQL异常信息
            }
        }
    }
}
