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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.jpg|*.jpg|*.bmp|*.bmp";//设置筛选列表
            DialogResult dr = openFileDialog1.ShowDialog();//显示打开文件对话框
            if (dr==DialogResult.OK)//确认已经点击确定按钮
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);//添加将要显示的图像
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;//图像被拉伸或收缩以适合PictureBox的大小
            }
        }
    }
}
