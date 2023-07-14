using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_4
{
    public class GameGrid
    {
        public static string[,] board = { { " ", " ", " ", " ", " ", " ", " "},
                                          { " ", " ", " ", " ", " ", " ", " "},
                                          { " ", " ", " ", " ", " ", " ", " "},
                                          { " ", " ", " ", " ", " ", " ", " "},
                                          { " ", " ", " ", " ", " ", " ", " "},
                                          { " ", " ", " ", " ", " ", " ", " "}};

        public static void PrintBoard()
        {
            Console.WriteLine("\n|1||2||3||4||5||6||7|");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.WriteLine("\n---------------------");
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write("|" + board[i, j] + "|");
                }
            }
        }
    }
}
