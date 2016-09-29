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
    public partial class Inventory : Form
    {
        ClientConnectionManager _connection;

        List<StockRecord> records = null;

        public Inventory(ClientConnectionManager connection)
        {
            InitializeComponent();

            _connection = connection;

            UpdateList();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dg_data_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    case 5: //Add Quantity
                        new screens.InventoryEdit(_connection, records, e.RowIndex).Show();
                        break;
                    case 6: //Delete Quantity
                        new screens.InventoryQuantityDel(_connection, records, e.RowIndex).Show();
                        break;
                    default:
                        break;
                }
            }

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void UpdateList()
        {
            //Request full stock list
            records = _connection.RequestStockInfo(-1);

            //Dummy string array to hold rows of records
            string[] row = null;

            //First clear the grid
            dg_data.Rows.Clear();

            //Insert each entry from the database into the grid.
            foreach (StockRecord s in records)
            {
                row = new string[] { s.StockID.ToString(), s.StockName, s.Purchase.ToString(), s.CurrentSell.ToString(), s.Quantity.ToString(), "Add", "Delete" };
                dg_data.Rows.Add(row);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            new screens.InventoryNew(_connection).Show();
        }

        private void tb_inventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            new screens.Inventory(_connection).Show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            new screens.InventoryEdit(_connection, records).Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            new screens.InventoryDelete(_connection, records).Show();
        }

        private void tb_sales_Click(object sender, EventArgs e)
        {
            this.Hide();
            new screens.Sales(_connection).Show();
        }
    }
}
