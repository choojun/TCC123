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

namespace U3_WpfApp_Image
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

        private void btnTransform_Click(object sender, RoutedEventArgs e)
        {
            // Defining the TranslateTransform
            TranslateTransform moveImage = new TranslateTransform();

            // Setting the x,y parameters
            double xValue = 0, yValue = 0;
            double.TryParse(txtTransformXCoordinate.Text.Trim(), out xValue);
            moveImage.X = xValue;
            double.TryParse(txtTransformYCoordinate.Text.Trim(), out yValue);
            moveImage.Y = yValue;

            // Assigning the transform to the image
            imgImage.RenderTransform = moveImage;
        }

        private void btnRotate_Click(object sender, RoutedEventArgs e)
        {
            // Defining the RotateTransform
            RotateTransform rotateImage = new RotateTransform();

            // Setting the roatation angle
            double userAngle = 0;
            double.TryParse(txtRoateAngle.Text.Trim(), out userAngle);
            rotateImage.Angle = userAngle;

            // Assigning the transform to the image
            imgImage.RenderTransform = rotateImage;
        }

        private void btnSkew_Click(object sender, RoutedEventArgs e)
        {
            // Defining the SkewTransform
            SkewTransform skewImage = new SkewTransform();

            // Setting the x,y parameters
            double xValue = 0, yValue = 0;
            double.TryParse(txtSkewXCoordiante.Text.Trim(), out xValue);
            skewImage.AngleX = xValue;
            double.TryParse(txtSkewYCoordiante.Text.Trim(), out yValue);
            skewImage.AngleY = yValue;

            // Assigning the transform to the image
            imgImage.RenderTransform = skewImage;
        }

        private void btnScale_Click(object sender, RoutedEventArgs e)
        {
            // Defining the ScaleTransform
            ScaleTransform scaleImage = new ScaleTransform();

            // Setting the x,y parameters
            double xValue = 0, yValue = 0;
            double.TryParse(txtScaleXCoordiante.Text.Trim(), out xValue);
            scaleImage.ScaleX = xValue;
            double.TryParse(txtScaleYCoordiante.Text.Trim(), out yValue);
            scaleImage.ScaleY = yValue;

            // Assigning the transform to the image
            imgImage.RenderTransform = scaleImage;
        }
    }
}
