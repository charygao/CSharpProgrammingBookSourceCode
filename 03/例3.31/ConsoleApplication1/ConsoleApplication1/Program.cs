class program
{
    static void Main()//入口方法
    {
        int i = 20;//定义整型变量i的值为20
        int j = 21;//定义整型变量j的值为21
        //使用三元运算符来判断，如果i大于j则返回i的值，如果i小于j则返回j的值
        int n = i > j ? i : j;
        System.Console.WriteLine("n={0}", n);//输出n的值
        System.Console.ReadLine();//等待回车继续
    }
}