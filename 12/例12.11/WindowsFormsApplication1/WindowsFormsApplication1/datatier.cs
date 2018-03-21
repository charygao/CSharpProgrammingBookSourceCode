using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class datatier
    {
        private SqlConnection GetConnection()
        {
            //返回连接到数据库的SqlConnection对象
            return new SqlConnection("server=WRET-MOSY688YVW\\MRGLL;database=db_test;Trusted_Connection=true");
        }

        private List<Instance> GetList(SqlDataReader sdr)
        {
            List<Instance> lit = new List<Instance>();//定义集合对象
            while (sdr.Read())//遍历SqlDataReader对象
            {
                //向集合对象内添加内容
                lit.Add(new Instance() { Name = sdr[0].ToString(), phone = sdr[1].ToString() });
            }
            return lit;//返回集合对象
        }

        public void Add(Instance it)
        {
            SqlConnection sc = GetConnection();//调用GetConnections()方法，得到连接对象
            try
            {
                sc.Open();//打开到数据库的连接
                SqlCommand cmd = new SqlCommand(//创建SqlCommand对象
                    "insert into tb_friend(names,phone) values(@names,@phone)", sc);
                cmd.Parameters.Add("@names", SqlDbType.VarChar).Value = it.Name;//向SqlCommand对象添加参数
                cmd.Parameters.Add("phone", SqlDbType.VarChar).Value = it.phone;//向SqlCommand对象添加参数
                cmd.ExecuteNonQuery();//执行SqlCommand对象中的SQL命令
            }
            catch (Exception ex)//捕获异常
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sc.State==ConnectionState.Open)//判断是否连接数据库
                {
                    sc.Close();//如果已经连接则关闭连接
                }
            }
        }

        public void Remove(string Name)
        {
            SqlConnection sc = GetConnection();//调用GetConnections()方法，得到连接对象
            try
            {
                sc.Open();//打开到数据库的连接
                SqlCommand cmd = new SqlCommand(//创建SqlCommand对象
                    "delete from tb_friend where names=@names", sc);
                cmd.Parameters.Add("@names", SqlDbType.VarChar).Value = Name;//向SqlCommand对象添加参数
                cmd.ExecuteNonQuery();//执行SqlCommand对象中的SQL命令
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sc.State == ConnectionState.Open)//判断是否连接数据库
                {
                    sc.Close();//如果已经连接则关闭连接
                }
            }
        }

        public void Update(Instance it)
        {
            SqlConnection sc = GetConnection();//调用GetConnections()方法，得到连接对象
            try
            {
                sc.Open();//打开到数据库的连接
                SqlCommand cmd = new SqlCommand(//创建SqlCommand对象
                    "update tb_friend set phone=@phone where names=@names", sc);
                cmd.Parameters.Add("@names", SqlDbType.VarChar).Value = it.Name;//向SqlCommand对象添加参数
                cmd.Parameters.Add("phone", SqlDbType.VarChar).Value = it.phone;//向SqlCommand对象添加参数
                cmd.ExecuteNonQuery();//执行SqlCommand对象中的SQL命令
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sc.State == ConnectionState.Open)//判断是否连接数据库
                {
                    sc.Close();//如果已经连接则关闭连接
                }
            }
        }

        public List<Instance> Select()
        {
            SqlConnection sc = GetConnection();//调用GetConnections()方法，得到连接对象
            try
            {
                sc.Open();//打开到数据库的连接
                SqlCommand cmd = new SqlCommand("select * from tb_friend", sc);//创建SqlCommand对象
                return GetList(cmd.ExecuteReader());//得到数据库中的查询结果，并将结果转换为集合后返回
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;//如果出现异常则返回空引用
            }
            finally
            {
                if (sc.State == ConnectionState.Open)//判断是否连接数据库
                {
                    sc.Close();//如果已经连接则关闭连接
                }
            }
        }
    }
}
