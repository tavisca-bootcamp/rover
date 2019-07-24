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
        public Compass compass { get; set; }
        public Map(Location currentLocation, SurfaceArea totalArea)
        {
            CurrentLocation = currentLocation;
            TotalArea = totalArea;
        }
    }
}


