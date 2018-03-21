using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsertStr
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "编程";//声明字符串变量str1并赋值为“编程”
            Console.WriteLine("原来字符串：" + str1);//输出原字符串
            string str2;//声明字符串变量str2
            str2 = str1.Insert(0, "C#");//使用Insert方法向字符串str1中插入字符串
            string str3 = str2.Insert(4, "词典");//使用Insert方法向字符串str2插入字符串
            Console.WriteLine("插入后的新字符串：" + str3);//输出插入后的字符串
            Console.ReadLine();
        }
    }
}
