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

        printCommand = linePrintStorage[0] + $"-----------" + linePrintStorage[1] + "-----------" + linePrintStorage[2];

        return printCommand;
	}

	public string checkWinner(List<List<char>> board)
	{
        string winnerCommand = "";

        for (int i = 0; i < board.Count; i++)
        {
        
        }

		return winnerCommand;
	}

    private bool threeEqual(string a, string b, string c) 
    {
        return a != " ";
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