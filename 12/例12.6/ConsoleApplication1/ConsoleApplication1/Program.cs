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
                "SELECT * FROM tb_student", sc);
            SqlDataReader sdr = cmd.ExecuteReader();//执行查找记录的命令
            while (sdr.Read())//while循环中调用Reader()方法读取下一条记录
            {
                Console.WriteLine("{0} {1} {2} {3} {4}",sdr[0],sdr[1],sdr[2],sdr[3],sdr[4]);
            }
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