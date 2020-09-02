using rover.Enums;
using System;

namespace rover {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Input");
            Console.WriteLine("5 5");

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("1 2 N");
            IRoboticRover firstRoboticRover = new RoboticRover(1, 3, Directions.Direction.N, new Plateau(5, 5));

            if (firstRoboticRover.CheckRoverPosition() == false) {
                Console.WriteLine("LMLMLMLMM");
                firstRoboticRover.Direct("LMLMLMLMM");
                Console.WriteLine("Output");
                firstRoboticRover.GetPosition();
            } else {
                Console.WriteLine("Please provide valid Co-Ordinates.");
            }

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("3 3 E");
            IRoboticRover secondRoboticRover = new RoboticRover(3, 3, Directions.Direction.E, new Plateau(5, 5));

            if (secondRoboticRover.CheckRoverPosition() == false) {
                Console.WriteLine("MMRMMRMRRM");
                secondRoboticRover.Direct("MMRMMRMRRM");
                Console.WriteLine("Output");
                secondRoboticRover.GetPosition();
            } else {
                Console.WriteLine("Please provide valid Co-Ordinates.");
                Console.WriteLine(Environment.NewLine);
            }

            Console.ReadLine();
        }
    }
}
