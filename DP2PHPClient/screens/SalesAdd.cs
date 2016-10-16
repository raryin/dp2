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
        Model _model;

        public SalesAdd(Model model)
        {
            InitializeComponent();

            _model = model;
            
            //First clear the grid
            dg_data.Rows.Clear();

            _model.PopulateComboBox(cmb_name);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                _model.AddItemSale(dg_data, cmb_name.SelectedIndex, int.Parse(txt_quantity.Text));
            }
            catch (Exception ex)
            {
                //If there's nothing in the quantity text box, send zero
                _model.AddItemSale(dg_data, cmb_name.SelectedIndex, 0);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            _model.InsertReceipt();
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
                        _model.RemoveItemSale(dg_data, e.RowIndex);
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
