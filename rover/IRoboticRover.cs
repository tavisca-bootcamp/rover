using rover.Enums;

namespace rover {
    public interface IRoboticRover {
        Plateau Plateau { get; set; }
        Directions.Direction RoboticRoverDirection { get; set; }
        int XPosition { get; set; }
        int YPosition { get; set; }

        void ChangeDirection(char direction);
        void Direct(string inputDirections);
        string GetPosition();
        bool CheckRoverPosition();
    }
}