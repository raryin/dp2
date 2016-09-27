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

            double[] elapsedMs = new double[20];

            for (int i = 0; i < 20; i++)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();

                dbconnect.Select(DatabaseTable.Receipt, -1);

                watch.Stop();
                elapsedMs[i] = watch.ElapsedMilliseconds;
            }

            foreach (double d in elapsedMs)
            {
                Console.WriteLine(d + "ms");
            }

            ServerHandler.CreateServer(System.Net.IPAddress.Any, 25565);

            //Let the user close the server
            Console.WriteLine("\nPress any key to close server.");
            Console.ReadKey(true);

            ServerHandler.EndServer();
        }

    }
}
