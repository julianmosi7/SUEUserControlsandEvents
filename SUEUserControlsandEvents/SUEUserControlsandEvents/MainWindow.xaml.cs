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
        string Path = @"Images\";
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
            SlideProzent.ValueChanged += ValueChangedEvent;

            SlideUeberschrift.Min = 0;
            SlideUeberschrift.Max = 50;
            SlideUeberschrift.TextboxBackground = Brushes.GreenYellow;
            SlideUeberschrift.Title = "Ueberschrift";
            SlideProzent.ValueChanged += ValueChangedEvent;

            SlideThousand.Min = 0;
            SlideThousand.Max = 1000;
            SlideThousand.Title = "0-1000";
            SlideProzent.ValueChanged += ValueChangedEvent;
            
            Equalizer1.BarForeground = Brushes.Red;
            Equalizer2.BarForeground = Brushes.Orange;

        }

        private void ValueChangedEvent(object sender, ValueChangedEventArgs e)
        {
            double maximal = 0;
            //Console.WriteLine($"Value changed to {e.ValEvent:0.0}");
            //Console.WriteLine($"Value before was {e.ValEventBefore:0.0}");            

            if (e.ValEventBefore.CompareTo(e.ValEvent) > 0)
            {
                //Console.WriteLine($"Value decreased");
                Arrow.Source = new BitmapImage(new Uri($"{Path}arrow_down.png", UriKind.Relative));
            }
            else if(e.ValEventBefore.CompareTo(e.ValEvent) < 0)
            {
                //Console.WriteLine($"Value increased");
                Arrow.Source = new BitmapImage(new Uri($"{Path}arrow_up.png",UriKind.Relative));
            }
                       
            Equalizer1.Val = Double.Parse($"{e.ValEvent:0}");
            Equalizer2.Val = Double.Parse($"{e.ValEvent:0}");
            SlideProzent.Val = Double.Parse($"{e.ValEvent:0}");
            SlideUeberschrift.Val = Double.Parse($"{e.ValEvent:0}");
            SlideThousand.Val = Double.Parse($"{e.ValEvent:0}");
            if (sender.Equals(SlideProzent))
            {
                maximal = 100;
            }else if (sender.Equals(SlideUeberschrift))
            {
                maximal = 50;
            }else if (sender.Equals(SlideThousand))
            {
                maximal = 1000;
            }

            Progressbar.Maximum = maximal;
            
            Progressbar.Value = Double.Parse($"{e.ValEvent:0}");            

            txtArrow.Text = $"{e.ValEvent:0}";
        }
    }
}
