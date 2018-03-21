using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PadStr
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "C#编程宝典";//声明一个字符串变量str1
            //声明一个字符串变量str2，并使用PadLeft方法在str1的左侧填充字符“《”
            string str2 = str1.PadLeft(str1.Length + 1, '《');
            //声明一个字符串变量str3，并使用PadLeft方法在str2右填充字符“》”
            string str3 = str2.PadRight(str2.Length + 1, '》');
            Console.WriteLine("填充字符串之前：" + str1);//输出字符串str1
            Console.WriteLine("填充字符串之后：" + str3);//输出字符串str2
            Console.ReadLine();
        }
    }
}
