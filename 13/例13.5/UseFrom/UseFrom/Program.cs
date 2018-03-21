using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseFrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = { "明日科技","C#编程宝典","C#编程词典" };//定义一个字符串数组
            var value = from v in values//使用from子句查询
                        select v;
            Console.WriteLine("查询结果：");
            foreach (var v in value)//遍历查询结果
            {
                Console.Write(v.ToString() + "、");
            }
            Console.ReadLine();
        }
    }
}
