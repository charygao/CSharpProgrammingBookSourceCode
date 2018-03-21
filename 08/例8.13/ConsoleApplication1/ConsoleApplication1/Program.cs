using System;
class program
{
    static void Main()//入口方法
    {
        Employee e = new Employee();//创建员工对象
        e.Name = "云峰";//定义字段的值
        e.timecard();//调用员工对象的timecard()方法
        Manager m = new Manager();//创建管理者对象
        m.Name = "会东";//定义字段的值
        m.timecard();//调用管理者对象的timecard()方法
        m.allot();//调用管理者对象的allot()方法
        System.Console.ReadLine();//等待回车继续
    }
}
class Employee//定义员工类
{
    public string Name;//定义字段

    public void timecard()//定义timecard()方法
    {
        Console.WriteLine("{0}已经考勤",Name);
    }
}
class Manager : Employee//定义管理者类继承于员工类
{
    public void allot()//定义allot()方法
    {
        Console.WriteLine("{0}正在分配任务", Name);
    }
}