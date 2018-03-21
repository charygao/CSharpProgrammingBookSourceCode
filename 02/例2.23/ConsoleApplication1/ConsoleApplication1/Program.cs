class program
{
    static void Main()//入口方法
    {
        System.Console.Write("请输入长方形的长：");//提示用户输入长方形长
        float c = float.Parse(System.Console.ReadLine());//将用户输入数值转换为单精度浮点型
        System.Console.Write("请输入长方形的宽：");//提示用户输入长方形宽
        float k = float.Parse(System.Console.ReadLine());//将用户输入数值转换为单精度浮点型
        double mj = c * k;//计算长方形面积
        System.Console.WriteLine("长方形的面积为：{0}", mj);//在控制台输出长方形面积
        System.Console.ReadLine();//等待回车继续
    }
}