class program
{
    static void Main()//入口方法
    {
        System.Console.WindowHeight = 2;//设置控制台高度
        System.Console.WindowWidth = 45;//设置控制台宽度
        time t = new time();//创建time对象
        while (true)//开始while循环
        {
            System.Threading.Thread.Sleep(100);//线程挂起100毫秒
            System.Console.Title = t.ToString();//在控制台标题处显示当前时间
            System.Console.Clear();//清空控制台信息
            System.Console.WriteLine(t.ToString());//输出当前时间
        }
    }
}
class time//定义time类
{
    public override string ToString()//重写object类的ToString()方法
    {
        return System.DateTime.Now.ToString("yyyy年MM月dd日  hh时 mm分 ss秒 fff 毫秒");
    }
}
