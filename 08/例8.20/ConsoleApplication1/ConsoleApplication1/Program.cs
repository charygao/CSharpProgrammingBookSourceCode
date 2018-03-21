using System;
class program
{
    static void Main()//入口方法
    {
        Car c = new Car();//创建Car对象
        c.Name = "HongQi";//为Name字段赋值
        c.run();//执行Run方法
        NewCar nc = new NewCar();//创建NewCar对象
        nc.Name = "HongQi";//为Name字段赋值
        nc.run();//执行Run方法
        System.Console.ReadLine();//等待回车继续
    }
}
class Car//定义Car类
{
    private string name;//定义私有字段
    public string Name//定义属性
    {
        get { return name; }
        set { name = value.Length > 0 ? value : name; }
    }
    public virtual void run()//使用virtual关键字定义虚方法
    {
        Console.WriteLine("{0}汽车跑起来", name);
    }
}
class NewCar : Car//NewCar继承于Car
{
    public override void run()//使用override关键字重写基类虚方法
    {
        Console.WriteLine("崭新的{0}汽车跑起来", Name);
    }
}
