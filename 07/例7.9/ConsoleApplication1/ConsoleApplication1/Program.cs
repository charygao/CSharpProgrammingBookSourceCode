class program
{
    static void Main()//入口方法
    {
        //定义一维数组并初始化
        string[] Name = new string[5] { "a", "b", "c", "d", "e" };
        System.Collections.IList il = Name;//将数组对象转换为IList接口对象
        il.Clear();//调用接口对象的Clear()方法清空数组元素内数据
        System.Console.ReadLine();//等待回车继续
    }
}
