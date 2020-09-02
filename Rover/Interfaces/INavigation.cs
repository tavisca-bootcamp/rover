using Rover.Common;
using Rover.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rover.Interfaces
{
    public interface INavigation
    {
        void  MoveForward(Position position,Direction RoverDirection);
        Direction  SpinLeft(Direction RoverDirection);
        Direction SpinRight(Direction RoverDirection);
    }
}
