using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DbColorBall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num1, num2, num3, num4, num5, num6, num7;//定义7个int变量，分别用来记录7个中奖号码
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "开 始")
            {
                button1.Text = "停 止";
                timer1.Start();//启动计时器
            }
            else if (button1.Text == "停 止")
            {
                button1.Text = "开 始";
                timer1.Stop();//停止计时器
                label1.Text = num1.ToString("00") + " " + num2.ToString("00") + " " + num3.ToString("00") + " " + num4.ToString("00") + " " + num5.ToString("00") + " " + num6.ToString("00") + " " + (num7-33).ToString("00");
            }
        }
        //绘制双色球
        private int DrawBall(int min,int max,Point pt)
        {
            Graphics g = this.CreateGraphics();//实例化绘图对象
            Random rnd = new Random();//实例化随机器对象
            int num = rnd.Next(min, max);//生成随机数字
            switch (num)//以生成的数字为条件，绘制双色球
            {
                case 1:
                    g.DrawImage(Image.FromFile("01.jpg"), pt);//在指定位置绘制双色球
                    break;
                case 2:
                    g.DrawImage(Image.FromFile("02.jpg"), pt);
                    break;
                case 3:
                    g.DrawImage(Image.FromFile("03.jpg"), pt);
                    break;
                case 4:
                    g.DrawImage(Image.FromFile("04.jpg"), pt);
                    break;
                case 5:
                    g.DrawImage(Image.FromFile("05.jpg"), pt);
                    break;
                case 6:
                    g.DrawImage(Image.FromFile("06.jpg"), pt);
                    break;
                case 7:
                    g.DrawImage(Image.FromFile("07.jpg"), pt);
                    break;
                case 8:
                    g.DrawImage(Image.FromFile("08.jpg"), pt);
                    break;
                case 9:
                    g.DrawImage(Image.FromFile("09.jpg"), pt);
                    break;
                case 10:
                    g.DrawImage(Image.FromFile("10.jpg"), pt);
                    break;
                case 11:
                    g.DrawImage(Image.FromFile("11.jpg"), pt);
                    break;
                case 12:
                    g.DrawImage(Image.FromFile("12.jpg"), pt);
                    break;
                case 13:
                    g.DrawImage(Image.FromFile("13.jpg"), pt);
                    break;
                case 14:
                    g.DrawImage(Image.FromFile("14.jpg"), pt);
                    break;
                case 15:
                    g.DrawImage(Image.FromFile("15.jpg"), pt);
                    break;
                case 16:
                    g.DrawImage(Image.FromFile("16.jpg"), pt);
                    break;
                case 17:
                    g.DrawImage(Image.FromFile("17.jpg"), pt);
                    break;
                case 18:
                    g.DrawImage(Image.FromFile("18.jpg"), pt);
                    break;
                case 19:
                    g.DrawImage(Image.FromFile("19.jpg"), pt);
                    break;
                case 20:
                    g.DrawImage(Image.FromFile("20.jpg"), pt);
                    break;
                case 21:
                    g.DrawImage(Image.FromFile("21.jpg"), pt);
                    break;
                case 22:
                    g.DrawImage(Image.FromFile("22.jpg"), pt);
                    break;
                case 23:
                    g.DrawImage(Image.FromFile("23.jpg"), pt);
                    break;
                case 24:
                    g.DrawImage(Image.FromFile("24.jpg"), pt);
                    break;
                case 25:
                    g.DrawImage(Image.FromFile("25.jpg"), pt);
                    break;
                case 26:
                    g.DrawImage(Image.FromFile("26.jpg"), pt);
                    break;
                case 27:
                    g.DrawImage(Image.FromFile("27.jpg"), pt);
                    break;
                case 28:
                    g.DrawImage(Image.FromFile("28.jpg"), pt);
                    break;
                case 29:
                    g.DrawImage(Image.FromFile("29.jpg"), pt);
                    break;
                case 30:
                    g.DrawImage(Image.FromFile("30.jpg"), pt);
                    break;
                case 31:
                    g.DrawImage(Image.FromFile("31.jpg"), pt);
                    break;
                case 32:
                    g.DrawImage(Image.FromFile("32.jpg"), pt);
                    break;
                case 33:
                    g.DrawImage(Image.FromFile("33.jpg"), pt);
                    break;
                case 34:
                    g.DrawImage(Image.FromFile("34.jpg"), pt);
                    break;
                case 35:
                    g.DrawImage(Image.FromFile("35.jpg"), pt);
                    break;
                case 36:
                    g.DrawImage(Image.FromFile("36.jpg"), pt);
                    break;
                case 37:
                    g.DrawImage(Image.FromFile("37.jpg"), pt);
                    break;
                case 38:
                    g.DrawImage(Image.FromFile("38.jpg"), pt);
                    break;
                case 39:
                    g.DrawImage(Image.FromFile("39.jpg"), pt);
                    break;
                case 40:
                    g.DrawImage(Image.FromFile("40.jpg"), pt);
                    break;
                case 41:
                    g.DrawImage(Image.FromFile("41.jpg"), pt);
                    break;
                case 42:
                    g.DrawImage(Image.FromFile("42.jpg"), pt);
                    break;
                case 43:
                    g.DrawImage(Image.FromFile("43.jpg"), pt);
                    break;
                case 44:
                    g.DrawImage(Image.FromFile("44.jpg"), pt);
                    break;
                case 45:
                    g.DrawImage(Image.FromFile("45.jpg"), pt);
                    break;
                case 46:
                    g.DrawImage(Image.FromFile("46.jpg"), pt);
                    break;
                case 47:
                    g.DrawImage(Image.FromFile("47.jpg"), pt);
                    break;
                case 48:
                    g.DrawImage(Image.FromFile("48.jpg"), pt);
                    break;
                case 49:
                    g.DrawImage(Image.FromFile("49.jpg"), pt);
                    break;
            }
            return num;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point pt1 = new Point(61, 117);//定义第1个数字的位置
            Point pt2 = new Point(93, 117);//定义第2个数字的位置
            Point pt3 = new Point(125, 117);//定义第3个数字的位置
            Point pt4 = new Point(157, 117);//定义第4个数字的位置
            Point pt5 = new Point(189, 117);//定义第5个数字的位置
            Point pt6 = new Point(221, 117);//定义第6个数字的位置
            Point pt7 = new Point(273, 117);//定义第7个数字的位置
            num1 = DrawBall(1, 33, pt1);//抽取第1个数字
            Thread.Sleep(5);//线程休眠5毫秒
            num2 = DrawBall(1, 33, pt2);//抽取第2个数字
            Thread.Sleep(5);//线程休眠5毫秒
            num3 = DrawBall(1, 33, pt3);//抽取第3个数字
            Thread.Sleep(5);//线程休眠5毫秒
            num4 = DrawBall(1, 33, pt4);//抽取第4个数字
            Thread.Sleep(5);//线程休眠5毫秒
            num5 = DrawBall(1, 33, pt5);//抽取第5个数字
            Thread.Sleep(5);//线程休眠5毫秒
            num6 = DrawBall(1, 33, pt6);//抽取第6个数字
            Thread.Sleep(5);//线程休眠5毫秒
            num7 = DrawBall(34, 50, pt7);//抽取第7个数字
        }
    }
}
