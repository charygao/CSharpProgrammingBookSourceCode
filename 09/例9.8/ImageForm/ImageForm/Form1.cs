using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bit;//声明位图对象
        private void Form1_Load(object sender, EventArgs e)
        {
            bit = new Bitmap("bg.png");//使用指定的图形实例化位图对象
            bit.MakeTransparent(Color.Blue);//设置图形透明
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage((Image)bit, new Point(0, 0));//窗体获得焦点时绘制图形
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//最小化窗体
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();//退出当前应用程序
        }
    }
}
