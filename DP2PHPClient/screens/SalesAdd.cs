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
    public partial class SalesAdd : Form
    {
        ClientConnectionManager _connection;
        List<StockRecord> _items = new List<StockRecord>();
        List<ItemSaleRecord> _saleItems = new List<ItemSaleRecord>();

        public SalesAdd(ClientConnectionManager connection, List<StockRecord> items)
        {
            InitializeComponent();

            _connection = connection;
            _items = items;

            //Dummy string array to hold rows of records
            string[] row = null;

            //First clear the grid
            dg_data.Rows.Clear();

            foreach (StockRecord s in _items)
                cmb_name.Items.Add(s.StockName);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //Add to item list
            StockRecord selected = _items[cmb_name.SelectedIndex];
            _saleItems.Add(new ItemSaleRecord(0, selected.StockID, selected.CurrentSell, int.Parse(txt_quantity.Text), selected.StockName));

            //Add to table
            string[] row = new string[] { (_saleItems.Count + 1).ToString(), selected.StockID.ToString(), selected.StockName, txt_quantity.Text, selected.CurrentSell.ToString(), "Remove" };
            dg_data.Rows.Add(row);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            _connection.InsertReceipt(_saleItems);
            this.Close();
        }

        private void dg_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    case 5: //Remove
                        _saleItems.Remove(_saleItems[e.RowIndex]);

                        //Update the grid
                        dg_data.Rows.Clear();
                        int j = 0;
                        foreach (ItemSaleRecord i in _saleItems)
                        {
                            string[] row = new string[] { (++j).ToString(), i.StockID.ToString(), i.Name, txt_quantity.ToString(), i.PriceSold.ToString(), "Remove" };
                            dg_data.Rows.Add(row);
                        }
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
