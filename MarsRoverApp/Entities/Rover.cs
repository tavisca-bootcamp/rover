using MarsRoverApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRoverApp.Entities
{
    public class Rover : IRover
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public string Direction { get; set; }
        private static readonly char MessageSeperator = ' ';
        public Rover(ILandingSurface landingSurface, string roverPosition, string roverCommands)
        {

            TranslateRoverPosition(roverPosition);
            if (!IsWithinLandingSurface(landingSurface))
            {
                throw new InvalidOperationException();
            }
            else
            {
                TranslateRoverCommands(roverCommands);
            }
        }

        #region Private Methods
        private void TranslateRoverPosition(string roverPosition)
        {
            string[] roverPositionMsgSplit = roverPosition.Split(Rover.MessageSeperator);

            int xCoordinateIndex = 0;
            int yCoordinateIndex = 1;
            int directionIndex = 2;

            this.XCoordinate = Convert.ToInt32(roverPositionMsgSplit[xCoordinateIndex]);
            this.YCoordinate = Convert.ToInt32(roverPositionMsgSplit[yCoordinateIndex]);
            this.Direction = roverPositionMsgSplit[directionIndex];
        }

        private void TranslateRoverCommands(string roverCommands)
        {
            char[] commands = roverCommands.ToCharArray();

            foreach (char command in commands)
            {
                switch (command.ToString())
                {
                    case RoverCommands.MoveForward:
                        MoveForward();
                        break;

                    case RoverCommands.SpinLeft:
                    case RoverCommands.SpinRight:
                        Spin(command.ToString());
                        break;
                }
            }
        }

        private bool IsWithinLandingSurface(ILandingSurface landingSurface)
        {
            return (XCoordinate >= 0) && (XCoordinate < landingSurface.XCoordinate) &&
                (YCoordinate >= 0) && (YCoordinate < landingSurface.YCoordinate);
        }

        private void MoveForward()
        {
            switch (this.Direction)
            {
                case CardinalDirection.North:
                    YCoordinate += 1;
                    break;

                case CardinalDirection.East:
                    XCoordinate += 1;
                    break;

                case CardinalDirection.South:
                    YCoordinate -= 1;
                    break;

                case CardinalDirection.West:
                    XCoordinate -= 1;
                    break;
            }
        }

        private void Spin(string directionCommand)
        {
            switch (directionCommand.ToUpper())
            {
                case RoverCommands.SpinLeft:
                    SpinLeft();
                    break;

                case RoverCommands.SpinRight:
                    SpinRight();
                    break;
                default:
                    throw new ArgumentException();
            }
        }



        private void SpinLeft()
        {
            switch (this.Direction)
            {
                case CardinalDirection.North:
                    Direction = CardinalDirection.West;
                    break;

                case CardinalDirection.West:
                    Direction = CardinalDirection.South;
                    break;

                case CardinalDirection.South:
                    Direction = CardinalDirection.East;
                    break;

                case CardinalDirection.East:
                    Direction = CardinalDirection.North;
                    break;
            }
        }

        private void SpinRight()
        {
            switch (Direction)
            {
                case CardinalDirection.North:
                    Direction = CardinalDirection.East;
                    break;

                case CardinalDirection.East:
                    Direction = CardinalDirection.South;
                    break;

                case CardinalDirection.South:
                    Direction = CardinalDirection.West;
                    break;

                case CardinalDirection.West:
                    Direction = CardinalDirection.North;
                    break;
            }
        }
        #endregion
    }
}
