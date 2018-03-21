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
        foreach (DataRow dr in ds.Tables[0].Rows)//遍历集合输出数据表中的记录
        {
            Console.WriteLine("{0} {1} {2} {3}",
                dr[0], dr[1], dr[2], dr[3]);
        }
        System.Console.ReadLine();//等待回车继续
    }
}