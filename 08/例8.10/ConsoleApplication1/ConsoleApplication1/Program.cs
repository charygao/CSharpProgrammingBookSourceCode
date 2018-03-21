class program
{
    static void Main()//入口方法
    {
        Student student = new Student();//创建student对象
        student.SetAge(25);//使用SetAge()方法更改student对象的状态
        System.Console.WriteLine(student.GetAge());//输出student对象的状态
        student.SetAge(1000);//使用SetAge()方法更改student对象的状态(不成功)
        System.Console.ReadLine();//等待回车继续
    }
}
class Student//定义Student类
{
    private int Age;//定义字段
    public int GetAge()//定义GetAge()方法
    {
        return Age;
    }
    public void SetAge(int age)//定义SetAge()方法
    {
        if (age > 0 && age < 1000)//如果年龄在规定范围内则进行赋值
        {
            this.Age = age;
        }
        else//如果年龄不在规定范围内则提示错误
        {
            System.Console.WriteLine("年龄错误！");
        }
    }
}