class program
{
    static void Main()//入口方法
    {
        new program().Play();//执行猜数字方法
    }

    void Play()//执行猜数字方法
    {
        System.Random r = new System.Random();//生成随机种子
        int j = r.Next(1, 100);//产生1至100随机的数字
        int i;//定义整型变量i
        int n = 1;//定义整型变量n
        System.Console.Write("请猜猜随机数是多少(1-100)：");//输出字符串
        do
        {
            i = int.Parse(System.Console.ReadLine());//得到用户输入数字
            if (i == j)//判断用户输入数字是否正确
            {
                System.Console.WriteLine("恭喜你!在第{0}次猜对了", n);
            }
            else
            {
                if (i < j)//判断用户输入数字与随机数的对比大小
                {
                    System.Console.WriteLine("第{0}次，猜小了", n);//输出猜小了
                    System.Console.Write("再试试：");
                }
                else
                {
                    System.Console.WriteLine("第{0}次，猜大了", n);//输出猜大了
                    System.Console.Write("再试试：");
                }
            }
            n++;//计数器加1
        } while (i != j);//直到猜对数字后退出
        System.Console.ReadLine();//等待回车继续
    }
}