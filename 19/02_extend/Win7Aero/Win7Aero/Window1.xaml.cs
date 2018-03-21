using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.InteropServices;
using System.Windows.Interop;

namespace Win7Aero
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Aero(this, 5, 5, (int)borderSplit.ActualHeight + 5, 5);//将窗体的指定区域实现Aero效果
        }

        /// <summary>
        /// 自定义结构
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        private struct Margins
        {
            public int Left;//左边距
            public int Right;//右边距
            public int Top;//顶边距
            public int Bottom;//底边距
        }

        //重写API函数，用来将透明边框扩充到窗体区
        [DllImport("dwmapi.dll")]
        private static extern int DwmExtendFrameIntoClientArea(IntPtr hwnd, ref Margins pMarInset);

        /// <summary>
        /// 获取窗体的Margins结构对象
        /// </summary>
        /// <param name="hwnd">窗体句柄</param>
        /// <param name="left">左边距</param>
        /// <param name="right">右边距</param>
        /// <param name="top">顶边距</param>
        /// <param name="bottom">底边距</param>
        /// <returns>窗体的Margins结构</returns>
        private static Margins GetDPIMargins(IntPtr hwnd, int left, int right, int top, int bottom)
        {
            //从指定句柄实例化绘图对象
            System.Drawing.Graphics graphics = System.Drawing.Graphics.FromHwnd(hwnd);
            float DPIX = graphics.DpiX;//获取窗体DPI的X坐标
            float DPIY = graphics.DpiY;//获取窗体DPI的Y坐标
            Margins margins = new Margins();//实例化Margins结构
            margins.Left = Convert.ToInt32(left * (DPIX / 96));//设置Margins结构的左边距
            margins.Right = Convert.ToInt32(right * (DPIX / 96));//设置Margins结构的右边距
            margins.Top = Convert.ToInt32(top * (DPIY / 96));//设置Margins结构的顶边距
            margins.Bottom = Convert.ToInt32(bottom * (DPIY / 96));//设置Margins结构的底边距
            return margins;//返回窗体的Margins结构
        }

        private static void Aero(Window window, int left, int right, int top, int bottom)
        {
            WindowInteropHelper winInterop = new WindowInteropHelper(window);//实例化WPF窗体对象
            IntPtr hwnd = winInterop.Handle;//获取WPF窗体句柄
            HwndSource hwndSource = HwndSource.FromHwnd(hwnd);//生成句柄资源
            hwndSource.CompositionTarget.BackgroundColor = Colors.Transparent;//设置指定句柄的窗体背景色透明
            Margins margins = GetDPIMargins(hwnd, left, right, top, bottom);//获取指定窗体的Margins结构
            int intAero = DwmExtendFrameIntoClientArea(hwnd, ref margins);//实现指定区域的Aero效果
            if (intAero < 0)//判断结果值是否小于0
            {
                MessageBox.Show("操作失败！");
            }
        }
    }
}
