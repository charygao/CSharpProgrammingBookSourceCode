using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindMaxAndMin
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)//定义一个死循环，以便能够循环输入
            {
                Console.Write("请输出一组数（用,号隔开）：");
                string strNums = Console.ReadLine();//记录输入的一组数
                string[] Array_str = strNums.Split(',');//获取要进行遍历的一组数
                int var_Max = Convert.ToInt32(Array_str[0]);//记录数组中的第一个数
                int var_Min = Convert.ToInt32(Array_str[0]);//记录数组中的第一个数
                for (int i = 1; i < Array_str.Length; i++)//对数组进行遍历
                {
                    //获取最大的数值
                    var_Max = var_Max >= Convert.ToInt32(Array_str[i]) ? var_Max : Convert.ToInt32(Array_str[i]);
                    //获取最小的数值
                    var_Min = var_Min <= Convert.ToInt32(Array_str[i]) ? var_Min : Convert.ToInt32(Array_str[i]);
                }
                Console.WriteLine("最大值：" + var_Max);//显示最大值
                Console.WriteLine("最小值：" + var_Min);//显示最小值
            }
        }
    }
}
