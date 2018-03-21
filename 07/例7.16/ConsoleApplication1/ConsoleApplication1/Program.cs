using System;
using System.Collections;
using System.Collections.Generic;
class program
{
    static void Main()//入口方法
    {
        Console.Title = "简单电话簿";//设置控制台标题
        ArrayList al = new ArrayList();//创建集合对象
        string name = string.Empty;//定义字符串变量，用于存放姓名
        string phone = string.Empty;//定义字符串变量，用于存放电话号码
        while (name != "q")//开始while循环
        {
            Console.Write("请输入姓名(f查看、q 退出)：");//提示用户输入姓名
            name = Console.ReadLine();//等待用户输入姓名
            if (name == "q") break;//判断是否退出
            if (name != "f")//判断是否查看电话簿
            {
                Console.Write("请输入电话：");//提示用户输入电话号码
                phone = Console.ReadLine();//等待用户输入电话号码
                al.Add(new student() { Name = name, Phone = phone });//向集合中添加信息
            }
            else
            {
                Console.Clear();//清空控制台
                Console.WriteLine("电话号码簿");//输出字符串
                foreach (object o in al)//遍历集合输出电话信息信息
                {
                    Console.WriteLine("姓名：{0}  电话：{1}", ((student)o).Name, ((student)o).Phone);
                }
                Console.WriteLine();//输出空行
            }
        }
        Console.Clear();//清空控制台
        Console.WriteLine("欢迎使用本系统！");//输出欢迎信息
        Console.ReadLine();//等待回车继续
    }
}
class student//定义student类
{
    public string Name;//定义Name字段
    public string Phone;//定义Phone字段
}