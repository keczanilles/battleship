﻿using Battleship.Game;
using Battleship.Util;

namespace Battleship.Gameplay
{
    public class Game : Program.Battleship
    {
        private Board _board;
        private Player _playerOne;
        private Player _playerTwo;

        public Game(int boardSize, int gameMode)
        {
            _boardSize = boardSize;
            _gameMode = gameMode;
            _board = new Board(_boardSize, _gameMode);

            Play();
        }

        public void Play()
        {
            var boardFactory = new BoardFactory();

            string playerOneName = GetName("Player 1");
            _display.NewLine();
            string playerTwoName = GetName("Player 2");
            Display.Clear(1);

            _playerOne = new Player(playerOneName);
            _playerTwo = new Player(playerTwoName);

            PlayerPlacement(boardFactory, _playerOne, _playerTwo);
        }

        public string GetName(string player)
        {
            _display.Message($"{player} please enter your name! ");
            return _input.Select();
        }

        public void PlayerPlacement(BoardFactory boardFactory, Player playerOne, Player playerTwo)
        {
            for (int index = 0; index < 5; index++)
            {
                Display.Clear(1);
                _display.Board(playerOne, _boardSize, _board);
                _display.PlacementTurn(playerOne, (ShipType)index);
                boardFactory.ManualPlacement(playerOne, _board, (ShipType)index);
                Display.Clear(1);
                _display.Board(playerOne, _boardSize, _board);

                Display.Clear(1);
                _display.Board(playerTwo, _boardSize, _board);
                _display.PlacementTurn(playerTwo, (ShipType)index);
                boardFactory.ManualPlacement(playerTwo, _board, (ShipType)index);
                Display.Clear(1);
                _display.Board(playerTwo, _boardSize, _board);
            }
        }

        public bool IsGameOver()
        {
            throw new NotImplementedException();
        }
    }
}
