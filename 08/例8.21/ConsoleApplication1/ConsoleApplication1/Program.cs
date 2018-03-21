class program
{
    static void Main()//入口方法
    {
        Car c = new BM();//创建BM对象
        c.Name = "宝马";//为Name字段赋值
        c.Color = "红色";//为Color属性赋值
        c.show();//执行show()方法
        c.Run();//执行Run()方法
        c.Stop();//执行Stop()方法
        System.Console.ReadLine();//等待回车继续
    }
}
public abstract class Car//定义Car抽象类
{
    public string Name;//定义Name字段
    public void show()//定义show()方法
    {
        System.Console.WriteLine(Name);
    }
    public abstract string Color { get; set; }//定义抽象属性Color
    public abstract void Run();//定义Run抽象方法
    public abstract void Stop();//定义Stop抽象方法
}
public class BM : Car//定义BM类继承于Car抽象类
{
    private string color;//定义color私有字段
    public override string Color//实现抽象类属性
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
    public override void Run()//实现抽象类的抽象方法Run()
    {
        System.Console.WriteLine("{0}{1} 跑起来", color, Name);
    }
    public override void Stop()//实现抽象类的抽象方法Stop()
    {
        System.Console.WriteLine("{0}{1} 停下来", color, Name);
    }
}