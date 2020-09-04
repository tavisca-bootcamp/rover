using MarsRoverApp.Interfaces;
using System;

namespace MarsRoverApp.Entities
{
    public class Plateau : ILandingSurface
    {
        public int XCoordinate { get; private set; }
        public int YCoordinate { get; private set; }

        private static readonly char seperator = ' ';

        public Plateau(int xMaxCoordinate, int yMaxCoordinate)
        {
            XCoordinate = xMaxCoordinate;
            YCoordinate = yMaxCoordinate;
        }

        public Plateau(string plateauCoordinates)
        {
            if (string.IsNullOrEmpty(plateauCoordinates))
                throw new InvalidOperationException();

            SplitCoordinates(plateauCoordinates);
        }

        private void SplitCoordinates(string plateauCoordinates)
        {
            string[] coordinateMessage = plateauCoordinates.Split(Plateau.seperator);

            int xCoordinateIdx = 0;
            int yCoordinateIdx = 1;
            int noOfValues = 2;

            if (coordinateMessage.Length != noOfValues)
                throw new ArgumentOutOfRangeException();

            XCoordinate = Convert.ToInt32(coordinateMessage[xCoordinateIdx]);
            YCoordinate = Convert.ToInt32(coordinateMessage[yCoordinateIdx]);
        }
    }
}
