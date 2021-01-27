using System;

namespace Domain
{
    public class King : Piece
    {
        public bool CastlingDone { get; set; } = false;
        
        public King(bool isWhite) : base(isWhite)
        {
        }

        public override bool CanMove(Board board, Spot start, Spot end)
        {
            // we can't move the piece to a Spot that  
            // has a piece of the same color 
            if (end.Piece.IsWhite && IsWhite)
            {
                return false;
            }

            var x = Math.Abs(start.X - end.X);
            var y = Math.Abs(start.Y - end.Y);

            if (x + y == 1)
            {
                // check if this move will not result in the king 
                // being attacked if so return true 
                return true;
            }

            return IsValidCastling( board,  start,  end);
        }

        private bool IsValidCastling( Board board1,  Spot start,  Spot end)
        {
            if (CastlingDone)
                return false;
            
            // logic for returning true or false
            return true;
        }
        
        public bool IsCastlingMove(Spot start, Spot end) 
        { 
            // check if the starting and  
            // ending position are correct 
            return true;
        } 
    }
}