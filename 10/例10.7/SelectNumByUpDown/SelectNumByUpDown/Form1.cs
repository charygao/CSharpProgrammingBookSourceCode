using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SelectNumByUpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 1;//设置控件的最小值为1
            numericUpDown1.Maximum = 20;//设置控件的最大值为20
            //设置控件的DecimalPlaces属性，使控件中的数值的小数点后显示两位数
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = 1;//设置递增或递减的值
            numericUpDown1.InterceptArrowKeys = true;//设置用户可以通过向上、向下键选择值
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //实现当控件的值改变时，显示当前的值
            label2.Text = "选中的数值为：" + numericUpDown1.Value;
        }
    }
}
