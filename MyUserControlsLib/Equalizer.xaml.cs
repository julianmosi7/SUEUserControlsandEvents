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
            get => progVal1.Value + progVal2.Value + progVal3.Value;
            set
            {
                
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
