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
    public partial class InventoryQuantityDel : Form
    {
        ClientConnectionManager _connection;
        List<StockRecord> _items;

        public InventoryQuantityDel(ClientConnectionManager connection, List<StockRecord> items, int selected)
        {
            InitializeComponent();
            _connection = connection;
            _items = items;

            cmb_name.Enabled = false;

            foreach (StockRecord s in _items)
                cmb_name.Items.Add(s.StockName);
            
            if ((selected >= 0) && (selected < _items.Count))
                cmb_name.SelectedItem = selected;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            _connection.DecrementStock(new StockRecord(_items[cmb_name.SelectedIndex].StockID, cmb_name.Text, 0, 0, int.Parse(txt_qty.Text)));
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
