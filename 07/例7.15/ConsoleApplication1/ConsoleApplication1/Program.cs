using System;
using System.Collections;
class program
{
    static void Main()//入口方法
    {
        ArrayList al = new ArrayList();//创建集合对象
        al.Add("a");//向ArrayList对象添加数据
        al.Add("b");//向ArrayList对象添加数据
        al.Add("c");//向ArrayList对象添加数据
        al.Remove("c");//从ArrayList对象中删除数据
        al[0] = "aa";//按索引修改ArrayList对象中的数据
        al[al.IndexOf("aa")] = "aaa";//按索引修改ArrayList对象中的数据
        int i = al.IndexOf("b");//在集合中查找指定字符串的索引
        foreach (object o in al)//遍历集合
        {
            Console.Write(o);//输出集合中的元素
        }
        Console.ReadLine();//等待回车继续
    }
}