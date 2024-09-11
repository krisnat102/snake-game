using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class GameManager
    {
        public int Row { get; }
        public int Column { get; }

        public Tile[,] Grid { get; }
        public Direction Direction { get; private set; }
        public int Score { get; private set; }
        public bool GameOver { get; private set; }
        
        private readonly LinkedList<Position> snakePosition = new LinkedList<Position>();
    }
}
