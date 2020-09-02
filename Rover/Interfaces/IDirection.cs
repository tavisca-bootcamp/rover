using MarsRover.Models;

namespace MarsRover.Interfaces
{
    public interface IDirection
    {
        IDirection RotateLeft();
        IDirection RotateRight();
        Location MoveForward(Location location);
        string GetDirectionString();
    }
}
