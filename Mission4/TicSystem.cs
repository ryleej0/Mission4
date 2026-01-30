using System;

namespace Mission4
{
    public class TicSystem
    {
        // Print the 3x3 board as a string
        public string PrintBoard(char[,] board)
        {
            return
                $" {board[0, 0]} | {board[0, 1]} | {board[0, 2]} \n" +
                "-----------\n" +
                $" {board[1, 0]} | {board[1, 1]} | {board[1, 2]} \n" +
                "-----------\n" +
                $" {board[2, 0]} | {board[2, 1]} | {board[2, 2]} ";
        }

        // Return 'X', 'O', or ' ' if no winner
        public char CheckWinner(char[,] board)
        {
            // rows
            for (int r = 0; r < 3; r++)
            {
                if (ThreeEqual(board[r, 0], board[r, 1], board[r, 2]))
                    return board[r, 0];
            }

            // columns
            for (int c = 0; c < 3; c++)
            {
                if (ThreeEqual(board[0, c], board[1, c], board[2, c]))
                    return board[0, c];
            }

            // diagonals
            if (ThreeEqual(board[0, 0], board[1, 1], board[2, 2]))
                return board[0, 0];

            if (ThreeEqual(board[0, 2], board[1, 1], board[2, 0]))
                return board[0, 2];

            return ' ';
        }

        private bool ThreeEqual(char a, char b, char c)
        {
            // Prevent "111" or other digits from counting as a win
            return !char.IsDigit(a) && a == b && b == c;
        }
    }
}






//- \  /
//-  \/
//-  /\
//- /  \
//-
//-  __
//- /  \
//-|    |
//- \__/
//-
//-
//-