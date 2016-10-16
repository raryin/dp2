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
        private Model _model;

        public Sales(Model model)
        {
            InitializeComponent();

            _model = model;

            _model.RefreshReceiptList(dg_data);
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
                        _model.OpenScreen(new SalesView(_model, e.RowIndex));
                        break;
                    case 3: //Edit
                        //Not implemented
                        break;
                    case 4: //Delete
                        _model.DeleteReceipt(e.RowIndex);
                        break;
                    default:
                        break;
                }
            }

        }

        private void tb_inventory_Click(object sender, EventArgs e)
        {
            _model.UpdateScreen(new screens.Inventory(_model));
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            _model.UpdateStoredReceipts();
            _model.RefreshReceiptList(dg_data);
        }

        private void btn_debug_Click(object sender, EventArgs e)
        {
            _model.OpenScreen(new screens.SalesAdd(_model));
        }
    }
}
