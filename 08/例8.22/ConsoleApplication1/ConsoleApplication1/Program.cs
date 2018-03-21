class program
{
    static void Main()//入口方法
    {
        Car c = new Car();//创建Car对象
        c.Color = "黑色";//为Color属性赋值
        c.Run();//执行Run方法
        c.Stop();//执行Stop方法
        System.Console.ReadLine();//等待回车继续
    }
}
interface ICar//定义ICar接口
{
    void Run();
    void Stop();
}
interface ICarColor//定义ICarColor接口
{
    string Color { get; set; }
}
class Car : ICar, ICarColor//定义Car类并继承了多个接口
{
    private string color;//定义私有字段
    public string Color//实现接口属性
    {
        get
        {
            return color;
        }
        set
        {
            color = value;
        }
    }
    public void Run()//实现接口方法
    {
        System.Console.WriteLine("{0}汽车跑起来", color);
    }
    public void Stop()//实现接口方法
    {
        System.Console.WriteLine("{0}汽车停下来", color);
    }
}