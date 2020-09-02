using Rover.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rover.Model
{
    public class Position
    {

        public int XCoOrdinate { get; set; }
        public int YCoOrdinate { get; set; }

        public Position(int X,int Y)
        {
            this.XCoOrdinate = X;
            this.YCoOrdinate = Y;
        }

       

    }


}
