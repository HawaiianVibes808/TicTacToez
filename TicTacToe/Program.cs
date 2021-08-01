using System;

namespace TicTacToe
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var gameEnder = "y";
            while (gameEnder != "n")
            {
                var player = 'X';
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

                    CheckIfWon(player, gameEnder, board, movesPlayed, gameEnd);
                    int n = 3;
                    for (int i = 0; i < n; i++)
                    {
                        if(board)
                    }
                    /*if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2])
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
                            gameEnder = "n";
                            gameEnd = true;
                        }
                    }
                    */

                    if (player == board[1, 0] && player == board[1, 1] && player == board[1, 2])
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
                            gameEnder = "n";
                            gameEnd = true;
                        }
                    }

                    if (player == board[2, 0] && player == board[2, 1] && player == board[2, 2])
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
                            gameEnder = "n";
                            gameEnd = true;
                        }
                    }

                    if (player == board[0, 0] && player == board[1, 0] && player == board[2, 0])
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
                            gameEnder = "n";
                            gameEnd = true;
                        }
                    }

                    if (player == board[0, 1] && player == board[1, 1] && player == board[2, 1])
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
                            gameEnder = "n";
                            gameEnd = true;
                        }
                    }

                    if (player == board[0, 2] && player == board[1, 2] && player == board[2, 2])
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
                            gameEnder = "n";
                            gameEnd = true;
                        }
                    }

                    if (player == board[0, 0] && player == board[1, 1] && player == board[2, 2])
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
                            gameEnder = "n";
                            gameEnd = true;
                        }
                    }

                    if (player == board[0, 2] && player == board[1, 1] && player == board[2, 0])
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
                            gameEnder = "n";
                            gameEnd = true;
                        }
                    }
                    

                    movesPlayed += 1;

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
                            gameEnder = "n";
                            gameEnd = true;
                        }
                    }

                    player = ChangeTurn(player);
                }
            }
        }

        private static void CheckIfWon(int player, string gameEnder, char[,] board, int movesPlayed, bool gameEnd)
        {
            if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2])
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
                    gameEnder = "n";
                    gameEnd = true;
                }
            }
            
            if (player == board[1, 0] && player == board[1, 1] && player == board[1, 2])
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
                    gameEnder = "n";
                    gameEnd = true;
                }
            }
            
            if (player == board[2, 0] && player == board[2, 1] && player == board[2, 2])
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
                            gameEnder = "n";
                            gameEnd = true;
                        }
                    }

            if (player == board[0, 0] && player == board[1, 0] && player == board[2, 0])
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
                            gameEnder = "n";
                            gameEnd = true;
                        }
                    }

            if (player == board[0, 1] && player == board[1, 1] && player == board[2, 1])
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
                            gameEnder = "n";
                            gameEnd = true;
                        }
                    }

            if (player == board[0, 2] && player == board[1, 2] && player == board[2, 2])
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
                            gameEnder = "n";
                            gameEnd = true;
                        }
                    }

            if (player == board[0, 0] && player == board[1, 1] && player == board[2, 2])
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
                            gameEnder = "n";
                            gameEnd = true;
                        }
                    }

            if (player == board[0, 2] && player == board[1, 1] && player == board[2, 0])
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
                            gameEnder = "n";
                            gameEnd = true;
                        }
                    }
            
        }

      /*  private static void Draw(int movesPlayed, bool gameEnd, string gameEnder, char[,] board)
        {
            movesPlayed += 1;

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
                    gameEnder = "n";
                    gameEnd = true;
                }
        } 
        */
      
      

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