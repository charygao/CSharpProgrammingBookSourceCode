class program
{
    //入口方法
    static void Main()
    {
        //建立结构对象
        stru s = new stru();
        //给结构对象的字段赋值
        s.x = 100;
        //输出结构字段的值
        System.Console.WriteLine(s.x);
        //等待回车继续
        System.Console.ReadLine();
    }
}

//定义结构
struct stru
{
    //定义字段
    public int x;
}