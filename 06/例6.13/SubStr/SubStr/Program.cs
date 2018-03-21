using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubStr
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义一个字符串，用来存储文件全路径
            string strAllPath = "D:\\c# 编程词典(普及版)\\c# 编程词典(普及版).exe";
            string strPath = strAllPath.Substring(0, strAllPath.LastIndexOf("\\") + 1);//获取文件路径
            string strName = strAllPath.Substring(strAllPath.LastIndexOf("\\") + 1);//获取文件名
            Console.WriteLine("文件路径：" + strPath);//显示文件路径
            Console.WriteLine("文件名：" + strName);//显示文件名
            Console.ReadLine();
        }
    }
}
