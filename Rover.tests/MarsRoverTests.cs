using MarsRover.Interfaces;
using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MarsRover.tests
{
    public class MarsRoverTests
    {
        [Fact]
        public void TestPlateauCreation()
        {
            string[] setup = new string[] { "5 5", "1 2 N", "LMLMLMLMM", "3 3 E", "MMRMMRMRRM" };
            MarsRover mr = new MarsRover(setup);

            Assert.Equal("5", mr.Plateau.Width.ToString());
            Assert.Equal("5", mr.Plateau.Height.ToString());
        }

        [Fact]
        public void TestRoverCreation()
        {
            string[] setup = new string[] { "5 5", "1 2 N", "LMLMLMLMM", "3 3 E", "MMRMMRMRRM" };
            MarsRover mr = new MarsRover(setup);

            Assert.Equal("1", mr.Rovers[0].InitialLocation.X.ToString());
            Assert.Equal("2", mr.Rovers[0].InitialLocation.Y.ToString());
            Assert.Equal("N", mr.Rovers[0].Direction.GetDirectionString());
        }

        [Fact]
        public void RunRoverWithinBoundaries()
        {
            string[] setup = new string[] { "5 5", "1 2 N", "LMLMLMLMM", "3 3 E", "MMRMMRMRRM" };
            MarsRover mr = new MarsRover(setup);

            mr.RunRovers();
            string[] newRoverPositions = mr.GetRoverPositions();

            Assert.Equal("1 3 N", newRoverPositions[0]);
            Assert.Equal("5 1 E", newRoverPositions[1]);
        }

        [Fact]
        public void RunRoverBeyondBoundaries()
        {
            string[] setup = new string[] { "4 4", "3 3 E", "MMRMMRMRRM" };
            MarsRover mr = new MarsRover(setup);

            Assert.Throws<ArgumentException>(() => mr.RunRovers());
        }


    }
}
