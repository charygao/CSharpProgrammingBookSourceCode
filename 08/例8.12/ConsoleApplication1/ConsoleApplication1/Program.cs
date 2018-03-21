class program
{
    static void Main()//入口方法
    {
        Book book = new Book();//建立Book对象
        System.Console.WriteLine(book[0]);//输出索引器的值
        book[0] = "C# 编程宝典";//更改索引器的值
        System.Console.WriteLine(book[0]);//输出索引器的值
        System.Console.ReadLine();//等待回车继续
    }
}
class Book
{
    private string[] books = new string[] //定义数组
    { "编程宝典", "实战宝典", "范例宝典", "经验与技巧宝典" };

    public string this[int i]//定义索引器
    {
        get { return books[i]; }//定义get访问器
        set { books[i] = value; }//定义set访问器
    }
}