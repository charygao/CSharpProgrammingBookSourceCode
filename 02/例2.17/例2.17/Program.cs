class program
{
    const double pi = 3.1415926;//定义常量π的值为3.1415926
    static void Main()//入口方法
    {
        int r = 20;//圆的半径为20
        double zc = 2 * pi * r;//得到圆的周长
        System.Console.WriteLine("周长为：{0}", zc);//输出圆的周长
        System.Console.ReadLine();//等待回车继续
    }
}
