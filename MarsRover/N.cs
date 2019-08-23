namespace MarsRover
{
    public class N : Direction
    {
        private static readonly int _XAxisStepSize = 0;
        private static readonly int _YAxisStepSize = 1;
        public N() : base(_XAxisStepSize, _YAxisStepSize)
        {
        }

        public override Direction Left()
        {
            return new W();
        }

        public override string ToString()
        {
            return "N";
        }

        public override Direction Right()
        {
            return new E();
        }
    }

}
