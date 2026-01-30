using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace Mission4;

public class TicSystem
{
    string printCommand = "";
	public string printBoard(List<List<char>> board)
    {
		string linePrintCommand = "";
        List<string> linePrintStorage = new List<string>();


        
        for (int i = 0; i < board.Count; i++)
        {
            linePrintCommand = $" " + board[i][0] + " | " + board[i][1] + " | " + board[i][2] + " ";
            linePrintStorage.Add(linePrintCommand);
        }

        printCommand = linePrintStorage[0] + $"\n-----------\n" + linePrintStorage[1] + "'\n-----------\n" + linePrintStorage[2];

        return printCommand;
	}

	public char checkWinner(List<List<char>> board)
	{
		for (int i = 0; i < board.Count; i++)
		{

			if (ThreeEqual(board[i][0], board[i][1], board[i][2]))
			{
				return board[i][0];
			}

			if (ThreeEqual(board[0][i], board[1][i], board[2][i]))
			{
				return board[0][i];
			}
		}

		if (ThreeEqual(board[0][0], board[1][1], board[2][2]))
		{
			return board[0][0];
		}

		if (ThreeEqual(board[0][2], board[1][1], board[2][0]))
		{
			return board[0][2];
		}

		return ' ';
	}

	private bool ThreeEqual(char a, char b, char c)
	{
		return !char.IsDigit(a) && a == b && b == c;
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