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
    public partial class InventoryNew : Form
    {
        Model _model;

        public InventoryNew(Model model)
        {
            InitializeComponent();

            _model = model;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            _model.InsertStock(txt_name.Text, double.Parse(txt_cost.Text), double.Parse(txt_sell.Text), int.Parse(txt_qty.Text));

            this.Close();
        }

    }
}
