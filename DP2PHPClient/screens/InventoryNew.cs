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
        ClientConnectionManager _connection;

        public InventoryNew(ClientConnectionManager connection)
        {
            InitializeComponent();
            _connection = connection;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            _connection.InsertStock(txt_name.Text, double.Parse(txt_cost.Text), double.Parse(txt_sell.Text), int.Parse(txt_qty.Text));
            this.Close();
        }

    }
}
