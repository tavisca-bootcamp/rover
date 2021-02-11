using System;
using Xunit;
using MarsRover;

namespace MarsRovertests
{
    public class RoverShould
    {
        [Fact]
        public void SpinLeft()
        {
            Rover rover = new Rover("1 2 N" , "5 5");

            rover.SpinLeft();

            Assert.Equal("W", rover.direction);
        }

        [Fact]
        public void SpinRight()
        {
            Rover rover = new Rover("1 2 N" , "5 5");

            rover.SpinRight();

            Assert.Equal("E", rover.direction);
        }

        [Fact]
        public void StepForward()
        {
            Rover rover = new Rover("1 2 N" , "5 5");

            rover.StepForward();

            Assert.Equal(3, rover.y);
        }

        [Fact]
        public void ValidTest1()
        {
            Rover rover = new Rover("1 2 N" , "5 5");

            rover.Move("LMLMLMLMM");

            Assert.Equal("1 3 N", rover.x + " " + rover.y + " " + rover.direction);
        }


        [Fact]
        public void ValidTest2()
        {
            Rover rover = new Rover("3 3 E", "5 5");

            rover.Move("MMRMMRMRRM");

            Assert.Equal("5 1 E", rover.x + " " + rover.y + " " + rover.direction);
        }

       

    }
}
