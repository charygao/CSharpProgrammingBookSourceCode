using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseLinqExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义一个字符串数组
            string[] strName = new string[] { "明日科技", "C#编程词典", "C#编程宝典", "视频学C#" };
            //定义LINQ查询表达式，从数组中查找长度小于6的所有项
            IEnumerable<string> selectQuery =
                from Name in strName
                where Name.Length < 6
                select Name;
            //执行LINQ查询，并输出结果
            foreach (string str in selectQuery)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
