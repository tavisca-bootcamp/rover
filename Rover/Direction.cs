using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    public enum Direction
    {
        East=0,
        NorthEast=45,
        North=90,
        NorthWest=135,
        West=180,
        SouthWest=225,
        South=270,
        SouthEast=315,
        OtherEast=360,
        otherSouthEast=-45
    }
}
