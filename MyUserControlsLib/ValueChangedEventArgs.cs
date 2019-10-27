using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUserControlsLib
{
    public delegate void ValueChangedEventHandler(object sender, ValueChangedEventArgs e);
    public class ValueChangedEventArgs : EventArgs
    {
        public double ValEvent { get; set; }

        public double ValEventBefore { get; set; }
    }
}
