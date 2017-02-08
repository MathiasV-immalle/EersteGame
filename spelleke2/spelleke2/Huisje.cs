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
    public class Huisje
    {
        // Banen
        private Rectangle Huis001;
        private Rectangle Dak001;
        private Rectangle Deur001;
        private Rectangle Raam001;
        //private Rectangle Huis002;
        // X & Y
        private int xHuis001 = 215;
        private int yHuis001 = 55;
        private int xDak001 = 212;
        private int yDak001 = 54;
        private int xDeur001 = 286;
        private int yDeur001 = 96;
        private int xRaam001 = 225;
        private int yRaam001 = 96;
        //private int xHuis002 = 320;
        //private int yHuis002 = 0;

        // Hoogte & Breedte
        private int Huis001Hoogte = 80;
        private int Huis001Breedte = 100;
        private int Dak001Hoogte = 35;
        private int Dak001Breedte = 104;
        private int Deur001Hoogte = 35;
        private int Deur001Breedte = 25;
        private int Raam001Hoogte = 20;
        private int Raam001Breedte = 50;
        //private double Huis002Hoogte = 350;
        //private double Huis002Breedte = 40;

        public Huisje()
        {
            CreateHuis();
            UpdateHuis();
        }

        public void MoveUp(int ystep)
        {
            yHuis001 = yHuis001 - ystep;
            yDak001 = yDak001 - ystep;
            yDeur001 = yDeur001 - ystep;
            yRaam001 = yRaam001 - ystep;
            //yHuis002 = yHuis002 - ystep;
            UpdateHuis();
        }

        public void MoveDown(int ystep)
        {
            yHuis001 = yHuis001 + ystep;
            yDak001 = yDak001 + ystep;
            yDeur001 = yDeur001 + ystep;
            yRaam001 = yRaam001 + ystep;
            //yHuis002 = yHuis002 + ystep;
            UpdateHuis();
        }

        public void MoveRight(int xstep)
        {
            xHuis001 = xHuis001 + xstep;
            xDak001 = xDak001 + xstep;
            xDeur001 = xDeur001 + xstep;
            xRaam001 = xRaam001 + xstep;
            //xHuis002 = xHuis002 + xstep;
            UpdateHuis();
        }

        public void MoveLeft(int xstep)
        {
            xHuis001 = xHuis001 - xstep;
            xDak001 = xDak001 - xstep;
            xDeur001 = xDeur001 - xstep;
            xRaam001 = xRaam001 - xstep;
            //xHuis002 = xHuis002 - xstep;
            UpdateHuis();
        }

        public void DisplayOn(Canvas canvas)
        {
            canvas.Children.Add(Huis001);
            canvas.Children.Add(Dak001);
            canvas.Children.Add(Deur001);
            canvas.Children.Add(Raam001);
            //canvas.Children.Add(Huis002);
        }

        public void CreateHuis()
        {
            // Huis001
            Huis001 = new Rectangle();
            Huis001.Fill = new SolidColorBrush(Colors.Lavender);
            Huis001.Stroke = new SolidColorBrush(Colors.Purple);
            Huis001.StrokeThickness = 2;
            Dak001 = new Rectangle();
            Dak001.Fill = new SolidColorBrush(Colors.Purple);
            Dak001.Stroke = new SolidColorBrush(Colors.Lavender);
            Dak001.StrokeThickness = 2;
            Deur001 = new Rectangle();
            Deur001.Fill = new SolidColorBrush(Colors.Purple);
            Raam001 = new Rectangle();
            Raam001.Fill = new SolidColorBrush(Colors.LightBlue);
            Raam001.Stroke = new SolidColorBrush(Colors.Purple);
            Raam001.StrokeThickness = 2;
            //// Huis002
            //Huis002 = new Rectangle();
            //Huis002.Fill = new SolidColorBrush(Colors.SandyBrown);
            //Huis002.Stroke = new SolidColorBrush(Colors.SaddleBrown);
            //Huis002.StrokeThickness = 2;
        }

        private void UpdateHuis()
        {
            // Huis001
            Huis001.Margin = new Thickness(xHuis001, yHuis001, 0, 0);
            Huis001.Height = Huis001Hoogte;
            Huis001.Width = Huis001Breedte;
            Dak001.Margin = new Thickness(xDak001, yDak001, 0, 0);
            Dak001.Height = Dak001Hoogte;
            Dak001.Width = Dak001Breedte;
            Deur001.Margin = new Thickness(xDeur001, yDeur001, 0, 0);
            Deur001.Height = Deur001Hoogte;
            Deur001.Width = Deur001Breedte;
            Raam001.Margin = new Thickness(xRaam001, yRaam001, 0, 0);
            Raam001.Height = Raam001Hoogte;
            Raam001.Width = Raam001Breedte;
            //// Huis002
            //Huis002.Margin = new Thickness(xHuis002, yHuis002, 0, 0);
            //Huis002.Height = Huis002Hoogte;
            //Huis002.Width = Huis002Breedte;
        }
    }
}
