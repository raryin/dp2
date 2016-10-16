using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace DP2PHPServer
{
    [ProtoContract]
    interface Record
    {

    }

    /// <summary>
    /// Struct to return the contents of a stock record from the database.
    /// ProtoContract is from NetworkCommsDotNet, allows the class to be serialized and sent over the
    /// connection.
    /// </summary>
    [ProtoContract]
    struct StockRecord : Record
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

        public StockRecord(int stockId, double purchase, double currentSell, int quantity)
        {
            StockID = stockId;
            StockName = "";
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
    struct ReceiptRecord : Record
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
    struct ItemSaleRecord : Record
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

        public ItemSaleRecord(int saleID, int stockID, double priceSold, int quantity)
        {
            SaleID = saleID;
            StockID = stockID;
            PriceSold = priceSold;
            Quantity = quantity;
            Name = "";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("SaleID: {0}; StockID: {1}; Price Sold: {2}; Quantity: {3}; Name: {4}", SaleID, StockID, PriceSold, Quantity, Name));
            return sb.ToString();
        }

    }

    /// <summary>
    /// Handles all communication with the database. Currently send dummy messages back in liu
    /// of a database implementation.
    /// </summary>
    class RecordParser
    {
        /// <summary>
        /// Converts from the format returned from the database into the Records format.
        /// </summary>
        /// <param name="type">Type to change to.</param>
        /// <param name="data">Database data.</param>
        /// <returns>The converted data as a generic Record.</returns>
        public static List<Record> ConvertToRecord(DatabaseTable type, List<string>[] data)
        {
            List<Record> records = new List<Record>();

            if (data.Length != 0)
            {
                try
                {
                    switch (type)
                    {
                        case DatabaseTable.Stock:
                            for (int i = 0; i < data[0].Count; i++)
                            {
                                records.Add(new StockRecord(int.Parse(data[0][i]), data[1][i], double.Parse(data[2][i]), double.Parse(data[3][i]), int.Parse(data[4][i])));
                            }

                            break;

                        case DatabaseTable.Receipt:
                            for (int i = 0; i < data[0].Count; i++)
                            {
                                records.Add(new ReceiptRecord(int.Parse(data[0][i]), DateTime.Parse(data[1][i])));
                            }

                            break;

                        case DatabaseTable.ItemSale:
                            for (int i = 0; i < data[0].Count; i++)
                            {
                                records.Add(new ItemSaleRecord(int.Parse(data[0][i]), int.Parse(data[1][i]), double.Parse(data[2][i]), int.Parse(data[3][i]), data[4][i]));
                            }

                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Could not read database data. Did the query return NULL values?");
                }

        }

            return records;
        }
    }

}
