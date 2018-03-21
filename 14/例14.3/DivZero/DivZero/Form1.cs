using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DivZero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = (Convert.ToDecimal(textBox1.Text) / Convert.ToDecimal(textBox2.Text)).ToString();//求两个数的商
            }
            catch (Exception ex)//捕捉异常
            {
                MessageBox.Show(ex.Message);//显示异常
            }
        }
    }
}
