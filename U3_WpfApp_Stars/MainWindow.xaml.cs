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

namespace U3_WpfApp_Stars
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // used to get random values for colors
            Random random = new Random(); 
            // create stars with loop
            for (int count = 1; count <= 12; count++)
            {
                // create a new polygon object
                Polygon newStar = new Polygon();
                // copy the points collection
                newStar.Points = star.Points;

                // create a four element Byte array
                byte[] colorValues = new byte[4];
                // creates four random values
                random.NextBytes(colorValues);
                // creates a random color brush
                newStar.Fill = new SolidColorBrush(Color.FromArgb(colorValues[0], colorValues[1], colorValues[2], colorValues[3])); 

                // apply a rotation to the shape
                RotateTransform rotate = new RotateTransform(count * 20, 150, 150);
                newStar.RenderTransform = rotate;
                // add the polygon to the window
                mainCanvas.Children.Add(newStar); 
            }
        }
    }
}
