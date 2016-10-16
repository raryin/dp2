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
        Model _model;
        int _threshold = 10;

        public Inventory(Model model)
        {
            InitializeComponent();

            _model = model;

            _model.RefreshStockList(dg_dataStock);
        }

        private void dg_data_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    case 5: //Add Quantity
                        _model.OpenScreen(new screens.InventoryEdit(_model, e.RowIndex));
                        break;
                    case 6: //Delete Quantity
                        _model.OpenScreen(new screens.InventoryQuantityDel(_model, e.RowIndex));
                        break;
                    case 7: //Predict
                        _model.OpenScreen(new screens.InventoryPredict(_model, e.RowIndex));
                        break;
                    default:
                        break;
                }
            }

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            _model.UpdateStoredStock();
            _model.RefreshStockList(dg_dataStock);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            _model.OpenScreen(new screens.InventoryNew(_model));
        }

        private void tb_inventory_Click(object sender, EventArgs e)
        {
            _model.UpdateScreen(new screens.Inventory(_model));
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            _model.OpenScreen(new screens.InventoryEdit(_model));
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            _model.OpenScreen(new screens.InventoryDelete(_model));
        }

        private void tb_sales_Click(object sender, EventArgs e)
        {
            _model.UpdateScreen(new screens.Sales(_model));
        }
    }
}
