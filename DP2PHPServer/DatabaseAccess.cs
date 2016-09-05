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
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Opens the connection to the database. Returns true if successful. Prints an error message otherwise.
        /// </summary>
        /// <returns>The success.</returns>
        public bool OpenConnection()
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
        public bool CloseConnection()
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
        public int Delete(int stockID)
        {
            //Calls DeleteCommand. Generates the query. The database connection is opened by DeleteCommand.
            //Delete all stock for -1.
            if (stockID == -1)
                return DeleteCommand(DatabaseTable.Stock);

            //Otherwise run the WHERE condition.
            return DeleteCommand(DatabaseTable.Stock, "StockID="+stockID);
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

                //Execute command.
                rowsAffected = cmd.ExecuteNonQuery();

                //Close connection.
                this.CloseConnection();
            }

            //Will return 0 if the database failed to open.
            return rowsAffected;
        }

        //Update statement
        public void Update()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Select statement
        public List<string>[] Select()
        {
            Console.WriteLine("Getting from db...");

            //string query = "SELECT * FROM " + DatabaseTable.Stock;
            string query = "SELECT * FROM Stock";

            //Create a list to store the result
            List<string>[] list = new List<string>[5];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["StockID"] + "");
                    list[1].Add(dataReader["StockName"] + "");
                    list[2].Add(dataReader["PurchaseCost"] + "");
                    list[3].Add(dataReader["SellPrice"] + "");
                    list[4].Add(dataReader["StockQty"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                Console.WriteLine("Fetching...");

                for (int i = 0; i < list[0].Count; i++)
                {
                    Console.WriteLine(i + ": ID - " + list[0][i] + ", Name - " + list[1][i] + ", Purchase - " + list[2][i] + ", Sell - " + list[3][i] + ", Qty - " + list[4][i]);
                }

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Count statement
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
