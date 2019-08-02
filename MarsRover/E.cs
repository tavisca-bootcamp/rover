namespace MarsRover
{
    public class E : Direction
    {
        private static readonly int _XAxisStepSize = 1;
        private static readonly int _YAxisStepSize = 0;
        public E() : base(_XAxisStepSize, _YAxisStepSize)
        {
        }

        public override Direction Left()
        {
            return new N();
        }

        public override string ToString()
        {
            return "E";
        }

        public override Direction Right()
        {
            return new S();
        }
    }

}
