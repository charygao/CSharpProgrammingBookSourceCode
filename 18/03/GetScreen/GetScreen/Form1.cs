using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
namespace GetScreen
{
    public partial class Form1 : Form
    {
        string PicPath = String.Empty;

        public Form1()
        {
            InitializeComponent();
        }
 
        [DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
        private static extern int GetSystemMetrics(int mVal);
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,string key,string val,string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,string key,string def,StringBuilder retval,int size,string filePath);
        
        #region 定义快捷键
        //如果函数执行成功，返回值不为0。       
        //如果函数执行失败，返回值为0。要得到扩展错误信息，调用GetLastError。        
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RegisterHotKey(
        IntPtr hWnd,                //要定义热键的窗口的句柄            
        int id,                     //定义热键ID（不能与其它ID重复）                       
        KeyModifiers fsModifiers,   //标识热键是否在按Alt、Ctrl、Shift、Windows等键时才会生效         
        Keys vk                     //定义热键的内容            
    );
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey(
            IntPtr hWnd,                //要取消热键的窗口的句柄            
            int id                      //要取消热键的ID            
        );
        //定义了辅助键的名称（将数字转变为字符以便于记忆，也可去除此枚举而直接使用数值）        
        [Flags()]
        public enum KeyModifiers
        {
            None = 0,
            Alt = 1,
            Ctrl = 2,
            Shift = 4,
            WindowsKey = 8
        }
        #endregion

        public string path;
        public void IniWriteValue(string section, string key, string value)
        {
            WritePrivateProfileString(section,key,value,path);
        }
        public string IniReadValue(string section, string key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(section,key,"",temp,255,path);
            return temp.ToString();
        }

        private Bitmap CaptureScreen()//抓取桌面
        {
            Bitmap _Source = new Bitmap(GetSystemMetrics(0), GetSystemMetrics(1));
            using (Graphics g = Graphics.FromImage(_Source))
            {
                g.CopyFromScreen(0, 0, 0, 0, _Source.Size);
            }
            return _Source;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSavaPath.Text = folderBrowserDialog1.SelectedPath;
                try
                {
                    path = Application.StartupPath.ToString();
                    path = path.Substring(0, path.LastIndexOf("\\"));
                    path = path.Substring(0, path.LastIndexOf("\\"));
                    path += @"\Setup.ini";
                    if (txtSavaPath.Text == "")
                    {
                        PicPath = @"D:\";
                    }
                    else
                    {
                        PicPath = txtSavaPath.Text.Trim();
                    }
                    IniWriteValue("Setup", "Dir", PicPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            Form1_Activated(sender, e);
        }

        private void Form1_StyleChanged(object sender, EventArgs e)
        {
            RegisterHotKey(Handle, 81, KeyModifiers.Shift, Keys.F);//注册快捷键
        }

        public bool flag=true;
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //注销Id号为81的热键设定    
            UnregisterHotKey(Handle, 81);
            timer1.Stop();
            flag = false;
            Application.Exit();
        }

        string MyPicPath;
        private void Form1_Activated(object sender, EventArgs e)
        {
            RegisterHotKey(Handle, 81, KeyModifiers.Shift, Keys.F);
            path = Application.StartupPath.ToString();
            path = path.Substring(0, path.LastIndexOf("\\"));
            path = path.Substring(0, path.LastIndexOf("\\"));
            path += @"\Setup.ini";
            MyPicPath = IniReadValue("Setup", "Dir");
            if ( MyPicPath == "")
            {
                txtSavaPath.Text = @"D:\";
            }
            else
            {
                txtSavaPath.Text = MyPicPath; 
            }
        }

        private void getImg()
        {
            DirectoryInfo di = new DirectoryInfo(MyPicPath);
            if (!di.Exists)
            {
                Directory.CreateDirectory(MyPicPath);
            }
            if (MyPicPath.Length == 3)
                MyPicPath = MyPicPath.Remove(MyPicPath.LastIndexOf(":") + 1);//移除冒号后面的"\",只保留“盘符：”
            //图片的保存路径
            string PicPath = MyPicPath + "\\IMG_" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".bmp";
            Bitmap bt = CaptureScreen();//获取屏幕图像，是一个位图实例
            bt.Save(PicPath);//把图片保存到指定位置
        }

        /// <summary>
        /// 用于获取操作系统向应用程序发送的一系列消息,例如按键消息、单击鼠标消息等等。
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312; //定义一个操作系统的消息号
            //按快捷键     
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 81:    //若按下的是<Shift+F>组合键                   
                            getImg();//则调用“屏幕抓图”方法
                            break;
                    }
                    break;
            }
            base.WndProc(ref m);//执行基类的WndProc方法
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)//双击显示设置窗体
        {
            this.Show();
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)//单击设置打开设置窗体
        {
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Handle：被定义了热键的窗口的句柄
            //81：定义热键ID
            //KeyModifiers.Shift：热键的配合键
            //Keys.F：定义热键的内容
            RegisterHotKey(Handle, 81, KeyModifiers.Shift, Keys.F);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            if (flag == true)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
