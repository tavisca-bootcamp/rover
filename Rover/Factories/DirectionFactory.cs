using MarsRover.Common;
using MarsRover.Interfaces;
using MarsRover.Models.Directions;
using System.Collections.Generic;

namespace MarsRover.Factories
{
    public class DirectionFactory
    {
        private static Dictionary<char, IDirection> directions = new Dictionary<char, IDirection>()
        {
            { Direction.North, new North()},
            { Direction.East, new East()},
            { Direction.South, new South()},
            { Direction.West, new West()}
        };

        public IDirection GetDirection(char direction)
        {
            return directions[direction];
        }
    }
}
