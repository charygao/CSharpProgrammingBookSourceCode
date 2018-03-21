class program
{
    static void Main()//入口方法
    {
        Car c = new Car();//得到Car对象
        c.Run();//调用Car对象的Run方法
    }
}
class Car//声明Car类
{
    string Name;//声明Name字段
    string Color;//声明Color字段
    void Run()//声明Run方法
    {
        System.Console.WriteLine("Car 启动");
    }
    void Stop()//声明Stop方法
    {
        System.Console.WriteLine("Car 停止");
    }
}