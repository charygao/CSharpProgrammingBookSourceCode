using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopyToStr
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "C#编程宝典";//声明一个字符串变量str并初始化
            Console.WriteLine("原字符串：" + str);//输出原字符串
            char[] myChar = new char[4];//声明一个字符数组myChar
            //将字符串str从索引0开始的4个字符串复制到字符数组myChar中
            str.CopyTo(0, myChar, 0, 4);
            Console.Write("复制的字符串：");
            Console.Write(myChar);//输出字符数组中的内容
            Console.ReadLine();
        }
    }
}
