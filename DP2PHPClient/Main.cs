using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP2PHPClient
{
    public partial class Main : Form
    {
        ClientConnection _connection;

        public Main()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            _connection = new ClientConnection(txt_ip.Text, int.Parse(txt_port.Text));
            _connection.StartConnection();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            _connection.SendTest();
        }

        private void btn_shutdown_Click(object sender, EventArgs e)
        {
            _connection.Shutdown();
        }

        private void btn_getState_Click(object sender, EventArgs e)
        {
            lbl_connectionState.Text = _connection.GetConnectionState().ToString();
        }
        
        private void btn_requestStock_Click(object sender, EventArgs e)
        {
            StockRecord record = _connection.RequestStockInfo(int.Parse(txt_requestID.Text));
            txt_stockID.Text = record.StockID.ToString();
            txt_stockName.Text = record.StockName;
            txt_purchase.Text = record.Purchase.ToString();
            txt_sell.Text = record.CurrentSell.ToString();
            txt_qty.Text = record.Quantity.ToString();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            _connection.InsertStock(txt_stknameinsert.Text, double.Parse(txt_purchaseinsert.Text), double.Parse(txt_sellinsert.Text), int.Parse(txt_qtyinsert.Text));
        }
    }
}
