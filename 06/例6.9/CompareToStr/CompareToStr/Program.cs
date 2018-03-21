using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareToStr
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "C#编程宝典";//声明一个字符串str1 
            string str2 = "C#编程词典";//声明一个字符串str2
            Console.WriteLine("字符串比较结果："+str1.CompareTo(str2));//输出str1与str2比较后的返回值
            Console.ReadLine();
        }
    }
}
