using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MarsRover.Models;
using MarsRover.Interfaces;
using MarsRover.Models.Directions;

namespace MarsRover.tests
{
    public class RoverTests
    {
        [Fact]
        public void TestRoverCreation()
        {
            Location location = new Location(1, 2);
            IDirection direction = new North();
            Rover rover = new Rover(location, direction);

            Assert.Equal(1, rover.InitialLocation.X);
            Assert.Equal(2, rover.InitialLocation.Y);
            Assert.Equal("N", rover.Direction.GetDirectionString());
        }

        [Fact]
        public void TestRoverCommand()
        {
            Location location = new Location(1, 2);
            IDirection direction = new North();
            Rover rover = new Rover(location, direction);

            rover.SendCommand('L');
            rover.SendCommand('M');

            Assert.Equal(0, rover.CurrentLocation.X);
            Assert.Equal(2, rover.CurrentLocation.Y);
            Assert.Equal("W", rover.Direction.GetDirectionString());
        }

        [Fact]
        public void TestInvalidRoverCommand()
        {
            Location location = new Location(1, 2);
            IDirection direction = new North();
            Rover rover = new Rover(location, direction);

            Assert.Throws<ArgumentException>(() =>
            {
                rover.SendCommand('X');
            });
        }
    }
}
