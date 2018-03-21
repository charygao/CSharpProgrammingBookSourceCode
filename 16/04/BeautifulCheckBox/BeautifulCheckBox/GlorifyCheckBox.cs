﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BeautifulCheckBox
{
    public partial class GlorifyCheckBox : CheckBox
    {
        public GlorifyCheckBox()
        {
            InitializeComponent();
            FontAspect = getAspect();//获取当前控件文本的读取方向
        }

        #region 变量
        private bool FontAspect = false;//判断字体的方向
        private int Measurement = 255;//设置渐变的初始值
        LinearGradientBrush Periphery_br;//外圆的颜色
        #endregion

        #region 添加属性
        public enum StyleSort
        {
            Null = 0,//无
            Integer = 1,//整数
            Decimal = 2,//小数
        }

        private Color TPeripheryColor = Color.DarkBlue;
        [Browsable(true), Category("设置填充颜色"), Description("外圆的颜色")] //在“属性”窗口中显示DataStyle属性
        public Color PeripheryColor
        {
            get { return TPeripheryColor; }
            set
            {
                TPeripheryColor = value;
                this.Invalidate();
            }
        }

        private Color TStippleColor = Color.DarkBlue;
        [Browsable(true), Category("设置填充颜色"), Description("选中后内圆的颜色")] //在“属性”窗口中显示DataStyle属性
        public Color StippleColor
        {
            get { return TStippleColor; }
            set
            {
                TStippleColor = value;
                this.Invalidate();
            }
        }
        #endregion

        #region 事件
        /// <summary>
        /// 控件在需要重绘时触发
        /// </summary>
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.FillRectangle(SystemBrushes.Control, e.ClipRectangle);//填充矩形
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//清除锯齿
            //获取左面图标的区域
            Rectangle boxrect = new Rectangle(e.ClipRectangle.X, e.ClipRectangle.Y, SystemInformation.SmallIconSize.Width, e.ClipRectangle.Height);
            //获取绘制的文本的区域
            Rectangle strrect = new Rectangle(e.ClipRectangle.X + SystemInformation.SmallIconSize.Width, e.ClipRectangle.Y, e.ClipRectangle.Width + 5 - SystemInformation.SmallIconSize.Width, e.ClipRectangle.Height);
            if (FontAspect)//判断字体的读取方式
            {
                boxrect.X = e.ClipRectangle.X + e.ClipRectangle.Width - SystemInformation.SmallIconSize.Width;//设置椭圆的位置
                strrect.X = e.ClipRectangle.X;//设置字体位置
            }

            Point MousePos = this.PointToClient(Control.MousePosition);//获取鼠标的位置
            bool Above = e.ClipRectangle.Contains(MousePos);//获取鼠标是否在当前控件上

            DrawBox(e.Graphics, boxrect, Above);//绘制复选框图案
            DrawText(e.Graphics, strrect);//绘制文字
            if (!Enabled)
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(127, SystemColors.Control)), e.ClipRectangle);
        }

        /// <summary>
        /// RightToLeft属性值更改时发生
        /// </summary>
        protected override void OnRightToLeftChanged(System.EventArgs e)
        {
            base.OnRightToLeftChanged(e);
            FontAspect = getAspect();
            this.Invalidate();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 绘制复选控件的图案
        /// </summary>
        /// <param g="Graphics">封装一个绘图的类对象</param>
        /// <param rect="Rectangle">单选图案的绘制区域</param> 
        /// <param Above="bool">断判鼠标是否在控件上方</param> 
        private void DrawBox(Graphics g, Rectangle rect, bool Above)
        {
            //设置外椭圆的渐变色
            int opacity = Measurement;
            //根据一个矩形、起始颜色和结束颜色以及方向，创建LinearGradientBrush 类的实例,用于设置外椭圆的渐变色
            Periphery_br = new LinearGradientBrush(rect, Color.FromArgb(opacity / 2, PeripheryColor), Color.FromArgb(opacity, PeripheryColor), LinearGradientMode.ForwardDiagonal);
            int size = this.Font.Height;//获取字体的高度
            //获取外椭圆的区域
            Rectangle box = new Rectangle(rect.X + ((rect.Width - size) / 2), rect.Y + ((rect.Height - size) / 2), size - 2, size - 2);
            Rectangle glyph = new Rectangle(box.X + 3, box.Y + 3, box.Width - 6, box.Height - 6);//设置内圆的绘制区域
            Rectangle right = new Rectangle(box.X, box.Y - 1, box.Width + 2, box.Height + 2);
            g.FillEllipse(new SolidBrush(SystemColors.Window), box);//以白色填充单选图案 

            if (this.CheckState == CheckState.Checked)//如果是选中状态
            {
                base.ForeColor = Color.DarkBlue;
                ControlPaint.DrawMenuGlyph(g, right, MenuGlyph.Checkmark, this.StippleColor, Color.White);//绘制对号
                g.DrawRectangle(new Pen(new SolidBrush(SystemColors.Control), (float)(3)), box);//绘制外椭圆
            }
            if (this.CheckState == CheckState.Indeterminate)
                g.FillRectangle(new SolidBrush(Color.FromArgb(127, SystemColors.Control)), right);
            g.DrawRectangle(new Pen(Periphery_br, (float)(1.5)), box);//绘制外椭圆
        }

        /// <summary>
        /// 绘制文本
        /// </summary>
        /// <param g="Graphics">封装一个绘图的类对象</param>
        /// <param rect="Rectangle">绘制文本的区域</param>
        private void DrawText(Graphics g, Rectangle rect)
        {
            StringFormat tem_StringF = new StringFormat();
            tem_StringF.Alignment = StringAlignment.Near;
            tem_StringF.LineAlignment = StringAlignment.Center;//文本居中对齐
            if (FontAspect)
                tem_StringF.FormatFlags = StringFormatFlags.DirectionRightToLeft;//按从左到右的顺序显示文本
            if (!FontAspect)
                g.DrawString(this.Text, this.Font, SystemBrushes.ControlText, rect, tem_StringF);//绘制文本
            else
            {
                rect.X = rect.X - SystemInformation.SmallIconSize.Width / 2 + 2;
                g.DrawString(this.Text, this.Font, SystemBrushes.ControlText, rect, tem_StringF);
            }
        }

        /// <summary>
        /// 获取文本的读取方向
        /// </summary>
        /// <return>布尔型</return>
        private bool getAspect()
        {
            bool tem_Aspect = SystemInformation.RightAlignedMenus;
            if (this.RightToLeft == RightToLeft.Yes)//从右到左进行读取
                tem_Aspect = true;
            if (this.RightToLeft == RightToLeft.No)//从左到右进行读取
                tem_Aspect = false;
            return tem_Aspect;
        }
        #endregion

    }
}
