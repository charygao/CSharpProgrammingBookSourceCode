class program
{
    static void Main()//入口方法
    {
        //定义二维数组并初始化
        string[,] Name = new string[2, 3] { { "a", "b", "c" }, { "d", "e", "f" } };
        //根据二维数组对象的索引更改数组元素的字符串
        Name[0, 0] = "aaa";
        //根据二维数组对象的索引获取数组元素的字符串
        string s = Name[0, 0];
        System.Console.WriteLine(s);//输出字符串
        System.Console.ReadLine();//等待回车继续
    }
}