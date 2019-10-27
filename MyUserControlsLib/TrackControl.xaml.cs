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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        [Category("Data"), Description("Set the current value")]


        public event EventHandler<ValueChangedEventArgs> ValueChanged;

               
        public int Min
        {
            get => Int32.Parse(sliVal.Minimum.ToString());
            set
            {
                sliVal.Minimum = value;
                lblVal1.Content = value;
            }
        }        

        public int Max
        {
            get => Int32.Parse(sliVal.Maximum.ToString());
            set
            {
                sliVal.Maximum = value;
                lblVal2.Content = value;
            }
        }        

        public double Val
        {
            get => sliVal.Value;
            set => sliVal.Value = value;
        }        

        /*
        public int Delta
        {
            
        }
        */

        public Brush TextboxBackground
        {
            get => txtVal.Background;
            set => txtVal.Background = value;
        }        

        public string Title
        {
            get => GroupBoxHeader.Header.ToString();
            set => GroupBoxHeader.Header = value;
        }


        public UserControl1()
        {
            InitializeComponent();
        }

        private void SliVal_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblVal3.Content = $"{sliVal.Value:0.0}";
            txtVal.Text = $"{sliVal.Value:0.0}";


            if (ValueChanged == null) return;
            ValueChanged(this, new ValueChangedEventArgs
            {
                ValEvent = sliVal.Value
            });
        }
    }
}
