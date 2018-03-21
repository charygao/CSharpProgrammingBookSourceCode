class program
{
    static void Main()//入口方法
    {
        //定义一维数组并初始化
        string[] Name = new string[5] { "a", "b", "c", "d", "e" };
        //使用for循环
        for (int i = 0; i < 5; i++)
        {
            Name[i] = null;//清空数组元素内容
        }
        System.Console.ReadLine();//等待回车继续
    }
}