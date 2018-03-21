using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try//使用try…catch语句
            {
                object obj = null;//声明一个object变量，初始值为null
                int num = (int)obj;//将object类型强制转换成int类型
            }
            catch (Exception ex)//捕获异常
            {
                Console.WriteLine("捕获异常：" + ex);//输出异常
            }
            Console.ReadLine();
        }
    }
}
