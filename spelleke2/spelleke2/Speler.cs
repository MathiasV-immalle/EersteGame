using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace spelleke2
{
    public class Speler
    {
        private Ellipse elly;
        private int x = 100;
        private int y = 100;
        private double diameter = 20;

        public Speler()
        {
            CreateSpeler();
            UpdateSpeler();
        }

        public void Grow(double change)
        {
            diameter = diameter * change;
            UpdateSpeler();
        }

        private void Shrink(double change)
        {
            diameter = diameter / change;
            UpdateSpeler();
        }

        public void DisplayOn(Canvas canvas)
        {
            canvas.Children.Add(elly);
        }

        public void CreateSpeler()
        {
            elly = new Ellipse();
            elly.Stroke = new SolidColorBrush(Colors.Aqua);
            elly.StrokeThickness = 3;
            elly.Fill = new SolidColorBrush(Colors.White);
        }

        private void UpdateSpeler()
        {
            elly.Margin = new Thickness(x, y, 0, 0);
            elly.Width = diameter;
            elly.Height = diameter;
        }
    }
}
