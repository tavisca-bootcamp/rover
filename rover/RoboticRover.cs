using rover.Enums;
using System;

namespace rover {
    public class RoboticRover : IRoboticRover {
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public Plateau Plateau { get; set; }
        public Directions.Direction RoboticRoverDirection { get; set; }

        public RoboticRover(int xPosition, int yPosition, Directions.Direction direction, Plateau plateau) {
            this.XPosition = xPosition;
            this.YPosition = yPosition;
            this.RoboticRoverDirection = direction;
            this.Plateau = plateau;
        }

        public void ChangeDirection(char direction) {
            if (direction == 'L') {
                this.RoboticRoverDirection = (this.RoboticRoverDirection - 90) < Directions.Direction.E ? Directions.Direction.N : this.RoboticRoverDirection - 90;
            } else if (direction == 'R') {
                this.RoboticRoverDirection = (this.RoboticRoverDirection + 90) > Directions.Direction.N ? Directions.Direction.E : this.RoboticRoverDirection + 90;
            }
        }

        public string GetPosition() {
            string roverPosition = string.Format("{0} {1} {2}", this.XPosition, this.YPosition, this.RoboticRoverDirection);
            Console.WriteLine(roverPosition);
            return roverPosition;
        }

        public void Direct(string inputDirections) {
            char[] directions = inputDirections.ToCharArray();

            foreach (char direction in directions) {
                if (direction == 'L' || direction == 'R')
                    this.ChangeDirection(direction);
                else if (direction == 'M')
                    this.Move();
            }
        }

        public void Move() {
            if (this.RoboticRoverDirection == Directions.Direction.N && this.Plateau.Y > this.YPosition) {
                this.YPosition++;
            } else if (this.RoboticRoverDirection == Directions.Direction.E && this.Plateau.X > this.XPosition) {
                this.XPosition++;
            } else if (this.RoboticRoverDirection == Directions.Direction.S && this.YPosition > 0) {
                this.YPosition--;
            } else if (this.RoboticRoverDirection == Directions.Direction.W && this.XPosition > 0) {
                this.XPosition--;
            }
        }

        public bool CheckRoverPosition() {
            bool result = false;

            if ((this.XPosition > this.Plateau.X) || (this.YPosition > this.Plateau.Y) || (this.XPosition < -(this.Plateau.X)) || (this.YPosition < -(this.Plateau.Y))) {
                result = true;
            }

            return result;
        }
    }
}
