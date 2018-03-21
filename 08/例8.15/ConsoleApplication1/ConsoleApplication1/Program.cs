class program
{
    static void Main()//入口方法
    {
        B b = new B();//创建B类对象
        b.Name = "会东";//设置B类对象的Name字段
        b.Age = 29;//设置B类对象的Age字段
        A a = b;//B类对象隐式转换为A类
        System.Console.WriteLine(a.Name);//输出A类对象字段的值
        System.Console.ReadLine();//等待回车继续
    }
}
class A { public string Name;}//定义A类并定义字段Name
class B : A { public int Age;}//定义B类并继承于A类，定义字段Age