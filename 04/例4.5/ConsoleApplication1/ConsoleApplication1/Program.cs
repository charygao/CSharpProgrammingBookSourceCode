class program
{
    static void Main()//入口方法
    {
        System.Boolean b = true;//定义布尔变量值
        switch (b)//使用switch多路分支判断
        {
            case true://如果布尔类型值为true则执行下面语句块
                System.Console.WriteLine("选择了是");
                break;
            case false://如果布尔类型值为false则执行下面语句块
                System.Console.WriteLine("选择了否");
                break;
        }
        System.Console.ReadLine();
    }
}