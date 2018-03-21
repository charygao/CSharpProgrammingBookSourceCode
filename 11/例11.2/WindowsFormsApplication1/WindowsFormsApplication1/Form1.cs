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
            //返回用户点击按钮的枚举
            DialogResult dr = MessageBox.Show("消息信息", "标题", MessageBoxButtons.YesNoCancel);
            switch (dr)//使用switch语句判断用户点击了哪个按钮
            {
                case DialogResult.Cancel://如果按下了Cancel则执行下面的语句块
                    MessageBox.Show("按下了Cancel");
                    break;
                case DialogResult.No://如果按下了No则执行下面的语句块
                    MessageBox.Show("按下了No");
                    break;
                case DialogResult.Yes://如果按下了Yes则执行下面的语句块
                    MessageBox.Show("按下了Yes");
                    break;
            }
        }
    }
}
