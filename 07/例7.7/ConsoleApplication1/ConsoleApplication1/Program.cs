class program
{
    static void Main()//入口方法
    {
        string[,] zuo = new string[5, 10];//定义二维数组
        for (int i = 0; i < 5; i++)//for循环开始
        {
            for (int j = 0; j < 10; j++)//for循环开始
            {
                zuo[i, j] = "【 空 】";//初始化二维数组
            }
        }
        //提示用户输入信息
        System.Console.Write("请输入坐位行号和列号(如：0,2)输入q键退出：");
        //接收用户输入信息
        string s = System.Console.ReadLine();
        while (s!="q")//开始售票
        {
            string[] ss=s.Split(',');//拆分字符串
            int one = int.Parse(ss[0]);//得到坐位行数
            int two = int.Parse(ss[1]);//得到坐位列数
            zuo[one, two] = "【已售】";//标记售出票状态
            System.Console.Clear();//清空控制台信息
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    System.Console.Write(zuo[i,j]);//重新输出售票信息
                }
                System.Console.WriteLine();//输出换行符
            }
            //提示用户输入信息
            System.Console.Write("请输入坐位行号和列号(如：0,2)输入q键退出：");
            s = System.Console.ReadLine();//等待下次信息输入
        }
    }
}