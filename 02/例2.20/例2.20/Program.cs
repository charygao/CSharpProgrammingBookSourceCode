class program
{
    static void Main()//入口方法
    {
        Test t = new Test();//t变量得到Test类型的实例
        t.show();////调用t变量引用实例的show方法
        System.Console.ReadLine();
    }
}
class Test//定义Test类型
{
    public void show()//定义show方法
    {
        string Name = "会东";//设置局部变量Name
        System.Console.WriteLine("你好：{0}",Name);//输出局部变量的值
    }
}