﻿namespace Battleship.Gameplay
{
    public class Board
    {
        private Square[,] _ocean;

        public Board(int boardSize, int gameMode)
        {
            _ocean = new Square[boardSize, boardSize];

            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    _ocean[row, col] = new Square((row, col), SquareStatus.Empty);
                }
            }
        }

        public bool IsPlacementOk()
        {
            throw new NotImplementedException();
        }

        public SquareStatus CheckSquare((int, int) position)
        {
            return _ocean[position.Item1, position.Item2]._squareStatus;
        }
    }
}