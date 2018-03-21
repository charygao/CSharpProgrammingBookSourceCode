class program
{
    static void Main()//入口方法
    {
        int i = new program().add(10, 10);//从方法中得到计算结果
        System.Console.WriteLine("得到结果为：{0}",i);//输出计算结果
        System.Console.ReadLine();//等待回车继续
    }

    int add(int i, int j)//计算相加的方法
    {
        return i + j;//跳转到方法结束位置，并返回值
        System.Console.WriteLine("运算已经完成");//输出计算已经完成
    }
}
