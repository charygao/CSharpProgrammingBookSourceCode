using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UseLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("楷体", 12);//设置label1控件的字体
            label1.Text = "明日科技";//设置label1控件显示的文字
            label2.ForeColor = Color.Red;//设置label2控件的字体颜色
            label2.Text = "C#编程词典";//设置label2控件显示的文字
        }
    }
}
