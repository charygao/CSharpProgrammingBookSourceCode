class program
{
    static void Main()//入口方法
    {
        //提示输入出生日期
        System.Console.Write("请输入出生年：");
        //得到出生日期数值
        int i = int.Parse(System.Console.ReadLine());
        if (i > 1000 && i < 3000)
        {
            //开始判断属相
            if (i % 12 == 0)
            {
                System.Console.WriteLine("属相：猴");
            }
            if (i % 12 == 1)
            {
                System.Console.WriteLine("属相：鸡");
            }
            if (i % 12 == 2)
            {
                System.Console.WriteLine("属相：狗");
            }
            if (i % 12 == 3)
            {
                System.Console.WriteLine("属相：猪");
            }
            if (i % 12 == 4)
            {
                System.Console.WriteLine("属相：鼠");
            }
            if (i % 12 == 5)
            {
                System.Console.WriteLine("属相：牛");
            }
            if (i % 12 == 6)
            {
                System.Console.WriteLine("属相：虎");
            }
            if (i % 12 == 7)
            {
                System.Console.WriteLine("属相：兔");
            }
            if (i % 12 == 8)
            {
                System.Console.WriteLine("属相：龙");
            }
            if (i % 12 == 9)
            {
                System.Console.WriteLine("属相：蛇");
            }
            if (i % 12 == 10)
            {
                System.Console.WriteLine("属相：马");
            }
            if (i % 12 == 11)
            {
                System.Console.WriteLine("属相：羊");
            }
        }
        else
        {
            System.Console.WriteLine("对不起输入有误，不在计算范围内");
        }
        //等待回车继续
        System.Console.ReadLine();
    }
}
