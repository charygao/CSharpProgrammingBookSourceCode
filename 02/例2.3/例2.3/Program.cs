class program
{
    static void Main()
    {
        byte byte_B = 255;                                       //设置byte_B最大值255
        System.Console.WriteLine("自加1之前的值：{0}", byte_B);  //输出byte_B的值
        byte_B++;                                                //byte_B的值自加1
        //输出byte_B的值，这时的值并不是我们期望的
        System.Console.WriteLine("自加1之后的值：{0}", byte_B);
        System.Console.ReadLine();                               //等待回车继续
    }
}
