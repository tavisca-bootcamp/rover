using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Rover
{
    public class SurfaceArea
    {
        Location UpperRightCoordinates;
        Location LowerLeftCoordinates;
        public SurfaceArea(Location upperReftCoordinates)
        {
            LowerLeftCoordinates = new Location(0, 0);
            UpperRightCoordinates = upperReftCoordinates;
        }
    }
}


