class program
{
    static void Main()//入口方法
    {
        //提示输入数值
        System.Console.Write("请输入数值：");
        //将输入的字符强制转换为整型
        int i = int.Parse(System.Console.ReadLine());
        if (i > 100)//判断整型数值是否大于100
        {//如果整型数值大于100则执行此复合语句
            System.Console.WriteLine("输入的值大于100");
        }
        else
        {//如果整型数值小于100则执行此复合语句
            System.Console.WriteLine("输入的值小于等于100");
        }
        //等待回车继续
        System.Console.ReadLine();
    }
}