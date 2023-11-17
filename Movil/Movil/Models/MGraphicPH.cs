using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Movil.Models
{
    public class MGraphicPh : INotifyPropertyChanged
    {
        private int hour;
        private int ph;

        public event PropertyChangedEventHandler PropertyChanged;


        public int Hour
        {
            get { return hour; } 
            set {  hour = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hora"));
            }
        }

        public int Ph
        {
            get { return ph; }
            set
            {
                ph = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PH"));
            }
        }

    }
}
