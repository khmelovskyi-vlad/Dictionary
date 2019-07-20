using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Coordinates
    {
        public Coordinates(int latitude, int longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public override bool Equals(object obj)
        {
            return obj is Coordinates otherCoordinates && otherCoordinates.Latitude == this.Latitude && otherCoordinates.Longitude == this.Longitude;
        }
        public override int GetHashCode()
        {
            return Latitude.GetHashCode() ^ Longitude.GetHashCode();
        }
    }
}
