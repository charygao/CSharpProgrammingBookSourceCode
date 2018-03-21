using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CreateMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 子窗体1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();//实例化Form2
            frm.MdiParent = this;//设置MdiParent属性，将当前窗体作为父窗体
            frm.Show();//使用Show方法打开窗体
        }

        private void 子窗体2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();//实例化Form3
            frm.MdiParent = this;//设置MdiParent属性，将当前窗体作为父窗体
            frm.Show();//使用Show方法打开窗体
        }
    }
}
