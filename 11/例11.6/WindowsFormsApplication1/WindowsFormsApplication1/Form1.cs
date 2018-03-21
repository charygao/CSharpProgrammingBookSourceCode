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
            DialogResult dr = fontDialog1.ShowDialog();//显示选择字体对话框
            if (dr==DialogResult.OK)//确定是否点击确定按钮
            {
                richTextBox1.SelectionFont = fontDialog1.Font;//设置richTextbox1中文本的字体
            }
        }
    }
}
