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

            dbconnect.ClearDatabase();
            dbconnect.PopulateDatabase();

            int[] databaseItems = new int[20];
            double[] elapsedMs = new double[20];
            List<int> index = new List<int>();
            index.Add(((StockRecord)dbconnect.Select(DatabaseTable.Stock, -1)[0]).StockID);

            for (int i = 0; i < 10; i++)
            {
                databaseItems[i] = (int)(6 * Math.Pow(2.0,(double)i));

                var watch = System.Diagnostics.Stopwatch.StartNew();

                for (int j = 0; j < 10; j++)
                {
                    dbconnect.PredictProfits(index);
                    dbconnect.PredictSales(index);
                }

                watch.Stop();
                elapsedMs[i] = watch.ElapsedMilliseconds/25.0;

                for (int j = 0; j < ((int)Math.Pow(2,(i+1))); j++)
                {
                    dbconnect.PopulateDatabase();
                }
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Items: " + databaseItems[i] + " - " + elapsedMs[i] + " ms");
            }

            ServerConnectionManager.CreateServer(System.Net.IPAddress.Any, 25565);

            //Let the user close the server
            Console.WriteLine("\nPress any key to close server.");
            Console.ReadKey(true);

            ServerConnectionManager.EndServer();
        }

    }
}
