using System;

namespace fc_tetris_core
{
    class Program
    {
        public static int Score { get; set; }
        static void Main(string[] args)
        {
            Score = 0;
            Char2Ascii.drawChar(Score.ToString()[0], 50, 8);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Board board = new Board();
            board.Draw(0,0);
            board.updateGrid();
        }

    }
}
