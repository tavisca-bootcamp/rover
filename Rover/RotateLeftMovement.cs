using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    public class RotateLeftMovement : IRotation
    {
        void IMovement.Update(Map roverMap)
        {
            if (roverMap.MapCompass.Needle == Direction.North)
                roverMap.MapCompass.Needle = Direction.West;
            else if (roverMap.MapCompass.Needle == Direction.South)
                roverMap.MapCompass.Needle = Direction.East;
            else if (roverMap.MapCompass.Needle == Direction.West)
                roverMap.MapCompass.Needle = Direction.South;
            else
                roverMap.MapCompass.Needle = Direction.North;
        }
    }
}
