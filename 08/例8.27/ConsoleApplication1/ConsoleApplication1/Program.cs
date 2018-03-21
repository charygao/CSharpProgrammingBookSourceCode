using System;
using System.Collections;
class program
{
    static void Main()//入口方法
    {
        IShape r = new Round();//创建IShape对象
        IShape s = new Square();//创建IShape对象
        Console.Write("请输入圆半径：");//提示用户输入圆半径
        r.r = double.Parse(System.Console.ReadLine());//等待用户输入信息
        Console.Write("请输入正方形边长：");//提示用户输入正方形边长
        s.r = double.Parse(System.Console.ReadLine());//等待用户输入信息
        Console.WriteLine("圆周长为：{0}  正方形周长为：{1}",
            r.Perimeter(), s.Perimeter());
        Console.ReadLine();//等待回车继续
    }
}
class Round : IShape//定义圆形类继承于IShape接口
{
    private double R;//定义私有字段
    public double Perimeter()//实现接口方法计算圆周长
    {
        return 2 * 3.1415926 * r;
    }
    public double r//实现接口属性
    {
        get//get访问器
        {
            return R;
        }
        set//set访问器
        {
            R = value;
        }
    }
}
class Square : IShape//定义正方形类继承于IShape接口
{
    private double R;//定义私有字段
    public double r//实现接口属性
    {
        get//get访问器
        {
            return R;
        }
        set//set访问器
        {
            R = value;
        }
    }
    public double Perimeter()//实现接口方法计算正方形周长
    {
        return R * 4;
    }
}

interface IShape//定义IShape接口
{
    double r { get; set; }//定义接口属性
    double Perimeter();//定义接口文法
}