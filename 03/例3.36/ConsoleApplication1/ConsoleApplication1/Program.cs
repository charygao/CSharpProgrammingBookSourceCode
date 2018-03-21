class program
{
    static void Main()//入口方法
    {
        System.Console.Title = "输入数字比大小";//设置控制台标题
        System.Console.WriteLine("请输入第一个数字：");//提示用户输入第一个数值
        double d = double.Parse(System.Console.ReadLine());//得到用户输入的第一个数值
        System.Console.WriteLine("请输入第二个数字：");//提示用户输入第二个数值
        double d2 = double.Parse(System.Console.ReadLine());//得到用户输入的第二个数值
        System.Console.Clear();//清空控制台内所有字符
        System.Console.WriteLine(d > d2 ? d.ToString() + " > " + d2.ToString() :
            d.ToString() + " < " + d2.ToString());//输出结果
        System.Console.ReadLine();//等待回车继续
    }
}