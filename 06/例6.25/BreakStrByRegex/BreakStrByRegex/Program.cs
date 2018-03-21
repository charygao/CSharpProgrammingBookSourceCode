using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BreakStrByRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义要分解的字符串
            string str = "14:08:30 192.168.1.1 明日科技 14:08:40 192.168.0.1 编程词典 ";
            //定义要按指定格式进行分解的正则表达式
            Regex myRegex = new Regex(@"(?<time>(\d|\:)+)\s" + @"(?<ip>(\d|\.)+)\s" + @"(?<company>\S+)\s");
            MatchCollection myMatches = myRegex.Matches(str);//对字符串按指定格式进行分解
            string strNew = "";//记录分解后的字符串
            foreach (Match myMatch in myMatches)//循环遍历分解后的字符串
            {
                strNew += "\n  时间:" + myMatch.Groups["time"].ToString();//输出表示time的字符串
                strNew += "\n  地址:" + myMatch.Groups["ip"].ToString();//输出表示ip的字符串
                strNew += "\n  公司:" + myMatch.Groups["company"].ToString() + "\n";//输出表示company的字符串
            }
            Console.WriteLine(strNew);
            Console.ReadLine();
        }
    }
}
