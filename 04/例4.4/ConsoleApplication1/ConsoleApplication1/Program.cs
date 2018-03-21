class program
{
    static void Main()//入口方法
    {
        int i = 1;//定义整型数值
        switch (i)//使用switch多路分支判断
        {
            case 1://如果值为1则执行下面语句块
                System.Console.WriteLine("选择了1");
                break;
            case 2://如果值为2则执行下面语句块
                System.Console.WriteLine("选择了2");
                break;
            case 3://如果值为3则执行下面语句块
                System.Console.WriteLine("选择了3");
                break;
            default://以上值都不相符
                break;
        }
        System.Console.ReadLine();
    }
}