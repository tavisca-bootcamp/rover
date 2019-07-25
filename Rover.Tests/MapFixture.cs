using System;
using Xunit;
using FluentAssertions;
namespace Rover.Tests
{
    public class MapFixture
    {
        [Fact]
        public void Every_Map_Shall_be_able_to_give_its_status()
        {
            var map = new Map(new Location(1,2),new SurfaceArea(new Location(3,3)),new Compass("N"));
            map.GetStatus().Should().Be("1 2 N");
        }

    }
}
