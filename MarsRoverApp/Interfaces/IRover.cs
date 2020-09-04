using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRoverApp.Interfaces
{
    public interface IRover
    {
        int XCoordinate { get; set; }
        int YCoordinate { get; set; }
        string Direction { get; set; }
    }
}
