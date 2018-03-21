using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SelectDPartByCombox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;//设置控件的下拉框样式
            //定义职位数组
            string[] str = new string[] { "总经理", "副总经理", "人事部经理", "财务部经理", "部门经理", "普通员工" };
            comboBox1.DataSource = str;//指定控件的数据源
            comboBox1.SelectedIndex = 0;//指定控件中默认选择第一项
        }
        //触发comboBox1控件的选择项更改事件
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = "您选择的职位为：" + comboBox1.SelectedItem;//获取控件中的选中项
        }
    }
}
