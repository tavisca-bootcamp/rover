using System;

namespace MarsRover
{
    public class Coordinate
    {
        private int _xCoordinate;
        private int _yCoordinate;

        public Coordinate(int xCoordinate, int yCoordinate)
        {
            _xCoordinate = xCoordinate;
            _yCoordinate = yCoordinate;
        }

        public override string ToString()
        {
            return _xCoordinate + " " + _yCoordinate;
        }

        public Coordinate NewCoordinate(int xCoordinateStepValue, int yCoordinateStepValue)
        {
            return new Coordinate(_xCoordinate + xCoordinateStepValue, _yCoordinate + yCoordinateStepValue);
        }

        public bool HasWithinBounds(Coordinate coordinate)
        {
            return IsXCoordinateWithinBounds(coordinate._xCoordinate) && IsYCoordinateWithinBounds(coordinate._yCoordinate);
        }

        private bool IsYCoordinateWithinBounds(int yCoordinate)
        {
            return yCoordinate <= _yCoordinate;
        }

        private bool IsXCoordinateWithinBounds(int xCoordinate)
        {
            return xCoordinate <= _xCoordinate;
        }

        public bool HasOutsideBounds(Coordinate coordinate)
        {
            return IsXCoordinateOutsideBounds(coordinate._xCoordinate) && IsYCoordinateOutsideBounds(coordinate._yCoordinate);
        }

        private bool IsYCoordinateOutsideBounds(int yCoordinate)
        {
            return yCoordinate >= _yCoordinate;
        }

        private bool IsXCoordinateOutsideBounds(int xCoordinate)
        {
            return xCoordinate >= _xCoordinate;
        }

        public Coordinate NewCoordinatesForStepSize(int xCoordinateStepValue, int yCoordinateStepValue)
        {
            return new Coordinate(_xCoordinate + xCoordinateStepValue, _yCoordinate + yCoordinateStepValue);
        }
    }

}
