using System;
using System.Collections.Generic;

namespace TicTacToe
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // var player1 = new Player("X");
            // var player2 = new Player("O");
            var player = 'X';
            
            /*
             * Create game class
             * Should create board
             * Should take in 2 players for the game
             * Should handle adding players character to board
             * Should check for win condition
             * Should print board
             */
            var board = new char[3, 3];
            Initialize(board);
            var movesPlayed = 0;
            var gameEnd = false;

            while (gameEnd == false)
            {
                Console.Clear();
                Print(board);

                Console.Write("Player, please enter row: ");
                var row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Player, please enter col: ");
                var col = Convert.ToInt32(Console.ReadLine());

                board[row, col] = player;
                var winner = false;
                for (var i = 0; i < board.GetLength(0); i++) // height
                {
                    var j = 0;

                    if ((board[i, j] == player && board[i, j + 1] == player && board[i, j + 2] == player) ||
                        (board[j, i] == player && board[j + 1, i] == player && board[j + 2, i] == player) ||
                        (player == board[i, i] && player == board[i, i] && player == board[i, i]) ||
                        (player == board[j, j + 2] && player == board[j + 1, j + 1] && player == board[j + 2, j]))
                    {
                        winner = true;
                    }
                }

                movesPlayed += 1;
                
                if (winner)
                {
                    Console.WriteLine(player + " has won the game!");
                    Console.WriteLine("Would you like to play again? Enter y for yes or n for no");
                    var answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        movesPlayed = -1;
                        Initialize(board);
                    }
                    else
                    {
                        Console.WriteLine("Thanks for playing!");
                        gameEnd = true;
                    }
                }
                
                if (movesPlayed == 9)
                {
                    Console.WriteLine("Draw");
                    Console.WriteLine("Would you like to play again? Enter y for yes or n for no");
                    var answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        Initialize(board);
                    }
                    else
                    {
                        Console.WriteLine("Thanks for playing!");
                        gameEnd = true;
                    }
                }

                player = ChangeTurn(player);
            }
        }

        private static char ChangeTurn(char currentPlayer)
        {
            if (currentPlayer == 'X')
                return 'O';
            return 'X';
        }

        private static void Initialize(char[,] board)
        {
            for (var row = 0; row < 3; row++)
            for (var col = 0; col < 3; col++)
                board[row, col] = ' ';
        }

        private static void Print(char[,] board)
        {
            Console.WriteLine("  | 0 | 1 | 2 |");
            for (var row = 0; row < 3; row++)
            {
                Console.Write(row + " | ");
                for (var col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" | ");
                }

                Console.WriteLine();
            }
        }
    }
}