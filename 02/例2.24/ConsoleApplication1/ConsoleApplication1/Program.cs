class program
{
    static void Main()//入口方法
    {
        System.Console.Write("输入员工每日工资：");//提示用户输入员工每日工资
        float f = float.Parse(System.Console.ReadLine());//将用户输入数值转换为单精度浮点型
        System.Console.Write("输入本月工作多少天：");//提示用户输入员工工作天数
        int t = int.Parse(System.Console.ReadLine());//将用户输入数值转换为单精度浮点型
        float z = f * t;//计算月工资
        System.Console.WriteLine("员工月工资是：{0}",z);//在控制台输出月工资
        System.Console.ReadLine();//等待回车继续
    }
}