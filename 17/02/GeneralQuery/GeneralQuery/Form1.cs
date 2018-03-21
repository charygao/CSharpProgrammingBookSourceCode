using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace GeneralQuery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 定义公共对象及变量
        SqlConnection sqlcon;
        SqlDataAdapter sqlda;
        DataSet myds;
        string strCon = "Data Source =WRET-MOSY688YVW\\MRGLL;Database=db_17;Uid=sa;Pwd=;";
        string strSql = "select ID as 员工编号,Name as 员工姓名,Sex as 性别,Age as 年龄,Tel as 联系电话,Address as 家庭地址,QQ as QQ号码,Email as Email地址 from tb_Employee";
        public static string FindValue = "";  //存储查询条件
        #endregion

        //窗体初始化时显示所有员工信息
        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllInfo(strSql);
            cboxSex.SelectedIndex = 0;
        }

        //综合查询员工信息
        private void btnQuery_Click(object sender, EventArgs e)
        {
            FindValue = "";    //清空存储查询语句的变量
            string Find_SQL = strSql;  //存储显示数据表中所有信息的SQL语句
            if (FindValue.Length > 0)
                FindValue = FindValue + "and";
            if (txtID.Text != "")
                FindValue += "(ID='" + txtID.Text + "') and";
            if (txtName.Text != "")
                FindValue += "(Name='" + txtName.Text + "') and";
            if (cboxSex.Text != "")
                FindValue += "(Sex='" + cboxSex.Text + "') and";
            if (txtFAge.Text != "" && txtTAge.Text != "")
            {
                if (validateNum(txtFAge.Text) && validateNum(txtTAge.Text))
                    FindValue += "(Age between " + Convert.ToInt32(txtFAge.Text) + " and " + Convert.ToInt32(txtTAge.Text) + ") and";
                else
                {
                    MessageBox.Show("年龄必须为数字！");
                    txtFAge.Text = txtTAge.Text = "";
                    txtFAge.Focus();
                }
            }
            else
            {
                if (txtFAge.Text != "")
                {
                    if (validateNum(txtFAge.Text))
                        FindValue += "(Age = " + Convert.ToInt32(txtFAge.Text) + ") and";
                    else
                    {
                        MessageBox.Show("年龄必须为数字！");
                        txtFAge.Text = "";
                        txtFAge.Focus();
                    }
                }
                else if (txtTAge.Text != "")
                {
                    if (validateNum(txtTAge.Text))
                        FindValue += "(Age = " + Convert.ToInt32(txtTAge.Text) + ") and";
                    else
                    {
                        MessageBox.Show("年龄必须为数字！");
                        txtTAge.Text = "";
                        txtTAge.Focus();
                    }
                }
            }
            if (txtQQ.Text != "")
            {
                if (validateNum(txtQQ.Text) && txtQQ.Text.Length >= 4 && txtQQ.Text.Length <= 9)
                    FindValue += "(QQ =" + Convert.ToInt32(txtQQ.Text) + ") and";
                else
                {
                    MessageBox.Show("QQ号码必须为4到9位以内的数字！");
                    txtQQ.Text = "";
                    txtQQ.Focus();
                }
            }
            if (txtTel.Text != "")
            {
                if (validatePhone(txtTel.Text))
                    FindValue += "(Tel='" + txtTel.Text + "') and";
                else
                {
                    MessageBox.Show("请输入正确的电话号码！");
                    txtTel.Text = "";
                    txtTel.Focus();
                }
            }
            if (txtEmail.Text != "")
            {
                if (validateEmail(txtEmail.Text))
                    FindValue += "(Email='" + txtEmail.Text + "') and";
                else
                {
                    MessageBox.Show("请输入正确的Email地址！");
                    txtEmail.Text = "";
                    txtEmail.Focus();
                }
            }
            if (txtAddress.Text != "")
                FindValue += "(Address='" + txtAddress.Text + "') and";
            if (FindValue.Length > 0)   //当存储查询条件的变量不为空时，删除逻辑运算符AND
            {
                if (FindValue.IndexOf("and") > -1)  //判断是否用AND连接条件
                    FindValue = FindValue.Substring(0, FindValue.Length - 4);
            }
            else
                FindValue = "";
            if (FindValue != "")   //如果FindValue字段不为空
                //将查询条件添加到SQL语句的尾部
                Find_SQL = Find_SQL + " where " + FindValue;
            //按照指定的条件进行查询
            GetAllInfo(Find_SQL);
        }

        //清空文本框
        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in groupBox1.Controls)
            {
                if (ctl.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    ctl.Text = "";
                }
            }
            txtID.Focus();
            cboxSex.SelectedIndex = 0;
        }

        #region 根据条件查询员工信息
        /// <summary>
        /// 根据条件查询员工信息
        /// </summary>
        /// <param name="strsql">设置查询条件的SQL语句</param>
        private void GetAllInfo(string strsql)
        {
            sqlcon = new SqlConnection(strCon);
            sqlda = new SqlDataAdapter(strsql, sqlcon);
            myds = new DataSet();
            sqlda.Fill(myds);
            dgvInfo.DataSource = myds.Tables[0];
        }
        #endregion

        #region  验证输入为数字
        /// <summary>
        /// 验证输入为数字
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool validateNum(string str)
        {
            return Regex.IsMatch(str, "^[0-9]*[1-9][0-9]*$");
        }
        #endregion

        #region  验证输入为电话号码
        /// <summary>
        /// 验证输入为电话号码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool validatePhone(string str)
        {
            return Regex.IsMatch(str, @"^(\d{3,4})-(\d{7,8})$");
        }
        #endregion

        #region  验证输入为Email
        /// <summary>
        /// 验证输入为Email
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool validateEmail(string str)
        {
            return Regex.IsMatch(str, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        }
        #endregion
    }
}
