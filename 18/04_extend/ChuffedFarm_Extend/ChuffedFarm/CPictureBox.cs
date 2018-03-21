using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChuffedFarm
{
    public partial class CPictureBox : PictureBox
    {
        public CPictureBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private bool boolIsInseminate;
        [Browsable(true), Category("自定义"), Description("当前的种子是否已经确定播种位置")] //在“属性”窗口中显示IsFollow属性
        public bool IsInseminate
        {
            get { return boolIsInseminate; }
            set
            {
                boolIsInseminate = value;
                this.Invalidate();
            }
        }

        private PlantState psPlantState;
        [Browsable(true), Category("自定义"), Description("种子所处的生长状态")] //在“属性”窗口中显示IsFollow属性
        public PlantState PlantState
        {
            get { return psPlantState; }
            set
            {
                psPlantState = value;
                this.Invalidate();
            }
        }
    }
}
