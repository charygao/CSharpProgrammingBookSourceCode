class program
{
    static void Main()//入口方法
    {
        int i = 0;//定义整型变量i的值为0
        while (i++ < 100)//得到布尔表达式的值判断是否执行循环
        {
            if (i % 2 == 0)//如果i整除2则执行下面语句
            {
                System.Console.WriteLine(i);//输出i的值
            }
        }
        System.Console.ReadLine();//等待回车继续
    }
}