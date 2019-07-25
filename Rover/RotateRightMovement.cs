using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    public class RotateRightMovement : IRotation
    {
        void IMovement.Update(Map roverMap)
        {

            roverMap.MapCompass.Needle = (roverMap.MapCompass.Needle - 45);
            if (roverMap.MapCompass.Needle==Direction.otherSouthEast)
                roverMap.MapCompass.Needle = Direction.SouthEast;
        }
    }
}
