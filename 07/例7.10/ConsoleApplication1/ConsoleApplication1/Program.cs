class program
{
    static void Main()//入口方法
    {
        string[] s1 = new string[5] { "a", "b", "c", "d", "e" };//定义第一个数组
        string[] s2 = new string[2] { "f", "g" };//定义第二个数组
        string[] s3 = new string[s1.Length + s2.Length];//定义第三个数组
        for (int i = 0; i < s1.Length; i++)//开始for循环
        {
            s3[i] = s1[i];//将第一个数组的内容添加到第三个数组中
        }
        for (int i = 0; i < s2.Length; i++)//开始for循环
        {
            s3[i + s1.Length] = s2[i];//将第二个数组的内容添加到第三个数组中
        }

        foreach (var s in s3)//使用迭带器
        {
            System.Console.Write(s+",");//输出合并后数组的元素
        }
        System.Console.ReadLine();//等待回车继续
    }
}