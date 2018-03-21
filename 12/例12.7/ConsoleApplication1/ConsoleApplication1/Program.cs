using System;
using System.Data;
using System.Data.SqlClient;
class program
{
    static void Main()
    {
        DataSet ds = new DataSet();//创建数据集DataSet对象
        DataTable dt = new DataTable();//创建数据表DataTable对象
        ds.Tables.Add(dt);//将数据表对象加入数据集对象集合中
        dt.Columns.Add("name", typeof(string));//向DataTable中添加列
        dt.Columns.Add(new DataColumn("address", typeof(string)));//向DataTable中添加列
        DataRow dr= dt.NewRow();//得到数据表，行对象
        dr[0] = "小李";//向行对象中添加数据
        dr[1] = "长春";//向行对象中添加数据
        dt.Rows.Add(dr);//将数据行对向添加到数据表中
        dt.Rows.Add(new object[] {"小明","长春" });//向数据表中添加新的行对象
        foreach (DataRow v in ds.Tables[0].Rows)//遍历DataTable中所有记录
        {
            Console.WriteLine(" {0} {1} ",v[0],v[1]);
        }
        System.Console.ReadLine();//等待回车继续
    }
}