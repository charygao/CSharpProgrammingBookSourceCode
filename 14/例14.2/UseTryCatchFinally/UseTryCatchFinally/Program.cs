using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseTryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "C#编程词典";//声明一个string类型的变量str
            object obj = str;//声明一个object类型的变量obj
            try//使用try…catch语句
            {
                int i = (int)obj;//将obj强制转换成int类型
            }
            catch (Exception ex)//获取异常
            {
                Console.WriteLine(ex.Message);//输出异常信息
            }
            finally//finally语句
            {
                Console.WriteLine("程序执行完毕...");//输出“程序执行完毕…”
            }
            Console.ReadLine();
        }
    }
}
