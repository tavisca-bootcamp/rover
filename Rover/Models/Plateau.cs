using MarsRover.Interfaces;
using System;

namespace MarsRover.Models
{
    public class Plateau : ISurface
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Plateau(string Dimensions)
        {
            if (Dimensions.Length > 0)
            {
                string[] xy = Dimensions.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                if (xy != null && xy.Length == 2)
                {
                    Width = Convert.ToInt32(xy[0]);
                    Height = Convert.ToInt32(xy[1]);
                }
                else
                    throw new ArgumentException("Invalid dimensions for Plateau");
            }
            else
                throw new ArgumentException("Invalid dimensions for Plateau");

        }
    }
}
