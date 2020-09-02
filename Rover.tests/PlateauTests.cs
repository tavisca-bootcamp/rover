using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MarsRover.tests
{
    public class PlateauTests
    {
        [Fact]
        public void TestPlateauCreation()
        {
            Plateau plateau = new Plateau("5 10");

            Assert.Equal(5, plateau.Width);
            Assert.Equal(10, plateau.Height);
        }
    }
}
