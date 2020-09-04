using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRoverApp.Interfaces
{
    public interface ILandingSurface
    {
        int XCoordinate { get; }
        int YCoordinate { get; }
    }
}
