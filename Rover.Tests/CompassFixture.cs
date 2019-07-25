using System;
using Xunit;
using FluentAssertions;
namespace Rover.Tests
{
    public class CompassFixture
    {
        [Fact]
        public void Compass_Needle_Should_Point_Towards_A_Direction()
        {
            Compass compass = new Compass("NE");
            compass.Needle.Should().Be(Direction.NorthEast);
        }
        [Fact]
        public void Every_Compass_Must_Return_Its_Status()
        {
            Compass compass = new Compass("SE");
            compass.GetStatus().Should().Be("SE");
        }
    }
}
