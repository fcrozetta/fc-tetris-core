using System.Collections.Generic;

namespace fc_tetris_core
{
    public class Brick
    {
        public List<(int X,int Y)> Positions { get; set;}
        public Brick()
        {
            Positions = new List<(int X, int Y)>();
        }
    }
}