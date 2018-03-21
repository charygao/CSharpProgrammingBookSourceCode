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
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;//设置窗体宽度
            this.Height = Screen.AllScreens[0].Bounds.Height;//设置窗体高度
            this.Location = new Point(0, 0);//设置窗体出现的位置
            pb = new PictureBox();//创建PictureBox对象pb
            pb.Location = new Point(0, 0);//设置pb的位置
            pb.Width = this.Width;//设置pb的宽度
            pb.Height = this.Height;//设置pb的高度
            pb.Click += new EventHandler(pb_Click);//设置pb的点击事件
            Controls.Add(pb);//将pb加入到Controls集合中
            timer1.Enabled = true;//启动记时器
        }

        void pb_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }
        private int G_int_Count = 1;//定义记数器
        private PictureBox pb;//定义PictureBox控件
        private void timer1_Tick(object sender, EventArgs e)
        {
            Image image = Image.FromFile(Application.StartupPath +
                "\\" + G_int_Count.ToString() + ".jpg");//得到image对象
            pb.Image = image;//PictureBox对象得到image对象引用，开始显示图像
            G_int_Count = ++G_int_Count > 9 ? 1 : G_int_Count;//记数器开始记数
        }
    }
}
