using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2PHPClient
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

    class RecordHandler
    {
    }
}
