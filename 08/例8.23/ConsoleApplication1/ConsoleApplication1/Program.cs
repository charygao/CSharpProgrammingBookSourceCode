class program
{
    static void Main()//入口方法
    {
        Car c = new Car();//创建Car对象
        c.show();//调用Car对象的show()方法
        ICar ic = c;//将Car对象转换为ICar接口
        ic.show();//调用ICar接口对象的show()方法
        System.Console.ReadLine();//等待加车继续
    }
}
interface ICar//定义ICar接口
{
    void show();//定义接口中的方法
}
class Car : ICar//定义Car类继承于ICar接口
{
    public void show()//隐式实现接口show()方法
    {
        System.Console.Write("执行show()方法 ");
    }
}