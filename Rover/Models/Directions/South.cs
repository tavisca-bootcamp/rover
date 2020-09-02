using MarsRover.Common;
using MarsRover.Factories;
using MarsRover.Interfaces;

namespace MarsRover.Models.Directions
{
    public class South : IDirection
    {
        #region Public methods
        public string GetDirectionString()
        {
            return Direction.South.ToString();
        }

        public Location MoveForward(Location location)
        {
            return new Location(location.X, location.Y - 1);
        }

        public IDirection RotateLeft()
        {
            DirectionFactory directionFactory = new DirectionFactory();
            return directionFactory.GetDirection(Direction.East);
        }

        public IDirection RotateRight()
        {
            DirectionFactory directionFactory = new DirectionFactory();
            return directionFactory.GetDirection(Direction.West);
        } 
        #endregion
    }
}
