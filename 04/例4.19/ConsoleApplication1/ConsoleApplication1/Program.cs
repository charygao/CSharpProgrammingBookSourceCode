class program
{
    static void Main()//入口方法
    {
        for (int i = 1; i <= 100; i++)//开始for循环
        {
            if (i % 2 != 0) continue;//如果i为奇数则跳出本次循环
            System.Console.WriteLine(i);//输出i的值
        }
        System.Console.ReadLine();//等待回车继续
    }
}