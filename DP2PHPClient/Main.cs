﻿using System;
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
        ClientConnectionManager _connection;

        public Main()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            _connection = new ClientConnectionManager(txt_ip.Text, int.Parse(txt_port.Text));
            _connection.ConnectToServer();
        }
        
        private void btn_shutdown_Click(object sender, EventArgs e)
        {
            _connection.Disconnect();
        }

        private void btn_getState_Click(object sender, EventArgs e)
        {
            lbl_connectionState.Text = _connection.GetConnectionState().ToString();
        }
        
        private void btn_requestStock_Click(object sender, EventArgs e)
        {
            List<StockRecord> record = null;

            if (txt_requestID.Text == "")
                record = _connection.RequestStockInfo(-1);
            else
                record = _connection.RequestStockInfo(int.Parse(txt_requestID.Text));

            if (record != null)
            {
                if (record.Count != 0)
                {
                    txt_stockID.Text = record[0].StockID.ToString();
                    txt_stockName.Text = record[0].StockName;
                    txt_purchase.Text = record[0].Purchase.ToString();
                    txt_sell.Text = record[0].CurrentSell.ToString();
                    txt_qty.Text = record[0].Quantity.ToString();
                }
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            _connection.InsertStock(txt_stknameinsert.Text, double.Parse(txt_purchaseinsert.Text), double.Parse(txt_sellinsert.Text), int.Parse(txt_qtyinsert.Text));
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_deleteID.Text == "")
                _connection.DeleteStock(-1);
            else
                _connection.DeleteStock(int.Parse(txt_deleteID.Text));
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if ((txt_deleteID.Text != "") && (txt_updateqty.Text != ""))
                _connection.UpdateStock(new StockRecord(int.Parse(txt_deleteID.Text), "", 0, 0, int.Parse(txt_updateqty.Text)));
        }

        private void btn_decrement_Click(object sender, EventArgs e)
        {
            if ((txt_deleteID.Text != "") && (txt_updateqty.Text != ""))
                _connection.DecrementStock(new StockRecord(int.Parse(txt_deleteID.Text), "", 0, 0, int.Parse(txt_updateqty.Text)));
        }

    }
}
