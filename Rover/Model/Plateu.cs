using Rover.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rover.Model
{
    public class Plateau : IPlateuSurface
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public Plateau(int length,int width)
        {
            this.Length = length;
            this.Width = width;
        }
    }
}
