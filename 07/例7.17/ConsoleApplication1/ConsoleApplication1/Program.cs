using System;
class program
{
    static void Main()//入口方法
    {
        Console.Title = "简单客车售票记录";//设置控制台标题
        string[,] zuo = new string[9, 4];//定义二维数组
        for (int i = 0; i < 9; i++)//for循环开始
        {
            for (int j = 0; j < 4; j++)//for循环开始
            {
                zuo[i, j] = "【 空 】";//初始化二维数组
            }
        }
        string s = string.Empty;//定义字符串变量
        while (true)//开始售票
        {
            System.Console.Clear();//清空控制台信息
            Console.WriteLine("\n        简单客车售票记录" + "\n");//输出字符串
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    System.Console.Write(zuo[i, j]);//输出售票信息
                }
                System.Console.WriteLine();//输出换行符
            }
            //提示用户输入信息
            System.Console.Write("请输入坐位行号和列号(如：0,2)输入q键退出：");
            s = System.Console.ReadLine();//售票信息输入
            if (s == "q") break;//输入字符串"q"退出系统
            string[] ss = s.Split(',');//拆分字符串
            int one = int.Parse(ss[0]);//得到坐位行数
            int two = int.Parse(ss[1]);//得到坐位列数
            zuo[one, two] = "【已售】";//标记售出票状态
        }
    }
}