using System;
using Xunit;
using FluentAssertions;
namespace Rover.Tests
{
    public class ForwardMovementFixture
    {
        [Fact]
        public void ForwardtMovement_shall_update_map()
        {
            var map = new Map(new Location(1, 2), new SurfaceArea(new Location(3, 3)), new Compass("N"));
            IMovement movement = new ForwardMovement();
            movement.Update(map);
            map.GetStatus().Should().Be("1 3 N");
        }
    }
}
