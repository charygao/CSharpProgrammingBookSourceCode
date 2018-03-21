using System;
using System.Data;
using System.Data.SqlClient;

class program
{
    static void Main()
    {
        //建立连接字符串
        string connection =
            "server=WRET-MOSY688YVW\\MRGLL;database=db_test;Integrated Security=true";
        //创建SqlConnection对象
        SqlConnection sc = new SqlConnection();
        //设置SqlConnection对象的连接字符串
        sc.ConnectionString = connection;
        try
        {
            //打开数据库连接
            sc.Open();
            //创建SqlCommand对象
            SqlCommand cmd = new SqlCommand();
            //设置SqlCommand对象执行SQL文本命令
            cmd.CommandType = CommandType.Text;
            //设置SqlCommand对象的Connection对象
            cmd.Connection = sc;
            //设置SqlCommand对象执行的SQL语句
            cmd.CommandText =
                "INSERT INTO tb_student(student_name,student_age,student_address,student_grade) VALUES(@name,@age,@address,@grade)";
            //添加参数并为参数赋值
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 10).Value = "小飞";
            //添加参数并为参数赋值
            cmd.Parameters.Add("@age", SqlDbType.Int).Value = 33;
            //添加参数并为参数赋值
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = "长春";
            //添加参数并为参数赋值
            cmd.Parameters.Add("@grade", SqlDbType.Int).Value = 100;
            //执行向数据库添加记录的命令
            int i = cmd.ExecuteNonQuery();
            //控制台输出添加记录成功的信息
            if (i > 0) Console.WriteLine("添加记录成功");
        }
        catch (Exception ex)//捕获异常
        {
            //控制台输出字符串
            Console.WriteLine("打开数据库错误：{0}", ex.Message);
        }
        finally
        {
            //关闭数据库连接
            sc.Close();
        }
        //等待回车继续
        System.Console.ReadLine();
    }
}