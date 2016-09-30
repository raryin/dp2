using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2PHPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseAccess dbconnect = new DatabaseAccess();

            dbconnect.DeleteItemSale(20);
            dbconnect.DeleteReceipt(20);

            ServerHandler.CreateServer(System.Net.IPAddress.Any, 25565);

            //Let the user close the server
            Console.WriteLine("\nPress any key to close server.");
            Console.ReadKey(true);

            ServerHandler.EndServer();
        }

    }
}
