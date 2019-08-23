using System;
using Xunit;
using MarsRover;

namespace MarsRover.Tests
{
    public class RoverTests
    {
        private Plateau _plateau;
        private Coordinate _startingPosition;
        private Rover _rover;
        [Fact]
        public void RunCommandWithMultipleInstructions()
        {
            _plateau = new Plateau(5, 5);
            _startingPosition = new Coordinate(1, 2);
            _rover = new Rover(_plateau, new N(), _startingPosition);
            _rover.Run("LMLMLMLMM");
            Assert.Equal("1 3 N", _rover.GetCurrentLocation());
        }

        

    }
}
