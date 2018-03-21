class program
{
    static void Main()
    {
        test obj1;//新建test类型变量obj1
        obj1 = new test();//obj1引用一个新的test实例
        obj1.Name = "王小科";//设置obj1字段的值为"王小科"
        int v1 = 2;    //定义值类型变量v1并赋值为2
        //输出值类型的值
        System.Console.WriteLine("v1={0}", v1);
        //输出引用类型Name字段的值
        System.Console.WriteLine("obj1={0}", obj1.Name);
        //等待回车继续
        System.Console.ReadLine();
    }
}
class test//定义test类
{
    //定义类型的实例字段
    public string Name;
}


