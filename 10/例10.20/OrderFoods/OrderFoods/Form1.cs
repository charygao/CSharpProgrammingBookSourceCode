using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderFoods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //����˵�����
            string[] strDishes = new string[] { "��������","�������","С����Ģ��","���պ��","������","��������","��޷����","�������²�","�𱬴�ͷ��"};
            for (int i = 0; i < strDishes.Length; i++)
            {
                lbSocure.Items.Add(strDishes[i]);//��Ӳ˵��б�
            }
        }

        private void button2_Click(object sender, EventArgs e)//ȫ����ӵ�ѡ�������
        {
            for (int i = 0; i < lbSocure.Items.Count; i++)
            {
                lbSocure.SelectedIndex=i;
                if (!lbChoose.Items.Contains(lbSocure.Text))//�ж��Ƿ��Ѿ�ѡ���˸ò�
                    lbChoose.Items.Add(lbSocure.SelectedItem.ToString());//���ѡ��Ĳ�
                else
                    MessageBox.Show("���Ѿ�ѡ���˸òˣ�������ѡ��");
            }
        }

        private void button3_Click(object sender, EventArgs e)//�Ƴ������Ѿ�ѡ��Ĳ�
        {
            lbChoose.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)//������ӵ�ѡ�������
        {
            if (lbSocure.SelectedIndex != -1)
            {
                if (!lbChoose.Items.Contains(lbSocure.Text))//�ж��Ƿ��Ѿ�ѡ���˸ò�
                    lbChoose.Items.Add(lbSocure.SelectedItem.ToString());//���ѡ��Ĳ�
                else
                    MessageBox.Show("���Ѿ�ѡ���˸òˣ�������ѡ��");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lbChoose.SelectedIndex != -1)
            {
                lbChoose.Items.Remove(lbChoose.SelectedItem);//�Ƴ�ѡ�еĲ�
            }
        }
    }
}