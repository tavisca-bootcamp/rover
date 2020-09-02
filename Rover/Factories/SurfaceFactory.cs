using MarsRover.Interfaces;
using MarsRover.Models;

namespace MarsRover.Factories
{
    class SurfaceFactory
    {
        public ISurface GetSurface(string dimenstions)
        {
            return new Plateau(dimenstions);
        }
    }
}
