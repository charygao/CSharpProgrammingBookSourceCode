using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //使用三元运算符为progressBar的Value值自加1
            progressBar1.Value = ++progressBar1.Value > 1000 - 1 ? 0 : progressBar1.Value;
            //显示载入百分比
            label2.Text = string.Format("已经载入{0}%", (int)(progressBar1.Value / 1000f * 100));
        }
    }
}
