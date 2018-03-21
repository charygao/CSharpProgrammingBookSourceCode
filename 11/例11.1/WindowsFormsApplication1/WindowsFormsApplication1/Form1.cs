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
            //弹出消息对话框，包涵确定按钮
            MessageBox.Show("消息信息", "标题");
            //弹出消息对话框，包涵确定按钮
            MessageBox.Show("消息信息", "标题", MessageBoxButtons.OK);
            //弹出消息对话框，包涵确定按钮和取消按钮
            MessageBox.Show("消息信息", "标题", MessageBoxButtons.OKCancel);
            //弹出消息对话框，包涵是和否按钮
            MessageBox.Show("消息信息", "标题", MessageBoxButtons.YesNo);
            //弹出消息对话框，包涵是、否和取消按钮
            MessageBox.Show("消息信息", "标题", MessageBoxButtons.YesNoCancel);
            //弹出消息对话框，包涵终上、重试和忽略按钮
            MessageBox.Show("消息信息", "标题", MessageBoxButtons.AbortRetryIgnore);
            //弹出消息对话框，包涵确定、取消按钮和提示图标
            MessageBox.Show("消息信息", "标题", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }
    }
}
