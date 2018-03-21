class program
{
    static void Main()//入口方法
    {
        Test t = new Test();//t变量得到Test类型的实例
        t.show();////调用t变量引用实例的show方法
        System.Console.ReadLine();
    }
}
class Test//定义Test类型
{
    public void show()//定义show方法
    {
        for (int i = 0; i < 5; i++)//for循环体
        {
            System.Console.WriteLine(i.ToString());//循环输出循环体内i变量的值
        }
    }
}
