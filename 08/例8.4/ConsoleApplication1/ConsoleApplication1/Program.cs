﻿class program
{
    static void Main()//入口方法
    {
        Test t = new Test();//调用Test类自动生成的的实例构造器
        t.Name = "编程宝典";
        System.Console.WriteLine(t.Name);//输出字段的字符串
        System.Console.ReadLine();//等待回车继续
    }
}
class Test//定义Test类
{
    public string Name;//定义Name字段
    public Test(string name)//定义实例构造器
    {
        this.Name = name;//为字段赋值
    }
}