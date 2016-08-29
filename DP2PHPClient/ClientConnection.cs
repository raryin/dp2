using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using NetworkCommsDotNet;
using NetworkCommsDotNet.Connections.TCP;

namespace DP2PHPClient
{
    /// <summary>
    /// Handles all the connections for the client end, including setting up the connection, sending
    /// and recieving messages. Modified from:
    /// http://www.networkcomms.net/synchronous-send-and-receive/
    /// </summary>
    class ClientConnection
    {
        private ConnectionInfo _connectionInfo;
        private TCPConnection _connection;
        private string _address;
        private int _port;

        public ClientConnection(string address, int port)
        {
            _connectionInfo = new ConnectionInfo(address, port);
            _address = address;
            _port = port;
        }

        public void StartConnection()
        {
            _connection = TCPConnection.GetConnection(_connectionInfo); 
            //Get a connection with the specified connectionInfo
            _connection.SendObject("Hello");
        }

        public ConnectionState GetConnectionState()
        {
            return _connectionInfo.ConnectionState;
        }

        public void SendTest()
        {
            _connection.SendObject("Message", "Test message.");
        }

        /// <summary>
        /// Requests the stock record of the specified ID from the business logic server. Assumed the
        /// connection has already been set up. Current has unhandled exceptions for timed out connections.
        /// Timeout currently set at 1000ms.
        /// </summary>
        /// <param name="stockID">The stock ID to request.</param>
        public StockRecord RequestStockInfo(int stockID)
        {
            return _connection.SendReceiveObject<StockRecord>("GetStockRequest", "ReturnStockRecord", 1000);
        }

        public void InsertStock(string stockName, double purchase, double sell, int qty)
        {
            _connection.SendObject("InsertStock", new StockRecord(0, stockName, purchase, sell, qty));
        }

        public void Shutdown()
        {
            NetworkComms.Shutdown();
        }

    }
}
