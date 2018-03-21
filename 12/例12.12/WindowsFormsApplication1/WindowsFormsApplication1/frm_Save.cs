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
    public partial class frm_Save : Form
    {
        public frm_Save()
        {
            InitializeComponent();
        }
        //定义datatier类型字段dt
        private datatier dt = new datatier();

        private void button1_Click(object sender, EventArgs e)
        {
            //使用OpenFileDialog组件的Filter属性筛选文件
            openFileDialog1.Filter = "*.jpg|*.jpg|*.bmp|*.bmp";
            //调用OpenFileDialog组件的ShowDialog()方法打开文件对话框
            DialogResult dr= openFileDialog1.ShowDialog();
            if (dr==DialogResult.OK)//如果确定选择了文件，则继续向下执行
            {
                //跟据图像文件得到image对象
                Image image = Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.Image = image;//在PictureBox控件中显示此图像
                //创建内存流对象
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                //将image对象放入内存流中
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //调用内存流对象的ToArray()方法返回字节对象
                byte[] bt = ms.ToArray();
                //调用dt对象的Add()方法，将字节对象放入数据库
                dt.Add(bt);
            }
        }
    }
}
