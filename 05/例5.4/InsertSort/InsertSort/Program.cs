using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsertSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 20, 40, 90, 30, 80, 70, 50 };//定义一个一维数组，并赋值            
            Console.Write("初始序列：");
            foreach (int n in arr)//循环遍历定义的一维数组，并输出其中的元素
                Console.Write("{0}", n + " ");
            Console.WriteLine();
            for (int i = 0; i < arr.Length; ++i)//循环访问数组中的元素
            {
                int temp = arr[i];//定义一个int变量，并使用获得的数组元素值赋值
                int j = i;
                while ((j > 0) && (arr[j - 1] > temp))//判断数组中的元素是否大于获得的值
                {
                    arr[j] = arr[j - 1];//如果是，则将后一个元素的值提前
                    --j;
                }
                arr[j] = temp;//最后将int变量存储的值赋值给最后一个元素
            }
            Console.Write("排序后的序列：");
            foreach (int n in arr)//循环访问排序后的数组元素并输出
                Console.Write("{0}", n + " ");
            Console.ReadLine();
        }
    }
}
