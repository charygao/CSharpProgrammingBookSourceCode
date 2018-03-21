class program
{
    static void Main()//入口方法
    {
        string[] ss = new string[] { "a", "b", "c"};//建立字符串数组
        foreach (string s in ss)//开始遍历数组
        {
            System.Console.Write(s);//输出字符串
        }
        System.Console.ReadLine();//等待回车继续
    }
}