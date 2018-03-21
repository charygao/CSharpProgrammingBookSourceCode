using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LinqCreateXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strPath = "C:\\test.xml";//定义XML文件路径
            if (System.IO.File.Exists(strPath))//判断XML文件是否已经存在
            {
                System.IO.File.Delete(strPath);//删除已经存在的XML文件
            }
            XDocument doc = new XDocument(//实例化XML文档对象
        new XDeclaration("1.0", "utf-8", "yes"),//添加XML文件声明
        new XElement("词典",//实例化XML元素
            new XElement("编程词典", new XAttribute("编号", "001"),//为XML元素添加属性
                new XElement("名称", "C#编程词典"),
                new XElement("版本", "普及版"),
                new XElement("价格", "98元")),
            new XElement("编程词典", new XAttribute("编号", "002"),
                new XElement("名称", "C#编程词典"),
                new XElement("版本", "标准版"),
                new XElement("价格", "368元")),
            new XElement("编程词典", new XAttribute("编号", "003"),
                new XElement("名称", "C#编程词典"),
                new XElement("版本", "珍藏版"),
                new XElement("价格", "698元"))
            )
        );
            doc.Save(strPath);//保存XML文件
        }
    }
}
