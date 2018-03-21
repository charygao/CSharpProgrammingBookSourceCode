using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LinqOperArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] intScores = { 45, 68, 80, 90, 75, 76, 32 };//定义int类型的一维数组
            //使用LINQ技术从数组中查找及格范围内的分数
            var score = from hgScroe in intScores
                        where hgScroe >= 60
                        orderby hgScroe ascending
                        select hgScroe;
            label1.Text = "及格的分数：";
            foreach (var v in score)//循环访问查询结果并显示
            {
                label1.Text += "  " + v.ToString();
            }
        }
    }
}
