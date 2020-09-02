using MarsRover.Models;

namespace MarsRover.Interfaces
{
    public interface IRover
    {
        Location InitialLocation { get; set; }
        Location CurrentLocation { get; set; }

        IDirection Direction { get; set; }

        string Commands { get; set; }

        void SendCommand(char command);
        void SendCommandSequence(string commands);
        void SendCommandSequence();
        bool IsWithinBoundaries(ISurface surface);

        void Reset();
    }
}
