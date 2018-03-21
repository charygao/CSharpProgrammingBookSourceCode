class program
{
    static void Main()//入口方法
    {
        int i = 1;//定义整型变量i的值为1
        do//开始执行循环体
        {
            if (i % 2 == 0)//判断i的值是否为偶数
            {
                System.Console.WriteLine(i);//输出i的值
            }
        } while (i++ < 100);//计算do while表达式的值
        System.Console.ReadLine();//等待回车继续
    }
}