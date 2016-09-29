using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2PHPClient
{
    [ProtoContract]
    public interface Record
    {

    }

    /// <summary>
    /// Struct to return the contents of a stock record from the database.
    /// ProtoContract is from NetworkCommsDotNet, allows the class to be serialized and sent over the
    /// connection.
    /// </summary>
    [ProtoContract]
    public struct StockRecord : Record
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
    /// Struct to return the contents of a receipt record from the database.
    /// ProtoContract is from NetworkCommsDotNet, allows the class to be serialized and sent over the
    /// connection.
    /// </summary>
    [ProtoContract]
    public struct ReceiptRecord : Record
    {
        [ProtoMember(1)]
        public int SaleID { get; set; }

        [ProtoMember(2)]
        public DateTime Date { get; set; }

        public ReceiptRecord(int saleID, DateTime date)
        {
            SaleID = saleID;
            Date = date;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("SaleID: {0}; Date: {1}", SaleID, Date));
            return sb.ToString();
        }

    }

    /// <summary>
    /// Struct to return the contents of a receipt record and associated ItemSales records from the database.
    /// ProtoContract is from NetworkCommsDotNet, allows the class to be serialized and sent over the
    /// connection.
    /// </summary>
    [ProtoContract]
    struct FullReceiptRecord : Record
    {
        [ProtoMember(1)]
        public int SaleID { get; set; }

        [ProtoMember(2)]
        public DateTime Date { get; set; }

        [ProtoMember(2)]
        public List<ItemSaleRecord> Items { get; set; }

        public FullReceiptRecord(int saleID, DateTime date, List<ItemSaleRecord> items)
        {
            SaleID = saleID;
            Date = date;
            Items = items;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("SaleID: {0}; Date: {1}", SaleID, Date));

            int i = 0;
            foreach (ItemSaleRecord r in Items)
            {
                sb.Append(string.Format("; #{0}: {1}, {2}, {3}, {4}", i, r.Name, r.StockID, r.PriceSold, r.Quantity));
                i++;
            }
            return sb.ToString();
        }

    }

    /// <summary>
    /// Struct to return the contents of a receipt record from the database.
    /// ProtoContract is from NetworkCommsDotNet, allows the class to be serialized and sent over the
    /// connection.
    /// </summary>
    [ProtoContract]
    public struct ItemSaleRecord : Record
    {
        [ProtoMember(1)]
        public int SaleID { get; set; }

        [ProtoMember(2)]
        public int StockID { get; set; }

        [ProtoMember(3)]
        public double PriceSold { get; set; }

        [ProtoMember(4)]
        public int Quantity { get; set; }

        [ProtoMember(5)]
        public string Name { get; set; }

        public ItemSaleRecord(int saleID, int stockID, double priceSold, int quantity, string name)
        {
            SaleID = saleID;
            StockID = stockID;
            PriceSold = priceSold;
            Quantity = quantity;
            Name = name;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("SaleID: {0}; StockID: {1}; Price Sold: {2}; Quantity: {3}; Name: {4}", SaleID, StockID, PriceSold, Quantity, Name));
            return sb.ToString();
        }
    }

    public class RecordHandler
    {
    }
}
