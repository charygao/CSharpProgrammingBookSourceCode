class program
{
    static void Main()//入口方法
    {
        int i = 200;//定义整型变量并赋值
        object o = i;//对值类型装箱操作
        i = 100;//修改整型变量的值
        System.Console.Write(i);//输出整型变量的值
        System.Console.Write(o);//输出已装箱值类型的值
        System.Console.ReadLine();//等待回车继续
    }
}