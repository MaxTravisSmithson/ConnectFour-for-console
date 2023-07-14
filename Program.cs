using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Net.Security;
using System.Net.Sockets;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace Connect_4
{
    class Program
    {
        public static bool win = false;
        public static void Main()
        {
            //This is the loop that will constantly repeat until a player wins and win becomes set to true
            while (Program.win == false)
            {
                Detection.PlayerTurn();
                Detection.Horizontal();
                Detection.Vertical();
                Detection.Diagonal();
            }

            //This should occur when the game has been won and it will show the board and an ascii art message
            Console.Clear();
            GameGrid.PrintBoard();
            Console.WriteLine("\n __     __                               _         \r\n \\ \\   / /                              (_)        \r\n  \\ \\_/ /    ___    _   _    __      __  _   _ __  \r\n   \\   /    / _ \\  | | | |   \\ \\ /\\ / / | | | '_ \\ \r\n    | |    | (_) | | |_| |    \\ V  V /  | | | | | |\r\n    |_|     \\___/   \\__,_|     \\_/\\_/   |_| |_| |_|");
        }

    }
}
