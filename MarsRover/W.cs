namespace MarsRover
{
    public class W : Direction
    {
        private static readonly int _XAxisStepSize = -1;
        private static readonly int _YAxisStepSize = 0;
        public W() : base(_XAxisStepSize, _YAxisStepSize)
        {
        }

        public override Direction Left()
        {
            return new S();
        }
        public override string ToString()
        {
            return "W";
        }
        public override Direction Right()
        {
            return new N();
        }
    }

}
