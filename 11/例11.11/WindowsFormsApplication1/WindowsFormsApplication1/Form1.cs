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
            this.Width = imageList1.Images.Count * 101;//设置窗体的宽
            this.Height = 120;//设置窗体的高
            for (int i = 0; i < imageList1.Images.Count; i++)//遍历ImageList的Images集合
            {
                PictureBox pb = new PictureBox();//创建PictureBox对象pb
                pb.Size = new Size(100, 100);//设置pb对象的宽和高
                pb.Location = new Point(i * 101, 0);//设置pb对象的位置
                pb.Image = imageList1.Images[i];//设置pb对象的图像
                Controls.Add(pb);//将pb对象加入控件树
            }
        }
    }
}
