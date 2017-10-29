namespace ticTacToe
{
    using System;

    public static class BoardDriver
    {
        public static void run()
        {
            int _choice = -1;
            Console.WriteLine("Welcome to tic tac toe game script ...!!!");
            while (true)
            {
                TicTacToeBoard._playerOne.isWiner = false;
                TicTacToeBoard._playerTwo.isWiner = false;
                Console.Write("1 in default config, 2 for add details, 3 for exit : ");
                try
                {
                    _choice = Convert.ToInt32(Console.ReadLine());
                    if (_choice == 1)
                    {
                        Console.WriteLine("Loading game in default settings ...");
                        BoardDriver.runGame();
                    }
                    else if (_choice == 2)
                    {
                        Console.Write("player one name : ");
                        TicTacToeBoard._playerOne.Name = Console.ReadLine();
                        Console.Write("player two name : ");
                        TicTacToeBoard._playerTwo.Name = Console.ReadLine();
                        BoardDriver.runGame();
                    }
                    else if (_choice == 3)
                    {
                        Console.WriteLine("Thank you for playing the game ...");
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message.ToString());
                }
            }
        }

        private static void runGame()
        {
            int tempX, tempY;
            bool flag = true;
            TicTacToeBoard.drawBoard();
            while (true)
            {
                if (TicTacToeBoard._playerOne.isWiner || TicTacToeBoard._playerTwo.isWiner)
                {
                    break;
                }
                while (flag)
                {
                    Console.WriteLine(TicTacToeBoard._playerOne.Name + "'s move (1 to 3) ,");
                    try
                    {
                        Console.Write("Y axis value : ");
                        tempX = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.Write("X axis value : ");
                        tempY = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (TicTacToeBoard.addMove(new BoardMovePosition(tempX, tempY), BoardMove.X))
                        {
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("wrong data format");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message.ToString());
                    }
                }
                TicTacToeBoard.drawBoard();
                flag = true;
                if (TicTacToeBoard._playerOne.isWiner || TicTacToeBoard._playerTwo.isWiner)
                {
                    break;
                }
                while (flag)
                {
                    Console.WriteLine(TicTacToeBoard._playerTwo.Name + "'s move(1 to 3) ,");
                    try
                    {
                        Console.Write("Y axis value : ");
                        tempX = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.Write("X axis value : ");
                        tempY = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (TicTacToeBoard.addMove(new BoardMovePosition(tempX, tempY), BoardMove.O))
                        {
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("wrong data format");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message.ToString());
                    }
                }
                TicTacToeBoard.drawBoard();
                flag = true;
            }
            Console.WriteLine(
                "Game ends,  winner is : "
                + ((TicTacToeBoard._playerOne.isWiner && !TicTacToeBoard._playerTwo.isWiner)
                       ? TicTacToeBoard._playerOne.Name
                       : ((TicTacToeBoard._playerTwo.isWiner && !TicTacToeBoard._playerOne.isWiner)
                              ? TicTacToeBoard._playerTwo.Name
                              : "match draw")));
            Console.WriteLine(
                "score => " + TicTacToeBoard._playerOne.Name + " : " + TicTacToeBoard._playerOne.leaderBoard.ToString()
                + " " + TicTacToeBoard._playerTwo.Name.ToString() + " : "
                + TicTacToeBoard._playerTwo.leaderBoard.ToString());
        }
    }
}