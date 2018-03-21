using System;
using System.Data;
using System.Data.SqlClient;

class program
{
    static void Main()//入口方法
    {
        string connection =
            "server=WRET-MOSY688YVW\\MRGLL;database=db_test;Integrated Security=true";//建立连接字符串
        SqlConnection sc = new SqlConnection();//创建SqlConnection对象
        sc.ConnectionString = connection;//设置SqlConnection对象的连接字符串
        try
        {
            sc.Open();//打开数据库连接
            Console.WriteLine("已经打开数据库连接");//控制台输出字符串
        }
        catch (Exception ex)//捕获异常
        {
            Console.WriteLine("打开数据库错误：{0}", ex.Message);//控制台输出字符串
        }
        finally
        {
            sc.Close();//关闭数据库连接
            Console.WriteLine("已经关闭数据库连接");//控制台输出字符串
        }
        System.Console.ReadLine();//等待回车继续
    }
}