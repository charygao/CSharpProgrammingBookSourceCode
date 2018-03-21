class program
{
    static void Main()          //入口方法
    {
        colors c = colors.red;  //定义枚举结构对象
        switch (c)              //使用switch进行判断
        {
            case colors.red:    //如果c为color.red则输出“红色”
                System.Console.WriteLine("红色");
                break;
            case colors.green:  //如果c为color.red则输出“红色”
                System.Console.WriteLine("绿色");
                break;
            case colors.blue:   //如果c为color.red则输出“红色”
                System.Console.WriteLine("蓝色");
                break;
            default:
                break;
        }
                               //等待回车继续
        System.Console.ReadLine();
    }
}


enum colors                    //建立枚举类型
{
    red,                       //红色
    green,                     //绿色
    blue                       //蓝色
}