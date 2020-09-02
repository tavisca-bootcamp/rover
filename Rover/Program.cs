using Rover.Common;
using Rover.Interfaces;
using Rover.Model;
using System;

namespace Rover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input");

            Console.WriteLine("5 5");
            Console.WriteLine("1 2 N");
            Console.WriteLine("LMLMLMLMM");

            RoboticRover roverOne = new RoboticRover(1,2,Direction.N,5,5);
            roverOne.inputCommand("LMLMLMLMM");

            Console.WriteLine("3 3 E");
            Console.WriteLine("MMRMMRMRRM");

            RoboticRover roverTwo = new RoboticRover(3, 3, Direction.E,5,5);
            roverTwo.inputCommand("MMRMMRMRRM");


            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Output");

            Console.WriteLine(roverOne.outputCommand());
            Console.WriteLine(roverTwo.outputCommand());

            Console.ReadLine();
        }
    }
}
