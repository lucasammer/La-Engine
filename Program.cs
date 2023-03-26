using La_engine_vt3;

namespace laEngine
{
    static class Program
    {
        static void Main(string[] args)
        {
            ChessBoard board = new ChessBoard();
            while(true)
            {
                string cmd = Console.ReadLine();
                string command = cmd.Split()[0];  
                string[] arguements = cmd.Split();

                switch (command)
                {
                    case "uci":
                        Console.WriteLine("id name la engine");
                        Console.WriteLine("id author LucasAmmer");
                        Console.WriteLine("uciok");
                        break;
                    case "isready":
                        Console.WriteLine("readyok");
                        break;
                    case "position":
                        if (arguements[1] == "startpos")
                        {
                            board.SetupBoard("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR");
                        }
                        else
                        {
                            board.SetupBoard(arguements[1]); // r1bqkbnr/pppp1ppp/2n5/4p3/2B1P3/5N2/PPPP1PPP/RNBQK2R
                        }
                        
                        break;
                    case "?":
                        board.ShowBoard(); 
                        break;
                    case "getpos":
                        board.getAtPos(arguements[1]);
                        break;
                }
            }
        }
    }
}