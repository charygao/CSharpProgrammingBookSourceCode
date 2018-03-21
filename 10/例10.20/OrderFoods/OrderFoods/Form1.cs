using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderFoods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //定义菜单数组
            string[] strDishes = new string[] { "豆角炖肉","酸菜炖肉","小鸡炖蘑菇","大葱蘸酱","地三鲜","麻辣豆腐","蒜薹炒肉","鸡蛋炒韭菜","火爆大头菜"};
            for (int i = 0; i < strDishes.Length; i++)
            {
                lbSocure.Items.Add(strDishes[i]);//添加菜单列表
            }
        }

        private void button2_Click(object sender, EventArgs e)//全部添加到选择的项中
        {
            for (int i = 0; i < lbSocure.Items.Count; i++)
            {
                lbSocure.SelectedIndex=i;
                if (!lbChoose.Items.Contains(lbSocure.Text))//判断是否已经选择了该菜
                    lbChoose.Items.Add(lbSocure.SelectedItem.ToString());//添加选择的菜
                else
                    MessageBox.Show("您已经选择了该菜，请重新选择。");
            }
        }

        private void button3_Click(object sender, EventArgs e)//移除所有已经选择的菜
        {
            lbChoose.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)//单个添加到选择的项中
        {
            if (lbSocure.SelectedIndex != -1)
            {
                if (!lbChoose.Items.Contains(lbSocure.Text))//判断是否已经选择了该菜
                    lbChoose.Items.Add(lbSocure.SelectedItem.ToString());//添加选择的菜
                else
                    MessageBox.Show("您已经选择了该菜，请重新选择。");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lbChoose.SelectedIndex != -1)
            {
                lbChoose.Items.Remove(lbChoose.SelectedItem);//移除选中的菜
            }
        }
    }
}