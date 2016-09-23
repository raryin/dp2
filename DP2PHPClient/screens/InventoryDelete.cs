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
    public partial class InventoryDelete : Form
    {
        ClientConnectionManager _connection;
        List<StockRecord> _items;

        public InventoryDelete(ClientConnectionManager connection, List<StockRecord> items)
        {
            InitializeComponent();
            _connection = connection;
            _items = items;

            foreach (StockRecord s in _items)
                cmb_name.Items.Add(s.StockName);
        }
        
        public InventoryDelete(ClientConnectionManager connection, List<StockRecord> items, int selected)
        {
            InitializeComponent();
            _connection = connection;
            _items = items;

            foreach (StockRecord s in _items)
                cmb_name.Items.Add(s.StockName);

            if ((selected >= 0) && (selected < _items.Count))
                cmb_name.SelectedItem = selected;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            _connection.DeleteStock(_items[cmb_name.SelectedIndex].StockID);
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
