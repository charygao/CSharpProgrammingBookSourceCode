using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(//创建SqlDataAdapter对象
                "select * from tb_student",
                "server=WRET-MOSY688YVW\\MRGLL;database=db_test;Trusted_Connection=true");
            DataSet ds = new DataSet();//创建数据集DataSet对象
            sda.Fill(ds);//调用SqlDataAdapter对象的Fill()方法填充数据集
            dataGridView1.DataSource = ds.Tables[0];//将数据集绑定到DataGridView1控件
        }
    }
}
