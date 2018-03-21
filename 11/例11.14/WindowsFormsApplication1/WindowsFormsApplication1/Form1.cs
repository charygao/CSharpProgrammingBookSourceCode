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
            pb = new PictureBox();//创建PictureBox对象pb
            pb.Location = new Point(0, 0);//设置pb的初始位置
            pb.Width = this.ClientRectangle.Width;//设置pb的宽度
            pb.Height = this.ClientRectangle.Height;//设置pb的高度
            pb.SizeMode = PictureBoxSizeMode.StretchImage;//图像被拉伸或收缩以适合大小
            Controls.Add(pb);//将pb对象放入Controls集合中
            timer1.Enabled = true;//启用记时器
        }
        private PictureBox pb;//定义PictureBox类型字段pb
        private int G_int_Count = 1;//定义整型字段，用于记数
        private void timer1_Tick(object sender, EventArgs e)
        {
            Image image = Image.FromFile(Application.StartupPath
                + @"\" + G_int_Count.ToString() + ".bmp");//得到image对象
            pb.Image = image;//PictureBox对象得到image对象引用，开始显示图像
            G_int_Count = ++G_int_Count > 8 ? 1 : G_int_Count;//记数器开始记数
        }
    }
}
