using System;
using Xunit;
using FluentAssertions;
using Rover;
namespace Rover.Tests
{
    public class MarsRoverFixture
    {
        [Fact]
        public void Rover1_Test()
        {
            new MarsRover().MarsRoverSentToMars("5 5", "1 2 N", "LLMLLMLLMLLMM").Should().Be("1 3 N");
        }
        [Fact]
        public void Rover2_Test()
        {
            new MarsRover().MarsRoverSentToMars("5 5", "3 3 E", "MMRRMMRRMRRRRM").Should().Be("5 1 E");
        }
        [Fact]
        public void Rover_Should_in_both_axis_if_facing_NE_Test()
        {
            new MarsRover().MarsRoverSentToMars("5 5", "3 3 NE", "MM").Should().Be("5 5 NE");
        }
        [Fact]
        public void Rover_rotates_by_45_degrees_Test()
        {
            new MarsRover().MarsRoverSentToMars("5 5", "3 3 NE", "R").Should().Be("3 3 E");
        }

    }
}
