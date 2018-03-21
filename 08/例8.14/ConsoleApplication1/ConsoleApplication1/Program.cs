class program
{
    static void Main()//入口方法
    {
        byte b = 10;//定义byte类型变量并赋值
        short s = b;//byte类型隐式转换为short类型
        int i = b;//short类型隐式转换为int类型
        long l = i;//int类型隐式转换为long类型
        float f = l;//long类型隐式转换为float类型
        double d = f;//float类型隐式转换为double类型
        System.Console.WriteLine(d);//输出变量d的值
        System.Console.ReadLine();//等待回车继续
    }
}