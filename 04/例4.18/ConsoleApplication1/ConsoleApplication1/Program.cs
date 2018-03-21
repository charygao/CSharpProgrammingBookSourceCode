using System.Collections.Generic;
class program
{
    static void Main()//入口方法
    {
        List<string> ls = new List<string>() { "a", "b", "c" };//定义集合并赋值
        foreach (string s in ls)//使用foreach遍历集合
        {
            ls.Add("d");//更改正在遍历的集合
        }
    }
}