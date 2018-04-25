using System;

namespace fc_tetris_core
{
    public class Board
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string[,] Grid { get; set; }
        public string VerticalWall { get; set; }
        public string HorizontalWall { get; set; }
        public string Blank { get; set; }
        public string TopLeft { get; set; }
        public string TopRight { get; set; }
        public string BottomLeft { get; set; }
        public string BottomRight { get; set; }

        public Board(int width=10,int height=20)
        {
            // Definições de desenho
            VerticalWall = "\u2551";
            HorizontalWall = "\u2550\u2550";
            Blank = "  ";
            TopLeft = "\u2554";
            TopRight = "\u2557";
            BottomLeft = "\u255A";
            BottomRight = "\u255D";

            // Definições de tamanho
            Width = width;
            Height = height;

            // Inicialização
            Grid = new string[Width,Height];
            initializeGrid();
        }

        public void Draw(int posX = 0,int posY = 0){
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.SetCursorPosition(posX, posY);
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    
                    System.Console.Write(Grid[j,i]);
                }
                System.Console.WriteLine("");
            }
        }

        private void initializeGrid(){
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {

                    if (i == 0 || i == Height -1)
                    {
                        Grid[j, i] = HorizontalWall;
                    }else
                    {
                        if (j == 0 || j == Width -1)
                        {
                            Grid[j, i] = VerticalWall;
                        }else
                        {
                            Grid[j, i] = Blank;
                        }
                    }
                }

                Grid[0, 0] = TopLeft;
                Grid[Width - 1, 0] = TopRight;
                Grid[0, Height - 1] = BottomLeft;
                Grid[Width - 1, Height - 1] = BottomRight;
            }
        }



    }
}