using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明一个数组并初始化
            string[] strLists = new string[] { "明日科技", "C#编程词典", "C#编程宝典" };
            //使用Lambda表达式查找数组中包含“C#”的字符串
            string[] strList = Array.FindAll(strLists, s => (s.IndexOf("C#") >= 0));
            //使用foreach语句遍历输出
            foreach (string str in strList)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
