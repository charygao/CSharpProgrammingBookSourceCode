using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ChuffedFarm
{
    public partial class Form1 : Form
    {
        private CPictureBox cpbxSeed;
        private int intAmount;

        public Form1()
        {
            InitializeComponent();
        }
    
        private void pbxSeed_MouseEnter(object sender, EventArgs e)
        {
            this.pbxInseminate.Image = ChuffedFarm.Properties.Resources.播种1;
        }

        private void pbxSeed_MouseLeave(object sender, EventArgs e)
        {
            this.pbxInseminate.Image = ChuffedFarm.Properties.Resources.播种;
        }

        private void pbxHarvest_MouseEnter(object sender, EventArgs e)
        {
            this.pbxHarvest.Image = ChuffedFarm.Properties.Resources.收获1;
        }

        private void pbxHarvest_MouseLeave(object sender, EventArgs e)
        {
            this.pbxHarvest.Image = ChuffedFarm.Properties.Resources.收获;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.cpbxSeed != null)//已经生成了种子图片
            {
                if (this.Bounds.Contains(Cursor.Position))//若光标在窗体内
                {
                    if (this.cpbxSeed.IsInseminate == false)//若种子还未种下
                    {
                        if (this.cpbxSeed.PlantState == PlantState.Inseminate)//若是种植状态
                        {
                            this.cpbxSeed.Location = new Point(e.X-20 , e.Y-40 );
                        }
                    }
                }
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (this.cpbxSeed != null&&this.cpbxSeed.IsInseminate == false)
            {
                this.cpbxSeed.IsInseminate = true;//表示种下——即确定位置
                Thread t = new Thread(GrowProcess);
                t.IsBackground = true;
                t.Start(this.cpbxSeed);
            }
        }

        private void cpbxSeed_Click(object sender, EventArgs e)
        {
            if (this.cpbxSeed != null && this.cpbxSeed.IsInseminate == false)
            {
                this.cpbxSeed.IsInseminate = true;//表示种下——即确定位置
                Thread t = new Thread(GrowProcess);//启动作物成长线程
                t.IsBackground = true;
                t.Start(this.cpbxSeed);//开始线程
            }
        }

        private void GrowProcess(object obj)
        {
            CPictureBox cpbx = obj as CPictureBox;
            //生长
            Thread.Sleep(5000);
            cpbx.Image = ChuffedFarm.Properties.Resources.grow;
            cpbx.PlantState = PlantState.Vegetate;
            //开花
            Thread.Sleep(5000);
            cpbx.Image = ChuffedFarm.Properties.Resources.bloom;
            cpbx.PlantState = PlantState.BlossomOut;
            //结果
            Thread.Sleep(5000);
            cpbx.Image = ChuffedFarm.Properties.Resources.fruit;
            cpbx.PlantState = PlantState.MakeFruitage;
        }


        private void pbxInseminate_Click(object sender, EventArgs e)
        {
           
           
            this.cpbxSeed = new CPictureBox();//先生成种子
            this.cpbxSeed.PlantState = PlantState.Inseminate;//后处于播种状态
            this.cpbxSeed.BackColor = System.Drawing.Color.Transparent;
            this.cpbxSeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cpbxSeed.Image = ChuffedFarm.Properties.Resources.seed2;
            this.cpbxSeed.Size = new System.Drawing.Size(ChuffedFarm.Properties.Resources.seed2.Width, ChuffedFarm.Properties.Resources.seed2.Height);//52.28
            this.cpbxSeed.Location = new System.Drawing.Point(this.pbxInseminate.Location.X-50,this.pbxInseminate.Location.Y - 80);


            this.cpbxSeed.TabStop = true;
            this.cpbxSeed.IsInseminate = false;//刚刚创建种子实例，还未种下
            this.cpbxSeed.Click += new System.EventHandler(this.cpbxSeed_Click);
            this.cpbxSeed.PlantState = PlantState.Inseminate;
            this.Controls.Add(this.cpbxSeed);
        }

       
        private void pbxHarvest_Click(object sender, EventArgs e)
        {   
            IEnumerable<Control> cons = this.GetCPictureBoxes();//查找播种的种子图片实例
            if (cons.Count<Control>()==0)//未播种
            {
                MessageBox.Show("还未播种，怎么收获?", "信息提示");
                return;
            }
            else//已播种了
            {
                //查找结果的
                IEnumerable<Control> cpxs = cons.Where<Control>(cpx => ((CPictureBox)cpx).PlantState == PlantState.MakeFruitage);
                if (cpxs.Count<Control>() == 0)//无成熟的
                {
                    MessageBox.Show("还没有成熟的，怎么收获?", "信息提示");
                }
                else//有已成熟的果实
                {
                    int intCount = cpxs.Count<Control>();
                    intAmount = intAmount + intCount;
                    for (int i = 0; i < intCount; i++)
                    {
                        cpxs.ElementAt<Control>(i).Dispose();
                        i -= 1;
                        intCount -= 1;
                    }
                    lbAmount.Text = "你的仓库里有" + intAmount.ToString() + "个果实！";
                }
            }
        }
        /// <summary>
        /// 获取动态生成的自定义PictureBox控件
        /// </summary>
        /// <returns></returns>
        private IEnumerable<Control> GetCPictureBoxes()
        {
            return this.Controls.Cast<Control>().Where(con => (con.GetType()==typeof(CPictureBox)));
        }
    }
}