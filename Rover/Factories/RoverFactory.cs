using MarsRover.Interfaces;
using MarsRover.Models;

namespace MarsRover.Factories
{
    class RoverFactory
    {
        public IRover GetRover(Location coOrdinates, IDirection direction)
        {
            return new Rover(coOrdinates, direction);
        }
    }
}
