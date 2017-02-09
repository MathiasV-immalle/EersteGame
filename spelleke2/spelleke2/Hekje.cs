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
    public class Hekje
    {
        // Banen
        private Rectangle Hekje00101;
        private Rectangle Hekje00102;
        private Rectangle Hekje001022;
        private Rectangle Hekje00103;
        private Rectangle Hekje00104;
        private Rectangle Hekje00105;
        //private Rectangle Huis002;
        // X & Y
        private int xHekje00101 = 195;
        private int yHekje00101 = 15;
        private int xHekje00102 = 195;
        private int yHekje00102 = 115;
        private int xHekje001022 = 195;
        private int yHekje001022 = 120;
        private int xHekje00103 = 205;
        private int yHekje00103 = 115;
        private int xHekje00104 = 195;
        private int yHekje00104 = 15;
        private int xHekje00105 = 313;
        private int yHekje00105 = 15;
        //private int xHuis002 = 320;
        //private int yHuis002 = 0;

        // Hoogte & Breedte
        private int Hekje00101Hoogte = 115;
        private int Hekje00101Breedte = 2;
        private int Hekje00102Hoogte = 2;
        private int Hekje00102Breedte = 20;
        private int Hekje001022Hoogte = 2;
        private int Hekje001022Breedte = 20;
        private int Hekje00103Hoogte = 15;
        private int Hekje00103Breedte = 2;
        private int Hekje00104Hoogte = 2;
        private int Hekje00104Breedte = 90;
        private int Hekje00105Hoogte = 40;
        private int Hekje00105Breedte = 2;
        //private double Huis002Hoogte = 350;
        //private double Huis002Breedte = 40;

        public Hekje()
        {
            CreateHuis();
            UpdateHuis();
        }

        public void MoveUp(int ystep)
        {
            yHekje00101 = yHekje00101 - ystep;
            yHekje00102 = yHekje00102 - ystep;
            yHekje001022 = yHekje001022 - ystep;
            yHekje00103 = yHekje00103 - ystep;
            yHekje00104 = yHekje00104 - ystep;
            yHekje00105 = yHekje00105 - ystep;
            //yHuis002 = yHuis002 - ystep;
            UpdateHuis();
        }

        public void MoveDown(int ystep)
        {
            yHekje00101 = yHekje00101 + ystep;
            yHekje00102 = yHekje00102 + ystep;
            yHekje001022 = yHekje001022 + ystep;
            yHekje00103 = yHekje00103 + ystep;
            yHekje00104 = yHekje00104 + ystep;
            yHekje00105 = yHekje00105 + ystep;
            //yHuis002 = yHuis002 + ystep;
            UpdateHuis();
        }

        public void MoveRight(int xstep)
        {
            xHekje00101 = xHekje00101 + xstep;
            xHekje00102 = xHekje00102 + xstep;
            xHekje001022 = xHekje001022 + xstep;
            xHekje00103 = xHekje00103 + xstep;
            xHekje00104 = xHekje00104 + xstep;
            xHekje00105 = xHekje00105 + xstep;
            //xHuis002 = xHuis002 + xstep;
            UpdateHuis();
        }

        public void MoveLeft(int xstep)
        {
            xHekje00101 = xHekje00101 - xstep;
            xHekje00102 = xHekje00102 - xstep;
            xHekje001022 = xHekje001022 - xstep;
            xHekje00103 = xHekje00103 - xstep;
            xHekje00104 = xHekje00104 - xstep;
            xHekje00105 = xHekje00105 - xstep;
            //xHuis002 = xHuis002 - xstep;
            UpdateHuis();
        }

        public void DisplayOn(Canvas canvas)
        {
            canvas.Children.Add(Hekje00101);
            canvas.Children.Add(Hekje00102);
            canvas.Children.Add(Hekje001022);
            canvas.Children.Add(Hekje00103);
            canvas.Children.Add(Hekje00104);
            canvas.Children.Add(Hekje00105);
            //canvas.Children.Add(Huis002);
        }

        public void RemoveFrom(Canvas canvas)
        {
            canvas.Children.Remove(Hekje00101);
            canvas.Children.Remove(Hekje00102);
            canvas.Children.Remove(Hekje001022);
            canvas.Children.Remove(Hekje00103);
            canvas.Children.Remove(Hekje00104);
            canvas.Children.Remove(Hekje00105);
            //canvas.Children.Remove(Huis002);
        }

        public void CreateHuis()
        {
            // Huis001
            Hekje00101 = new Rectangle();
            Hekje00101.Fill = new SolidColorBrush(Colors.White);
            Hekje00102 = new Rectangle();
            Hekje00102.Fill = new SolidColorBrush(Colors.White);
            Hekje001022 = new Rectangle();
            Hekje001022.Fill = new SolidColorBrush(Colors.White);
            Hekje00103 = new Rectangle();
            Hekje00103.Fill = new SolidColorBrush(Colors.White);
            Hekje00104 = new Rectangle();
            Hekje00104.Fill = new SolidColorBrush(Colors.White);
            Hekje00105 = new Rectangle();
            Hekje00105.Fill = new SolidColorBrush(Colors.White);

            //// Huis002
            //Huis002 = new Rectangle();
            //Huis002.Fill = new SolidColorBrush(Colors.SandyBrown);
            //Huis002.Stroke = new SolidColorBrush(Colors.SaddleBrown);
            //Huis002.StrokeThickness = 2;
        }

        private void UpdateHuis()
        {
            // Huis001
            Hekje00101.Margin = new Thickness(xHekje00101, yHekje00101, 0, 0);
            Hekje00101.Height = Hekje00101Hoogte;
            Hekje00101.Width = Hekje00101Breedte;
            Hekje00102.Margin = new Thickness(xHekje00102, yHekje00102, 0, 0);
            Hekje00102.Height = Hekje00102Hoogte;
            Hekje00102.Width = Hekje00102Breedte;
            Hekje001022.Margin = new Thickness(xHekje001022, yHekje001022, 0, 0);
            Hekje001022.Height = Hekje001022Hoogte;
            Hekje001022.Width = Hekje001022Breedte;
            Hekje00103.Margin = new Thickness(xHekje00103, yHekje00103, 0, 0);
            Hekje00103.Height = Hekje00103Hoogte;
            Hekje00103.Width = Hekje00103Breedte;
            Hekje00104.Margin = new Thickness(xHekje00104, yHekje00104, 0, 0);
            Hekje00104.Height = Hekje00104Hoogte;
            Hekje00104.Width = Hekje00104Breedte;
            Hekje00105.Margin = new Thickness(xHekje00105, yHekje00105, 0, 0);
            Hekje00105.Height = Hekje00105Hoogte;
            Hekje00105.Width = Hekje00105Breedte;
            //// Huis002
            //Huis002.Margin = new Thickness(xHuis002, yHuis002, 0, 0);
            //Huis002.Height = Huis002Hoogte;
            //Huis002.Width = Huis002Breedte;
        }
    }
}

