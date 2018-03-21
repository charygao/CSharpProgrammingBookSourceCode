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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void 存储图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //关闭所有Mdi窗体
            CloseForm();
            //创建frm_Save子窗体对象
            frm_Save fs = new frm_Save();
            //设置子窗体的Mdi父窗体对象
            fs.MdiParent = this;
            //将子窗体最大化
            fs.WindowState = FormWindowState.Maximized;
            //显示子窗体
            fs.Show();
        }

        private void 取出图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //关闭所有Mdi窗体
            CloseForm();
            //创建frm_Get子窗体对象
            frm_Get fg = new frm_Get();
            //设置子窗体的Mdi父窗体对象
            fg.MdiParent = this;
            //将子窗体最大化
            fg.WindowState = FormWindowState.Maximized;
            //显示子窗体
            fg.Show();
        }

        private void CloseForm()
        {
            //使用循环遍历子窗体集合
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                //关闭子窗体集合中的每一个窗体
                this.MdiChildren[i].Close();
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //关闭主窗体
            this.Close();
        }
    }
}
