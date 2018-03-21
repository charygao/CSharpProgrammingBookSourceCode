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
            timer1.Enabled = true;//启动timer1记时器
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;//启动timer2记时器
            timer1.Enabled = false;//停上timer1记时器            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;//停止Timer1记时器
        }

        private List<Point> L_Point = new List<Point>();//泛型集合，用于记录鼠标移动坐标
        private int G_int_Count;//用于播放鼠标移动的记数器

        private void timer1_Tick(object sender, EventArgs e)
        {
            L_Point.Add(Cursor.Position);//记录鼠标移动坐标
            timer1.Enabled = L_Point.Count < 10000000;//如果集合中元素过多会停止记录
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (G_int_Count == L_Point.Count - 1)//如果计数器等于集合元素的数量则执行下面代码
            {
                L_Point.Clear();//清空集合内的坐标信息
                timer2.Enabled = false;//停止timer2记时器
                G_int_Count = 0;//清空记数器
                return;//跳转到方法结束
            }
            Cursor.Position = L_Point[G_int_Count];//播放鼠标移动坐标
            G_int_Count++;//计数器自加1
        }
    }
}
