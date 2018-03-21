using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UseBtn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor=Color.Orange;//设置背景颜色
            button1.FlatStyle = FlatStyle.Flat;//设置显示外观
            button1.Font = new Font("宋体", 9);//设置字体及大小
            button1.Text = "确定";//设置显示文本
            button1.TextAlign = ContentAlignment.MiddleCenter;//设置文本居中显示
        }
        //触发button1控件的Click单击事件
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "您输入的文字为："+textBox1.Text;//显示文本框中的输入
        }
    }
}
