using System;

namespace MarsRover
{
    public class Rover
    {
        private Coordinate _currentCoordinate;
        public Direction _currentDirection;
        private Plateau _plateau;

        public Rover(Plateau plateau, Direction currentDirection, Coordinate currentCoordinate)
        {
            _currentCoordinate = currentCoordinate;
            _plateau = plateau;
            _currentDirection = currentDirection;
        }

        public void Run(string CommandString)
        {
            var RoverCommands = new CommandProcessor(CommandString).ToCommands();
            foreach(var command in RoverCommands)
            {
                command.Execute(this);
            }
        }

        public string GetCurrentLocation()
        {
            return _currentCoordinate.ToString().Trim() + " " + _currentDirection.ToString().Trim();
        }



        public void Move()
        {
            var PositionAfterMove = _currentCoordinate.NewCoordinatesForStepSize(_currentDirection.XAxisStepSize, _currentDirection.YAxisStepSize);
            
            if (_plateau.HasWithinBounds(PositionAfterMove))
                _currentCoordinate = _currentCoordinate.NewCoordinate(_currentDirection.XAxisStepSize, _currentDirection.YAxisStepSize);
        }

        public void TurnRight()
        {
            _currentDirection = _currentDirection.Right();
        }

        public void TurnLeft()
        {
            _currentDirection = _currentDirection.Left();
        }
    }
}