class program
{
    static void Main()//入口方法
    {
        System.Random rd = new System.Random();//创建随机对象
        System.Console.Title = "彩色控制台";//设置控制台标题
        while (true)//开始无限循环
        {
            System.Console.BackgroundColor = (System.ConsoleColor)rd.Next(9, 15);//生成随机背景颜色
            System.Console.ForegroundColor = (System.ConsoleColor)rd.Next(9, 15);//生成随机文字颜色
            System.Console.Clear();//清空控制台
            for (int i = 0; i < 100; i++)//开始for循环
            {
                System.Console.Write("《编程宝典》    ");//输出文字
            }
            System.Threading.Thread.Sleep(1000);//等待1秒钟
        }
    }
}