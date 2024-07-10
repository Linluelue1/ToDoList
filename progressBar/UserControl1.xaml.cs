using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace CircularProgressBar
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateProgress(double progress)
        {
            if (progress < 0 || progress > 1)
                throw new ArgumentOutOfRangeException("Progress must be between 0 and 1.");

            // Calculate the angle for the progress
            double angle = 360 * progress;

            // Create the arc for the progress
            var arc = new ArcSegment
            {
                Point = new Point(100, 100), // This should be the center of your ellipse
                Size = new Size(100, 100), // This should match the radius of your ellipse
                SweepDirection = SweepDirection.Counterclockwise,
                IsLargeArc = angle > 180 // This determines if the arc is a long arc or a short arc
            };

            // Create a PathGeometry to hold the arc
            var pathGeometry = new PathGeometry();
            var pathFigure = new PathFigure { StartPoint = new Point(100, 0), IsClosed = false };
            pathFigure.Segments.Add(arc);
            pathGeometry.Figures.Add(pathFigure);

            // Apply the geometry to the progress path
            progressPath.Data = pathGeometry;

            // Optionally, animate the progress
            DoubleAnimation animation = new DoubleAnimation
            {
                From = progress,
                To = progress,
                Duration = new Duration(TimeSpan.FromSeconds(1))
            };
            progressPath.BeginAnimation(Path.StrokeThicknessProperty, animation);
        }
    }
}