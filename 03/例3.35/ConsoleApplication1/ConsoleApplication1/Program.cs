class program
{
    static void Main()//入口方法
    {
        System.Console.Title = "简单计算器";//设置控制台标题
        System.Console.Write("输入第一个数字：");//提示用户输入第一个数值
        double d = double.Parse(System.Console.ReadLine());//得到第一个数值
        System.Console.Write("输入第二个数字：");//提示用户输入第二个数值
        double d2 = double.Parse(System.Console.ReadLine());//得到第二个数值
        System.Console.Write("输入第三个数字：");//提示用户输入第三个数值
        double d3 = double.Parse(System.Console.ReadLine());//得到第三个数值
        System.Console.Clear();//清空控制台内所有字符
        System.Console.WriteLine("{0} + {1} + {2} = {3}", d, d2, d3, d + d2 + d3);//输出计算结果
        System.Console.ReadLine();//等待回车继续
    }
}