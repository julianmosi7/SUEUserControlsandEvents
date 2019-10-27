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

namespace MyUserControlsLib
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SlideProzent.Min = 0;
            SlideProzent.Max = 100;
            SlideProzent.TextboxBackground = Brushes.LightBlue;
            SlideProzent.Title = "Prozent";

            SlideUeberschrift.Min = 0;
            SlideUeberschrift.Max = 50;
            SlideUeberschrift.TextboxBackground = Brushes.GreenYellow;
            SlideUeberschrift.Title = "Ueberschrift";
        }               
    }
}
