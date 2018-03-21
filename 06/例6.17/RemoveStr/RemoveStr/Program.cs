using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoveStr
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)//定义一个死循环，以便能够循环输入数据
            {
                Console.Write("请输入一个字符串：");
                string str1 = Console.ReadLine();//记录输入的字符串
                //声明一个字符串变量str2，并使用Remove方法从字符串str1的索引2处开始删除
                string str2 = str1.Remove(2);
                Console.WriteLine("第一次删除：" + str2);//输出字符串str2
                //声明一个字符串变量str3，并使用Remove方法从字符串str1的索引0处删除一个字符
                string str3 = str1.Remove(0, 1);
                Console.WriteLine("第二次删除：" + str3);//输出字符串str3
                Console.ReadLine();
            }
        }
    }
}
