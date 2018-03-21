using System;
using System.Data;
using System.Data.SqlClient;

class program
{
    static void Main()
    {
        string connection =//建立连接字符串
            "server=WRET-MOSY688YVW\\MRGLL;database=db_test;Trusted_Connection=true";
        SqlConnection sc = new SqlConnection(connection);//创建SqlConnection对象
        try
        {
            sc.Open();//打开数据库连接
            SqlCommand cmd = new SqlCommand(//创建SqlCommand对象
                "SELECT count(*) FROM tb_student", sc);
            int i = (int)cmd.ExecuteScalar();//执行查找记录的命令
            Console.WriteLine("表中共有{0}条数据",i.ToString());//控制台输出字符串
        }
        catch (Exception ex)//捕获异常
        {
            Console.WriteLine("打开数据库错误：{0}", ex.Message);//控制台输出字符串
        }
        finally
        {
            sc.Close();//关闭数据库连接
        }
        System.Console.ReadLine();//等待回车继续
    }
}