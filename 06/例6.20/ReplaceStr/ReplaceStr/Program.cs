using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceStr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一段字符串：");//提示输入
            string strOld = Console.ReadLine();//记录输入的整段字符串
            Console.Write("请输入要替换的字符串：");//提示输入
            string strTemp = Console.ReadLine();//记录要替换的字符串
            Console.Write("请输入替换为的字符串：");//提示输入
            string strReplace = Console.ReadLine();//记录替换为的字符串
            string strNew = strOld.Replace(strTemp, strReplace);//替换字符串
            Console.WriteLine("原字符串：" + strOld);//输出原字符串
            Console.WriteLine("新字符串：" + strNew);//输出新字符串
            Console.ReadLine();
        }
    }
}
