using System;
using System.Collections.Generic;

namespace fc_tetris_core
{
    public class Brick
    {
        public List<string> Shapes { get; set; }
        public (int x, int y) BoardPosition { get; set; }
        public List<(int X,int Y)> Positions { get; set;}
        public string Shape { get; set; }
        public bool canMove { get; set; }
        public Brick(string _shape="")
        {
            Random r = new Random();
            Shapes = new List<string>(){"Square","I","L","Corner"};
            Positions = new List<(int X, int Y)>();
            canMove = true;
            BoardPosition = (0, 0);
            if (_shape == "")
            {
                Shape = Shapes[r.Next(0, Shapes.Count)];
            }else
            {
                Shape = _shape;
            }

            switch (Shape)
            {
                case "Square":
                    Positions = new List<(int X, int Y)>() { (0, 0), (0, 1), (1, 0), (1, 1) };
                    break;
            }
            
        }


    }
}