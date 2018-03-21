using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormatDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;//获取系统当前日期
            string strDate = String.Format("{0:D}", dt);//格式化成短日期格式
            Console.WriteLine("今天的日期为：" + strDate);//输出格式化后的日期
            Console.ReadLine();
        }
    }
}
