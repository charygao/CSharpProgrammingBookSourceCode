class program
{
    static void Main()//入口方法
    {
        Car car2 = new Car("奔驰");//使用一个参数的构造器创建对象
        System.Console.WriteLine(car2.Name);//输出对象字段的值
        Car car3 = new Car("宝马", "红色");//使用两个参数的构造器创建对象
        System.Console.WriteLine(car3.Name + " " + car3.Color);//输出对象字段的值
        System.Console.ReadLine();//等待回车继续
    }
}

class Car//定义汽车类
{
    public string Name;//定义字段
    public string Color;//定义字段
    public Car(string name) //定义一个参数的构造器
    {
        this.Name = name; 
    }
    public Car(string name, string color)//定义两个参数的构造器
    {
        this.Name = name;
        this.Color = color;
    }
}