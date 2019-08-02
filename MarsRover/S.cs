namespace MarsRover
{
    public class S : Direction
    {
        private static readonly int _XAxisStepSize = 0;
        private static readonly int _YAxisStepSize = -1;
        public S() : base(_XAxisStepSize, _YAxisStepSize)
        {
        }

        public override Direction Left()
        {
            return new E();
        }
        public override string ToString()
        {
            return "S";
        }
        public override Direction Right()
        {
            return new W();
        }
    }

}
