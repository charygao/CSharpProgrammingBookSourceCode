using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UseLView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //设置listView1控件的View属性，设置样式
            listView1.View = View.SmallIcon;
            //为listView1建立两个组
            listView1.Groups.Add(new ListViewGroup("名称", HorizontalAlignment.Left));
            listView1.Groups.Add(new ListViewGroup("类别", HorizontalAlignment.Left));
            //向控件中添加项目
            listView1.Items.Add("明日科技");
            listView1.Items.Add("C#编程词典");
            listView1.Items.Add("C#编程宝典");
            listView1.Items.Add("公司");
            listView1.Items.Add("软件");
            listView1.Items.Add("图书");
            //将listView1控件中索引是0、1和2的项添加到第一个分组
            listView1.Items[0].Group = listView1.Groups[0];
            listView1.Items[1].Group = listView1.Groups[0];
            listView1.Items[2].Group = listView1.Groups[0];
            //将listView1控件中索引是3、4和5的项添加到第二个分组
            listView1.Items[3].Group = listView1.Groups[1];
            listView1.Items[4].Group = listView1.Groups[1];
            listView1.Items[5].Group = listView1.Groups[1];
        }
        //添加项
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")//判断文本框中是否输入数据
            {
                MessageBox.Show("项目不能为空");//如果没有输入数据则弹出提示
            }
            else
            {
                listView1.Items.Add(textBox1.Text.Trim());//使用Add方法向控件中添加数据
            }
        }
        //移除项
        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)//判断是否选择了要删除的项
            {
                MessageBox.Show("请选择要删除的项");//如果没有选择弹出提示
            }
            else
            {
                //使用RemoveAt方法移除选择的项目
                listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
                listView1.SelectedItems.Clear();//取消控件的选择
            }
        }
        //清空项
        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)//判断控件中是否存在项目
            {
                MessageBox.Show("项目中已经没有项目");//如果没有项目弹出提示
            }
            else
            {
                listView1.Items.Clear();//使用Clear方法移除所有项目
            }
        }
    }
}
