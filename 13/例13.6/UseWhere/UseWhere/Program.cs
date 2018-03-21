using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseWhere
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };//定义一个数组
            var value = from v in values
                        where v % 2 == 0 && v > 2//使用where子句指定查询条件
                        select v;
            Console.WriteLine("查询结果：");
            foreach (var v in value)//遍历查询结果
            {
                Console.Write(v.ToString() + " ");//输出查询到的结果
            }
            Console.ReadLine();
        }
    }
}
