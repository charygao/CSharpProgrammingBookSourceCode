using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseSBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = 698;//声明一个int类型变量Num并初始化为698
            //实例化一个StringBuilder类，并初始化为“明日科技”
            StringBuilder SBuilder = new StringBuilder("明日科技", 100);
            SBuilder.Append("》C#编程词典");//使用Append方法将字符串追加到SBuilder的末尾
            Console.WriteLine(SBuilder);//输出SBuilder
            //使用AppendFormat方法将字符串按照指定的格式追加到SBuilder的末尾
            SBuilder.AppendFormat("{0:C}", Num);
            Console.WriteLine(SBuilder);//输出SBuilder
            SBuilder.Insert(0, "软件：");//使用Insert方法将“软件：”追加到SBuilder的开头
            Console.WriteLine(SBuilder);//输出SBuilder
            SBuilder.Remove(14, SBuilder.Length - 14);//使用Remove方法从SBuilder中删除索引14以后的字符串
            Console.WriteLine(SBuilder);//输出SBuilder
            //使用Replace方法将“软件：”替换成“软件工程师必备”
            SBuilder.Replace("软件", "软件工程师必备");
            Console.WriteLine(SBuilder);//输出SBuilder
            Console.ReadLine();
        }
    }
}
