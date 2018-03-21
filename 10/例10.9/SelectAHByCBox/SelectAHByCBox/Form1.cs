using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SelectAHByCBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)//遍历窗体中的控件
            {
                if (ctl.GetType().Name == "CheckBox")//判断控件类型是否是CheckBox
                {
                    CheckBox cbox = (CheckBox)ctl;//将遍历到的控件强制转换为CheckBox类型
                    cbox.AutoEllipsis = true;//设置文本过长时，显示…
                    cbox.CheckAlign = ContentAlignment.MiddleLeft;//设置文本居左对齐
                    cbox.Checked = false;//设置复选框不选中
                }
            }
        }
        //选择“篮球”复选框
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)//判断checkBox1是否选中
            {
                if (richTextBox1.Text == "")
                    richTextBox1.Text = checkBox1.Text;//为文本框赋值
                else
                    richTextBox1.Text += "、" + checkBox1.Text;//为文本框赋值
            }
        }
        //选择“足球”复选框
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)//判断checkBox2是否选中
            {
                if (richTextBox1.Text == "")
                    richTextBox1.Text = checkBox2.Text;//为文本框赋值
                else
                    richTextBox1.Text += "、" + checkBox2.Text;//为文本框赋值
            }
        }
        //选择“乒乓球”复选框
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)//判断checkBox3是否选中
            {
                if (richTextBox1.Text == "")
                    richTextBox1.Text = checkBox3.Text;//为文本框赋值
                else
                    richTextBox1.Text += "、" + checkBox3.Text;//为文本框赋值
            }
        }
        //选择“羽毛球”复选框
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)//判断checkBox4是否选中
            {
                if (richTextBox1.Text == "")
                    richTextBox1.Text = checkBox4.Text;//为文本框赋值
                else
                    richTextBox1.Text += "、" + checkBox4.Text;//为文本框赋值
            }
        }
    }
}
