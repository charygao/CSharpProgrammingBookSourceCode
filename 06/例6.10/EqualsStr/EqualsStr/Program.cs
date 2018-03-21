using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EqualsStr
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "C#编程宝典";//声明一个字符串Str1 
            string str2 = "C#编程词典";//声明一个字符串str2
            Console.WriteLine("非静态方法比较：" + str1.Equals(str2));//用Equals方法比较字符串str1和str2
            Console.WriteLine("静态方法比较：" + string.Equals(str1, str2));//用Equals方法比较字符串str1和str2
            Console.ReadLine();
        }
    }
}
