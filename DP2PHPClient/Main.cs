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
        ClientConnectionManager _connection;

        List<ItemSaleRecord> itemSales = new List<ItemSaleRecord>();
        List<StockRecord> record = null;
        List<Record> recordList = new List<Record>();

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

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            itemSales.Add(new ItemSaleRecord(0, int.Parse(txt_receiptID.Text), double.Parse(txt_receiptsell.Text), int.Parse(txt_receiptqty.Text), ""));
            txt_receiptsell.Text = "";
            txt_receiptqty.Text = "";
            txt_receiptID.Text = "";
        }

        private void btn_addSale_Click(object sender, EventArgs e)
        {
            _connection.InsertReceipt(itemSales);
            itemSales.Clear();
        }

        private void btn_requestReceipt_Click(object sender, EventArgs e)
        {
            if (txt_receiptRequestBox.Text != "")
            {
                if ((recordList = _connection.RequestReceiptInfo(int.Parse(txt_receiptRequestBox.Text))) != null)
                {
                    txt_requestReceiptName.Text = ((ItemSaleRecord)recordList[0]).Name;
                    txt_requestReceiptQty.Text = ((ItemSaleRecord)recordList[0]).Quantity.ToString();
                    txt_requestReceiptSell.Text = ((ItemSaleRecord)recordList[0]).PriceSold.ToString();
                    txt_requestReceiptNo.Text = "0";
                }
            }
            else
            {
                if ((recordList = _connection.RequestReceiptInfo()) != null)
                {
                    txt_requestReceiptDate.Text = ((ReceiptRecord)recordList[0]).Date.ToString();
                    txt_requestReceiptID.Text = ((ReceiptRecord)recordList[0]).SaleID.ToString();
                }
            }
            
        }

        private void btn_requestReceiptNext_Click(object sender, EventArgs e)
        {
            if (recordList.Count > 1)
            {
                int i = 0;
                if ((i = int.Parse(txt_requestReceiptNo.Text)) < recordList.Count -1)
                    txt_requestReceiptNo.Text = (++i).ToString();
                else
                    txt_requestReceiptNo.Text = (i=0).ToString();

                txt_requestReceiptName.Text = ((ItemSaleRecord)recordList[i]).Name;
                txt_requestReceiptQty.Text = ((ItemSaleRecord)recordList[i]).Quantity.ToString();
                txt_requestReceiptSell.Text = ((ItemSaleRecord)recordList[i]).PriceSold.ToString();
            }

        }

    }
}
