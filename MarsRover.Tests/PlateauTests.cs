using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using MarsRover;

namespace MarsRover.Tests
{
    public class PlateauTests
    {
       // private Coordinate coordinate1 = new Coordinate(3, 2);
      //  private Coordinate coordinate2 = new Coordinate(4, 6);

        private Plateau _plateau = new Plateau(4, 5);

        [Theory]
        [InlineData(4, 6)]
        [InlineData(5, 5)]
        [InlineData(6, 7)]
        public void check_within_bounds_or_not(int a, int b)
        {
            Assert.False(_plateau.HasWithinBounds(new Coordinate(a, b)));
            
        }

        
    }
}
