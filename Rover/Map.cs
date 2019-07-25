using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Rover
{
    public class Map
    {
        public Location CurrentLocation { get; set; }
        public SurfaceArea TotalArea { get; set; }
        public Compass MapCompass { get; set; }
        public Map(Location currentLocation, SurfaceArea totalArea,Compass mapCompass)
        {
            CurrentLocation = currentLocation;
            TotalArea = totalArea;
            MapCompass = mapCompass;
        }
        public String GetStatus()
        {
            string status=String.Empty;
            status = status + CurrentLocation.GetStatus()+" "+MapCompass.GetStatus();
            return status;
        }

    }
}


