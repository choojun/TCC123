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

namespace U3_WpfApp_Polygons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.polyLine.Points = points; // assign Polyline points
            this.polygon.Points = points; // assign Polygon points
            this.filledPolygon.Points = points; // assign filled Polygon points

            this.polyLine.Visibility = System.Windows.Visibility.Visible;
            this.polygon.Visibility = System.Windows.Visibility.Visible;
            this.filledPolygon.Visibility = System.Windows.Visibility.Visible;
        }

        // stores the collection of points for the multi-sided shapes
        private PointCollection points = new PointCollection();

        private void lineRadio_Checked(object sender, RoutedEventArgs e)
        {
            // Polyline is visible, the other two are not
            polyLine.Visibility = System.Windows.Visibility.Visible;
            polygon.Visibility = System.Windows.Visibility.Collapsed;
            filledPolygon.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void polygonRadio_Checked(object sender, RoutedEventArgs e)
        {
            // Polygon is visible, the other two are not
            polyLine.Visibility = System.Windows.Visibility.Collapsed;
            polygon.Visibility = System.Windows.Visibility.Visible;
            filledPolygon.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void filledPolygonRadio_Checked(object sender, RoutedEventArgs e)
        {
            // filled Polygon is visible, the other two are not
            polyLine.Visibility = System.Windows.Visibility.Collapsed;
            polygon.Visibility = System.Windows.Visibility.Collapsed;
            filledPolygon.Visibility = System.Windows.Visibility.Visible;
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            points.Clear(); // clear the points from the collection
        }

        private void drawCanvas_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            points.Add(e.GetPosition(drawCanvas)); // add point to collection
        }
    }
}
