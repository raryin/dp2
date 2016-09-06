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
    /// A struct to be a list of StockRecords. Needed as lists cannot be sent directly over the client-server connection.
    /// </summary>
    [ProtoContract]
    struct StockRecordList
    {
        [ProtoMember(1)]
        List<StockRecord> _records;

        public StockRecordList(List<StockRecord> records)
        {
            _records = records;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (StockRecord s in _records)
                sb.AppendLine(string.Format("StockID: {0}; Stock Name: {1}; Purchase: {2}; Sell: {3}; Qty: {4}\n", s.StockID, s.StockName, s.Purchase, s.CurrentSell, s.Quantity));
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

        public static List<StockRecord> ConvertToRecord(List<string>[] data)
        {
            List<StockRecord> records = new List<StockRecord>();

            for (int i = 0; i < data[0].Count; i++)
            {
                records.Add(new StockRecord(int.Parse(data[0][i]), data[1][i], double.Parse(data[2][i]), double.Parse(data[3][i]), int.Parse(data[4][i])));
            }

            return records;
        }
    }

}
