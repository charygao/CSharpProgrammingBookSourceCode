class program
{
    static void Main()//入口方法
    {
        for (int i = 1; i < 100; i++)//开始for循环
        {
            if (i > 3)//如果i的值大于3则退出循环体
            {
                break;
            }
            System.Console.WriteLine(i);//输出i的值
        }
        System.Console.ReadLine();//等待回车继续
    }
}