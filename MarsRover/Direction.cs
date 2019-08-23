namespace MarsRover
{
    public abstract class Direction
    {
        private int _XAxisStepSize;
        private int _YAxisStepSize;
        public Direction(int XAxisStepSize, int YAxisStepSize)
        {
            _XAxisStepSize = XAxisStepSize;
            _YAxisStepSize = YAxisStepSize;
        }

        public int XAxisStepSize
        {
            get => _XAxisStepSize;
        }

        public int YAxisStepSize
        {
            get => _YAxisStepSize;
        }

        public abstract Direction Right();
        public abstract Direction Left();

    }

}
