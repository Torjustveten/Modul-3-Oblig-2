using System;

namespace Oblig2
{
    
    abstract class Piece
        {
            public string Symbol { get; set; }

        protected Piece(string symbol)
            {
                Symbol = symbol;
            }

            public abstract bool Move(string fromPosition, string toPosition);
        }
}

