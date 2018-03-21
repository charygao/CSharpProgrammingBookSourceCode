class program
{
    static void Main()//入口方法
    {
        System.Console.Write("请输入1-10的整数：");//提示输入数字
        int i = int.Parse(System.Console.ReadLine());//得到整型数值
        switch (i)//使用switch多路分支判断
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 9:
                System.Console.WriteLine("是奇数");
                break;
            case 2:
            case 4:
            case 6:
            case 8:
            case 10:
                System.Console.WriteLine("是偶数");
                break;
            default:
                System.Console.WriteLine("不在计算范围内");
                break;
        }
        System.Console.ReadLine();
    }
}