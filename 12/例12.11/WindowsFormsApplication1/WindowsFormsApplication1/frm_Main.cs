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

        private void button1_Click(object sender, EventArgs e)
        {
            //调用datatier对象的Add()方法向数据库添加数据
            dt.Add(new Instance() { Name = txt_name_add.Text, phone = txt_phone_add.Text });
            dataGridView1.DataSource = dt.Select();//更新dataGridView1控件中的信息
            Clear();//清空TextBox控件中的文本
        }

        private datatier dt = new datatier();//定义datatier类型的私有字段

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt.Select();//更新dataGridView1控件中的信息
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            dt.Remove(txt_name_delete.Text);//调用datatier对象的Remove()方法，从数据库中删除数据
            dataGridView1.DataSource = dt.Select();//更新dataGridView1控件中的信息
            Clear();//清空TextBox控件中的文本
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //调用datatier对象的Update()方法，更改数据库中的信息
            dt.Update(new Instance() { Name = txt_name_update.Text, phone = txt_phone_update.Text });
            dataGridView1.DataSource = dt.Select();//更新dataGridView1控件中的信息
            Clear();//清空TextBox控件中的文本
        }

        private void Clear()
        {
            txt_name_add.Text = string.Empty;//清空添加姓名文本框中的文本内容
            txt_name_delete.Text = string.Empty;//清空删除姓名文本框中的文本内容
            txt_name_update.Text = string.Empty;//清空更改姓名文本框中的文本内容
            txt_phone_add.Text = string.Empty;//清空添加电话文本框中的文本内容
            txt_phone_update.Text = string.Empty;//清空修改电话文本框中的文本内容
        }
    }
}
