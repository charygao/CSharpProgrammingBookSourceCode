using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SplitStr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一段文字：");//输入提示
            string strOld = Console.ReadLine();//记录输入的字符串
            string[] strNews = strOld.Split('。');//将输入的字符串根据指定标点符号分割
            string strNew = "";//定义一个新的字符串变量，用来存储分行后的字符串
            for (int i = 0; i < strNews.Length; i++)
            {
                if (strNew == "")//判断字符串是否有值
                    strNew = "  " + strNews[i].ToString();//记录分行后的第一段字符串
                else
                    strNew += "。\n  " + strNews[i].ToString();//记录字符串，并分行显示
            }
            Console.Write("\n新字符串：\n" + strNew);//显示新字符串
            Console.ReadLine();
        }
    }
}
