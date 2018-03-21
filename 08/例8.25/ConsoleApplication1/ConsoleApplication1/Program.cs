using System;
using System.Collections.Generic;
class program
{
    static void Main()//入口方法
    {
        Car bmw = new BM();//基类对象引用子类实例，创建Car对象
        Car benz = new Benz();//基类对象引用子类实例，创建Car对象
        Car hongqi = new HongQi();//基类对象引用子类实例，创建Car对象
        List<Car> LCar = new List<Car>();//创建集合对象
        LCar.Add(bmw);//向集合添加Car对象
        LCar.Add(benz);//向集合添加Car对象
        LCar.Add(hongqi);//向集合添加Car对象
        foreach (Car c in LCar)//遍历集合
        {
            c.Run();//执行Run方法
        }
        Console.ReadLine();//等待回车继续
    }
}
abstract class Car//创建抽象类
{
    public abstract void Run();
}
class BM : Car//创建BM类继承于抽象类
{
    public override void Run()//重写抽象类Run方法
    {
        Console.WriteLine("宝马跑起来");
    }
}
class Benz : Car//创建Benz类继承于抽象类
{
    public override void Run()//重写抽象类Run方法
    {
        Console.WriteLine("奔驰跑起来");
    }
}
class HongQi : Car//创建HongQi类继承于抽象类
{
    public override void Run()//重写抽象类Run方法
    {
        Console.WriteLine("红旗跑起来");
    }
}