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
            char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            
            // Instantiate the supporting class (created by the other half of your team)
            TicSystem tools = new TicSystem();

            bool gameOver = false;
            char currentPlayer = 'X';
            int turns = 0;

            while (!gameOver)
            {
            }

        

