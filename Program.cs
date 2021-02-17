using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rover
{
    public class Program
    {
        int XCoordinates;
        int YCoordinates;
        string RoverHeadPosition;

        public string FinalRoverPosition(string existingPosition, string movements)
        {
            string[] temp = existingPosition.Split(' ');

            XCoordinates = int.Parse(temp[0]);
            YCoordinates = int.Parse(temp[1]);

            RoverHeadPosition = temp[2];

            RoverMovement(movements);
            return ConcatHeadAndCoordiantePosition(XCoordinates, YCoordinates, RoverHeadPosition);

        }

        private string ConcatHeadAndCoordiantePosition(int xCoordinates, int yCoordinates, string headPostition)
        {
            return xCoordinates + " " + yCoordinates + " " + headPostition;
        }
        public void NewHeadPosition(string rotate, string headPosition)
        {
            if (rotate == "L")
            {
                switch(headPosition)
                {
                    case "N":
                        RoverHeadPosition = "W";
                        break;
                    case "W":
                        RoverHeadPosition = "S";
                        break;
                    case "S":
                        RoverHeadPosition = "E";
                        break;
                    case "E":
                        RoverHeadPosition = "N";
                        break;

                }
            }
            else
            {
                switch(headPosition)
                {
                    case "N":
                        RoverHeadPosition = "E";
                        break;
                    case "E":
                        RoverHeadPosition = "S";
                        break;
                    case "S":
                        RoverHeadPosition = "W";
                        break;
                    case "W":
                        RoverHeadPosition = "N";
                        break;
                }
            }
        }

        public void NewCordinates()
        {
            switch (RoverHeadPosition)
            {
                case "N":
                    YCoordinates += 1;
                    break;
                case "E":
                    XCoordinates += 1;
                    break;
                case "S":
                    YCoordinates -= 1;
                    break;
                case "W":
                    XCoordinates -= 1;
                    break;
            }
        }
        public void RoverMovement(string movement)
        {
            foreach (var move in movement)
            {
                switch (move)
                {
                    case 'L':
                        NewHeadPosition("L", RoverHeadPosition);
                        break;
                    case 'R':
                        NewHeadPosition("R", RoverHeadPosition);
                        break;
                    case 'M':
                        NewCordinates();
                        break;

                }

            }
        }
    }
}
