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
        //定义私有字段，用于保存连接数据库字符串
        private string connection =
            string.Format("server=WRET-MOSY688YVW\\MRGLL;database=db_test;Trusted_Connection=true");
        private SqlConnection GetConnection()
        {
            //返回SqlConnection连接数据库对象
            return new SqlConnection(connection);
        }

        public void Add(byte[] bt)
        {
            //调用GetConnection()方法得到连接数据库对象
            SqlConnection sc = GetConnection();
            try
            {
                sc.Open();//打开数据库连接
                //定义SqlCommand对象
                SqlCommand cmd = new SqlCommand("insert into tb_image(images) values(@image)", sc);
                //向SqlCommand对象添加参数
                cmd.Parameters.Add("@image", SqlDbType.Image).Value = bt;
                //执行SqlCommand对象中的SQL命令
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)//捕获异常
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //判断数据库连接是否打开
                if (sc.State==ConnectionState.Open)
                {
                    //如果打开则关闭连接
                    sc.Close();
                }
            }
        }

        public List<byte[]> Get()
        {
            //调用GetConnection()方法得到连接数据库对象
            SqlConnection sc = GetConnection();
            try
            {
                sc.Open();//打开数据库连接
                //定义SqlCommand对象
                SqlCommand cmd = new SqlCommand("select images from tb_image", sc);
                //得到数据库中的查询结果，并将结果转换为集合后返回
                return GetList(cmd.ExecuteReader());
            }
            catch (Exception ex)//捕获异常
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                //判断数据库连接是否打开
                if (sc.State == ConnectionState.Open)
                {
                    //如果打开则关闭连接
                    sc.Close();
                }
            }
        }

        private List<byte[]> GetList(SqlDataReader sdr)
        {
            List<byte[]> lbt = new List<byte[]>();//定义集合对象
            while (sdr.Read())//遍历SqlConnection对象
            {
                lbt.Add((byte[])sdr[0]);//向集合中添加元素
            }
            return lbt;//返回集合对象
        }
    }
}
