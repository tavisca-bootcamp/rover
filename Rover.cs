using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Rover
    {
        public int x;
        public int y;
        public int upper_limit_x;
        public int upper_limit_y;
        public string direction;
        public int underlimits_flag = 0;

        public Rover(string location , string upperlimits)
        {
            Int32.TryParse(upperlimits.Split(" ")[0], out upper_limit_x);
            Int32.TryParse(upperlimits.Split(" ")[0], out upper_limit_y);
            Int32.TryParse(location.Split(" ")[0], out x);
            Int32.TryParse(location.Split(" ")[1], out y);
            direction = location.Split(" ")[2];


        }

        public bool Is_under_limits(int x, int y)
        {
            if (this.x > x || this.y > y) return false;
            else return true;

        }

        public void SpinLeft()
        {
            switch (direction)
            {
                case "N":
                    direction = "W";
                    break;

                case "E":
                    direction = "N";
                    break;

                case "S":
                    direction = "E";
                    break;

                case "W":
                    direction = "S";
                    break;

                default:
                    throw new ArgumentException();

            }
        }


        public void SpinRight()
        {
            switch (direction)
            {
                case "N":
                    direction = "E";
                    break;

                case "E":
                    direction = "S";
                    break;

                case "S":
                    direction = "W";
                    break;

                case "W":
                    direction = "N";
                    break;

                default:
                    throw new ArgumentException();

            }
        }

        public void StepForward()
        {
            switch (direction)
            {
                case "N":
                    y+=1;
                    break;

                case "E":
                    x+=1;
                    break;

                case "S":
                    y-=1;
                    break;

                case "W":
                    x-=1;
                    break;

                default:
                    throw new ArgumentException();

            }

        }

        public void Move(string roverCommand)
        {

            char[] instructions = roverCommand.ToCharArray();

            for( int i=0; i< instructions.Length; i++)
            {

                switch (instructions[i])
                {
                    case 'L':
                        SpinLeft();
                        break;

                    case 'R':
                        SpinRight();
                        break;

                    case 'M':
                        StepForward();
                        if(!Is_under_limits(upper_limit_x, upper_limit_y))
                        {
                            underlimits_flag = 1;
                        }
                        break;


                    default:
                        throw new ArgumentException();

                }

                if(underlimits_flag == 1)
                {
                    throw new OutOfLimitsException("Next move is ot of limits");
                }
            }

        }
    }
}
