using System;
using Xunit;
using FluentAssertions;
namespace Rover.Tests
{
    public class ProcessorFixture
    {
        private Processor processor=new Processor();
        [Fact]
        public void Processor_shall_read_signal()
        {
            processor.ReadSignal('L').Should().Be(Signal.L);
        }
        [Fact]
        public void Processor_shall_Execute_Signal()
        {
            IMovement movement=processor.ExecuteSignal(processor.ReadSignal('L'));
            movement.Should().BeOfType<RotateLeftMovement>();
        }

    }
}
