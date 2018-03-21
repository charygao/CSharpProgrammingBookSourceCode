class program
{
    static void Main()//入口方法
    {
        int Age = 20;//定义整型变量Age
        string Name = "小李";//定义字符串型变量Name
        test t = new test();//新建一个test类型的对象将此对象的引用交给变量t
        t.TestName = "会东";//设置所引用对象的属性
        //输出变量值
        System.Console.WriteLine("姓名：{0}  年龄：{1}  test姓名：{2}", Name, Age, t.TestName);
        System.Console.ReadLine();//等待回车继续
    }
}
class test
{
    public string TestName;//定义字符串型变是TestName
}