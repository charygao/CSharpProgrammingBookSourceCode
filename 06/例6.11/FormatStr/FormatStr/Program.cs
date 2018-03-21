using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormatStr
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "C#编程词典";//声明字符串str1
            string str2 = "编程好帮手";//声明字符串str2
            string newstr = String.Format("{0},{1}!!!", str1, str2);//格式化字符串
            Console.WriteLine(newstr);//输出新字符串
            Console.ReadLine();
        }
    }
}
