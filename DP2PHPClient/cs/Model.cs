using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP2PHPClient
{

    public class Model
    {
        private List<StockRecord> _stockRecords = new List<StockRecord>();
        private List<ReceiptRecord> _receiptRecords = new List<ReceiptRecord>();
        private List<ItemSaleRecord> _itemSaleRecords = new List<ItemSaleRecord>();
        private List<ItemSaleRecord> _temp = new List<ItemSaleRecord>();
        private Form _currentScreen;
        private ClientConnectionManager _connection;
        private int _threshold = 10;

        public List<StockRecord> StockRecords
        {
            get
            {
                return _stockRecords;
            }

            set
            {
                _stockRecords = value;
            }
        }

        public List<ReceiptRecord> ReceiptRecords
        {
            get
            {
                return _receiptRecords;
            }

            set
            {
                _receiptRecords = value;
            }
        }

        public List<ItemSaleRecord> ItemSaleRecords
        {
            get
            {
                return _itemSaleRecords;
            }

            set
            {
                _itemSaleRecords = value;
            }
        }

        public Model()
        {
            Application.Run(_currentScreen = new screens.LandingPage(this));
        }

        public bool ClearRecords()
        {
            _stockRecords.Clear();
            _receiptRecords.Clear();
            _itemSaleRecords.Clear();

            return true;
        }

        public bool UpdateScreen(Form screen)
        {
            _currentScreen.Hide();
            screen.Show();
            _currentScreen = screen;

            return true;
        }

        public bool OpenScreen(Form screen)
        {
            screen.Show();

            return true;
        }

        public void ConnectToServer()
        {
            _connection = new ClientConnectionManager("127.0.0.1", 25565);

            _connection.ConnectToServer();

            if (_connection != null)
            {
                //Refresh records when first connecting to the server.
                UpdateStoredStock();
                UpdateStoredReceipts();
            }
        }

        public bool UpdateStoredStock()
        {
            _stockRecords = _connection.RequestStockInfo(-1);

            return true;
        }

        public bool UpdateStoredReceipts()
        {
            //Request full receipt list
            List<Record> temp = _connection.RequestReceiptInfo();
            //Since it is received as a generic "Records" list, must be converted to "Receipts" list.
            _receiptRecords.Clear();
            if (temp != null)
            {
                foreach (Record r in temp)
                    _receiptRecords.Add((ReceiptRecord)r);
            }

            return true;
        }

        public void RefreshReceiptList(DataGridView dg_data)
        {
            //Dummy string array to hold rows of records
            string[] row = null;

            //First clear the grid
            dg_data.Rows.Clear();

            //Insert each entry from the database into the grid.
            foreach (ReceiptRecord r in _receiptRecords)
            {
                row = new string[] { r.SaleID.ToString(), r.Date.ToString(), "View", "Edit", "Delete" };
                dg_data.Rows.Add(row);
            }
        }

        public void RefreshStockList(DataGridView dg_data)
        {
            //Dummy string array to hold rows of records
            string[] row = null;

            //First clear the grid
            dg_data.Rows.Clear();

            //Insert each entry from the database into the grid.
            foreach (StockRecord s in _stockRecords)
            {
                row = new string[] { s.StockID.ToString(), s.StockName, s.Purchase.ToString(), s.CurrentSell.ToString(), s.Quantity.ToString(), "Add", "Delete", "Predict" };
                dg_data.Rows.Add(row);
            }

            foreach (DataGridViewRow r in dg_data.Rows)
                if (Convert.ToInt32(r.Cells[4].Value) < _threshold)
                    r.DefaultCellStyle.BackColor = Color.Red;
        }

        public bool GetFullReceipt(int selected, DataGridView dg_data)
        {
            //Get the list of itemsales associated with the receipt
            List<Record> temp = _connection.RequestReceiptInfo(_receiptRecords[selected].SaleID);
            //Since it is received as a generic "Records" list, must be converted to "Receipts" list.
            _itemSaleRecords.Clear();
            if (temp != null)
            {
                foreach (Record r in temp)
                    _itemSaleRecords.Add((ItemSaleRecord)r);
            }

            //Dummy string array to hold rows of records
            string[] row = null;

            //First clear the grid
            dg_data.Rows.Clear();

            //Insert each entry from the database into the grid.
            int i = 0;
            foreach (ItemSaleRecord r in _itemSaleRecords)
            {
                row = new string[] { (++i).ToString(), r.StockID.ToString(), r.Name.ToString(), r.Quantity.ToString(), r.PriceSold.ToString() };
                dg_data.Rows.Add(row);
            }

            return true;
        }

        public bool DeleteReceipt(int index)
        {
            return _connection.DeleteReceipt(_receiptRecords[index].SaleID);
        }

        public bool PopulateComboBox(ComboBox cmb_name)
        {
            _temp.Clear();

            foreach (StockRecord s in _stockRecords)
                cmb_name.Items.Add(s.StockName);

            return true;
        }

        public bool AddItemSale(DataGridView dg_data, int index, int qty)
        {
            //Add to item list
            StockRecord selected = _stockRecords[index];
            _temp.Add(new ItemSaleRecord(0, selected.StockID, selected.CurrentSell, qty, selected.StockName));

            //Add to table
            string[] row = new string[] { (_temp.Count + 1).ToString(), selected.StockID.ToString(), selected.StockName, qty.ToString(), selected.CurrentSell.ToString(), "Remove" };
            dg_data.Rows.Add(row);

            return true;
        }

        public bool RemoveItemSale(DataGridView dg_data, int index)
        {
            _temp.Remove(_temp[index]);

            //Update the grid
            dg_data.Rows.Clear();
            int j = 0;
            foreach (ItemSaleRecord i in _temp)
            {
                string[] row = new string[] { (++j).ToString(), i.StockID.ToString(), i.Name, i.Quantity.ToString(), i.PriceSold.ToString(), "Remove" };
                dg_data.Rows.Add(row);
            }

            return true;
        }

        public bool InsertReceipt()
        {
            _connection.InsertReceipt(_temp);
            return true;
        }

        public bool InsertStock(string name, double cost, double sell, int qty)
        {
            return _connection.InsertStock(name, cost, sell, qty);
        }

        public bool DeleteStock(int index)
        {
            return _connection.DeleteStock(_stockRecords[index].StockID);
        }

        public bool DecrementStock(int index, int qty)
        {
            return _connection.DecrementStock(new StockRecord(_stockRecords[index].StockID, _stockRecords[index].StockName, 0, 0, qty));
        }

        public double PredictSales(int index)
        {
            List<int> temp = new List<int>();

            temp.Add(_stockRecords[index].StockID);

            return PredictSales(temp);
        }

        public double PredictProfit(int index)
        {
            List<int> temp = new List<int>();

            temp.Add(_stockRecords[index].StockID);

            return PredictProfit(temp);
        }

        public double PredictSales(List<int> IDs)
        {
            return _connection.PredictNextMonthSales(IDs);
        }

        public double PredictProfit(List<int> IDs)
        {
            return _connection.PredictNextMonthProfit(IDs);
        }

        public bool RefreshStockList(int index, int qty)
        {
            _connection.UpdateStock(new StockRecord(_stockRecords[index].StockID, _stockRecords[index].StockName, 0, 0, qty));

            return true;
        }

    }
}
