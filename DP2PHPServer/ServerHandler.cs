using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using NetworkCommsDotNet;
using NetworkCommsDotNet.Connections;
using ProtoBuf;

namespace DP2PHPServer
{
    /// <summary>
    /// Handles passing tasks recieved from incoming packets to other classes. Call the "CreateServer"
    /// method to begin the program. Modified from the example at:
    /// http://www.networkcomms.net/how-to-create-a-client-server-application-in-minutes/
    /// </summary>
    static class ServerHandler
    {
        /// <summary>
        /// Starts the server at the designated IP address and port. Also sets up all the required handlers
        /// to recieve packets. Call "EndServer" once the server has completed its job.
        /// </summary>
        /// <param name="address">IP address on which to listen.</param>
        /// <param name="port">Port on which to listen.</param>
        public static void CreateServer(IPAddress address, int port)
        {
            //Trigger the method PrintIncomingMessage when a packet of type 'Message' (defined in the Client
            //is received. We expect the incoming object to be a string which we state explicitly by using
            //<string>.
            NetworkComms.AppendGlobalIncomingPacketHandler<string>("Message", PrintIncomingMessage);
            NetworkComms.AppendGlobalIncomingPacketHandler<string>("Hello", NewIncomingConnection);
            NetworkComms.AppendGlobalIncomingPacketHandler<int>("GetStockRequest", GetStockRecord);
            NetworkComms.AppendGlobalIncomingPacketHandler<StockRecord>("InsertStockRecord", InsertStock);
            //Start listening for incoming connections
            Connection.StartListening(ConnectionType.TCP, new System.Net.IPEndPoint(address, port));

            //Print out the IPs and ports we are now listening on
            Console.WriteLine("Server listening for TCP connection on:");
            foreach (System.Net.IPEndPoint localEndPoint in Connection.ExistingLocalListenEndPoints(ConnectionType.TCP))
                Console.WriteLine("{0}:{1}", localEndPoint.Address, localEndPoint.Port);
        }

        /// <summary>
        /// Starts the server at the designated port. Listens on any available address. Also sets
        /// up all the required handlers to recieve packets. Call "EndServer" once the server has
        /// completed its job.
        /// </summary>
        /// <param name="port">Port on which to listen.</param>
        public static void CreateServer(int port)
        {
            CreateServer(IPAddress.Any, port);
        }

        /// <summary>
        /// Starts the server. Listens on any available address and on the first found port. Also sets
        /// up all the required handlers to recieve packets. Call "EndServer" once the server has
        /// completed its job.
        /// </summary>
        public static void CreateServer()
        {
            CreateServer(0);
        }

        /// <summary>
        /// Safely closes any servers that have been opened.
        /// </summary>
        public static void EndServer()
        {
            //We have used NetworkComms so we should ensure that we correctly call shutdown
            NetworkComms.Shutdown();
        }

        private static void NewIncomingConnection(PacketHeader header, Connection connection, string message)
        {
            Console.WriteLine("\nA new connection detected from " + connection.ToString() + ".");
        }

        /// <summary>
        /// Writes the provided message to the console window
        /// </summary>
        /// <param name="header">The packet header associated with the incoming message</param>
        /// <param name="connection">The connection used by the incoming message</param>
        /// <param name="message">The message to be printed to the console</param>
        private static void PrintIncomingMessage(PacketHeader header, Connection connection, string message)
        {
            Console.WriteLine("\nA message was received from " + connection.ToString() + " which said '" + message + "'.");
        }

        private static void GetStockRecord(PacketHeader header, Connection connection, int stockID)
        {
            //Get the requested stock record from the database.
            StockRecord record = DataWrapper.GetStockRecord(stockID);

            Console.WriteLine("\nSending info about stock item: " + record.ToString() + " to connection: " + connection.ToString() + "'.");

            //Send the record back to the client.
            connection.SendObject("ReturnStockRecord", record);
        }

        private static void InsertStock(PacketHeader header, Connection connection, StockRecord record)
        {
            Console.WriteLine("\nInserting: " + record.StockName + record.Purchase + record.CurrentSell + record.Quantity + " for connection: " + connection.ToString() + "'.");
            DatabaseAccess dbconnect = new DatabaseAccess();
            if (dbconnect.Insert(record.StockName, record.Purchase, record.CurrentSell, record.Quantity) != 0)
            {
                Console.WriteLine("Success.");
                connection.SendObject("ReturnInsertStockRecord", true);
            }
            else
            {
                Console.WriteLine("Failed.");
                connection.SendObject("ReturnInsertStockRecord", false);
            }
            Console.WriteLine("Done");
        }

    }
}
