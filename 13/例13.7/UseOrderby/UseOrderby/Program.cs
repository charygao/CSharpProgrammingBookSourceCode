using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseOrderby
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 3, 8, 6, 4, 1, 5, 7, 0, 9, 2 };//定义一个数组
            var value = from v in values
                        where v < 3 || v > 7//使用where子句指定查询条件
                        orderby v descending//使用orderby子句对查询结果进行排序
                        select v;
            Console.WriteLine("查询结果：");
            foreach (var i in value)//遍历查询结果
            {
                Console.Write(i + " ");//输出查询结果
            }
            Console.ReadLine();
        }
    }
}
