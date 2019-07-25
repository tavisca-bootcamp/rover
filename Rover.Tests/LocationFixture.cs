using System;
using Xunit;
using FluentAssertions;
namespace Rover.Tests
{
    public class LocationFixture
    {
        [Fact]
        public void Every_Location_Must_Have_Coordinate_Values()
        {
            var location = new Location(2, 5);
            location.XCoordinate.Should().Be(2);
            location.YCoordinate.Should().Be(5);
        }
        [Fact]
        public void Every_Location_Must_Return_Its_Status()
        {
            var location = new Location(1, 2);
            location.GetStatus().Should().Be("1 2");
        }

    }
}
