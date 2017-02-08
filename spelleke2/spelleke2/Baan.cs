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
        // Banen
        private Rectangle Baan001;
        private Rectangle Baan002;
        private Rectangle Baan001002Cross;
        // X & Y
        private int xBaan001 = 0;
        private int yBaan001 = 139;
        private int xBaan002 = 320;
        private int yBaan002 = 0;
        private int xBaan001002Cross = 310;
        private int yBaan001002Cross = 141;

        // Hoogte & Breedte
        private int Baan001Hoogte = 40;
        private int Baan001Breedte = 517;
        private int Baan002Hoogte = 350;
        private int Baan002Breedte = 40;
        private int Baan001002CrossHoogte = 36;
        private int Baan001002CrossBreedte = 60;

        public Baan() 
        {
            CreateBaan();
            UpdateBaan();
        }

        public void MoveUp(int ystep)
        {
            yBaan001 = yBaan001 - ystep;
            yBaan002 = yBaan002 - ystep;
            yBaan001002Cross = yBaan001002Cross - ystep;
            UpdateBaan();
        }

        public void MoveDown(int ystep)
        {
            yBaan001 = yBaan001 + ystep;
            yBaan002 = yBaan002 + ystep;
            yBaan001002Cross = yBaan001002Cross + ystep;
            UpdateBaan();
        }

        public void MoveRight(int xstep)
        {
            xBaan001 = xBaan001 + xstep;
            xBaan002 = xBaan002 + xstep;
            xBaan001002Cross = xBaan001002Cross + xstep;
            UpdateBaan();
        }

        public void MoveLeft(int xstep)
        {
            xBaan001 = xBaan001 - xstep;
            xBaan002 = xBaan002 - xstep;
            xBaan001002Cross = xBaan001002Cross - xstep;
            UpdateBaan();
        }

        public void DisplayOn(Canvas canvas)
        {
            canvas.Children.Add(Baan001);
            canvas.Children.Add(Baan002);
            canvas.Children.Add(Baan001002Cross);
        }

        public void CreateBaan()
        {
            // Baan001
            Baan001 = new Rectangle();
            Baan001.Fill = new SolidColorBrush(Colors.SandyBrown);
            Baan001.Stroke = new SolidColorBrush(Colors.SaddleBrown);
            Baan001.StrokeThickness = 2;
            // Baan002
            Baan002 = new Rectangle();
            Baan002.Fill = new SolidColorBrush(Colors.SandyBrown);
            Baan002.Stroke = new SolidColorBrush(Colors.SaddleBrown);
            Baan002.StrokeThickness = 2;
            // Baan001002Cross
            Baan001002Cross = new Rectangle();
            Baan001002Cross.Fill = new SolidColorBrush(Colors.SandyBrown);
        }

        private void UpdateBaan()
        {
            // Baan001
            Baan001.Margin = new Thickness(xBaan001, yBaan001, 0, 0);
            Baan001.Height = Baan001Hoogte;
            Baan001.Width = Baan001Breedte;
            // Baan002
            Baan002.Margin = new Thickness(xBaan002, yBaan002, 0, 0);
            Baan002.Height = Baan002Hoogte;
            Baan002.Width = Baan002Breedte;
            // Baan001002Cross
            Baan001002Cross.Margin = new Thickness(xBaan001002Cross, yBaan001002Cross, 0, 0);
            Baan001002Cross.Height = Baan001002CrossHoogte;
            Baan001002Cross.Width = Baan001002CrossBreedte;
        }
    }
}
