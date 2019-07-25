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
        [Fact]
        public void Every_Surface_Area_Can_Check_If_A_Location_Exists_On_It()
        {
            var surfaceArea = new SurfaceArea(new Location(5, 5));
            var location = new Location(2, 3);
            surfaceArea.HasLocation(location).Should().Be(true);
        }

    }
}
