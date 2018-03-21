using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HillSort
{
    class Program
    {
        #region 希尔排序算法的实现
        /// <summary>
        /// 希尔排序算法的实现
        /// </summary>
        /// <param name="arr">要排序的一维数组</param>
        public static void Sort(int[] arr)
        {
            int inc;
            for (inc = 1; inc <= arr.Length / 9; inc = 3 * inc + 1) ;
            for (; inc > 0; inc /= 3)
            {
                for (int i = inc + 1; i <= arr.Length; i += inc)
                {
                    int t = arr[i - 1];//记录当前值
                    int j = i;//定义下一个索引
                    while ((j > inc) && (arr[j - inc - 1] > t))
                    {
                        arr[j - 1] = arr[j - inc - 1];//交换数据
                        j -= inc;
                    }
                    arr[j - 1] = t;//将下一个元素值设置为当前值
                }
            }
        }
        #endregion
        static void Main(string[] args)
        {
            int[] arr = new int[] { 21, 4, 26, 18, 32, 54, 47, 9, 15, 48 };//定义一个一维数组，并赋值
            Console.Write("初始序列：");
            foreach (int n in arr)//循环遍历定义的一维数组，并输出其中的元素
                Console.Write("{0}", n + " ");
            Console.WriteLine();
            Program.Sort(arr);//调用自定义方法对数组进行排序
            Console.Write("排序后的序列：");
            foreach (int m in arr)
                Console.Write("{0} ", m);//输出排序后的数组元素
            Console.ReadLine();
        }
    }
}
