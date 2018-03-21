class program
{
    static void Main()//入口方法
    {
        Car c = new Car("奥迪","黑色");//使用两个参数的构造器创建Car对象
        System.Console.WriteLine(c.Color+" "+c.Name);//输出Car对象的两个字段
        System.Console.ReadLine();//等待回车继续
    }
}
class Car//定义Car类
{
    public string Name;//定义字段
    public string Color;//定义字段
    public Car(string name)//定义一个参数的Car构造器
    {
        this.Name = name;
    }
    public Car(string name, string color)//定义两个string参数的Car构造器
        : this(name)//在调用本构造器前要先调用一个string参数的构造器
    {
        this.Color = color;
    }
}