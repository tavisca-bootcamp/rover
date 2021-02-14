using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary2 ;


namespace UnitTestProject1

{
    [TestClass]
    public class RoverTest1
    {
        [TestMethod]

        public void LeftSpin()
        {
            Rover rover = new Rover("1 2 N");

            rover.LeftRotate();

            Assert.AreEqual("W", rover.direction);
        }

        [TestMethod]

        public void RightSpin()
        {
            Rover rover = new Rover("1 2 N");

            rover.RightRotate();

            Assert.AreEqual("E", rover.direction);
        }
        [TestMethod]

        public void StepForward()
        {
            Rover rover = new Rover("1 2 N");

            rover.StepForward();

            Assert.AreEqual(3, rover.Var_Y);
        }

        [TestMethod]

        public void TestCase1()
        {
            Rover rover = new Rover("1 2 N");

            rover.Move("LMLMLMLMM");

            Assert.AreEqual("1 3 N", rover.Var_X + " " + rover.Var_Y + " " + rover.direction);
        }


        [TestMethod]

        public void Testcase2()
        {
            Rover rover = new Rover("3 3 E");

            rover.Move("MMRMMRMRRM");

            Assert.AreEqual("5 1 E", rover.Var_X + " " + rover.Var_Y + " " + rover.direction);
        }
    }
}