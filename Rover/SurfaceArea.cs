using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Rover
{
    public class SurfaceArea
    {
        public Location UpperRightCoordinates { set; get; }
        public Location LowerLeftCoordinates { set; get; }
        public SurfaceArea(Location upperRightCoordinates)
        {
            LowerLeftCoordinates = new Location(0, 0);
            UpperRightCoordinates = upperRightCoordinates;
        }
        public bool HasLocation(Location location)
        {
            if ((location.XCoordinate <= UpperRightCoordinates.XCoordinate) && (location.YCoordinate <= UpperRightCoordinates.YCoordinate) && (location.XCoordinate >= LowerLeftCoordinates.XCoordinate) && (location.YCoordinate >= LowerLeftCoordinates.YCoordinate))
                return true;
            return false;
        }
    }
}


