class program
{
    static void Main()//入口方法
    {
        int i = 100;//定义int类型并赋值
        byte b = (byte)i;//将int类型变量显示转换为byte类型
        byte b2 = System.Convert.ToByte(i);//将int类型变量显示转换为byte类型
        byte b3 = byte.Parse("123");//将字符串转换为byte类型数值
        System.Console.WriteLine(b2);//输出byte类型变量的值
        System.Console.ReadLine();//等待回车继续
    }
}