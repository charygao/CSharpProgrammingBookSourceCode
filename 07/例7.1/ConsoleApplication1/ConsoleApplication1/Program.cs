class program
{
    static void Main()//入口方法
    {
        string[] Name;//定义数组类型变量Name
        Name = new string[200];//数组变量Name得到新的数组对象引用
        for (int i = 0; i < 200; i++)//开始for循环
        {
            Name[i] = i.ToString();//对数组元素进行赋值
        }
        System.Console.ReadLine();//等待回车继续
    }
}