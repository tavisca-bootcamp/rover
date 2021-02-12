using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoverProblem;


namespace RoverTest
{
    [TestClass]
    public class RoverTest1
    {
        [TestMethod]

        public void SpinLeft()
        {
            Rover rover = new Rover("1 2 N");

            rover.SpinLeft();

            Assert.AreEqual("W", rover.direction);
        }

        [TestMethod]

        public void SpinRight()
        {
            Rover rover = new Rover("1 2 N");

            rover.SpinRight();

            Assert.AreEqual("E", rover.direction);
        }
        [TestMethod]

        public void StepForward()
        {
            Rover rover = new Rover("1 2 N");

            rover.StepForward();

            Assert.AreEqual(3, rover.y);
        }

        [TestMethod]

        public void TestCase1()
        {
            Rover rover = new Rover("1 2 N");

            rover.Move("LMLMLMLMM");

            Assert.AreEqual("1 3 N", rover.x + " " + rover.y + " " + rover.direction);
        }


        [TestMethod]

        public void Testcase2()
        {
            Rover rover = new Rover("3 3 E");

            rover.Move("MMRMMRMRRM");

            Assert.AreEqual("5 1 E", rover.x + " " + rover.y + " " + rover.direction);
        }
    }
}
