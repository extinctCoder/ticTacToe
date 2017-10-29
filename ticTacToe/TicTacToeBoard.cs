using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticTacToe
{
    public static class TicTacToeBoard
    {
        private static BoardMove[,] _board = new BoardMove[3, 3];
        public static Player _playerOne = new Player();
        public static Player _playerTwo = new Player();
        public static List<BoardMovePosition> playerOneMoves = new List<BoardMovePosition>();
        public static List<BoardMovePosition> playerTwoMoves = new List<BoardMovePosition>();

        public static void drawBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t" + TicTacToeBoard._board[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static bool addMove(BoardMovePosition _position, BoardMove _boardMove)
        {
            if (_board[_position.X, _position.Y] == BoardMove.Empty && (_position.X != -1 || _position.Y != -1))
            {
                _board[_position.X, _position.Y] = _boardMove;
                if (_boardMove == BoardMove.X)
                {
                    playerOneMoves.Add(_position);
                }
                else if (_boardMove == BoardMove.O)
                {
                    playerTwoMoves.Add(_position);
                }
                TicTacToeBoard.cheackWinner();
                return true;
            }
            return false;
        }

        public static void cheackWinner()
        {
            Console.WriteLine("move inserted successfully, checking for the winner ...");
            if (_board[0, 0] == BoardMove.X && _board[0, 1] == BoardMove.X && _board[0, 2] == BoardMove.X)
            {
                TicTacToeBoard._playerOne.isWiner = true;
            }
            else if (_board[1, 0] == BoardMove.X && _board[1, 1] == BoardMove.X && _board[1, 2] == BoardMove.X)
            {
                TicTacToeBoard._playerOne.isWiner = true;
            }
            else if (_board[2, 0] == BoardMove.X && _board[2, 1] == BoardMove.X && _board[2, 2] == BoardMove.X)
            {
                TicTacToeBoard._playerOne.isWiner = true;
            }
            else if(_board[0, 0] == BoardMove.X && _board[1, 0] == BoardMove.X && _board[2, 0] == BoardMove.X)
            {
                TicTacToeBoard._playerOne.isWiner = true;
            }
            else if (_board[0, 1] == BoardMove.X && _board[1, 1] == BoardMove.X && _board[2, 1] == BoardMove.X)
            {
                TicTacToeBoard._playerOne.isWiner = true;
            }
            else if (_board[0, 2] == BoardMove.X && _board[1, 2] == BoardMove.X && _board[2, 2] == BoardMove.X)
            {
                TicTacToeBoard._playerOne.isWiner = true;
            }
            else if (_board[0, 0] == BoardMove.X && _board[1, 1] == BoardMove.X && _board[2, 2] == BoardMove.X)
            {
                TicTacToeBoard._playerOne.isWiner = true;
            }
            else if (_board[0, 2] == BoardMove.X && _board[1, 1] == BoardMove.X && _board[2, 0] == BoardMove.X)
            {
                TicTacToeBoard._playerOne.isWiner = true;
            }

            if (_board[0, 0] == BoardMove.O && _board[0, 1] == BoardMove.O && _board[0, 2] == BoardMove.O)
            {
                TicTacToeBoard._playerTwo.isWiner = true;
            }
            else if (_board[1, 0] == BoardMove.O && _board[1, 1] == BoardMove.O && _board[1, 2] == BoardMove.O)
            {
                TicTacToeBoard._playerTwo.isWiner = true;
            }
            else if (_board[2, 0] == BoardMove.O && _board[2, 1] == BoardMove.O && _board[2, 2] == BoardMove.O)
            {
                TicTacToeBoard._playerTwo.isWiner = true;
            }
            else if (_board[0, 0] == BoardMove.O && _board[1, 0] == BoardMove.O && _board[2, 0] == BoardMove.O)
            {
                TicTacToeBoard._playerTwo.isWiner = true;
            }
            else if (_board[0, 1] == BoardMove.O && _board[1, 1] == BoardMove.O && _board[2, 1] == BoardMove.O)
            {
                TicTacToeBoard._playerTwo.isWiner = true;
            }
            else if (_board[0, 2] == BoardMove.O && _board[1, 2] == BoardMove.O && _board[2, 2] == BoardMove.O)
            {
                TicTacToeBoard._playerTwo.isWiner = true;
            }
            else if (_board[0, 0] == BoardMove.O && _board[1, 1] == BoardMove.O && _board[2, 2] == BoardMove.O)
            {
                TicTacToeBoard._playerTwo.isWiner = true;
            }
            else if (_board[0, 2] == BoardMove.O && _board[1, 1] == BoardMove.O && _board[2, 0] == BoardMove.O)
            {
                TicTacToeBoard._playerTwo.isWiner = true;
            }

            if (TicTacToeBoard._playerOne.isWiner)
            {
                TicTacToeBoard._playerOne.leaderBoard++;
            }

            if (TicTacToeBoard._playerTwo.isWiner)
            {
                Console.WriteLine(TicTacToeBoard.playerTwoMoves.ToArray().ToString());
                TicTacToeBoard._playerTwo.leaderBoard++;
            }
        }
    }
}
