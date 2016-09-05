using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace DP2PHPServer
{
    /// <summary>
    /// Struct to return the contents of a stock record from the database.
    /// ProtoContract is from NetworkCommsDotNet, allows the class to be serialized and sent over the
    /// connection.
    /// </summary>
    [ProtoContract]
    struct StockRecord
    {
        [ProtoMember(1)]
        public int StockID { get; set; }

        [ProtoMember(2)]
        public string StockName { get; set; }

        [ProtoMember(3)]
        public double Purchase { get; set; }

        [ProtoMember(4)]
        public double CurrentSell { get; set; }

        [ProtoMember(5)]
        public int Quantity { get; set; }

        public StockRecord(int stockId, string stockName, double purchase, double currentSell, int quantity)
        {
            StockID = stockId;
            StockName = stockName;
            Purchase = purchase;
            CurrentSell = currentSell;
            Quantity = quantity;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("StockID: {0}; Stock Name: {1}; Purchase: {2}; Sell: {3}; Qty: {4}", StockID, StockName, Purchase, CurrentSell, Quantity));
            return sb.ToString();
        }

    }

    /// <summary>
    /// Handles all communication with the database. Currently send dummy messages back in liu
    /// of a database implementation.
    /// </summary>
    class DataWrapper
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
