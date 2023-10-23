using System;
using System.Diagnostics.PerformanceData;
using System.Windows;

namespace LAB1 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow {
        private Rectangle _rectangle;

        public MainWindow() {
            InitializeComponent();
            _rectangle = new Rectangle();
        }

        public void Count(object sender, RoutedEventArgs e) {
            try {
                var x1_v = int.Parse(x1.Text);
                var x2_v = int.Parse(x2.Text);
                var y1_v = int.Parse(y1.Text);
                var y2_v = int.Parse(y2.Text);

                _rectangle.Point_1(x1_v, y1_v);
                _rectangle.Point_2(x2_v, y2_v);

                var sides = _rectangle.find_sides();

                width.Content = sides.Item1;
                height.Content = sides.Item2;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}