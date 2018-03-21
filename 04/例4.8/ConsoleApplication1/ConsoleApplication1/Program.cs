class program
{
    static void Main()//入口方法
    {
        //提示输入出生日期
        System.Console.Write("请输入出生年：");
        //得到出生日期数值
        int i = int.Parse(System.Console.ReadLine());
        switch (i % 12)//使用switch多路分支判断
        {
            case 0:
                System.Console.WriteLine("属相：猴");
                break;
            case 1:
                System.Console.WriteLine("属相：鸡");
                break;
            case 2:
                System.Console.WriteLine("属相：狗");
                break;
            case 3:
                System.Console.WriteLine("属相：猪");
                break;
            case 4:
                System.Console.WriteLine("属相：鼠");
                break;
            case 5:
                System.Console.WriteLine("属相：牛");
                break;
            case 6:
                System.Console.WriteLine("属相：虎");
                break;
            case 7:
                System.Console.WriteLine("属相：兔");
                break;
            case 8:
                System.Console.WriteLine("属相：龙");
                break;
            case 9:
                System.Console.WriteLine("属相：蛇");
                break;
            case 10:
                System.Console.WriteLine("属相：马");
                break;
            case 11:
                System.Console.WriteLine("属相：羊");
                break;
        }
        //等待回车继续
        System.Console.ReadLine();
    }
}