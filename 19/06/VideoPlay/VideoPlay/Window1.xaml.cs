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
using System.Windows.Forms;
using System.Windows.Interop;

namespace VideoPlay
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        //实例化一个计时器对象
        private System.Windows.Threading.DispatcherTimer timer =new System.Windows.Threading.DispatcherTimer();

        public Window1()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timer_Tick);//为计时器添加事件
        }

        void timer_Tick(object sender, EventArgs e)
        {
            slider2.Value =mediaElement1.Position.TotalMilliseconds;//实时显示音频或视频播放进度条
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            slider1.SelectionStart = 0;//设置音量最小值
            slider1.SelectionEnd = 1;//设置音量最大值
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();//实例化打开对话框对象
            openFile.Filter = "音频/视频文件|*.avi;*.mp3;*.dat;*.wav;*.rmvb;*.rm;*.wmv";//设置打开对话框的文件筛选器
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)//判断是否选择了文件
            {
                mediaElement1.Source = new Uri(openFile.FileName);//设置播放的资源文件
                mediaElement1.Volume = slider1.Value;//设置播放音量
                mediaElement1.Play();//播放选择的音频或视频文件
                btnStart.Content = "暂停";//设置按钮的文本
                image1.Visibility = Visibility.Hidden;//隐藏背景图片
            }
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            if (btnStart.Content.ToString() == "开始")//判断按钮的文本是否为“开始”
            {
                if (mediaElement1.HasAudio || mediaElement1.HasVideo)//判断是否有音频或视频资源
                {
                    mediaElement1.Play();//播放音频或视频文件
                    btnStart.Content = "暂停";//设置按钮的文本
                    image1.Visibility = Visibility.Hidden;//隐藏背景图片
                }
            }
            else
            {
                mediaElement1.Pause();//暂停音频或视频文件的播放
                btnStart.Content = "开始";//设置按钮的文本
                image1.Visibility = Visibility.Hidden;//隐藏背景图片
            }
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            StopMovie();//停止音频或视频的播放
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaElement1.Volume = slider1.Value;//设置播放音量
        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TimeSpan TSpan = new TimeSpan(0, 0, 0, 0, (int)slider2.Value);//获取播放进度
            mediaElement1.Position = TSpan;//设置播放进度
        }

        private void mediaElement1_MediaOpened(object sender, RoutedEventArgs e)
        {
            slider2.Maximum = mediaElement1.NaturalDuration.TimeSpan.TotalMilliseconds;//获取音频或视频的总长度
            timer.Interval = new TimeSpan(0, 0, 1);//设置计时器的时间间隔
            timer.Start();//启动计时器
        }

        private void mediaElement1_MediaEnded(object sender, RoutedEventArgs e)
        {
            StopMovie();//停止音频或视频的播放
            timer.Stop();//停止计时器
        }
        
        //停止音频或视频的播放
        private void StopMovie()
        {
            mediaElement1.Position = TimeSpan.Zero;//初始化播放进度
            mediaElement1.Stop();//停止音频或视频播放
            slider2.Value = 0;//初始化播放进度条
            btnStart.Content = "开始";//设置按钮文本
            image1.Visibility = Visibility.Visible;//显示背景图片
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();//退出播放器
        }
    }
}
