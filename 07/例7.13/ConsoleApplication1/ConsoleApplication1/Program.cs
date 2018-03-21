class program
{
    static void Main()//入口方法
    {
        //定义数组
        test[] t = new test[] { new test() { Name = "xiaoke" }, new test() { Name = "huidong" }, new test() { Name = "jun" } };
        test[] tt = (test[])t.Clone();//对数组进行浅复制产生一个数组对象副本
        t[0].Name = "xiaoli";//更改第一个数组的第一个元素的Name属性
        System.Console.WriteLine("第一个数组的元素：");
        foreach (test testfield in t)
        {
            //遍历第一个数组输出每个元素的Name属性
            System.Console.WriteLine(testfield.Name);
        }
        System.Console.WriteLine("数组对象副本的元素");
        foreach (test testfield in tt)
        {
            //遍历数组对象副本输出每个元素的Name属性
            System.Console.WriteLine(testfield.Name);
        }
        System.Console.ReadLine();//等待回车继续
    }
}
class test//定义test类型
{
    public string Name;//定义Name字符串类型字段
}