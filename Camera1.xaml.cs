using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WPFSamplesTest
{
    /// <summary>
    /// Camera1.xaml 的交互逻辑
    /// </summary>
    public partial class Camera1 : Window
    {
        DispatcherTimer dispatTime = null; //计时器
        double AxAngle = 90; //角度

        /// <summary>
        /// 构造方法
        /// </summary>
        public Camera1()
        {
            InitializeComponent();
            if (dispatTime == null)
                dispatTime = new DispatcherTimer();
            dispatTime.Tick += new EventHandler(DT_Tick);
            dispatTime.Interval = new TimeSpan(0, 0, 0, 0, 2);

        }

        /// <summary>
        /// 计时事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DT_Tick(object sender, EventArgs e)
        {
            AxisAngleRot.Angle += 1;
            if (AxisAngleRot.Angle >= AxAngle)
                dispatTime.Stop();
        }

        /// <summary>
        /// 正面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrontSide_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AxisAngleRot.Angle = 0;
            AxAngle = 90;
            dispatTime.Start();

        }

        /// <summary>
        /// 右面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RightSide_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AxAngle = 180;      
            dispatTime.Start();

        }

        /// <summary>
        /// 左面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeftSide_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AxAngle = 360;
            dispatTime.Start();
        }

        /// <summary>
        /// 后面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackSide_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AxAngle = 270;
            dispatTime.Start();
        }

        /// <summary>
        /// 下面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DownSide_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AxAngle =180;
            dispatTime.Start();
        }

        /// <summary>
        /// 上面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpSide_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AxAngle = 360;
            dispatTime.Start();
        }
       
        /// <summary>
        /// 水平转动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_Horizontal(object sender, RoutedEventArgs e)
        {
            AxisAngleRot.Axis = new Vector3D(0, 1, 0);
        }

        /// <summary>
        /// 垂直转动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_Vertical(object sender, RoutedEventArgs e)
        {
            AxisAngleRot.Axis = new Vector3D(1, 0, 0);
        }
    }
}
