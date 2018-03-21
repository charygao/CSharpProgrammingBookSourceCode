class program
{
    static void Main()//入口方法
    {
        color c = color.blue;//定义枚举类型变量并赋值
        switch (c)//使用switch多路分支判断
        {
            case color.red://如果枚举值为red则执行下面语句块
                System.Console.WriteLine("是红色");
                break;
            case color.green://如果枚举值为red则执行下面语句块
                System.Console.WriteLine("是绿色");
                break;
            case color.blue://如果枚举值为red则执行下面语句块
                System.Console.WriteLine("是蓝色");
                break;
        }
        System.Console.ReadLine();//等待回车继续
    }
}

enum color : int//定义枚举结构
{
    red,//红色
    green,//绿色
    blue//蓝色
}