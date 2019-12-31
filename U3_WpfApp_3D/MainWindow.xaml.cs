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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace U3_WpfApp_3D
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void xRadio_Checked(object sender, RoutedEventArgs e)
        {
            // set rotation axis
            rotation.Axis = new System.Windows.Media.Media3D.Vector3D(1, 0, 0);
            // set camera position
            camera.Position = new System.Windows.Media.Media3D.Point3D(6, 0, 0);
        }

        private void yRadio_Checked(object sender, RoutedEventArgs e)
        {
            // set rotation axis
            rotation.Axis = new System.Windows.Media.Media3D.Vector3D(0, 1, 0);
            // set camera position
            camera.Position = new System.Windows.Media.Media3D.Point3D(6, 0, 0);
        }

        private void zRadio_Checked(object sender, RoutedEventArgs e)
        {
            // set rotation axis
            rotation.Axis = new System.Windows.Media.Media3D.Vector3D(0, 0, 1);
            // set camera position
            camera.Position = new System.Windows.Media.Media3D.Point3D(6, 0, 1);
        }
    }
}
