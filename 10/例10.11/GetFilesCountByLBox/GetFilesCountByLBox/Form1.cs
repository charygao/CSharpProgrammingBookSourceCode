using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GetFilesCountByLBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //HorizontalScrollbar属性设置为true，使其能显示水平方向的滚动条
            listBox1.HorizontalScrollbar = true;
            //和ScrollAlwaysVisible属性设置为true，使其能显示垂直方向的滚动条
            listBox1.ScrollAlwaysVisible = true;
            //SelectionMode属性值为SelectionMode枚举成员MultiExtended，实现在控件中可以选择多项
            listBox1.SelectionMode = SelectionMode.MultiExtended;
        }
        //获取文件列表
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderbrowser = new FolderBrowserDialog();//实例化浏览文件夹对话框
            if (folderbrowser.ShowDialog() == DialogResult.OK)//判断是否选择了要浏览的文件夹
            {
                textBox1.Text = folderbrowser.SelectedPath;//获取选择的文件夹路径
                DirectoryInfo dinfo = new DirectoryInfo(textBox1.Text);//使用获取的文件夹路径实例化DirectoryInfo类对象
                FileSystemInfo[] finfo = dinfo.GetFileSystemInfos();//获取指定文件夹下的所有子文件夹及文件
                listBox1.Items.AddRange(finfo);//将获取到的子文件夹及文件添加到ListBox控件中
                label3.Text = "(" + listBox1.Items.Count + "项)";//获取ListBox控件中的项数
            }
        }
        //获取选择项
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = "您选择的是：";
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)//循环遍历选择的多项
            {
                label4.Text += listBox1.SelectedItems[i]+"、";//获取选择项
            }
        }
    }
}
