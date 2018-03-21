using System;
class program//定义program类
{
    static void Main()//入口方法
    {
        Car c = new Car();//创建对象
        c.Run();//调用无参数的Run()方法
        c.Run("奔驰");//调用1个string参数的Run()方法
        c.Run("奔驰", "黑色");//调用两个string参数的Run()方法
        System.Console.ReadLine();//等待回车继续
    }
}
class Car//定义Car类
{
    public void Run()//定义无参数的Run方法
    {
        Console.WriteLine("汽车跑起来");//控制台输出
    }
    public void Run(string name)//定义1个string参数的Run方法
    {
        Console.WriteLine(name + " 汽车跑起来");//控制台输出
    }
    public void Run(string name, string color)//定义两个string参数的Run方法
    {
        Console.WriteLine(color + name + " 汽车跑起来");//控制台输出
    }
}