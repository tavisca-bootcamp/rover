namespace MarsRover
{
    public class Plateau
    {
        private Coordinate _topRightCoordinates = new Coordinate(0, 0);
        private Coordinate _bottomLeftCoordinates = new Coordinate(0, 0);

        public Plateau(int topRightXCoordinate, int topRightYCoordinate)
        {
            _topRightCoordinates = _topRightCoordinates.NewCoordinatesForStepSize(topRightXCoordinate, topRightYCoordinate);
        }

        public bool HasWithinBounds(Coordinate coordinate)
        {
            return _bottomLeftCoordinates.HasOutsideBounds(coordinate) && _topRightCoordinates.HasWithinBounds(coordinate);
        }
    }


}
