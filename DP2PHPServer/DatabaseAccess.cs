using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

//Heavily based on http://www.codeproject.com/Articles/43438/Connect-C-to-MySQL
namespace DP2PHPServer
{
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

        public DatabaseAccess()
        {
            Initialise();
        }

        public void Initialise()
        {
            //server = "fdb13.biz.nf";
            //database = "2195923_dp2";
            //uid = "2195923_dp2";
            //password = "swinburnedp2";

            server = "db4free.net";
            database = "dp2db";
            uid = "dp2user";
            password = "dp2000";

            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
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

        //Close connection
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

        //Insert statement
        public int Insert(string stockName, double purchase, double sell, int qty)
        {
            return InsertCommand(DatabaseTable.Stock, " (StockName, PurchaseCost, SellPrice, StockQty) VALUES('"+stockName+"', "+purchase+", "+sell+", "+qty+")");
        }
            

        private int InsertCommand(DatabaseTable table, string values)
        {
            string query = "INSERT INTO " + table + values;
            int rowsAffected = 0;

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                rowsAffected = cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }

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

        //Delete statement
        public void Delete()
        {
            string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
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
