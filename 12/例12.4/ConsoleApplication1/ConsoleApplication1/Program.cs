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
                "UPDATE tb_student SET student_grade=99 where student_id=@id ", sc);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = 1;//添加参数并为参数赋值
            int i = cmd.ExecuteNonQuery();//执行修改记录的命令
            if (i > 0) Console.WriteLine("修改记录成功");//控制台输出字符串
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