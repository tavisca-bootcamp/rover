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

    }
}
