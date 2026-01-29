using System;

namespace Mission4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Welcome the user
            Console.WriteLine("Hello! Welcome to Tic-Tac-Toe in C#");

            // 2. Create the game board array (9 spots for a 3x3 grid)
            // Initialized with numbers 1-9 so players can choose a spot easily
            char[,] board = {
                                { '1', '2', '3' },
                                { '4', '5', '6' },
                                { '7', '8', '9' }
                            };

            // Instantiate the supporting class (created by the other half of your team)
            TicSystem ts = new TicSystem();

            bool gameOver = false;
            char currentPlayer = 'X';
            int turns = 0;
            List<string> numUsed = new List<string>();
            List<string> options = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" };


            while (!gameOver)
            {

                ts.printBoard(board);
                Console.Write("Player 1, choose an available square (1-9): ");
                string input1 = Console.ReadLine();

                if (!options.Contains(input1))
                {
                    Console.WriteLine("Invalid choice.");
                }

                else if (numUsed.Contains(input1))
                {
                    Console.WriteLine("Space already selected.");
                }

                // Just check the string directly
                else
                {
                    switch (input1)
                    {
                        case "1": board[0, 0] = 'X'; break;
                        case "2": board[0, 1] = 'X'; break;
                        case "3": board[0, 2] = 'X'; break;
                        case "4": board[1, 0] = 'X'; break;
                        case "5": board[1, 1] = 'X'; break;
                        case "6": board[1, 2] = 'X'; break;
                        case "7": board[2, 0] = 'X'; break;
                        case "8": board[2, 1] = 'X'; break;
                        case "9": board[2, 2] = 'X'; break;
                    }
                    numUsed.Add(input1);
                }


                ts.printBoard(board);
                Console.Write("Player 2, choose an available square (1-9): ");
                string input2 = Console.ReadLine();

                if (!options.Contains(input2))
                {
                    Console.WriteLine("Invalid choice.");
                }

                else if (numUsed.Contains(input2))
                {
                    Console.WriteLine("Space already selected.");
                }
                // Just check the string directly
                else
                {
                    switch (input2)
                    {
                        case "1": board[0, 0] = 'O'; break;
                        case "2": board[0, 1] = 'O'; break;
                        case "3": board[0, 2] = 'O'; break;
                        case "4": board[1, 0] = 'O'; break;
                        case "5": board[1, 1] = 'O'; break;
                        case "6": board[1, 2] = 'O'; break;
                        case "7": board[2, 0] = 'O'; break;
                        case "8": board[2, 1] = 'O'; break;
                        case "9": board[2, 2] = 'O'; break;
                    }
                    numUsed.Add(input2);
                }
            }
        }
    }
}

        

