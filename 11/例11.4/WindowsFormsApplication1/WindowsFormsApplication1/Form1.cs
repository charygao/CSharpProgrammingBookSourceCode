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
            saveFileDialog1.Filter = "*.txt|*.txt";//设置保存文件的筛选条件，只保存文本文件
            DialogResult dr = saveFileDialog1.ShowDialog();//显示保存对话框
            if (dr==DialogResult.OK)//确认是否点击确定按钮
            {
                System.IO.File.WriteAllText(//将richTextBox1中的内容写入文本文件
                    saveFileDialog1.FileName, richTextBox1.Text,Encoding.Default);
            }
        }
    }
}
