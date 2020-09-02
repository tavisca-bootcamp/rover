using MarsRover.Common;
using MarsRover.Factories;
using MarsRover.Interfaces;

namespace MarsRover.Models.Directions
{
    public class West
        : IDirection
    {
        #region Public methods
        public string GetDirectionString()
        {
            return Direction.West.ToString();
        }

        public Location MoveForward(Location location)
        {
            return new Location(location.X - 1, location.Y);
        }

        public IDirection RotateLeft()
        {
            DirectionFactory directionFactory = new DirectionFactory();
            return directionFactory.GetDirection(Direction.South);
        }

        public IDirection RotateRight()
        {
            DirectionFactory directionFactory = new DirectionFactory();
            return directionFactory.GetDirection(Direction.North);
        } 
        #endregion
    }
}
