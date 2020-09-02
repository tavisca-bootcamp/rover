namespace rover {
    public class Plateau : IPlateau {
        /// <summary>
        /// Width of the Plateau.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Height of the Plateau.
        /// </summary>
        public int Y { get; set; }

        public Plateau(int x, int y) {
            this.X = x;
            this.Y = y;
        }
    }
}
