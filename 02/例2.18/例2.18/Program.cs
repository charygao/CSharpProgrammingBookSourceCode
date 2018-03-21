class Program
{
    static void Main()//入口方法
    {
        Test t = new Test(22);//变量t引用新建的test类型的实例
        t.show();//调用show方法在控制台输出Age字段的值
        System.Console.ReadLine();//等待回车继续
    }
}

class Test
{
    public Test(int age)//定义构造方法
    {
        this.Age = age;//在构造方法中设置只读字段的值
    }
    public readonly int Age;//定义只读字段
    public void show()//定义show方法
    {
        System.Console.WriteLine("年龄：{0}", Age);//输出Age字段的值
    }
}