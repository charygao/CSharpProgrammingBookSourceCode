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
    public partial class frm_Get : Form
    {
        public frm_Get()
        {
            InitializeComponent();
        }
        //定义datatier类型私有字段dt
        private datatier dt = new datatier();

        //定义PictureBox类型私有字段G_pb_picturebox
        private PictureBox G_pb_picturebox;

        private void frm_Get_Load(object sender, EventArgs e)
        {
            //定义局部变量，用于计算图片在窗体中放置的位置
            int P_int_x = -1, P_int_y = 0;
            //遍历从数据库中得到的图片的集合
            foreach (Image image in GetImageList())
            {
                P_int_x++;//图片的横向位置自动加1
                //计算图片的纵向位置
                P_int_y = P_int_x > 9 ? ++P_int_y : P_int_y;
                //计算图片的横向位置
                P_int_x = P_int_x > 9 ? 0 : P_int_x;
                //创建PictureBox对象P_pb_picture
                PictureBox P_pb_picture = new PictureBox();
                //设置PictureBox对象的高
                P_pb_picture.Height = 50;
                //设置PictureBox对象的宽
                P_pb_picture.Width = 50;
                //设置PictureBox对象的横向位置
                P_pb_picture.Left = P_int_x * 51;
                //设置PictureBox对象的纵向位置
                P_pb_picture.Top = P_int_y * 51;
                //设置PictureBox对象的image对象
                P_pb_picture.Image = image;
                //设置PictureBox对象的图像显示方式
                P_pb_picture.SizeMode = PictureBoxSizeMode.StretchImage;
                //为PictureBox对象定义Click事件
                P_pb_picture.Click += new EventHandler(pb_Click);
                //将PictureBox对象放入窗体控件集合中
                Controls.Add(P_pb_picture);
            }
            //为PictureBox类型的私有字段G_pb_picturebox创建对象实例
            G_pb_picturebox = new PictureBox();
            //设置PictureBox对象的纵向位置
            G_pb_picturebox.Top = (P_int_y+1) * 51;
            //设置PictureBox对象的横向位置
            G_pb_picturebox.Left = 0;
            //设置PictureBox对象的宽
            G_pb_picturebox.Width = 500;
            //设置PictureBox对象的高
            G_pb_picturebox.Height = 365;
            ////设置PictureBox对象的图像显示方式
            G_pb_picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            //将PictureBox对象放入窗体控件集合中
            Controls.Add(G_pb_picturebox);
        }

        void pb_Click(object sender, EventArgs e)
        {
            //在PictureBox中显示图像
            G_pb_picturebox.Image = ((PictureBox)sender).Image;
        }

        private List<Image> GetImageList()
        {
            //定义image对象集合
            List<Image> li = new List<Image>();
            //调用dt对象的Get()方法返回byte[]的集合对象，然后遍历集合
            foreach (byte[] v in dt.Get())
            {
                //将byte[]对象作为参数，创建内存流对象
                System.IO.MemoryStream ms=new System.IO.MemoryStream(v);
                //调用Image类的FromStream()静态方法将内存流中的对象转换为image对象，并放入image集合中
                li.Add(Image.FromStream(ms));
            }
            //返回image集合
            return li;
        }
    }
}
