class program
{
    static void Main()//入口方法
    {
        bool a = true;//定义布尔变量a值为true
        bool b = false;//定义布尔变量b值为false
        bool c = true;//定义布尔变量c值为true
        bool e = a ^ c & b;//定义布变量e值为a^c&b表达式的结果
        System.Console.WriteLine(e);//输出布尔变量e的结果
        System.Console.ReadLine();//等待回车继续
    }
}