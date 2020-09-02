using MarsRover.Common;
using MarsRover.Interfaces;
using System;

namespace MarsRover.Models
{
    public class Rover : IRover
    {
        #region Properties
        public Location InitialLocation { get; set; }
        public Location CurrentLocation { get; set; }
        public IDirection Direction { get; set; }
        public string Commands { get; set; }

        #endregion Properties
        public Rover(Location startingPoint, IDirection direction)
        {
            InitialLocation = CurrentLocation = startingPoint;
            Direction = direction;
        }
        #region Public methods
        public void Reset()
        {
            CurrentLocation = InitialLocation;
        }

        /// <summary>
        /// Check if Rover's current position is within boundaries of surface
        /// </summary>
        /// <param name="plateau"></param>
        /// <returns>True if within boundaries</returns>
        public bool IsWithinBoundaries(ISurface plateau)
        {
            return CurrentLocation.X >= 0
                && CurrentLocation.X <= plateau.Width
                && CurrentLocation.Y >= 0
                && CurrentLocation.Y <= plateau.Height;
        }

        /// <summary>
        /// Send a command to rover
        /// </summary>
        /// <param name="command">Command(L,R,M)</param>
        public void SendCommand(char command)
        {
            switch (command)
            {
                case RoverCommand.Move:
                    CurrentLocation = Direction.MoveForward(CurrentLocation);
                    break;
                case RoverCommand.Left:
                    Direction = Direction.RotateLeft();
                    break;
                case RoverCommand.Right:
                    Direction = Direction.RotateRight();
                    break;
                default:
                    throw new ArgumentException("Invalid Rover command");
            }
        }

        /// <summary>
        /// Send a sequence of commands
        /// </summary>
        /// <param name="commands">Command Sequence(e.g. "LRMLLR")</param>
        public void SendCommandSequence(string commands)
        {
            foreach (char command in commands)
            {
                SendCommand(command);
            }
        }

        public void SendCommandSequence()
        {
            foreach (char command in Commands)
            {
                SendCommand(command);
            }
        } 
        #endregion Public Methods
    }
}
