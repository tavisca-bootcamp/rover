using rover;
using rover.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace rover_tests {
    public class GetRoboticRoverPosition_Tests {
        IRoboticRover roboticRover;

        //public GetRoboticRoverPosition_Tests() {
        //    roboticRover = new RoboticRover(1, 2, Directions.Direction.N, new Plateau(5, 5));
        //}

        [Fact]
        public void MoveAndComparePosition() {
            roboticRover = new RoboticRover(1, 2, Directions.Direction.N, new Plateau(5, 5));
            roboticRover.Direct("LMLMLMLMM");
            Assert.Equal("1 3 N", roboticRover.GetPosition());
        }

        [Fact]
        public void MoveOnly() {
            roboticRover = new RoboticRover(1, 2, Directions.Direction.N, new Plateau(5, 5));
            roboticRover.Direct("MMMMMMMM");
            Assert.Equal("1 5 N", roboticRover.GetPosition());
        }

        [Fact]
        public void CheckRoverPosition() {
            roboticRover = new RoboticRover(1,3, Directions.Direction.N, new Plateau(5, 5));
            Assert.False(roboticRover.CheckRoverPosition());
        }
    }
}
