using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP2PHPClient.screens
{
    public partial class SalesView : Form
    {
        ClientConnectionManager _connection;
        List<ItemSaleRecord> _items = new List<ItemSaleRecord>();
        DateTime _date;

        public SalesView(ClientConnectionManager connection, int selected, DateTime date)
        {
            InitializeComponent();

            _connection = connection;
            _date = date;

            //Get the list of itemsales associated with the receipt
            List<Record> temp = _connection.RequestReceiptInfo(selected);
            //Since it is received as a generic "Records" list, must be converted to "Receipts" list.
            _items.Clear();
            if (temp != null)
            {
                foreach (Record r in temp)
                    _items.Add((ItemSaleRecord)r);
            }

            //Dummy string array to hold rows of records
            string[] row = null;

            //First clear the grid
            dg_data.Rows.Clear();

            //Insert each entry from the database into the grid.
            int i = 0;
            foreach (ItemSaleRecord r in _items)
            {
                row = new string[] { (++i).ToString(), r.StockID.ToString(), r.Name.ToString(), r.Quantity.ToString(), r.PriceSold.ToString() };
                dg_data.Rows.Add(row);
            }

        }

    }
}
