using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2PHPServer
{
    /// <summary>
    /// Struct to return the contents of a stock record from the database.
    /// </summary>
    struct StockRecord
    {
        public StockRecord(int stockId, string stockName, float purchase, float currentSell, int quantity)
        {
            StockID = stockId;
            StockName = stockName;
            Purchase = purchase;
            CurrentSell = currentSell;
            Quantity = quantity;
        }

        public int StockID;
        public string StockName;
        public float Purchase;
        public float CurrentSell;
        public int Quantity;
    }

    /// <summary>
    /// Handles all communication with the database. Currently send dummy messages back in liu
    /// of a database implementation.
    /// </summary>
    class Database
    {
        /// <summary>
        /// Returns a dummy record for basic testing.
        /// </summary>
        /// <param name="stockID"></param>
        /// <returns>A dummy stock record.</returns>
        public static StockRecord GetStockRecord(int stockID)
        {
            StockRecord record = new StockRecord(0, "Dummy", 10, 15, 20);

            return record;
        }
    }
}
