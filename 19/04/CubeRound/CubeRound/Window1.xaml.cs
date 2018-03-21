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
using System.Windows.Media.Media3D;
using System.Windows.Media.Animation;

namespace CubeRound
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

        Viewport3D myViewport = new Viewport3D();//实例化三维呈现图面
        //实例化6个三维模型
        GeometryModel3D side1 = new GeometryModel3D();
        GeometryModel3D side2 = new GeometryModel3D();
        GeometryModel3D side3 = new GeometryModel3D();
        GeometryModel3D side4 = new GeometryModel3D();
        GeometryModel3D side5 = new GeometryModel3D();
        GeometryModel3D side6 = new GeometryModel3D();
        PerspectiveCamera myCamera = new PerspectiveCamera();//实例化摄像机对象
        AmbientLight myLight = new AmbientLight();//实例化灯光对象
        Transform3DGroup transform3D = new Transform3DGroup();//实例化三维图形组转换对象
        Model3DGroup cubeModel = new Model3DGroup();//实例化一个3D模型
        //实例化6个三维的三角形基元
        MeshGeometry3D baseside1 = new MeshGeometry3D();
        MeshGeometry3D baseside2 = new MeshGeometry3D();
        MeshGeometry3D baseside3 = new MeshGeometry3D();
        MeshGeometry3D baseside4 = new MeshGeometry3D();
        MeshGeometry3D baseside5 = new MeshGeometry3D();
        MeshGeometry3D baseside6 = new MeshGeometry3D();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DrawCube();//绘制立方体的6个面
            SetCubeRound();//组合立方体并旋转
        }

        //组合立方体并旋转
        private void SetCubeRound()
        {
            ModelVisual3D myModelVisual = new ModelVisual3D();//实例化三维模型呈现对象
            myCamera.FarPlaneDistance = 20;//设置到摄像机远端剪裁平面的摄像机的距离
            myCamera.NearPlaneDistance = 0;//设置到摄像机近端剪裁平面的摄像机的距离
            myCamera.FieldOfView = 25;//设置摄像机的水平视角
            myCamera.Position = new Point3D(-5, 2, 3);//设置以世界坐标表示的摄像机位置
            myCamera.LookDirection = new Vector3D(5, -2, -3);//设置摄像机在世界坐标中的拍摄方向的三维空间置换
            myCamera.UpDirection = new Vector3D(0, 1, 0);//设置摄像机向上方向的三维空间置换
            //为6个三维模型赋值，值为对应的6个三角基元
            side1.Geometry = baseside1;
            side2.Geometry = baseside2;
            side3.Geometry = baseside3;
            side4.Geometry = baseside4;
            side5.Geometry = baseside5;
            side6.Geometry = baseside6;
            //实例化旋转转换对象
            RotateTransform3D myRotateTransform = new RotateTransform3D(new AxisAngleRotation3D(new Vector3D(0, 1, 0), 1));
            //实例化动画处理对象
            DoubleAnimation myAnimation = new DoubleAnimation();
            myAnimation.From = 1;//设置动画的起始值
            myAnimation.To = 360;//设置动画的结束值
            myAnimation.Duration = new Duration(TimeSpan.FromMilliseconds(3000));//设置动画播放的时间长度
            myAnimation.RepeatBehavior = RepeatBehavior.Forever;//设置动画的重复行为
            //实例化三维动画处理对象
            Vector3DAnimation myVectorAnimation = new Vector3DAnimation(new Vector3D(-1, -1, -1), new Duration(TimeSpan.FromMilliseconds(3000)));
            myVectorAnimation.RepeatBehavior = RepeatBehavior.Forever;//设置三维动画的重复行为
            //以普通动画的形式开始旋转
            myRotateTransform.Rotation.BeginAnimation(AxisAngleRotation3D.AngleProperty, myAnimation);
            //以三维动画的形式开始旋转
            myRotateTransform.Rotation.BeginAnimation(AxisAngleRotation3D.AxisProperty, myVectorAnimation);
            //将旋转转换添加到三维图形组转换对象中
            transform3D.Children.Add(myRotateTransform);
            //将6个面添加到一个3D模型中
            cubeModel.Children.Add(side1);
            cubeModel.Children.Add(side2);
            cubeModel.Children.Add(side3);
            cubeModel.Children.Add(side4);
            cubeModel.Children.Add(side5);
            cubeModel.Children.Add(side6);
            cubeModel.Transform = transform3D;//设置3D模型的转换方式
            cubeModel.Children.Add(myLight);//设置3D模型的灯光
            myViewport.Camera = myCamera;//设置三维呈现图面的摄像机
            myModelVisual.Content = cubeModel;//设置三维模型呈现的对象为立方体
            myViewport.Children.Add(myModelVisual);//将旋转的立方体添加到三维呈现图面中
            MainWindow.Content = myViewport;//将三维呈现图面显示在窗体中
        }

        //绘制立方体的6个面
        private void DrawCube()
        {
            //绘制立方体的第一个面
            baseside1.Positions.Add(new Point3D(-0.5, -0.5, -0.5));
            baseside1.Positions.Add(new Point3D(-0.5, 0.5, -0.5));
            baseside1.Positions.Add(new Point3D(0.5, 0.5, -0.5));
            baseside1.Positions.Add(new Point3D(0.5, 0.5, -0.5));
            baseside1.Positions.Add(new Point3D(0.5, -0.5, -0.5));
            baseside1.Positions.Add(new Point3D(-0.5, -0.5, -0.5));
            //绘制立方体的第二个面
            baseside2.Positions.Add(new Point3D(-0.5, -0.5, 0.5));
            baseside2.Positions.Add(new Point3D(0.5, -0.5, 0.5));
            baseside2.Positions.Add(new Point3D(0.5, 0.5, 0.5));
            baseside2.Positions.Add(new Point3D(0.5, 0.5, 0.5));
            baseside2.Positions.Add(new Point3D(-0.5, 0.5, 0.5));
            baseside2.Positions.Add(new Point3D(-0.5, -0.5, 0.5));
            //绘制立方体的第3个面
            baseside3.Positions.Add(new Point3D(-0.5, -0.5, -0.5));
            baseside3.Positions.Add(new Point3D(0.5, -0.5, -0.5));
            baseside3.Positions.Add(new Point3D(0.5, -0.5, 0.5));
            baseside3.Positions.Add(new Point3D(0.5, -0.5, 0.5));
            baseside3.Positions.Add(new Point3D(-0.5, -0.5, 0.5));
            baseside3.Positions.Add(new Point3D(-0.5, -0.5, -0.5));
            //绘制立方体的第4个面
            baseside4.Positions.Add(new Point3D(0.5, -0.5, -0.5));
            baseside4.Positions.Add(new Point3D(0.5, 0.5, -0.5));
            baseside4.Positions.Add(new Point3D(0.5, 0.5, 0.5));
            baseside4.Positions.Add(new Point3D(0.5, 0.5, 0.5));
            baseside4.Positions.Add(new Point3D(0.5, -0.5, 0.5));
            baseside4.Positions.Add(new Point3D(0.5, -0.5, -0.5));
            //绘制立方体的第5个面
            baseside5.Positions.Add(new Point3D(0.5, 0.5, -0.5));
            baseside5.Positions.Add(new Point3D(-0.5, 0.5, -0.5));
            baseside5.Positions.Add(new Point3D(-0.5, 0.5, 0.5));
            baseside5.Positions.Add(new Point3D(-0.5, 0.5, 0.5));
            baseside5.Positions.Add(new Point3D(0.5, 0.5, 0.5));
            baseside5.Positions.Add(new Point3D(0.5, 0.5, -0.5));
            //绘制立方体的第6个面
            baseside6.Positions.Add(new Point3D(-0.5, 0.5, -0.5));
            baseside6.Positions.Add(new Point3D(-0.5, -0.5, -0.5));
            baseside6.Positions.Add(new Point3D(-0.5, -0.5, 0.5));
            baseside6.Positions.Add(new Point3D(-0.5, -0.5, 0.5));
            baseside6.Positions.Add(new Point3D(-0.5, 0.5, 0.5));
            baseside6.Positions.Add(new Point3D(-0.5, 0.5, -0.5));
            //定义6个将二维画笔应用到光线漫射的三维模型
            DiffuseMaterial side1Material = new DiffuseMaterial((Brush)Application.Current.Resources["blueBrush"]);
            DiffuseMaterial side2Material = new DiffuseMaterial((Brush)Application.Current.Resources["yellowBrush"]);
            DiffuseMaterial side3Material = new DiffuseMaterial((Brush)Application.Current.Resources["redBrush"]);
            DiffuseMaterial side4Material = new DiffuseMaterial((Brush)Application.Current.Resources["cyanBrush"]);
            DiffuseMaterial side5Material = new DiffuseMaterial((Brush)Application.Current.Resources["yellowgreenBrush"]);
            DiffuseMaterial side6Material = new DiffuseMaterial((Brush)Application.Current.Resources["orangeBrush"]);
            //设置立方体每一个面的材质属性
            side1.Material = side1Material;
            side2.Material = side2Material;
            side3.Material = side3Material;
            side4.Material = side4Material;
            side5.Material = side5Material;
            side6.Material = side6Material;
        }
    }
}
