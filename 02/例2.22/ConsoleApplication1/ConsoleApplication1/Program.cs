class program
{
    static void Main()//入口方法
    {
        const float pi = 3.1415926f;//将圆周率定义为常量值
        System.Console.Write("请输入圆半径：");//提示用户输入圆半径
        float r = float.Parse(System.Console.ReadLine());//将用户输入数值转换为单精度浮点型
        double mj = pi * r * r;//计算圆面积
        System.Console.WriteLine("圆的面积为：{0}", mj);//在控制台输出圆面积
        System.Console.ReadLine();//等待回车继续
    }
}