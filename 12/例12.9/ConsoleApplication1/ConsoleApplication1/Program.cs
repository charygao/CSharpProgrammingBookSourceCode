using System;
using System.Data;
using System.Data.SqlClient;
class program
{
    static void Main()
    {
        SqlDataAdapter sda = new SqlDataAdapter(//创建SqlDataAdapter对象
            "select * from tb_student",
            "server=WRET-MOSY688YVW\\MRGLL;database=db_test;Trusted_Connection=true");
        DataSet ds = new DataSet();//创建数据集DataSet对象
        sda.Fill(ds);//填充数据集DataSet
        ds.Tables[0].Rows[0][1] = "张小";//修改数据表中的数据
        SqlCommandBuilder scb = new SqlCommandBuilder(sda);//填充SqlDataAdapter对象的命令
        sda.Update(ds);//更新数据集中的记录到数据库
        Console.WriteLine("已经更新信息到数据库");//控制台输入字符串
        System.Console.ReadLine();//等待回车继续
    }
}