class program
{
    static void Main()
    {
        int i = 1000000000;//定义整型变量i的值为10亿
        checked//checked关键字
        {
            long L = i * 3;//如果这里出现溢出会被抛出异常
            System.Console.WriteLine(L);//输出长整型变量l的值
        }
        System.Console.ReadLine();//等待回车继续
    }
}
