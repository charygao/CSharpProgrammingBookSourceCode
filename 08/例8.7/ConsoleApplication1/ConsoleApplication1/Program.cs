class program//定义program类
{
    static void Main()//入口方法
    {
        new Car();//创建Car对象
    }
}
class Car//定义Car类型
{
    public Car()//定义构造器
    {
        System.Console.WriteLine("构造器已经调用");//在控制台输出
    }
    ~Car()//定义析构器
    {
        System.Console.WriteLine("析构器已经调用");//在控制台输出
    }
}