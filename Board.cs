using System;

namespace fc_tetris_core
{
    public class Board
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string[,] Grid { get; set; }
        public string CharVerticalWall { get; set; }
        public string CharHorizontalWall { get; set; }
        public string CharBlank { get; set; }
        public string CharTopLeft { get; set; }
        public string CharTopRight { get; set; }
        public string CharBottomLeft { get; set; }
        public string CharBottomRight { get; set; }
        public string CharBrick { get; set; }
        public Brick ActiveBrick { get; set; }

        public Board(int width=20,int height=30)
        {
            // Definições de desenho
            CharVerticalWall = "\u2551";
            CharHorizontalWall = "\u2550\u2550";
            CharBlank = "  ";
            CharTopLeft = "\u2554";
            CharTopRight = "\u2557";
            CharBottomLeft = "\u255A";
            CharBottomRight = "\u255D";
            CharBrick = "\u2588\u2588";

            // Definições de tamanho
            Width = width;
            Height = height;

            // Inicialização
            Grid = new string[Width,Height];
            initializeGrid();
            CreateBrick();
        }

        public void Draw(int posX = 0,int posY = 0){
            DrawActiveBrick();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.SetCursorPosition(posX, posY);
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    
                    System.Console.Write(Grid[j,i]);
                }
                Console.SetCursorPosition(posX, posY + i + 1);
            }
        }

        private void initializeGrid(){
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {

                    if (i == 0 || i == Height -1)
                    {
                        Grid[j, i] = CharHorizontalWall;
                    }else
                    {
                        if (j == 0 || j == Width -1)
                        {
                            Grid[j, i] = CharVerticalWall;
                        }else
                        {
                            Grid[j, i] = CharBlank;
                        }
                    }
                }

                Grid[0, 0] = CharTopLeft;
                Grid[Width - 1, 0] = CharTopRight;
                Grid[0, Height - 1] = CharBottomLeft;
                Grid[Width - 1, Height - 1] = CharBottomRight;
            }
        }

        /// <summary>
        /// Creates a new Brick to add into the Grid
        /// </summary>
        public void CreateBrick(){
            ActiveBrick = new Brick("Square");
            ActiveBrick.BoardPosition = ((Width / 2 ) -1, 1);
        }

        public void updateActiveBrick(){

        }

        public void DrawActiveBrick(){
            foreach ((int x, int y) pos in ActiveBrick.Positions)
            {
                Grid[pos.x + ActiveBrick.BoardPosition.x, pos.y + ActiveBrick.BoardPosition.y] = CharBrick;
            }
        }

        private void destroyFullLines(){
            for (int i = Height - 2; i > 0; i--)
            {
                for (int j = 1; j < Width; j++)
                {
                    if (Grid[j, i] != CharBrick)
                    {
                        break;
                    }
                }

            }
        }

        /// <summary>
        /// Applies Gravity to blocks, making everything fall
        /// </summary>
        public void updateGrid(){
            if (ActiveBrick.canMove)
            {
                //Move Brick
            }else
            {
                destroyFullLines();
                CreateBrick();
            }
            
        }



    }
}