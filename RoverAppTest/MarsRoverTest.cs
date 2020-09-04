using MarsRoverApp;
using MarsRoverApp.Entities;
using MarsRoverApp.Interfaces;
using System;
using Xunit;

namespace RoverAppTest
{
    public class MarsRoverTest
    {

        [Fact]
        public void TestPlateauCreation()
        {
            Plateau plateau = new Plateau("7 7");

            Assert.Equal(7, plateau.XCoordinate);
            Assert.Equal(7, plateau.YCoordinate);
        }

        [Fact]
        public void TestInvalidPlateau()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Plateau("5 5 5"));
        }

        [Fact]
        public void TestRovers()
        {
            Plateau plateau = new Plateau("5 5");
            RoverSquad roverSquad = new RoverSquad(plateau);

            roverSquad.DeployNewRover("1 2 N", "LMLMLMLMM");
            roverSquad.DeployNewRover("3 3 E", "MMRMMRMRRM");

            int noRovers = 2;

            Assert.True(roverSquad.Count == noRovers);
        }

        [Fact]
        public void TestRoverMovement()
        {
            Plateau plateau = new Plateau("5 5");
            RoverSquad roverSquad = new RoverSquad(plateau);

            roverSquad.DeployNewRover("1 2 N", "LMLMLMLMM");
            roverSquad.DeployNewRover("3 3 E", "MMRMMRMRRM");

            int roverOneIdx = 0;
            int roverTwoIdx = 1;

            IRover roverOne = roverSquad[roverOneIdx];
            IRover roverTwo = roverSquad[roverTwoIdx];

            Assert.True(roverOne.XCoordinate == 1);
            Assert.True(roverOne.YCoordinate == 3);
            Assert.True(roverOne.Direction == "N");

            Assert.True(roverTwo.XCoordinate == 5);
            Assert.True(roverTwo.YCoordinate == 1);
            Assert.True(roverTwo.Direction == "E");
        }

        [Fact]
        public void TestInvalidRoverMovement()
        {
            Plateau plateau = new Plateau("1 1");
            RoverSquad roverSquad = new RoverSquad(plateau);
            Assert.Throws<InvalidOperationException>(() => roverSquad.DeployNewRover("1 2 N", "LMLMLMLMM"));
        }

    }
}
