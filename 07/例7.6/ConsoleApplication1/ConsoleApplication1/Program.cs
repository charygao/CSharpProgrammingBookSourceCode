class program
{
    static void Main()//入口方法
    {
        string[, ,] Names = new string[3, 4, 5];//定义三维数组
        for (int i = 0; i < 3; i++)//开始第一层for循环
        {
            for (int i2 = 0; i2 < 4; i2++)//开始第二层for循环
            {
                for (int i3 = 0; i3 < 5; i3++)//开始第三层for循环
                {
                    //初始化三维数组
                    Names[i,i2,i3]="["+i.ToString()+","+i2.ToString()+","+i3.ToString()+"]  ";
                }
            }
        }
        for (int i = 0; i < 3; i++)//开始第一层循环
			{
                for (int i2 = 0; i2 < 4; i2++)//开始第二层循环
                {
                    for (int i3 = 0; i3 < 5; i3++)//开始第三层循环
                    {
                        //在控制台输出三维数组
                        System.Console.Write(Names[i,i2,i3]);
                    }
                    System.Console.WriteLine();//输出换行符
                }
                System.Console.WriteLine();//输出换行符
			}
        System.Console.ReadLine();//等待回车继续
    }
}