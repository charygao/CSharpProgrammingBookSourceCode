using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopyStr
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "C#编程宝典";//声明一个字符串变量str1并初始化
            string str2;//声明一个字符串变量str2
            //使用string类的Copy方法，复制字符串str1并赋值给str2
            str2 = string.Copy(str1);
            Console.WriteLine(str2);//输出字符串str2
            Console.ReadLine();
        }
    }
}
