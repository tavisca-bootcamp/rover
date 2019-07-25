using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    public class ForwardMovement : IMovement
    {
        void IMovement.Update(Map roverMap)
        {
            int yCoordinate= roverMap.CurrentLocation.YCoordinate, xCoordinate= roverMap.CurrentLocation.XCoordinate;
            if (roverMap.MapCompass.Needle == Direction.North)
                yCoordinate += 1;
            if (roverMap.MapCompass.Needle == Direction.South)
                yCoordinate -= 1;
            if (roverMap.MapCompass.Needle == Direction.West)
                xCoordinate -= 1;
            if (roverMap.MapCompass.Needle == Direction.East)
                xCoordinate += 1;
            if (roverMap.MapCompass.Needle == Direction.NorthEast) { yCoordinate += 1; xCoordinate += 1; }
            if (roverMap.MapCompass.Needle == Direction.SouthEast) { yCoordinate -= 1; xCoordinate += 1; }
            if (roverMap.MapCompass.Needle == Direction.NorthWest) { yCoordinate += 1; xCoordinate -= 1; }
            if (roverMap.MapCompass.Needle == Direction.SouthWest) { yCoordinate -= 1; xCoordinate -= 1; }
            if (roverMap.TotalArea.HasLocation(new Location(xCoordinate, yCoordinate)))
                roverMap.CurrentLocation = new Location(xCoordinate, yCoordinate);
        }
    }
}
