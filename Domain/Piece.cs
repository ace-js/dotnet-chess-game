namespace Domain
{
    public abstract class Piece
    {
        public bool IsKilled { get; set; } = false;
        public bool IsWhite { get; set; }

        protected Piece(bool isWhite)
        {
            IsWhite = isWhite;
        }

        public abstract bool CanMove(Board board, Spot start, Spot end);
    }
}