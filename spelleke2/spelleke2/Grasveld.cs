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

namespace spelleke2
{
    public class Grasveld
    {
        // Banen
        private Rectangle Veld;
        // X & Y
        private int xVeld = 0;
        private int yVeld = 0;

        // Hoogte & Breedte
        private int VeldHoogte = 350;
        private int VeldBreedte = 517;

        public Grasveld()
        {
            Veld = new Rectangle();
            Veld.Fill = new SolidColorBrush(Colors.LightGreen);
            Veld.Stroke = new SolidColorBrush(Colors.ForestGreen);
            Veld.StrokeThickness = 2;
            Veld.Margin = new Thickness(xVeld, yVeld, 0, 0);
            Veld.Height = VeldHoogte;
            Veld.Width = VeldBreedte;
        }

        public void DisplayOn(Canvas canvas)
        {
            canvas.Children.Add(Veld);
        }
    }
}

