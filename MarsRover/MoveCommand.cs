﻿namespace MarsRover.Commands
{
    public class MoveCommand : ICommand
    {
        public void Execute(Rover rover)
        {
            rover.Move();
        }
    }

}
