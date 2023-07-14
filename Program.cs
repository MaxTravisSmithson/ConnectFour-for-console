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
            while (Program.win == false)
            {
                Detection.PlayerTurn();
                Detection.Horizontal();
                Detection.Vertical();
                Detection.Diagonal();
            }
        }

    }
}
