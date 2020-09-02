using MarsRover.Common;
using MarsRover.Factories;
using MarsRover.Interfaces;

namespace MarsRover.Models.Directions
{
    public class East : IDirection
    {
        #region Public methods
        public string GetDirectionString()
        {
            return Direction.East.ToString();
        }

        public Location MoveForward(Location location)
        {
            return new Location(location.X + 1, location.Y);
        }

        public IDirection RotateLeft()
        {
            DirectionFactory directionFactory = new DirectionFactory();
            return directionFactory.GetDirection(Direction.North);
        }

        public IDirection RotateRight()
        {
            DirectionFactory directionFactory = new DirectionFactory();
            return directionFactory.GetDirection(Direction.South);
        } 
        #endregion
    }
}
