using spelleke2;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Baan baan;
        private Speler speler;

        public MainWindow()
        {
            InitializeComponent();
            baan = new Baan();
            baan.DisplayOn(canvas);
            speler = new Speler();
            speler.DisplayOn(canvas);
            //canvas.Children.Add(elly);

        }

        private void MoveUpButton_Click(object sender, RoutedEventArgs e)
        {
            baan.MoveDown(5);
            //y = y - 10;
            //elly.Margin = new Thickness(x, y, 0, 0);
        }

        private void MoveDownButton_Click(object sender, RoutedEventArgs e)
        {
            baan.MoveUp(5);
            //y = y + 10;
            //elly.Margin = new Thickness(x, y, 0, 0);
        }

        private void MoveLeftButton_Click(object sender, RoutedEventArgs e)
        {
            baan.MoveRight(5);
            //x = x - 10;
            //elly.Margin = new Thickness(x, y, 0, 0);
        }

        private void MoveRightButton_Click(object sender, RoutedEventArgs e)
        {
            baan.MoveLeft(5);
            //x = x + 10;
            //elly.Margin = new Thickness(x, y, 0, 0);
        }

        private void GrowButton_Click(object sender, RoutedEventArgs e)
        {
            baan.Grow(1.25);
            speler.Grow(1.25);
            //if (elly.Height < 40)
            //{
            //    elly.Height = elly.Height + 10;
            //    elly.Width = elly.Width + 10;
            //} else { }
        }

        private void ShrinkButton_Click(object sender, RoutedEventArgs e)
        {
            baan.Shrink(1.25);
            //if (elly.Height > 20)
            //{
            //    elly.Height = elly.Height - 10;
            //    elly.Width = elly.Width - 10;
            //}
            //else { }
        }
    }
}
