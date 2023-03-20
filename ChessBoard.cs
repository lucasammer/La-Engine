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
            for(int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    board[i, j] = new Piece(Piece.types.None, Piece.Color.BLACK);
                }
            }
        }

        public void ShowBoard()
        {
            for(int i = 0; i < 8; ++i)
            {
                for(int j = 0; j < 8; ++j)
                {
                    try
                    {
                        Console.Write(board[i, j].sym);
                    }catch(Exception e)
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
            Console.WriteLine(board[int.Parse(pos[1].ToString()) -1, Array.IndexOf(files, pos[0])].sym);
        }

        public void SetupBoard(string fen)
        {
            string[] firstSplit = fen.Split('/');
            int j = 0;

            for(int i = 0; i< 8; ++i)
            {
                for(int p = 0; p < 8; ++p)
                {
                    try
                    {
                        char c = firstSplit[i][p];

                        if (char.IsDigit(c))
                        {
                            board[i, j] = new Piece(Piece.types.None, Piece.Color.BLACK);
                            j += (int)Char.GetNumericValue(c);
                        }
                        else
                        {
                            switch (c)
                            {
                                case ('P'):
                                    board[i, j] = new Piece(Piece.types.Pawn, Piece.Color.WHITE);
                                    break;
                                case ('p'):
                                    board[i, j] = new Piece(Piece.types.Pawn, Piece.Color.BLACK);
                                    break;
                                case ('N'):
                                    board[i, j] = new Piece(Piece.types.Knight, Piece.Color.WHITE);
                                    break;
                                case ('n'):
                                    board[i, j] = new Piece(Piece.types.Knight, Piece.Color.BLACK);
                                    break;
                                case ('R'):
                                    board[i, j] = new Piece(Piece.types.Rook, Piece.Color.WHITE);
                                    break;
                                case ('r'):
                                    board[i, j] = new Piece(Piece.types.Rook, Piece.Color.BLACK);
                                    break;
                                case ('B'):
                                    board[i, j] = new Piece(Piece.types.Bishop, Piece.Color.WHITE);
                                    break;
                                case ('b'):
                                    board[i, j] = new Piece(Piece.types.Bishop, Piece.Color.BLACK);
                                    break;
                                case ('Q'):
                                    board[i, j] = new Piece(Piece.types.Queen, Piece.Color.WHITE);
                                    break;
                                case ('q'):
                                    board[i, j] = new Piece(Piece.types.Queen, Piece.Color.BLACK);
                                    break;
                                case ('K'):
                                    board[i, j] = new Piece(Piece.types.King, Piece.Color.WHITE);
                                    break;
                                case ('k'):
                                    board[i, j] = new Piece(Piece.types.King, Piece.Color.BLACK);
                                    break;
                            }
                            ++j;
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            // for(int i=0;i<8;i++)
            // {
            //     int b = 0;
            //     for (int p=0;p<8;p++)
            //     { 
            //         try
            //         {
            //             int j = p + b;

            //             Debug.WriteLine(firstSplit[i][p]);
            //             switch (firstSplit[i][p])
            //             {
            //                 case ('P'):
            //                     board[i, j] = new Piece(Piece.types.Pawn, Piece.Color.WHITE);
            //                     break;
            //                 case ('p'):
            //                     board[i, j] = new Piece(Piece.types.Pawn, Piece.Color.BLACK);
            //                     break;
            //                 case ('N'):
            //                     board[i, j] = new Piece(Piece.types.Knight, Piece.Color.WHITE);
            //                     break;
            //                 case ('n'):
            //                     board[i, j] = new Piece(Piece.types.Knight, Piece.Color.BLACK);
            //                     break;
            //                 case ('R'):
            //                     board[i, j] = new Piece(Piece.types.Rook, Piece.Color.WHITE);
            //                     break;
            //                 case ('r'):
            //                     board[i, j] = new Piece(Piece.types.Rook, Piece.Color.BLACK);
            //                     break;
            //                 case ('B'):
            //                     board[i, j] = new Piece(Piece.types.Bishop, Piece.Color.WHITE);
            //                     break;
            //                 case ('b'):
            //                     board[i, j] = new Piece(Piece.types.Bishop, Piece.Color.BLACK);
            //                     break;
            //                 case ('Q'):
            //                     board[i, j] = new Piece(Piece.types.Queen, Piece.Color.WHITE);
            //                     break;
            //                 case ('q'):
            //                     board[i, j] = new Piece(Piece.types.Queen, Piece.Color.BLACK);
            //                     break;
            //                 case ('K'):
            //                     board[i, j] = new Piece(Piece.types.King, Piece.Color.WHITE);
            //                     break;
            //                 case ('k'):
            //                     board[i, j] = new Piece(Piece.types.King, Piece.Color.BLACK);
            //                     break;

            //                 default:
            //                     if (int.TryParse(firstSplit[i][j].ToString(), out int a))
            //                     {
            //                         b += a-1;
            //                         for (int k = 0; k < i; ++k)
            //                         {
            //                             board[i, j + k+1] = new Piece(Piece.types.None, Piece.Color.BLACK);
            //                         }
            //                     }
            //                     break;

            //             }
            //             Debug.WriteLine(board[i, j].type);
            //         }
            //         catch (Exception e)
            //         {
            //             continue;
            //         }
                    

            //     }
            // }
        }
    }
}
