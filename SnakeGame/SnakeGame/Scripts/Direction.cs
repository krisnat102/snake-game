using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Direction
    {
        public static readonly Direction Left = new Direction(-1, 0);
        public static readonly Direction Right = new Direction(1, 0);
        public static readonly Direction Up = new Direction(0, -1);
        public static readonly Direction Down = new Direction(0, 1);

        public int Row { get; }
        public int Column { get; }

        public Direction(int row, int column)
        {
            this.Row = row;
            this.Column = column;
        }

        public Direction Opposite(Direction direction)
        {
            return new Direction(-Row, -Column);
        }

        public override bool Equals(object? obj)
        {
            return obj is Direction direction &&
                   Row == direction.Row &&
                   Column == direction.Column;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Column);
        }

        public static bool operator ==(Direction? left, Direction? right)
        {
            return EqualityComparer<Direction>.Default.Equals(left, right);
        }

        public static bool operator !=(Direction? left, Direction? right)
        {
            return !(left == right);
        }
    }
}
