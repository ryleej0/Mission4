using System;
using System.Collections.Generic;

namespace Mission4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Tic-Tac-Toe in C#");

            // 3x3 board with positions 1-9
            char[,] board = new char[,]
            {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };

            TicSystem ts = new TicSystem();

            bool gameOver = false;
            List<string> numUsed = new List<string>();
            List<string> options = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            string checkWin = ""; // "X", "O", or "" for tie

            while (!gameOver)
            {
                // Show board at start of round
                Console.WriteLine(ts.PrintBoard(board));

                // ---------- Player 1 (X) ----------
                string input1;
                while (true)
                {
                    Console.Write("Player 1 (X), choose an available square (1-9): ");
                    input1 = (Console.ReadLine() ?? "").Trim();

                    if (!options.Contains(input1))
                    {
                        Console.WriteLine("Invalid choice. Enter a number 1-9.");
                        continue;
                    }

                    if (numUsed.Contains(input1))
                    {
                        Console.WriteLine("Space already selected. Pick another.");
                        continue;
                    }

                    break; // valid input
                }

                PlaceMove(board, input1, 'X');
                numUsed.Add(input1);

                char winner = ts.CheckWinner(board);
                if (winner != ' ')
                {
                    checkWin = winner.ToString();
                    gameOver = true;
                    break;
                }

                if (numUsed.Count == 9)
                {
                    // All spots filled and no winner => tie
                    checkWin = "";
                    gameOver = true;
                    break;
                }

                // Show board after X move
                Console.WriteLine(ts.PrintBoard(board));

                // ---------- Player 2 (O) ----------
                string input2;
                while (true)
                {
                    Console.Write("Player 2 (O), choose an available square (1-9): ");
                    input2 = (Console.ReadLine() ?? "").Trim();

                    if (!options.Contains(input2))
                    {
                        Console.WriteLine("Invalid choice. Enter a number 1-9.");
                        continue;
                    }

                    if (numUsed.Contains(input2))
                    {
                        Console.WriteLine("Space already selected. Pick another.");
                        continue;
                    }

                    break; // valid input
                }

                PlaceMove(board, input2, 'O');
                numUsed.Add(input2);

                winner = ts.CheckWinner(board);
                if (winner != ' ')
                {
                    checkWin = winner.ToString();
                    gameOver = true;
                    break;
                }

                if (numUsed.Count == 9)
                {
                    checkWin = "";
                    gameOver = true;
                    break;
                }
            }

            // Final board display
            Console.WriteLine(ts.PrintBoard(board));

            // Final message
            if (string.IsNullOrEmpty(checkWin))
            {
                Console.WriteLine("It's a tie!");
            }
            else
            {
                Console.WriteLine($"Congratulations {checkWin}, you have won!");
            }
        }

        // Helper to place a move based on 1-9 input
        static void PlaceMove(char[,] board, string input, char symbol)
        {
            switch (input)
            {
                case "1": board[0, 0] = symbol; break;
                case "2": board[0, 1] = symbol; break;
                case "3": board[0, 2] = symbol; break;
                case "4": board[1, 0] = symbol; break;
                case "5": board[1, 1] = symbol; break;
                case "6": board[1, 2] = symbol; break;
                case "7": board[2, 0] = symbol; break;
                case "8": board[2, 1] = symbol; break;
                case "9": board[2, 2] = symbol; break;
            }
        }
    }
}


