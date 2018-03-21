using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XPMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static Panel Var_Panel = new Panel();//实例化Panel对象，用来记录要操作的Panel控件
        private static PictureBox Var_Pict = new PictureBox();//实例化PictureBox对象，用来记录要操作的PictureBox控件
        private static int Var_i = 0;//定义一个标识，标识要操作的控件
        private Font Var_Font = new Font("宋体", 9);//实例化Font对象，用来记录控件的字体样式

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox_1.Image = null;//清空图片
            pictureBox_1.Image = Properties.Resources.朝上按钮;//加载指定的图片
            pictureBox_2.Image = null;
            pictureBox_2.Image = Properties.Resources.朝上按钮;
            pictureBox_3.Image = null;
            pictureBox_3.Image = Properties.Resources.朝上按钮;
            Var_Font = label_1.Font;//记录控件的字体样式
        }

        private void pictureBox_1_Click(object sender, EventArgs e)
        {
            Var_i = Convert.ToInt16(((PictureBox)sender).Tag.ToString());//获取PictureBox控件标识
            switch (Var_i)//根据标识获取要操作的控件
            {
                case 1:
                    {
                        Var_Panel = panel_Gut_1;//记录要操作的Panel控件
                        Var_Pict = pictureBox_1;//记录要操作的PictureBox控件
                        break;
                    }
                case 2:
                    {
                        Var_Panel = panel_Gut_2;
                        Var_Pict = pictureBox_2;
                        break;
                    }
                case 3:
                    {
                        Var_Panel = panel_Gut_3;
                        Var_Pict = pictureBox_3;
                        break;
                    }
            }
            //隐藏控件
            if (Convert.ToInt16(Var_Panel.Tag.ToString()) == 0 || Convert.ToInt16(Var_Panel.Tag.ToString()) == 2)
            {
                Var_Panel.Tag = 1;//隐藏标识
                Var_Pict.Image = null;//清空图片
                Var_Pict.Image = Properties.Resources.朝下按钮;//加载指定的图片
                Var_Panel.Visible = false;//隐藏控件
            }
            else
            {
                if (Convert.ToInt16(Var_Panel.Tag.ToString()) == 1)
                {
                    Var_Panel.Tag = 2;//显示标识
                    Var_Pict.Image = null;
                    Var_Pict.Image = Properties.Resources.朝上按钮;
                    Var_Panel.Visible = true;//显示控件
                }
            }
        }

        private void label_1_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Gray;//设置控件的字体颜色
            ((Label)sender).Font = new Font(Var_Font, Var_Font.Style | FontStyle.Underline);//设置控件的字体样式
        }

        private void label_1_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Black;//设置控件的字体颜色
            ((Label)sender).Font = new Font(Var_Font, Var_Font.Style);//设置控件的字体样式
        }
    }
}
