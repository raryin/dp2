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
    public class ClientConnectionManager
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
        /// for 10000ms.
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
                if (_connection.SendReceiveObject<StockRecord, bool>("InsertStockRecord", "ReturnInsertStockRecord", 10000,
                    new StockRecord(0, stockName, purchase, sell, qty)))
                {
                    View.SuccessNotify("Successfully added stock.", "Receipt successful");
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
        /// Sends a request to delete the specified stockID from the database. Produces error messages if failed. Waits
        /// for 10000ms.
        /// </summary>
        /// <param name="stockID"></param>
        /// <returns>The success of the delete command.</returns>
        public bool DeleteStock(int stockID)
        {
            int rows = 0;

            try
            {
                //Send a request to insert stock, expecting a confirmation. Also writes the number of rows deleted to rows.
                if ((rows = _connection.SendReceiveObject<int, int>("DeleteStockRecord", "ReturnDeleteStockRecord", 10000, stockID)) != 0)
                {
                    View.SuccessNotify("Successfully deleted " + rows + " rows.", "Delete successful");
                    return true;
                }
                //The server has failed to insert the stock in the database.
                else
                {
                    View.ErrorNotify("Data could not be deleted from the database.\n Check the server for further details.",
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
        /// Timeout currently set at 10000ms.
        /// </summary>
        /// <param name="stockID">The stock ID to request.</param>
        /// <returns>List of stock records that match the request.</returns>
        public List<StockRecord> RequestStockInfo(int stockID)
        {
            List<StockRecord> records = null;

            try
            {
                //Send a request to insert stock, expecting a confirmation. Also writes the number of rows deleted to rows.
                if ((records = _connection.SendReceiveObject<int, List<StockRecord>>("SelectStockRecord", "ReturnSelectStockRecord", 10000, stockID)) == null)
                {
                    View.ErrorNotify("Data could not be selected from the database.\n Check the server for further details.",
                    "Database Error");
                }

                //The server has failed to insert the stock in the database.
                else if (records.Count == 0)
                {
                    View.ErrorNotify("Data could not be selected from the database.\n Check the server for further details.",
                    "Database Error");
                }
            }
            catch (ExpectedReturnTimeoutException exception)
            {
                View.ErrorNotify("No confirmation recieved from server.\n Likly a connection issue, check the server status.",
                    "Connection Error");
            }

            return records;
        }

        /// <summary>
        /// Updates the stock record of the specified ID to the specified quantity. Assumed the
        /// connection has already been set up. Current has unhandled exceptions for timed out connections.
        /// Timeout currently set at 10000ms.
        /// </summary>
        /// <param name="stockID">The stock ID to request.</param>
        public bool UpdateStock(StockRecord record)
        {
            int rows = 0;

            try
            {
                //Send a request to update stock, expecting a confirmation. Also writes the number of rows updated to rows.
                if ((rows = _connection.SendReceiveObject<StockRecord, int>("UpdateStockRecord", "ReturnUpdateStockRecord", 10000, record)) != 0)
                {
                    View.SuccessNotify("Successfully updated " + rows + " rows.", "Update successful");
                    return true;
                }
                //The server has failed to insert the stock in the database.
                else
                {
                    View.ErrorNotify("Data could not be updated in the database.\n Check the server for further details.",
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
        /// Decrements the stock record of the specified ID by the specified quantity. Assumed the
        /// connection has already been set up. Current has unhandled exceptions for timed out connections.
        /// Timeout currently set at 10000ms.
        /// </summary>
        /// <param name="stockID">The stock ID to request.</param>
        public bool DecrementStock(StockRecord record)
        {
            int rows = 0;

            try
            {
                //Send a request to update stock, expecting a confirmation. Also writes the number of rows updated to rows.
                if ((rows = _connection.SendReceiveObject<StockRecord, int>("DecrementStockRecord", "ReturnDecrementStockRecord", 10000, record)) != 0)
                {
                    View.SuccessNotify("Successfully decremented " + rows + " rows.", "Decrement successful");
                    return true;
                }
                //The server has failed to insert the stock in the database.
                else
                {
                    View.ErrorNotify("Data could not be updated in the database.\n Check the server for further details.",
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
        /// Sends a request to add the specified receipt record to the database with associated ItemSales.
        /// Produces error messages if failed. Waits for 10000ms.
        /// </summary>
        /// <param name="records">List of ItemSales to add. ID is generated so is ignored in the record.</param>
        /// <returns>The success of the insert command.</returns>
        public bool InsertReceipt(List<ItemSaleRecord> records)
        {
            try
            {
                //Send a request to insert stock, expecting a confirmation.
                if (_connection.SendReceiveObject<List<ItemSaleRecord>, bool>("InsertReceiptRecord", "ReturnInsertReceiptRecord", 10000, records))
                {
                    View.SuccessNotify("Successfully added receipt.", "Receipt successful");
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


		/////////TEST SHELLS////////////

		/// <summary>
		/// Sends a request to delete the specified receipt record from the database with associated ItemSales.
		/// Produces error messages if failed. Waits for 10000ms.
		/// </summary>
		/// <param name="SaleID">SaleID (receipt) to delete from the database.</param>
		/// <returns>The success of the delete operation.</returns>
		public bool DeleteReceipt(int SaleID)
		{
			return false; //force fail for test case until implementation complete
		}

		/// <summary>
		/// Sends a request for details of a receipt. Returns the list of associated ItemSale records if a specific
        /// id is specified, or returns a list of all reciepts if -1 is provided.
		/// </summary>
		/// <param name="id">ID requested</param>
		/// <returns>List of ReceiptRecords or ItemSaleRecords. Null if query fails.</returns>
		public List<Record> RequestReceiptInfo(int SaleID)
		{
            List<Record> records = null;

            try
            {

                //Request is for all Receipt records
                if (SaleID == -1)
                {
                    List<ReceiptRecord> temp;

                    //Send a request for Receipt records, expecting a list of records.
                    if ((temp = _connection.SendReceiveObject<int, List<ReceiptRecord>>("GetAllReceipt", "ReturnGetAllReceipt", 10000, SaleID)) == null)
                    {
                        View.ErrorNotify("Data could not be selected from the database.\n Check the server for further details.",
                        "Database Error");
                    }
                    //The server has failed to retrieve the stock in the database.
                    else if (temp.Count == 0)
                    {
                        View.ErrorNotify("Data could not be selected from the database.\n Check the server for further details.",
                        "Database Error");
                    }
                    else
                    {
                        records = new List<Record>();
                        foreach (ReceiptRecord r in temp)
                            records.Add(r);
                    }
                }
                //Request is for full Receipt record
                else
                {
                    List<ItemSaleRecord> temp;

                    //Send a request for Receipt records, expecting a list of records.
                    if ((temp = _connection.SendReceiveObject<int, List<ItemSaleRecord>>("GetFullReceipt", "ReturnGetFullReceipt", 10000, SaleID)) == null)
                    {
                        View.ErrorNotify("Data could not be selected from the database.\n Check the server for further details.",
                        "Database Error");
                    }
                    //The server has failed to retrieve the stock in the database.
                    else if (temp.Count == 0)
                    {
                        View.ErrorNotify("Data could not be selected from the database.\n Check the server for further details.",
                        "Database Error");
                    }
                    else
                    {
                        records = new List<Record>();
                        foreach (ItemSaleRecord r in temp)
                            records.Add(r);
                    }
                }
                
            }
            catch (ExpectedReturnTimeoutException exception)
            {
                View.ErrorNotify("No confirmation recieved from server.\n Likly a connection issue, check the server status.",
                    "Connection Error");
            }

            return records;
        }

        /// <summary>
        /// Overload for RequestReceiptInfo.
        /// </summary>
        /// <returns>Returns the full list of ReceiptRecords</returns>
        public List<Record> RequestReceiptInfo()
        {
            return RequestReceiptInfo(-1);
        }

        /// <summary>
        /// Sends a request to update the receipt record with the specified SaleID.
        /// Produces error messages if failed. Waits for 10000ms.
        /// </summary>
        /// <param name="SaleID">The receipt to update.</param>
        /// <returns>The success of the update command.</returns>
        public bool UpdateReceipt(int SaleID)
		{
			return false; //force fail for test case until implementation complete
		}


		/// <summary>
		/// Sends a request to display the receipt record with the specified SaleID.
		/// Produces error messages if failed. Waits for 10000ms.
		/// </summary>
		/// <param name="SaleID">The receipt to display.</param>
		/// <returns>The success of the insert command.</returns>
		public bool DisplayReceipt(int SaleID)
		{
			return false; //force fail for test case until implementation complete
		}
		
		//SPRINT 2
		public double PredictNextMonthSales(List<int> StockID)
		{
			return 0.0; //force fail for test case until implementation complete
		}
		
		public double PredictNextMonthProfit(List<int> StockID)
		{
			return 0.0; //force fail for test case until implementation complete
		}

    }
}
