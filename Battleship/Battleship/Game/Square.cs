﻿using Battleship.Enum;

namespace Battleship.Gameplay
{
    public class Square
    {
        public Tuple<int, int> Position { get; set; }
        private SquareStatus _squareStatus;

        public Square(Tuple<int, int> position, SquareStatus status)
        {
            _squareStatus = status;
            Position = position;
        }

        public SquareStatus GetSquareStatus()
        {
            return _squareStatus;
        }

        public void ChangeStatus(SquareStatus status)
        {
            _squareStatus = status;
        }

        public static string GetCharacter(SquareStatus status)
        {
            string empty = "🟦  ";
            string ship = "🚢  ";
            string hit = "🔥  ";
            string missed = "❌  ";
            switch (status)
            {
                case SquareStatus.Empty:
                    return empty;
                case SquareStatus.Ship:
                    return ship;
                case SquareStatus.Hit:
                    return hit;
                case SquareStatus.Missed:
                    return missed;
            }
            return empty;
        }

    }
}