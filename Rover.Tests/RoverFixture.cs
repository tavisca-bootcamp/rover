using System;
using Xunit;
using FluentAssertions;
namespace Rover.Tests
{
    public class RoverFixture
    {
        private Rover MarsRover;
        [Fact]
        public void Rover_should_have_map_and_processor()
        {
            Map marsMap = new Map(new Location(2,2),new SurfaceArea(new Location(5,5)),new Compass('E'));
            MarsRover = new Rover(marsMap);
            MarsRover.RoverMap.Should().Be(marsMap);
            MarsRover.RoverProcessor.Should().BeOfType<Processor>();
        }
        [Fact]
        public void Rover_can_send_its_location_details()
        {
            Map marsMap = new Map(new Location(2, 2), new SurfaceArea(new Location(5, 5)), new Compass('E'));
            MarsRover = new Rover(marsMap);
            MarsRover.SendLocationDetails().Should().Be("2 2 E");
        }

    }
}
