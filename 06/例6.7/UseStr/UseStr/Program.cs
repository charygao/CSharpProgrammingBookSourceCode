using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseStr
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "C#编程词典";//声明一个字符串变量str
            char char1 = str[2];//获取字符串str的第3个字符
            char char2 = str[3];//获取字符串str的第4个字符
            Console.WriteLine("字符串str中的第3个字符是：{0}", char1);
            Console.WriteLine("字符串str中的第4个字符是：{0}", char2);
            Console.ReadLine();
        }
    }
}
