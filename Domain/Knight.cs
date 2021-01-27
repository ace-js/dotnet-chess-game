using System;

namespace Domain
{
    public class Knight: Piece
    {
        public Knight(bool isWhite) : base(isWhite)
        {
        }

        public override bool CanMove(Board board, Spot start, Spot end)
        {
            // we can't move the piece to a spot that has 
            // a piece of the same colour 
            if (end.Piece.IsWhite == IsWhite) { 
                return false; 
            } 
  
            int x = Math.Abs(start.X - end.X); 
            int y = Math.Abs(start.Y - end.Y); 
            
            return x * y == 2;
        }
    }
}