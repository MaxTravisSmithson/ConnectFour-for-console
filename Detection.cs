using Connect_4;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Connect_4
{
    public class Detection
    {
        static int turn = 0;
        static string piece;

        static int row;
        static int column;

        //PlayerTurn will detect which players turn it is and will then change the colour and the piece accordingly
        //After this it will take the input for what column that the player wan
        //ts to place their piece in and check if it is
        //and then place the piece
        public static void PlayerTurn()
        {
            Console.Clear();
            turn++;
            if (turn % 2 == 0)
            {
                piece = "O";
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                piece = "X";
                Console.ForegroundColor = ConsoleColor.Red;
            }
            GameGrid.PrintBoard();
            Console.WriteLine("\nWhich column?");
            column = Convert.ToInt32(Console.ReadLine());
            column--;
            for (row = 1; row <= GameGrid.board.GetLength(0); row++)
            {
                var length = GameGrid.board.GetLength(0);
                
                if (GameGrid.board[GameGrid.board.GetLength(0) - row, column] == " ")
                {
                    GameGrid.board[GameGrid.board.GetLength(0) - row, column] = piece;
                    Console.WriteLine($"{row}{column}");
                    break;
                }
            }
        }
        //Detect any fours
        //The counter goes up one everytime it counts one of the players pieces
        //If it goes to a row segment without any then it resets to zero
        //If counter reaches 4 then the player wins

        //HORIZONTAL
        //Goes along the row that the player just placed a piece in
        public static void Horizontal()
        {
            int counter = 0;
            for (int j = 0; j < GameGrid.board.GetLength(1); j++)
            {
                if (GameGrid.board[GameGrid.board.GetLength(0) - row, j] == piece)
                {
                    counter++;
                    if (counter == 4)
                    {
                        Program.win = true;
                    }
                }
                else
                {
                    counter = 0;
                }
            }
        }

        //VERTICAL
        //Goes up the column that the player just placed a piece in
        public static void Vertical()
        {
            int counter = 0;
            for (int j = 0; j < GameGrid.board.GetLength(1); j++)
            {
                if (GameGrid.board[row - 1, column] == piece)
                {
                    counter++;
                    if (counter == 4)
                    {
                        Program.win = true;
                    }
                }
                else
                {
                    counter = 0;
                }
            }
        }

        //DIAGONAL
        //To check if the diagonal pieces make a 4

        public static void Diagonal()
        {
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 6; x++)
                {

                    if (GameGrid.board[y, x] == piece)
                    {

                        //Diagonally left:
                        try
                        {
                            if (GameGrid.board[y + 1, x - 1] == piece)
                            {
                                if (GameGrid.board[y + 2, x - 2] == piece)
                                {
                                    if (GameGrid.board[y + 3, x - 3] == piece)
                                    {
                                        Program.win = true;
                                    }
                                }
                            }
                        }
                        catch (IndexOutOfRangeException) { }

                        //Diagonally right:
                        try
                        {
                            if (GameGrid.board[y + 1, x + 1] == piece)
                            {
                                if (GameGrid.board[y + 2, x + 2] == piece)
                                {
                                    if (GameGrid.board[y + 3, x + 3] == piece)
                                    {
                                        Program.win = true;
                                    }
                                }
                            }
                        }
                        catch (IndexOutOfRangeException) { }
                    }
                }
            }
        }
    }
}
