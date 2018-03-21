class program
{
    static void Main()
    {
        //新建引用类型实例obj1，并为引用类型字段赋值Name="小科"
        test obj1 = new test() { Name = "小科" };
        int v1 = 2;    //定义值类型变量v1并赋值为2
        //新建引用类型实例obj2，并为引用类型字段赋值Name="会东"
        test obj2 = new test() { Name = "会东" };
        int v2 = 5;    //定义值类型变量v2并赋值为5
        //输出值类型的值
        System.Console.WriteLine("v1={0} v2={1}", v1, v2);
        //输出引用类型Name字段的值
        System.Console.WriteLine("o1={0} o2={1}", obj1.Name, obj2.Name);

        v2 = v1;      //值类型变量进行赋值操作
        obj2 = obj1;  //引用类型变量进行赋值操作
        obj2.Name = "王小科"; //更改引用类型字段的值
        //输出值类型的值
        System.Console.WriteLine("v1={0} v2={1}", v1, v2);
        //输出引用类型Name字段的值
        System.Console.WriteLine("o1={0} o2={1}", obj1.Name, obj2.Name);

        v2 = 10;      //值类型变量进行赋值操作
        //引用类型变量得到一个新的实例
        obj2 = new test() { Name = "云峰" };
        //输出值类型的值
        System.Console.WriteLine("v1={0} v2={1}", v1, v2);
        //输出引用类型Name字段的值
        System.Console.WriteLine("o1={0} o2={1}", obj1.Name, obj2.Name);
        //等待回车继续
        System.Console.ReadLine();
    }
}

class test
{
    public string Name;
}