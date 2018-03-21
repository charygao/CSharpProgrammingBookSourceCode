class program
{
    static void Main()//入口方法
    {
        int i = 20;//定义整型变量i值为20
        int j = ++i + 10;//定义整型变量j值为变量i的值自加1，然后再加10
        System.Console.WriteLine("i={0}", i);//输出变量i的值
        System.Console.WriteLine("j={0}", j);//输出变量j的值
        System.Console.ReadLine();//等待回车继续
    }
}