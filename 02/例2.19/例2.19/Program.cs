class program
{
    static void Main()//入口方法
    {
        Test t = new Test();//t变量得到Test类型的实例
        t.Name = "会东";//设置t变量引用实例的Name字段
        t.show();//调用t变量引用实例的show方法
        t.show2();//调用t变量引用实例的show方法
        System.Console.ReadLine();//等待回车继续
    }
}
class Test//定义Test类型
{
    public string Name;//定义全局变量

    public void show()//定义show方法
    {
        System.Console.WriteLine("姓名：{0}",Name);//输出全局变量
    }
    public void show2()//定义show2方法
    {
        System.Console.WriteLine("你好：{0}",Name);//输出全局变量
    }
}