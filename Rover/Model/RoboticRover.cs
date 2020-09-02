using Rover.Common;
using Rover.Interfaces;
using System;

namespace Rover.Model
{
    public class RoboticRover
    {
        Navigation navigate = new Navigation();
        Position position;
        Plateau plateau;


        #region Public methods
        public RoboticRover(int x,int y,Direction direction,int l,int w)
        {
            RoverDirection = direction;
            position=new Position(x, y);
            plateau = new Plateau(l, w);

            if (!CoOrdinatesWithinBoundary())
                return;
        }
        

        public Direction RoverDirection { get; set;}

        public bool CoOrdinatesWithinBoundary()
        {
            if (position.XCoOrdinate < plateau.Width && 
                position.XCoOrdinate>=0 &&
                position.YCoOrdinate>=0 &&
                position.YCoOrdinate < plateau.Length)
                return true;
            else
                return false;
        }


        public void inputCommand(string input)
        {
            foreach (var command in input)
            {
                switch(command)
                {
                    case RoverCommand.SpinRight:
                         RoverDirection=navigate.SpinRight(RoverDirection);
                        break;
                    case RoverCommand.SpinLeft:
                        RoverDirection=navigate.SpinLeft(RoverDirection);
                        break;
                    default:
                        navigate.MoveForward(position,RoverDirection);
                        break;
                }
               
            }
        }
        
       
        public string outputCommand()
        {
            string roverPosition = string.Format("{0} {1} {2}", position.XCoOrdinate, position.YCoOrdinate, RoverDirection);
            return roverPosition;
        }

        #endregion Public Methods

    }
}
