namespace Domain
{
    public class Spot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Piece Piece { get; set; }

        public Spot(int x, int y, Piece piece)
        {
            this.X = x;
            this.Y = y;
            this.Piece = piece;
        }
    }
}