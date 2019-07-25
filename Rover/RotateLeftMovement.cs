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
            roverMap.MapCompass.Needle= (roverMap.MapCompass.Needle+45);
            if (roverMap.MapCompass.Needle==Direction.OtherEast)
                roverMap.MapCompass.Needle = Direction.East;
        }
    }
}
