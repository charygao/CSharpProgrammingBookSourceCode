class program
{
    static void Main()//入口方法
    {
        string[] s = new string[] { "a", "b", "c", "d", "e" };//定义数组
        string[] s2 = (string[])s.Clone();//对数组进行浅复制
        foreach (string ss in s2)
        {
            System.Console.Write(ss+" ");//遍历新数组的元素
        }
        System.Console.ReadLine();
    }
}