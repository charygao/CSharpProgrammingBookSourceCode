using System;
class program
{
    static void Main()//入口方法
    {
        Student student = new Student();//创建student对象
        student.Name = "会东";//设置Name属性值
        student.Age = 28;//设置Age属性值
        Console.WriteLine("姓名：{0}   年龄：{1}",
            student.Name, student.Age);//输出姓名和年龄
        student.Name = string.Empty;//设置Name属性值
        student.Age = -1;//设置Age属性值
        Console.WriteLine("姓名：{0}   年龄：{1}",
            student.Name, student.Age);//输出姓名和年龄
        Console.ReadLine();//等待回车继续
    }
}
class Student//定义Student类
{
    private string name;//定义name字段
    private int age;//定义age字段
    public int Age//定义Age属性
    {
        get { return age; }//定义get访问器
        set//定义set访问器
        {
            age = value > 0 ? value : age;//年龄大于0才可以正常赋值
        }
    }
    public string Name//定义Name属性
    {
        get { return name; }//定义get访问器
        set//定义set访问器
        {
            name = value.Length > 0 ? value : name;//姓名不是空字符串才可以正常赋值
        }
    }

}