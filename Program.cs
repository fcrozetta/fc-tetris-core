using System;

namespace fc_tetris_core
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Board board = new Board();
            board.Draw();
        }

    }
}
