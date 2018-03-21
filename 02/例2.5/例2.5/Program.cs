class program
{
    //入口方法
    static void Main()
    {
        //值3.33后面没有添加f或F，编译器会将这个值
        //理解为double类型，这里会抛出异常
        float v = 3.33;
        //输出值
        System.Console.WriteLine(v);
        //等待回车继续
        System.Console.ReadLine();
    }
}