class program
{
    static void Main()//入口方法
    {
        int i = 2000000000;//定义整型变量i的值为20亿
        int i2 = 500000000;//定义整型变量i2的值为5亿
        long i3 = i + 0L + i2;//定义整型变量i3的值为i+i2的和
        System.Console.WriteLine(i3);//输出i3的值
        System.Console.ReadLine();//等待回车继续
    }
}