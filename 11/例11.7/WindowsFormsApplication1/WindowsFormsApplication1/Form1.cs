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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();//显示选择文字颜色对话框
            if (dr==DialogResult.OK)//确认是否按下确定按钮
            {
                richTextBox1.SelectionColor = colorDialog1.Color;//设置richTextbox1中文字颜色
            }
        }
    }
}
