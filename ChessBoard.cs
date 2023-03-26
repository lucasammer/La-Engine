using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_engine_vt3
{
    internal class ChessBoard
    {
        public Piece[,] board = new Piece[8, 8];

        public ChessBoard()
        {
            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    board[i, j] = new Piece(Piece.types.None, Piece.Color.BLACK);
                }
            }
        }

        public void ShowBoard()
        {
            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    try
                    {
                        Console.Write(board[i, j].sym);
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine(e);
                        Console.Write('-');
                    }

                }
                Console.WriteLine();
            }
        }

        public void getAtPos(string pos)
        {
            pos = pos.ToLower();
            char[] files = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            Console.WriteLine(board[int.Parse(pos[1].ToString()) - 1, Array.IndexOf(files, pos[0])].sym);
        }

        public void SetupBoard(string fen)
        {
            string[] firstSplit = fen.Split('/');
            int j = 0;

            for (int i = 0; i < 8; ++i)
            {
                for (int p = 0; p < 8; ++p)
                {
                }
            }
        }
    }
}
