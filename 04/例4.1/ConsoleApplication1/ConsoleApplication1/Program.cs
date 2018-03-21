class program
{
    static void Main()//入口方法
    {
        //提示输入信息
        System.Console.Write("请输入数字(0为下雨)：");
        //得到输入的数值
        int i = int.Parse(System.Console.ReadLine());
        if (i == 0) //使用if语句判断
        {
            //如果输入的值为0则
            System.Console.WriteLine("出门要带伞");
        }
        else
        {
            //如果输入的值不为0则
            System.Console.WriteLine("出门不要带伞");
        }
        //等待回车继续
        System.Console.ReadLine();
    }
}