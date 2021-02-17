using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using rover;

namespace RoverTest
{
    [TestClass]
    public class RoverPositionTest
    {
        Program rover = new Program();

        [TestMethod]
        public void MoveOneStepWithFixedHeadPosition()
        {
            string actual = rover.FinalRoverPosition("1 2 N", "M");
            string expected = "1 3 N";
            Assert.AreEqual (expected, actual);
        }
        [TestMethod]
        public void MoveHeadPositionLeftSideWithoutStepForward()
        {
            string actual = rover.FinalRoverPosition("1 2 N", "L");
            string expected = "1 2 W";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MoveHeadPositionRightSideWithoutStepForward()
        {
            string actual = rover.FinalRoverPosition("1 2 N", "R");
            string expected = "1 2 E";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MoveHeadPositioAsWellAsStepForwardAccToFollowinInstruction()
        {
            string actual = rover.FinalRoverPosition("1 2 N", "LMLMLMLMM");
            string expected = "1 3 N";
            Assert.AreEqual(expected, actual);
        }
    }
}
