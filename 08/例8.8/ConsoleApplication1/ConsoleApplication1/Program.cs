using System;
class program//定义类
{
    static void Main()//入口方法
    {
        new Car("奔驰", "黑色").Run();//创建对象并调用Run方法
        System.Console.ReadLine();//等待回车继续
    }
}
class Car//定义汽车类
{
    public Car(string name, string color)//定义构造器
    {
        this.Name = name;//初始化字段
        this.Color = color;//初始化字段
    }
    public string Name;//定义字段
    public string Color;//定义字段
    public void Run()//定义方法
    {
        Console.WriteLine("{0}{1} 跑起来", Color, Name);//控制台输出
    }
}