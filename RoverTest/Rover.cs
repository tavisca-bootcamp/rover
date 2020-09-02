using System;
using Xunit;
using Rover.Model;
using Rover.Interfaces;
using Rover.Common;

namespace RoverTest
{
    public class RoverTest
    {
        [Fact]
        public void TestPlateauCreation()
        {
            Plateau plateau = new Plateau(5, 10);

            Assert.Equal(5, plateau.Length);
            Assert.Equal(10, plateau.Width);
        }

 
        [Fact]
        public void TestValidRoverCommand()
        {
            RoboticRover rover = new RoboticRover(1, 2, Direction.N,5,5);
            rover.inputCommand("LMLMLMLMM");
            Assert.Equal("1 3 N", rover.outputCommand());
        }

        [Fact]
        public void TestRoverWithinBoundary()
        {
            RoboticRover rover = new RoboticRover(1, 2, Direction.N, 5, 5);
            Assert.True(rover.CoOrdinatesWithinBoundary());
        }


        [Fact]
        public void TestRoverOutsideBoundary()
        {
            RoboticRover rover = new RoboticRover(1, 6, Direction.N, 5, 5);
            Assert.False(rover.CoOrdinatesWithinBoundary());
        }
    }
}
