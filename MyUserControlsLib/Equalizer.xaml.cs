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
using System.ComponentModel;

namespace MyUserControlsLib
{
    /// <summary>
    /// Interaction logic for Equlizer.xaml
    /// </summary>
    public partial class Equlizer : UserControl
    {       
        [Category("Data"), Description("See the current value")]
        public double Val
        {
            
            get => Double.Parse($"{progVal1.Value}{progVal2.Value}{progVal3.Value}");
            set
            {
                progVal1.Value = 0;
                lblVal1.Content = 0;
                progVal2.Value = 0;
                lblVal2.Content = 0;
                progVal3.Value = 0;
                lblVal3.Content = 0;

                if (value.ToString().Length < 2)
                {                    
                    progVal3.Value = value;
                    lblVal3.Content = progVal3.Value;
                }else if(value.ToString().Length < 3)
                {                                 
                    progVal2.Value = Double.Parse(value.ToString().Substring(0, 1));
                    lblVal2.Content = progVal2.Value;
                    progVal3.Value = Double.Parse(value.ToString().Substring(1, 1));
                    lblVal3.Content = progVal3.Value;
                }else if(value.ToString().Length < 4)
                {
                    progVal1.Value = Double.Parse(value.ToString().Substring(0, 1));
                    lblVal1.Content = progVal1.Value;
                    progVal2.Value = Double.Parse(value.ToString().Substring(1, 1));
                    lblVal2.Content = progVal2.Value;
                    progVal3.Value = Double.Parse(value.ToString().Substring(2, 1));
                    lblVal3.Content = progVal3.Value;
                }
            }
        }        

        public Brush BarBackground
        {
            get => progVal1.Background;
            set
            {
                progVal1.Background = value;
                progVal2.Background = value;
                progVal3.Background = value;
            }
        }        

        public Brush BarForeground
        {
            get => progVal1.Foreground;
            set
            {
                progVal1.Foreground = value;
                progVal2.Foreground = value;
                progVal3.Foreground = value;
            }
        }


        public Equlizer()
        {
            InitializeComponent();
        }

        private void ProgMouseClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
