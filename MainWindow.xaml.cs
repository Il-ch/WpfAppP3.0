using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Threading;

namespace WpfAppP3
{
    public partial class MainWindow : Window
    {
        private RotateTransform3D myYRotate;
        private AxisAngleRotation3D myYAxis;
        private Transform3DGroup myTransform1;
        private Transform3DGroup myTransform2;
        private RotateTransform3D myXRotate;
        private AxisAngleRotation3D myXAxis;
        private RotateTransform3D myZRotate;
        private AxisAngleRotation3D myZAxis;
        private RotateTransform3D myYRotate2;
        private AxisAngleRotation3D myYAxis2;
        private RotateTransform3D myZRotate2;
        private AxisAngleRotation3D myZAxis2;
        private DispatcherTimer MyTimer;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            myYRotate = new RotateTransform3D();
            myYAxis = new AxisAngleRotation3D();
            myYAxis.Axis = new Vector3D(0, 1, 0);
            myYAxis.Angle = 0;
            myYRotate.Rotation = myYAxis;
            myZRotate = new RotateTransform3D();
            myZAxis = new AxisAngleRotation3D();
            myZAxis.Axis = new Vector3D(0, 0, 1);
            myZAxis.Angle = 0;
            myZRotate.Rotation = myZAxis;
            myTransform1 = new Transform3DGroup();
            MyModel.Transform = myTransform1;
            myTransform1.Children.Add(myYRotate);
            myTransform1.Children.Add(myZRotate);

            myYRotate2 = new RotateTransform3D();
            myYAxis2 = new AxisAngleRotation3D();
            myYAxis2.Axis = new Vector3D(0, 1, 0);
            myYAxis2.Angle = 0;
            myYRotate2.Rotation = myYAxis2;
            myZRotate2 = new RotateTransform3D();
            myZAxis2 = new AxisAngleRotation3D();
            myZAxis2.Axis = new Vector3D(0, 0, 1);
            myZAxis2.Angle = 0;
            myZRotate2.Rotation = myZAxis2;
            myTransform2 = new Transform3DGroup();
            MyModel2.Transform = myTransform2;
            myTransform2.Children.Add(myYRotate2);
            myTransform2.Children.Add(myZRotate2);

            MyTimer = new DispatcherTimer();
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Interval = new TimeSpan(0, 0, 0, 0, 10);
        }


        private void MyTimer_Tick(object sender, EventArgs e)
        {
            myYAxis.Angle += 0.8;
            myZAxis.Angle += 0.8;

            myYAxis2.Angle += 0.4;
            myZAxis2.Angle += 0.4;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MyTimer.Start();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MyTimer.Stop();
        }
        
    }
}
