class program
{
    static void Main()
    {
        //定义将要被拆分的数组
        string[] s1 = new string[] { "a", "b", "c", "d", "e", "f" };
        string[] s2 = new string[s1.Length-3];//定义第一个数组
        string[] s3 = new string[s1.Length - s2.Length];//定义第二个数组
        for (int i = 0; i < s2.Length; i++)
        {
            s2[i] = s1[i];//得到第一个数组
        }
        for (int i = 0; i < s3.Length; i++)
        {
            s3[i] = s1[i + s2.Length];//得到第二个数组
        }
        System.Console.Write("第一个数组内的元素：");
        foreach (string item in s2)
        {
            System.Console.Write(item + ",");//输出第一个数组的元素
        }
        System.Console.WriteLine();//换行
        System.Console.Write("第二个数组内的元素：");
        foreach (string item in s3)
        {
            System.Console.Write(item+",");//输出第二个数组的元素
        }
        System.Console.ReadLine();//按回车继续
    }
}