using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

//Heavily based on http://www.codeproject.com/Articles/43438/Connect-C-to-MySQL
namespace DP2PHPServer
{
    /// <summary>
    /// Lists the tables available in the database. Prevents typos.
    /// </summary>
    enum DatabaseTable
    {
        Stock,
        Receipt,
        ItemSale
    }

    class DatabaseAccess
    {
        public MySqlConnection connection;
        public string server;
        public string database;
        public string uid;
        public string password;

        /// <summary>
        /// Constructor. Calls initialiser.
        /// </summary>
        public DatabaseAccess()
        {
            Initialise();
        }

        /// <summary>
        /// Sets up the connection to the database. Database adderss is fixed to db4free.net. Saves the database connection
        /// in the connection global.
        /// </summary>
        public void Initialise()
        {
            //Database logon details.
            server = "db4free.net";
            database = "dp2db";
            uid = "dp2user";
            password = "dp2000";

            string connectionString;
            //Standard connection string, but need to add Allow User Variables=True to enabled the AddNewReceipt method to work.
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + "; Allow User Variables=True";

            connection = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Opens the connection to the database. Returns true if successful. Prints an error message otherwise.
        /// </summary>
        /// <returns>The success.</returns>
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //Handles the two most common error numbers when connecting:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                //Other errors are printing with an error number.
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server. Contact administrator.");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again.");
                        break;
                    default:
                        Console.WriteLine("Unknown error: " + ex.Number);
                        break;
                }
                return false;
            }
        }

        /// <summary>
        /// Closes the connection to the database. Returns true if successful. Prints an error message otherwise.
        /// </summary>
        /// <returns>The success.</returns>
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Inserts data into the Stock table. ID is automatically generated. Returns 0 if failed.
        /// </summary>
        /// <param name="stockName">Stock name.</param>
        /// <param name="purchase">Purchased price.</param>
        /// <param name="sell">Current sell price.</param>
        /// <param name="qty">Current stock level.</param>
        /// <returns>Number of rows added. 1 if successful, 0 otherwise.</returns>
        public int Insert(string stockName, double purchase, double sell, int qty)
        {
            //Calls InsertCommand. Generates the query. The database connection is opened by InsertCommand.
            return InsertCommand(DatabaseTable.Stock, "(StockName, PurchaseCost, SellPrice, StockQty) VALUES('"+stockName+"', "+purchase+", "+sell+", "+qty+")");
        }

        /// <summary>
        /// Method to add a new receipt and the associated itemsale records.
        /// </summary>
        /// <param name="itemSales">List of item sales to add. SaleID is generated, provided value is ignored.</param>
        /// <returns>The number of rows added. Should equal @ItemSales+1, 0 if failed.</returns>
        public int InsertNewReceipt(List<ItemSaleRecord> itemSales)
        {
            //Create a new receipt.
            string query = "INSERT INTO Receipt VALUES();";
            //Get the id of the reciept just inserted.
            query += "SET @last_id = LAST_INSERT_ID();";
            //Add the relevant itemsales with the matching id of the receipt inserted.
            foreach (ItemSaleRecord i in itemSales)
                query += "INSERT INTO ItemSale (SaleID, StockID, PriceSold, Quantity) VALUES (@last_id, " + i.StockID + ", " + i.PriceSold + ", " + i.Quantity + ");";

            return RunNonQueryCommand(query);
        }
        
        /// <summary>
        /// Overload to insert data into the Receipt table. ID is automatically generated. Returns 0 if failed.
        /// </summary>
        /// <returns>Number of rows added. 1 if successful, 0 otherwise.</returns>
        private int Insert()
        {
            //Calls InsertCommand. Generates the query. The database connection is opened by InsertCommand.
            return InsertCommand(DatabaseTable.Receipt, "VALUES()");
        }
        
        /// <summary>
        /// Overload to insert data into the ItemSale table. Returns 0 if failed.
        /// </summary>
        /// <param name="saleID">SaleID</param>
        /// <param name="stockID">StockID</param>
        /// <param name="priceSold">Price sold as of transaction</param>
        /// <param name="quantity">Quantity sold</param>
        /// <returns>Number of rows added. 1 if successful, 0 otherwise.</returns>
        private int Insert(int saleID, int stockID, double priceSold, int quantity)
        {
            //Calls InsertCommand. Generates the query. The database connection is opened by InsertCommand.
            return InsertCommand(DatabaseTable.ItemSale, "(SaleID, StockID, PriceSold, Quantity) VALUES('" + saleID + "', " + stockID + ", " + priceSold + ", " + quantity + ")");
        }

        /// <summary>
        /// Runs a generic insert query. Table and values must be specified.
        /// </summary>
        /// <param name="table">The table to insert into.</param>
        /// <param name="values">The query in the form "([columns]) VALUES ([values])".</param>
        /// <returns>Number of rows added. 1 if successful, 0 otherwise.</returns>
        private int InsertCommand(DatabaseTable table, string values)
        {
            //Form the query.
            string query = "INSERT INTO " + table + " " + values;

            return RunNonQueryCommand(query);
        }

        /// <summary>
        /// Deletes data from the Stock table based on StockID. Deletes all if stock ID is -1. Returns 0 if failed.
        /// </summary>
        /// <param name="stockID">StockID to delete. Specify -1 to delete all.</param>
        /// <returns>Number of rows added. Number of rows deleted. 0 if failed. As StockID is unique, will only every return one record.</returns>
        public int DeleteStock(int stockID)
        {
            //Calls DeleteCommand. Generates the query. The database connection is opened by DeleteCommand.
            //Delete all stock for -1.
            if (stockID == -1)
                return DeleteCommand(DatabaseTable.Stock);

            //Otherwise run the WHERE condition.
            return DeleteCommand(DatabaseTable.Stock, "StockID="+stockID);
        }

        /// <summary>
        /// Deletes data from the ItemSale table based on SaleID. Deletes all if saleID is -1. Returns 0 if failed.
        /// </summary>
        /// <param name="saleID">SaleID to delete. Specify -1 to delete all.</param>
        /// <returns>Number of rows added. Number of rows deleted. 0 if failed or if the receipt had no items.</returns>
        public int DeleteItemSale(int saleID)
        {
            //Calls DeleteCommand. Generates the query. The database connection is opened by DeleteCommand.
            //Delete all stock for -1.
            if (saleID == -1)
                return DeleteCommand(DatabaseTable.ItemSale);

            //Otherwise run the WHERE condition.
            return DeleteCommand(DatabaseTable.ItemSale, "SaleID=" + saleID);
        }

        /// <summary>
        /// Deletes data from the Receipt table based on SaleID. Deletes all if saleID is -1. Returns 0 if failed.
        /// </summary>
        /// <param name="saleID">SaleID to delete. Specify -1 to delete all.</param>
        /// <returns>Number of rows added. Number of rows deleted. 0 if failed or if the receipt had no items.</returns>
        public int DeleteReceipt(int saleID)
        {
            //Calls DeleteCommand. Generates the query. The database connection is opened by DeleteCommand.
            //Delete all stock for -1.
            if (saleID == -1)
                return DeleteCommand(DatabaseTable.Receipt);

            //Otherwise run the WHERE condition.
            return DeleteCommand(DatabaseTable.Receipt, "SaleID=" + saleID);
        }

        /// <summary>
        /// Runs a generic delete query. Table and condition must be specified.
        /// </summary>
        /// <param name="table">The table to delete from.</param>
        /// <param name="values">The condition in the form "condition".</param>
        /// <returns>Number of rows deleted. 0 if failed.</returns>
        private int DeleteCommand(DatabaseTable table, string condition)
        {
            //Form the query.
            string query = "DELETE FROM " + table + " WHERE " + condition;

            return RunNonQueryCommand(query);
        }

        /// <summary>
        /// Overload to delete all entries in a table.
        /// </summary>
        /// <param name="table">The table to delete from.</param>
        /// <returns>Number of rows deleted. 0 if failed.</returns>
        private int DeleteCommand(DatabaseTable table)
        {
            //Form the query.
            string query = "DELETE FROM " + table;

            return RunNonQueryCommand(query);
        }

        /// <summary>
        /// Updates a single stock item. Record specifies the details.
        /// </summary>
        /// <param name="table">The table to update from.</param>
        /// <param name="record">Stock record. StockID indicates stock to change; Quantity indicates new amount.</param>
        /// <returns>Number of rows updated. 0 if failed.</returns>
        public int Update(DatabaseTable table, StockRecord record)
        {

            int stockID = record.StockID;
            int qty = record.Quantity;

            string query = "UPDATE " + table + " SET StockQty=" + qty + " WHERE StockID=" + stockID;

            return RunNonQueryCommand(query);
        }

        /// <summary>
        /// Updates a single stock item. Record specifies the details.
        /// </summary>
        /// <param name="table">The table to update from.</param>
        /// <param name="record">Stock record. StockID indicates stock to change; Quantity indicates decrement amount.</param>
        /// <returns>Number of rows updated. 0 if failed.</returns>
        public int Decrement(DatabaseTable table, StockRecord record)
        {

            int stockID = record.StockID;
            int qty = record.Quantity;

            string query = "UPDATE " + table + " SET StockQty=StockQty-" + qty + " WHERE StockID=" + stockID + " AND StockQty > " + (qty-1);
            return RunNonQueryCommand(query);
        }

        /// <summary>
        /// Generic run for commands that do not return data. Returns the rows affected.
        /// </summary>
        /// <param name="query">The query to run.</param>
        /// <returns>Number of rows affected. Success or failure depends on command.</returns>
        private int RunNonQueryCommand(string query)
        {
            int rowsAffected = 0;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create command and assign the query and connection from the constructor.
                MySqlCommand cmd = new MySqlCommand(query, connection);
                try
                {
                    //Execute command.
                    rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Query Failed.");
                }

                //Close connection.
                this.CloseConnection();
            }

            //Will return 0 if the database failed to open.
            return rowsAffected;
        }

        /// <summary>
        /// Selects data from a table based on StockID. Selects all if stock ID is -1. Returns 0 if failed.
        /// </summary>
        /// <param name="table">Table to select from.</param>
        /// <param name="stockID">ID to select. Specify -1 to select all.</param>
        /// <returns>List of records selected.</returns>
        public List<Record> Select(DatabaseTable table, int id)
        {
            //Calls SelectCommand. Generates the query. The database connection is opened by SelectCommand.
            //Delete all stock for -1.
            if (id == -1)
                return SelectCommand(table);

            //Otherwise run the WHERE condition.
            switch (table)
            {
                case DatabaseTable.Stock:
                    return SelectCommand(table, "StockID=" + id);
                case DatabaseTable.Receipt:
                    return SelectCommand(table, "SaleID=" + id);
                case DatabaseTable.ItemSale:
                    //Needs a custom query for a JOIN command, so does not use the Select method
                    return RunQueryCommand(table, "SELECT ItemSale.SaleID, ItemSale.StockID, ItemSale.PriceSold, ItemSale.Quantity, Stock.StockName FROM ItemSale INNER JOIN Stock ON ItemSale.StockID=Stock.StockID WHERE ItemSale.SaleID="+id);
            }

            //Fallthrough case, should never reach
            return null;
        }

        private List<Record> SelectCommand(DatabaseTable table, string condition)
        {
            //Form the query.
            string query = "SELECT * FROM " + table + " WHERE " + condition;

            return RunQueryCommand(table, query);
        }

        private List<Record> SelectCommand(DatabaseTable table)
        {
            //Form the query.
            string query = "SELECT * FROM " + table;

            return RunQueryCommand(table, query);
        }

        private List<Record> RunQueryCommand(DatabaseTable type, string query)
        {
            Console.WriteLine("Query: " + query);

            //Record for converted lists.
            List<string>[] list = null;
            List<Record> records = null;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                switch (type)
                {
                    case DatabaseTable.Stock:
                        //Create a list to store the result
                        list = new List<string>[5];

                        list[0] = new List<string>();
                        list[1] = new List<string>();
                        list[2] = new List<string>();
                        list[3] = new List<string>();
                        list[4] = new List<string>();

                        //Read the data and store them in the list
                        while (dataReader.Read())
                        {
                            list[0].Add(dataReader["StockID"] + "");
                            list[1].Add(dataReader["StockName"] + "");
                            list[2].Add(dataReader["PurchaseCost"] + "");
                            list[3].Add(dataReader["SellPrice"] + "");
                            list[4].Add(dataReader["StockQty"] + "");
                        }

                        break;

                    case DatabaseTable.Receipt:
                        //Create a list to store the result
                        list = new List<string>[2];

                        list[0] = new List<string>();
                        list[1] = new List<string>();

                        //Read the data and store them in the list
                        while (dataReader.Read())
                        {
                            list[0].Add(dataReader["SaleID"] + "");
                            list[1].Add(dataReader["Date"] + "");
                        }

                        break;

                    case DatabaseTable.ItemSale:
                        //Create a list to store the result
                        list = new List<string>[5];

                        list[0] = new List<string>();
                        list[1] = new List<string>();
                        list[2] = new List<string>();
                        list[3] = new List<string>();
                        list[4] = new List<string>();

                        //Read the data and store them in the list
                        while (dataReader.Read())
                        {
                            list[0].Add(dataReader["SaleID"] + "");
                            list[1].Add(dataReader["StockID"] + "");
                            list[2].Add(dataReader["PriceSold"] + "");
                            list[3].Add(dataReader["Quantity"] + "");
                            list[4].Add(dataReader["StockName"] + "");
                        }

                        break;
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //Convert to proper records
                records = RecordParser.ConvertToRecord(type, list);

                Console.WriteLine("Fetching...");

                for (int i = 0; i < records.Count; i++)
                {
                    Console.WriteLine(i + ": " + records[i].ToString());
                }
            }

            //return list to be displayed
            return records;
        }

        /// <summary>
        /// Predicts the next month of sales by getting the total sales and the date of the first
        /// sale. This calculates the average sales per day, which is used to estimate the sales over
        /// the next 30 days.
        /// </summary>
        /// <param name="ItemIDs">List of item ids to check.</param>
        /// <returns>The estimates list of sales. Returns empty list if failed.</returns>
        public List<double> PredictSales(List<int> ItemIDs)
        {
            List<double> returnDict = new List<double>();

            foreach (int i in ItemIDs)
            {
                double salesPerDay = 0;
                int totalSales = 0;
                int daysSinceFirstSale = 0;
                
                totalSales = GetTotalSales(i);
                daysSinceFirstSale = GetDaysSinceFirstSale(i);

                if (totalSales == -1)
                {
                    Console.WriteLine("Could not predict sales. Could not get total sales.");
                    break;
                }

                //Calculate average sales per day
                salesPerDay = (double)totalSales / (double)daysSinceFirstSale;

                //Predict next month of sales by salesPerDay * 30.
                returnDict.Add(salesPerDay * 30);

                Console.WriteLine("Predicting {0} as {1}", i, salesPerDay * 30);
            }

            return returnDict;
        }

        /// <summary>
        /// Predicts the next month of sales by getting the total sales and the date of the first
        /// sale. This calculates the average sales per day, which is used to estimate the sales over
        /// the next 30 days.
        /// </summary>
        /// <param name="ItemIDs">List of item ids to check.</param>
        /// <returns>The estimates list of sales. Returns empty list if failed.</returns>
        public List<double> PredictProfits(List<int> ItemIDs)
        {
            List<double> returnDict = new List<double>();

            foreach (int i in ItemIDs)
            {
                double salesPerDay = 0;
                double priceSum = 0;
                int daysSinceFirstSale = 0;

                priceSum = GetTotalSalePrice(i);
                daysSinceFirstSale = GetDaysSinceFirstSale(i);

                if (priceSum == -1)
                {
                    Console.WriteLine("Could not predict profits. Could not get price sum.");
                    break;
                }

                //Calculate average sales per day
                salesPerDay = (double)priceSum / (double)daysSinceFirstSale;

                //Predict next month of sales by salesPerDay * 30.
                returnDict.Add(salesPerDay * 30);

                Console.WriteLine("Predicting {0} as {1}", i, salesPerDay * 30);
            }

            return returnDict;
        }

        /// <summary>
        /// Gets the total sales for the item provided. Gets from the ItemSale table.
        /// </summary>
        /// <param name="ItemID">Item to check.</param>
        /// <returns>The total number of recorded quantity sold. Returns -1 if failed.</returns>
        private int GetTotalSales(int ItemID)
        {
            //Requests a list of Receipt Records that includes the specified stock item. Sorted by oldest to newest.
            List<Record> returnQuery = RunQueryCommand(DatabaseTable.ItemSale, "SELECT ItemSale.SaleID, ItemSale.StockID, ItemSale.PriceSold, SUM(ItemSale.Quantity) AS Quantity, Stock.StockName FROM ItemSale INNER JOIN Stock ON ItemSale.StockID=Stock.StockID WHERE ItemSale.StockID=" + ItemID);

            if (returnQuery.Count != 0)
            {
                Console.WriteLine("Total sales of {0} is {1}", ItemID, ((ItemSaleRecord)returnQuery[0]).Quantity);

                //Returns total sales of the item.
                return ((ItemSaleRecord)returnQuery[0]).Quantity;
            }

            Console.WriteLine("Could not get sales data.");
            return -1;
        }

        /// <summary>
        /// Gets the total selling price for the item provided. Gets from the ItemSale table.
        /// </summary>
        /// <param name="ItemID">Item to check.</param>
        /// <returns>The sum of sale prices. Returns -1 if failed.</returns>
        private double GetTotalSalePrice(int ItemID)
        {
            //Requests a list of Receipt Records that includes the specified stock item. Sorted by oldest to newest.
            List<Record> returnQuery = RunQueryCommand(DatabaseTable.ItemSale, "SELECT ItemSale.SaleID, ItemSale.StockID, SUM(ItemSale.PriceSold) AS PriceSold, ItemSale.Quantity, Stock.StockName FROM ItemSale INNER JOIN Stock ON ItemSale.StockID=Stock.StockID WHERE ItemSale.StockID=" + ItemID);

            if (returnQuery.Count != 0)
            {
                Console.WriteLine("Total sales of {0} is {1}", ItemID, ((ItemSaleRecord)returnQuery[0]).Quantity);

                //Returns total sales of the item.
                return ((ItemSaleRecord)returnQuery[0]).PriceSold;
            }

            Console.WriteLine("Could not get sale price data.");
            return -1;
        }

        /// <summary>
        /// Gets the date of the first recorded item sale and subtracts it from now to
        /// determine the total days since first sale.
        /// </summary>
        /// <param name="ItemID">The ID to check</param>
        /// <returns>Days since first sale.</returns>
        private int GetDaysSinceFirstSale(int ItemID)
        {
            //Use Timespan to calculate the days since first sale.
            TimeSpan span = DateTime.Now.Subtract(GetFirstSale(ItemID));

            Console.WriteLine("{0} sold between {1}", ItemID, span.Days);

            return span.Days;
        }

        /// <summary>
        /// Gets the DateTime of the first sale recorded.
        /// </summary>
        /// <param name="ItemID">Item to check</param>
        /// <returns>The first date recorded, returns 0 if failed.</returns>
        private DateTime GetFirstSale(int ItemID)
        {
            //Requests a list of Receipt Records that includes the specified stock item. Sorted by oldest to newest.
            List<Record> returnQuery = RunQueryCommand(DatabaseTable.Receipt, "SELECT ItemSale.SaleID, Receipt.Date, ItemSale.StockID FROM ItemSale INNER JOIN Receipt ON ItemSale.SaleID = Receipt.SaleID WHERE ItemSale.StockID = " + ItemID + " ORDER BY Receipt.Date ASC");

            if (returnQuery.Count != 0)
            {
                Console.WriteLine("First {0} sold on {1}", ItemID, ((ReceiptRecord)returnQuery[0]).Date);

                //Returns the date of the first record in the list.
                return ((ReceiptRecord)returnQuery[0]).Date;
            }

            Console.WriteLine("Could not get Date/Time data.");
            return new DateTime(0);
        }
        
        /// <summary>
        /// Count statement. Currently unused.
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

    }
}
