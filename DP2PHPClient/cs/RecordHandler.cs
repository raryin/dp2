﻿using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2PHPClient
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

    class RecordHandler
    {
    }
}
