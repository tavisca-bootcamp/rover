namespace MarsRover.Commands
{
    public class RotateLeftCommand : ICommand
    {
        public void Execute(Rover rover)
        {
            rover.TurnLeft();
        }
    }

}
