using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    public class Compass
    {
        public Direction Needle { set; get; }
        public Compass(char needle)
        {
            switch (needle)
            {
                case 'N':
                    Needle = Direction.North;
                break;
                case 'S':
                    Needle = Direction.South;
                    break;
                case 'E':
                    Needle = Direction.East;
                    break;
                case 'W':
                    Needle = Direction.West;
                break;
            }
        }
        public string GetStatus()
        {
            String status = String.Empty;
            if (Needle == Direction.North)
                status = "N";
            if (Needle == Direction.South)
                status = "S";
            if (Needle == Direction.East)
                status = "E";
            if (Needle == Direction.West)
                status = "W";
            return status;
        }
    }
}
