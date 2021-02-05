using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace roket_yer_bilgisayari.Models
{
    class RoketModel : INotifyPropertyChanged
    {

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged("Name"); }
        }

        private double _speed;

        public double Speed
        {
            get { return _speed; }
            set { _speed = value; OnPropertyChanged("Speed"); }
        }


        private double _longitude;

        public double Longitude
        {
            get { return _longitude; }
            set { _longitude = value; OnPropertyChanged("Longitude"); }
        }

        private double _latitude;

        public double Latitude
        {
            get { return _latitude; }
            set { _latitude = value; OnPropertyChanged("Latitude"); }
        }

        private double _altitude;

        public double Altitude
        {
            get { return _altitude; }
            set { _altitude = value; OnPropertyChanged("Altitude"); }
        }


        private double _pich;

        public double Pich
        {
            get { return _pich; }
            set { _pich = value; OnPropertyChanged("Pich"); }
        }

        private double _row;

        public double Row
        {
            get { return _row; }
            set { _row = value; OnPropertyChanged("Row"); }
        }

        private double _yaw;

        public double Yaw
        {
            get { return _yaw; }
            set { _yaw = value; OnPropertyChanged("Yaw"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
