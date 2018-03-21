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
            folderBrowserDialog1.ShowNewFolderButton = true;//是否显示新建文件夹选项
            DialogResult dr = folderBrowserDialog1.ShowDialog();//显示选择文件夹对话框
            if (dr==DialogResult.OK)//确认是否按下确定按钮
            {
                MessageBox.Show(folderBrowserDialog1.SelectedPath,"选择的路径");//显示选择的路径
            }
        }
    }
}
