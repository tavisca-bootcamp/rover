using Rover.Common;
using Rover.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rover.Model
{
    class Navigation : INavigation
    {
        public void MoveForward(Position positionObj,Direction RoverDirection)
        {
            switch (RoverDirection)
            {
                case Direction.E:
                    positionObj.XCoOrdinate += 1;
                    break;

                case Direction.W:
                    positionObj.XCoOrdinate -= 1;
                    break;

                case Direction.N:
                    positionObj.YCoOrdinate += 1;
                    break;

                case Direction.S:
                    positionObj.YCoOrdinate -= 1;
                    break;
            }
        }

        public Direction SpinLeft(Direction RoverDirection)
        {
            switch (RoverDirection)
            {
                case Direction.E:
                    return Direction.N;

                case Direction.W:
                    return Direction.S;

                case Direction.N:
                    return Direction.W;
               
                case Direction.S:
                    return Direction.E;
            }
            return Direction.E;
        }

        public Direction SpinRight(Direction RoverDirection)
        {
            switch (RoverDirection)
            {
                case Direction.E:
                    return Direction.S;
                    
                case Direction.W:
                    return Direction.N;
                    
                case Direction.N:
                    return Direction.E;
                    
                case Direction.S:
                    return Direction.W;
                    
            }
            return Direction.E;
        }
       
       
    }
}
