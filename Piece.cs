using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_engine_vt3
{
    internal class Piece
    {
        public types type;
        public int value;
        public Color color;
        public char sym;

        public enum types
        {
            None = 0,
            Pawn = 1,
            Rook = 2,
            Bishop = 3,
            Knight = 4,
            King = 5,
            Queen = 6,
        }

        public enum Color
        {
            WHITE = 0,
            BLACK = 1,
        }

        public Piece(types type, Color colour)
        {
            this.type = type;
            int typeVal = (int)type;
            this.value = Getvalues()[typeVal];
            this.color = colour;
            char[] Wsymbols = { '.', 'P', 'R', 'B', 'N', 'K', 'Q' };
            char[] Bsymbols = { '.', 'p', 'r', 'b', 'n', 'k', 'q' };
            this.sym = this.color == Color.WHITE ? Wsymbols[(int)this.type] : Bsymbols[(int)this.type];
        }
        
        private int[] Getvalues()
        {
            int[] values = { 0, 1, 5, 4, 3, 999, 10 };
            return values;
        }

        public static implicit operator int(Piece v)
        {
            return 0;
        }
    }
}
