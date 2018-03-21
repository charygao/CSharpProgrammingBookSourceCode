class program
{
    static void Main()//入口方法
    {
        string[] Name = new string[200];//定义字符串数组，元素个数为200
        for (int i = 0; i < 200; i++)//开始循环
        {
            Name[i] = i.ToString();//初始化数组每一个元素
        }
        foreach (string s in Name)//开始循环
        {
            System.Console.Write(s + ",");//在控制台输出数组的每一个元素
        }
        System.Console.ReadLine();//等待回车继续
    }
}
