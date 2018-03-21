using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareStr
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "C#编程宝典";//声明一个字符串str1
            string str2 = "C#编程词典";//声明一个字符串str2
            Console.WriteLine(String.Compare(str1, str2));//输出字符串str1与str2比较后的返回值
            Console.WriteLine(String.Compare(str1, str1));//输出字符串str1与str1比较后的返回值
            Console.WriteLine(String.Compare(str2, str1));//输出字符串str2与str1比较后的返回值
            Console.ReadLine();
        }
    }
}
