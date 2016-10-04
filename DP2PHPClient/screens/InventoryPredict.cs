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
    public partial class InventoryPredict : Form
    {
        ClientConnectionManager _connection;
        List<StockRecord> _items;

        public InventoryPredict(ClientConnectionManager connection, List<StockRecord> items)
        {
            InitializeComponent();
            _connection = connection;
            _items = items;

            foreach (StockRecord s in _items)
                cmb_name.Items.Add(s.StockName);
        }
        
        public InventoryPredict(ClientConnectionManager connection, List<StockRecord> items, int selected)
        {
            InitializeComponent();
            _connection = connection;
            _items = items;

            List<int> IDs = new List<int>();

            foreach (StockRecord s in _items)
                cmb_name.Items.Add(s.StockName);

            if ((selected >= 0) && (selected < _items.Count))
                cmb_name.SelectedIndex = selected;

            cmb_name.Enabled = false;

            IDs.Add(_items[selected].StockID);

            txt_sales.Text = PredictSales(IDs).ToString();
            txt_profits.Text = PredictProfit(IDs).ToString();
        }

        private double PredictSales(List<int> IDs)
        {
            return _connection.PredictNextMonthSales(IDs);
        }

        private double PredictProfit(List<int> IDs)
        {
            return _connection.PredictNextMonthProfit(IDs);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
