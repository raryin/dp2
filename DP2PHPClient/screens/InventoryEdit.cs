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
    public partial class InventoryEdit : Form
    {
        ClientConnectionManager _connection;
        List<StockRecord> _items;

        public InventoryEdit(ClientConnectionManager connection, List<StockRecord> items)
        {
            InitializeComponent();
            _connection = connection;
            _items = items;

            foreach (StockRecord s in _items)
                cmb_name.Items.Add(s.StockName);
        }

        public InventoryEdit(ClientConnectionManager connection, List<StockRecord> items, int selected)
        {
            InitializeComponent();
            _connection = connection;
            _items = items;

            cmb_name.Enabled = false;

            foreach (StockRecord s in _items)
                cmb_name.Items.Add(s.StockName);

            if ((selected >= 0) && (selected < _items.Count))
                cmb_name.SelectedIndex = selected;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item: " + cmb_name.SelectedItem + ", Text: " + cmb_name.SelectedText + ", Value: " + cmb_name.SelectedValue);
            _connection.UpdateStock(new StockRecord(_items[cmb_name.SelectedIndex].StockID, cmb_name.Text, 0, 0, int.Parse(txt_qty.Text)));
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
