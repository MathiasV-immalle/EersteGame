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
    public class Baan
    {
        private Rectangle rect;
        private int x = 0;
        private int y = 139;
        private double hoogte = 40;
        private double breedte = 517;
        public Baan() 
        {
            CreateBaan();
            UpdateBaan();
        }

        public void MoveUp(int ystep)
        {
            y = y - ystep;
            UpdateBaan();
        }

        public void MoveDown(int ystep)
        {
            y = y + ystep;
            UpdateBaan();
        }

        public void MoveRight(int xstep)
        {
            x = x + xstep;
            UpdateBaan();
        }

        public void MoveLeft(int xstep)
        {
            x = x - xstep;
            UpdateBaan();
        }

        private void Grow(double change)
        {
            hoogte = hoogte * change;
            breedte = breedte * change;
            UpdateBaan();
        }

        private void Shrink(double change)
        {
            hoogte = hoogte / change;
            breedte = breedte / change;
            UpdateBaan();
        }

        public void DisplayOn(Canvas canvas)
        {
            canvas.Children.Add(rect);
        }

        public void CreateBaan()
        {
            rect = new Rectangle();
            rect.Fill = new SolidColorBrush(Colors.SandyBrown);
            rect.Stroke = new SolidColorBrush(Colors.SaddleBrown);
            rect.StrokeThickness = 2;
        }

        private void UpdateBaan()
        {
            rect.Margin = new Thickness(x, y, 0, 0);
            rect.Height = hoogte;
            rect.Width = hoogte;
        }       
    }
}
