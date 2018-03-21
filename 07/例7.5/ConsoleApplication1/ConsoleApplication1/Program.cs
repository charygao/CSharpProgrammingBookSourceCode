class program
{
    static void Main()//入口方法
    {
        string[,] Names = new string[6, 4];//创建数组对象
        for (int i = 0; i < 6; i++)//开始第一层for循环
        {
            for (int j = 0; j < 4; j++)//开始第二层for循环
            {
                //初始化二维数组中的元素
                Names[i, j] = "[" + i.ToString() + "," + j.ToString() + "]  ";
            }
        }
        for (int i = 0; i < 6; i++)//开始第一层for循环
        {
            for (int j = 0; j < 4; j++)//开始第二层for循环
            {
                //在控制台输出二维数组中的所有元素
                System.Console.Write(Names[i, j]);
            }
            System.Console.WriteLine();//输出换行符
        }
        System.Console.ReadLine();//等待回车继续
    }
}