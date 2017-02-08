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
        int stap = 40;
        
        // Banen
        private Baan Banen;
        // Veld
        private Grasveld Veld;
        // Huisjes
        private Huisje Huisjes;
        // Hekjes
        private Hekje Hekjes;
        // Speler
        private Speler speler;
        public MainWindow()
        {
            InitializeComponent();
            // Veld
            Veld = new Grasveld();
            Veld.DisplayOn(StartCanvas);
            // Banen
            Banen = new Baan();
            Banen.DisplayOn(StartCanvas);
            // Huisjes
            Huisjes = new Huisje();
            Huisjes.DisplayOn(StartCanvas);
            // Hekjes
            Hekjes = new Hekje();
            Hekjes.DisplayOn(StartCanvas);
            // Speler
            speler = new Speler();
            speler.DisplayOn(StartCanvas);

        }

        private void MoveUpButton_Click(object sender, RoutedEventArgs e)
        {
            Banen.MoveDown(stap);
            Huisjes.MoveDown(stap);
            Hekjes.MoveDown(stap);
        }
            
        private void MoveDownButton_Click(object sender, RoutedEventArgs e)
        {
            Banen.MoveUp(stap);
            Huisjes.MoveUp(stap);
            Hekjes.MoveUp(stap);
        }

        private void MoveLeftButton_Click(object sender, RoutedEventArgs e)
        {
            Banen.MoveRight(stap);
            Huisjes.MoveRight(stap);
            Hekjes.MoveRight(stap);
        }

        private void MoveRightButton_Click(object sender, RoutedEventArgs e)
        {
            Banen.MoveLeft(stap);
            Huisjes.MoveLeft(stap);
            Hekjes.MoveLeft(stap);
        }
    }
}
