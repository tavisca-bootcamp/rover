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
            Compass compass = new Compass('N');
            compass.Needle.Should().Be(Direction.North);
        }
    }
}
