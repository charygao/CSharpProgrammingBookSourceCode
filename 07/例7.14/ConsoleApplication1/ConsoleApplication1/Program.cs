class program
{
    static void Main()//入口方法
    {
        string[] s = new string[] { "a", "b", "c", "d", "e" };//定义数组
        int i = System.Array.IndexOf(s, "c");//使用System.Array类的静态方法查找数组中字符串的索引
        System.Console.WriteLine(i);//输出索引
        System.Console.ReadLine();//等待回车继续
    }
}