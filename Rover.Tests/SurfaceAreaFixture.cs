using System;
using Xunit;
using FluentAssertions;
namespace Rover.Tests
{
    public class SurfaceAreaFixture
    {
        [Fact]
        public void Every_Surface_Area_Should_Have_UpperLeftCoordinate()
        {
            var upperRightCoordinate = new Location(5,5);
            var surfaceArea = new SurfaceArea(upperRightCoordinate);
            surfaceArea.UpperRightCoordinates.Should().Be(upperRightCoordinate);
        }

    }
}
