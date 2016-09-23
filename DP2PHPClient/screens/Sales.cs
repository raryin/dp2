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

        public Sales(ClientConnectionManager connection)
        {
            InitializeComponent();

            _connection = connection;

            string[] row = new string[] { "1", "1/1/2016", "View", "Edit", "Delete" };
            dg_data.Rows.Add(row);
            row = new string[] { "2", "1/1/2016", "View", "Edit", "Delete" };
            dg_data.Rows.Add(row);
            row = new string[] { "3", "1/1/2016", "View", "Edit", "Delete" };
            dg_data.Rows.Add(row);
            row = new string[] { "4", "1/1/2016", "View", "Edit", "Delete" };
            dg_data.Rows.Add(row);
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
                    case 2:
                        new screens.SalesView().Show();
                        break;
                    case 3:
                    case 4:
                        MessageBox.Show("Clicked Column: " + e.ColumnIndex + ", Row: " + e.RowIndex, "Unassigned action");
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
    }
}
