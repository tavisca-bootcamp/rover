using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Rover
    {
        public int Var_X;
        public int Var_Y;
        public string direction;
        public Rover(string location)
        {
            Int32.TryParse(location.Split(' ')[0], out Var_X);
            Int32.TryParse(location.Split(' ')[1], out Var_Y);
            direction = location.Split(' ')[2];
        }

        public void Move(string RoverInstructions)
        {

            char[] Steps = RoverInstructions.ToCharArray();
            for (int i = 0; i < Steps.Length; i++)
            {
                switch (Steps[i])
                {
                    case 'L':
                        LeftRotate();
                        break;

                    case 'R':
                        RightRotate();
                        break;

                    case 'M':
                        StepForward();
                        break;
                    default:
                        throw new ArgumentException();

                }

            }

        }
        public void LeftRotate()
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
        public void RightRotate()
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
                    Var_Y += 1;
                    break;
                case "E":
                    Var_X += 1;
                    break;
                case "S":
                    Var_Y -= 1;
                    break;
                case "W":
                    Var_X -= 1;
                    break;
                default:
                    throw new ArgumentException();

            }

        }
        
    }
}
