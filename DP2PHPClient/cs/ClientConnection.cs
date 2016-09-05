using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using NetworkCommsDotNet;
using NetworkCommsDotNet.Connections.TCP;
using NetworkCommsDotNet.Connections;

namespace DP2PHPClient
{
    /// <summary>
    /// Handles all the connections for the client end, including setting up the connection, sending
    /// and recieving messages. Modified from:
    /// http://www.networkcomms.net/synchronous-send-and-receive/
    /// </summary>
    class ClientConnectionManager
    {
        private ConnectionInfo _connectionInfo;
        private TCPConnection _connection;
        private string _address;
        private int _port;

        /// <summary>
        /// Instantiates this class. Address and port must be specified here and cannot be changed.
        /// Connection server is fixed.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="port"></param>
        public ClientConnectionManager(string address, int port)
        {
            //Put the address and port into a format the NetworkComms library can parse.
            _connectionInfo = new ConnectionInfo(address, port);
            _address = address;
            _port = port;
        }
        
        /// <summary>
        /// Connects to the server specified during instantiation. Returns false on a ConnectionSetupException and prints an error message.
        /// </summary>
        /// <returns>Success of connection.</returns>
        public bool ConnectToServer()
        {
            try
            {
                //Get a connection with the specified connectionInfo.
                _connection = TCPConnection.GetConnection(_connectionInfo);
                //Need to send a dummy message for the server to acknowledge.
                _connection.SendObject("Hello");
            }
            catch (ConnectionSetupException exception)
            {
                View.ErrorNotify("Failed to connect to server.\nPlease check connection details.", "Connection Error");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Disconnects from the current connection. Returns the success of the disconnection.
        /// </summary>
        /// <returns>Success of disconnection.</returns>
        public bool Disconnect()
        {
            //No need for any action if no connection has been defined.
            if (_connection != null)
            {
                try
                {
                    //NetworkComms library handles the shutdown process.
                    NetworkComms.Shutdown();
                }
                catch (CommsSetupShutdownException exception)
                {
                    View.ErrorNotify("Failed to disconnect from server.\n Likly a connection issue.", "Connection Error");
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Returns the current state of the established connection. If no connection is established, returns
        /// Undefined.
        /// </summary>
        /// <returns>The connection state (Established, Establishing, Shutdown, Undefined).</returns>
        public ConnectionState GetConnectionState()
        {
            if (_connection == null)
                return ConnectionState.Undefined;

            return _connectionInfo.ConnectionState;
        }

        /// <summary>
        /// Sends a request to add the specified stock record to the database. Produces error messages if failed. Waits
        /// for 5000ms.
        /// </summary>
        /// <param name="stockName">Name of new stock.</param>
        /// <param name="purchase">Purchase cost of new stock.</param>
        /// <param name="sell">Sell price of the item.</param>
        /// <param name="qty">Current quantity of the stock.</param>
        /// <returns>The success of the insert command.</returns>
        public bool InsertStock(string stockName, double purchase, double sell, int qty)
        {
            try
            {
                //Send a request to insert stock, expecting a confirmation.
                if (_connection.SendReceiveObject<StockRecord, bool>("InsertStockRecord", "ReturnInsertStockRecord", 5000,
                    new StockRecord(0, stockName, purchase, sell, qty)))
                {
                    return true;
                }
                //The server has failed to insert the stock in the database.
                else
                {
                    View.ErrorNotify("Data could not be added to the database.\n Check the server for further details.",
                        "Database Error");
                }
            }
            catch (ExpectedReturnTimeoutException exception)
            {
                View.ErrorNotify("No confirmation recieved from server.\n Likly a connection issue, check the server status.",
                    "Connection Error");
            }

            return false;
        }

        /// <summary>
        /// Requests the stock record of the specified ID from the business logic server. Assumed the
        /// connection has already been set up. Current has unhandled exceptions for timed out connections.
        /// Timeout currently set at 5000ms.
        /// </summary>
        /// <param name="stockID">The stock ID to request.</param>
        public StockRecord RequestStockInfo(int stockID)
        {
            return _connection.SendReceiveObject<StockRecord>("GetStockRequest", "ReturnStockRecord", 5000);
        }

    }
}
