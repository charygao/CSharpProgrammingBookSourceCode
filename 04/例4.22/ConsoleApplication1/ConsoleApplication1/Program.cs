class program
{
    static void Main()//入口方法
    {

        for (int i = 0; i < 100; i++)//第一层循环
        {
            for (int i2 = 0; i2 < 100; i2++)//第二层循环
            {
                for (int i3 = 0; i3 < 100; i3++)//第三层循环
                {
                    if ( i * i2 * i3>1000000)//如果条件满足使用goto语句跳到labe标签处
                    {
                        goto labe;
                    }
                }
            }
        }
    labe://labe标签
        System.Console.WriteLine("已经跳出了嵌套循环");//输出字符串
        System.Console.ReadLine();//等待回车继续
    }
}