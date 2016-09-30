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
    public partial class Sales : Form
    {
        ClientConnectionManager _connection;

        List<ReceiptRecord> records = new List<ReceiptRecord>();

        public Sales(ClientConnectionManager connection)
        {
            InitializeComponent();

            _connection = connection;

            UpdateList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UpdateList()
        {
            //Request full receipt list
            List<Record> temp = _connection.RequestReceiptInfo();
            //Since it is received as a generic "Records" list, must be converted to "Receipts" list.
            records.Clear();
            if (temp != null)
            {
                foreach (Record r in temp)
                    records.Add((ReceiptRecord)r);
            }

            //Dummy string array to hold rows of records
            string[] row = null;

            //First clear the grid
            dg_data.Rows.Clear();

            //Insert each entry from the database into the grid.
            foreach (ReceiptRecord r in records)
            {
                row = new string[] { r.SaleID.ToString(), r.Date.ToString(), "View", "Edit", "Delete" };
                dg_data.Rows.Add(row);
            }
        }

        private void dg_data_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    case 2: //View
                        //Pass the ID to view and the date of the sale.
                        //The date is passed so the database doesn't need to retrieve it again.
                        new screens.SalesView(_connection, records[e.RowIndex].SaleID, records[e.RowIndex].Date).Show();
                        break;
                    case 3: //Edit
                    case 4: //Delete
                        _connection.DeleteReceipt(records[e.RowIndex].SaleID);
                        break;
                    default:
                        break;
                }
            }

        }

        private void tb_inventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            new screens.Inventory(_connection).Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void btn_debug_Click(object sender, EventArgs e)
        {

        }
    }
}
