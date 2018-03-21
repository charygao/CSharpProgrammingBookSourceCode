using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConvertMoney
{
    public partial class Form1 : Form
    {
        private const string STR_UPPER = "零壹贰叁肆伍陆柒捌玖";

        private const string STR_UNIT = "分角元拾佰仟萬拾佰仟亿";



        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>

        /// 转换整数为大写金额

        /// </summary>

        /// <param name="capValue">整数值</param>

        /// <returns>返回大写金额</returns>

        private string ConvertIntToUpper(string strValue)
        {
            string strCurrCap = "";
            string strCapResult = "";
            int intPrevChar = -1;

            int intCurrChar = 0;

            int intPosIndex = 2;

            if (Convert.ToDouble(strValue) == 0) return "";

            for (int i = strValue.Length - 1; i >= 0; i--)
            {

                if (strValue.Substring(i, 1) == "-")
                {
                    break;
                }

                intCurrChar = Convert.ToInt16(strValue.Substring(i, 1));


                if (intCurrChar != 0)
                {

                    strCurrCap = STR_UPPER.Substring(intCurrChar, 1) + STR_UNIT.Substring(intPosIndex, 1);

                }

                else
                {

                    switch (intPosIndex)
                    {

                        case 2: strCurrCap = "元"; break;

                        case 6: strCurrCap = "萬"; break;

                        case 10: strCurrCap = "亿"; break;



                        default: break;

                    }

                    if (intPrevChar != 0)
                    {

                        if (strCurrCap != "")
                        {

                            if (strCurrCap != "元") strCurrCap += "零";

                        }

                        else
                        {

                            strCurrCap = "零";

                        }

                    }

                }

                strCapResult = strCurrCap + strCapResult;

                intPrevChar = intCurrChar;

                intPosIndex += 1;

                strCurrCap = "";

            }

            return strCapResult;

        }



        /// <summary>

        /// 转换小数为大写金额

        /// </summary>

        /// <param name="capValue">小数值</param>

        /// <param name="isExistInt">是否存在整数位</param>

        /// <returns>返回大写金额</returns>

        private string ConvertDecToUpper(string strCapValue, bool isExistInt)
        {

            string strCurrCap = "";

            string strCapResult = "";

            int intCurrChar = 0;
            int intPosIndex = 1;
            if (Convert.ToDouble(strCapValue) == 0) return "";
            for (int i = 0; i < strCapValue.Length; i++)
            {
                intCurrChar = Convert.ToInt16(strCapValue.Substring(i, 1));
                if (intCurrChar == 0)//若当前字符为0
                {
                    if (i == 0)//若是角的索引
                    {
                        if (isExistInt)//若存在整数部分
                        {
                            strCurrCap = "零";
                        }
                    }
                }
                else//若当前字符为非0
                {
                    strCurrCap = STR_UPPER.Substring(intCurrChar, 1) + STR_UNIT.Substring(intPosIndex, 1);
                }
                strCapResult += strCurrCap;
                intPosIndex -= 1;
                strCurrCap = "";
            }
            return strCapResult;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strCapResult = "";
            string strCapValue = String.Format("{0:f2}", Convert.ToDouble(txtALower.Text));
            int intDotPos = strCapValue.IndexOf(".");//点的位置
            bool isMinus = strCapValue.Substring(0, 1) == "-" ? true : false;//判断是否负数
            int intBeginPos = isMinus ? 1 : 0;//数值的开始位置
            string strCapInt = strCapValue.Substring(intBeginPos, isMinus ? intDotPos - 1 : intDotPos);//取出整数部分
            string strCapDec = strCapValue.Substring(intDotPos + 1);//取出小数部分
            strCapResult = ConvertIntToUpper(strCapInt) + ConvertDecToUpper(strCapDec, Convert.ToInt32(strCapDec) >= 1 ? true : false);
            if (isMinus) strCapResult = "负" + strCapResult;
            if (Convert.ToDouble(strCapDec) == 0) strCapResult += "整";
            this.txtAUpper.Text = strCapResult;
        }

        private void txtALower_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (String.IsNullOrEmpty(txtALower.Text) && e.KeyChar.ToString() == ".")
            {
                e.Handled = true;
            }

            if ((((TextBox)sender).Text.Length != 0) && e.KeyChar.ToString() == "-")//若输入的负号字符不是第一位
            {
                e.Handled = true;
            }

            if ((txtALower.Text.Contains(".") && e.KeyChar.ToString() == ".") || (txtALower.Text.Contains("-") && e.KeyChar.ToString() == "-"))
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar.ToString() != "." && e.KeyChar.ToString() != "" && e.KeyChar.ToString() != "-")
            {
                e.Handled = true;
            }
        }
    }
}
