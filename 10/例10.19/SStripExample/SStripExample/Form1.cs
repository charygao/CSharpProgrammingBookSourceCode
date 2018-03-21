using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SStripExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //在状态栏上显示系统的当前时间
            toolStripStatusLabel1.Text = "当前时间：" + DateTime.Now.ToLongTimeString();
        }
    }
}
