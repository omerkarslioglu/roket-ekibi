using roket_yer_bilgisayari.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roket_yer_bilgisayari.ViewModel
{
    class RoketViewModel
    {
        public static RoketModel YıldırımRoket = new RoketModel()
        {
            Name = "YıldırımRoket"
        };

        public static void setName(string name)
        {
            YıldırımRoket.Name = name;
        }

        public static void setAltitude(double altitude)
        {
            YıldırımRoket.Altitude = altitude;
        }

        public static void setSpeed(double speed)
        {
            YıldırımRoket.Speed = speed;
        }

        public static void setLatitude(double latitude)
        {
            YıldırımRoket.Latitude = latitude;
        }

        public static void setLongitude(double longitude)
        {
            YıldırımRoket.Longitude = longitude;
        }
    }
}
