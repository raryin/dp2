namespace DP2PHPClient
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_shutdown = new System.Windows.Forms.Button();
            this.lbl_connectionState = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_getState = new System.Windows.Forms.Button();
            this.txt_stockName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_stockID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sell = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_purchase = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_requestID = new System.Windows.Forms.TextBox();
            this.btn_requestStock = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.txt_qtyinsert = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_sellinsert = new System.Windows.Forms.TextBox();
            this.txt_stknameinsert = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_purchaseinsert = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_decrement = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_updateqty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_deleteID = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.btn_addSale = new System.Windows.Forms.Button();
            this.txt_receiptqty = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_receiptID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_receiptsell = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_requestReceiptNext = new System.Windows.Forms.Button();
            this.txt_requestReceiptName = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_receiptRequestBox = new System.Windows.Forms.TextBox();
            this.btn_requestReceipt = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_requestReceiptQty = new System.Windows.Forms.TextBox();
            this.txt_requestReceiptID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_requestReceiptSell = new System.Windows.Forms.TextBox();
            this.txt_requestReceiptDate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_requestReceiptNo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(70, 23);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(100, 20);
            this.txt_ip.TabIndex = 1;
            this.txt_ip.Text = "127.0.0.1";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(70, 55);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(100, 20);
            this.txt_port.TabIndex = 3;
            this.txt_port.Text = "25565";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // btn_shutdown
            // 
            this.btn_shutdown.Location = new System.Drawing.Point(207, 52);
            this.btn_shutdown.Name = "btn_shutdown";
            this.btn_shutdown.Size = new System.Drawing.Size(75, 23);
            this.btn_shutdown.TabIndex = 5;
            this.btn_shutdown.Text = "Shut down";
            this.btn_shutdown.UseVisualStyleBackColor = true;
            this.btn_shutdown.Click += new System.EventHandler(this.btn_shutdown_Click);
            // 
            // lbl_connectionState
            // 
            this.lbl_connectionState.AutoSize = true;
            this.lbl_connectionState.Location = new System.Drawing.Point(350, 25);
            this.lbl_connectionState.Name = "lbl_connectionState";
            this.lbl_connectionState.Size = new System.Drawing.Size(32, 13);
            this.lbl_connectionState.TabIndex = 6;
            this.lbl_connectionState.Text = "State";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(207, 20);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 7;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_getState
            // 
            this.btn_getState.AutoSize = true;
            this.btn_getState.Location = new System.Drawing.Point(306, 46);
            this.btn_getState.Name = "btn_getState";
            this.btn_getState.Size = new System.Drawing.Size(119, 23);
            this.btn_getState.TabIndex = 8;
            this.btn_getState.Text = "Get Connection State";
            this.btn_getState.UseVisualStyleBackColor = true;
            this.btn_getState.Click += new System.EventHandler(this.btn_getState_Click);
            // 
            // txt_stockName
            // 
            this.txt_stockName.Enabled = false;
            this.txt_stockName.Location = new System.Drawing.Point(70, 54);
            this.txt_stockName.Name = "txt_stockName";
            this.txt_stockName.Size = new System.Drawing.Size(100, 20);
            this.txt_stockName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Stock Name";
            // 
            // txt_stockID
            // 
            this.txt_stockID.Enabled = false;
            this.txt_stockID.Location = new System.Drawing.Point(70, 22);
            this.txt_stockID.Name = "txt_stockID";
            this.txt_stockID.Size = new System.Drawing.Size(100, 20);
            this.txt_stockID.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "StockID";
            // 
            // txt_sell
            // 
            this.txt_sell.Enabled = false;
            this.txt_sell.Location = new System.Drawing.Point(275, 54);
            this.txt_sell.Name = "txt_sell";
            this.txt_sell.Size = new System.Drawing.Size(100, 20);
            this.txt_sell.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sell Price";
            // 
            // txt_purchase
            // 
            this.txt_purchase.Enabled = false;
            this.txt_purchase.Location = new System.Drawing.Point(275, 22);
            this.txt_purchase.Name = "txt_purchase";
            this.txt_purchase.Size = new System.Drawing.Size(100, 20);
            this.txt_purchase.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Purchase Cost";
            // 
            // txt_qty
            // 
            this.txt_qty.Enabled = false;
            this.txt_qty.Location = new System.Drawing.Point(69, 86);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(100, 20);
            this.txt_qty.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Quantity";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_requestID);
            this.groupBox1.Controls.Add(this.btn_requestStock);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_qty);
            this.groupBox1.Controls.Add(this.txt_stockID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_sell);
            this.groupBox1.Controls.Add(this.txt_stockName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_purchase);
            this.groupBox1.Location = new System.Drawing.Point(16, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 119);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Record Info";
            // 
            // txt_requestID
            // 
            this.txt_requestID.Location = new System.Drawing.Point(196, 82);
            this.txt_requestID.Name = "txt_requestID";
            this.txt_requestID.Size = new System.Drawing.Size(48, 20);
            this.txt_requestID.TabIndex = 9;
            // 
            // btn_requestStock
            // 
            this.btn_requestStock.AutoSize = true;
            this.btn_requestStock.Location = new System.Drawing.Point(275, 83);
            this.btn_requestStock.Name = "btn_requestStock";
            this.btn_requestStock.Size = new System.Drawing.Size(109, 23);
            this.btn_requestStock.TabIndex = 9;
            this.btn_requestStock.Text = "Request Stock Info";
            this.btn_requestStock.UseVisualStyleBackColor = true;
            this.btn_requestStock.Click += new System.EventHandler(this.btn_requestStock_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_ip);
            this.groupBox2.Controls.Add(this.btn_getState);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_connect);
            this.groupBox2.Controls.Add(this.txt_port);
            this.groupBox2.Controls.Add(this.lbl_connectionState);
            this.groupBox2.Controls.Add(this.btn_shutdown);
            this.groupBox2.Location = new System.Drawing.Point(16, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 130);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection Info";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_insert);
            this.groupBox3.Controls.Add(this.txt_qtyinsert);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_sellinsert);
            this.groupBox3.Controls.Add(this.txt_stknameinsert);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_purchaseinsert);
            this.groupBox3.Location = new System.Drawing.Point(473, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 119);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insert Record Into Stock";
            // 
            // btn_insert
            // 
            this.btn_insert.AutoSize = true;
            this.btn_insert.Location = new System.Drawing.Point(158, 90);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(109, 23);
            this.btn_insert.TabIndex = 9;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // txt_qtyinsert
            // 
            this.txt_qtyinsert.Location = new System.Drawing.Point(69, 54);
            this.txt_qtyinsert.Name = "txt_qtyinsert";
            this.txt_qtyinsert.Size = new System.Drawing.Size(100, 20);
            this.txt_qtyinsert.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Stock Name";
            // 
            // txt_sellinsert
            // 
            this.txt_sellinsert.Location = new System.Drawing.Point(275, 54);
            this.txt_sellinsert.Name = "txt_sellinsert";
            this.txt_sellinsert.Size = new System.Drawing.Size(100, 20);
            this.txt_sellinsert.TabIndex = 16;
            // 
            // txt_stknameinsert
            // 
            this.txt_stknameinsert.Location = new System.Drawing.Point(70, 22);
            this.txt_stknameinsert.Name = "txt_stknameinsert";
            this.txt_stknameinsert.Size = new System.Drawing.Size(100, 20);
            this.txt_stknameinsert.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(193, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Sell Price";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(193, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Purchase Cost";
            // 
            // txt_purchaseinsert
            // 
            this.txt_purchaseinsert.Location = new System.Drawing.Point(275, 22);
            this.txt_purchaseinsert.Name = "txt_purchaseinsert";
            this.txt_purchaseinsert.Size = new System.Drawing.Size(100, 20);
            this.txt_purchaseinsert.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_decrement);
            this.groupBox4.Controls.Add(this.btn_update);
            this.groupBox4.Controls.Add(this.txt_updateqty);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btn_delete);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txt_deleteID);
            this.groupBox4.Location = new System.Drawing.Point(473, 161);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(396, 119);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete Record In Stock";
            // 
            // btn_decrement
            // 
            this.btn_decrement.AutoSize = true;
            this.btn_decrement.Location = new System.Drawing.Point(257, 83);
            this.btn_decrement.Name = "btn_decrement";
            this.btn_decrement.Size = new System.Drawing.Size(109, 23);
            this.btn_decrement.TabIndex = 22;
            this.btn_decrement.Text = "Decrement";
            this.btn_decrement.UseVisualStyleBackColor = true;
            this.btn_decrement.Click += new System.EventHandler(this.btn_decrement_Click);
            // 
            // btn_update
            // 
            this.btn_update.AutoSize = true;
            this.btn_update.Location = new System.Drawing.Point(257, 51);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(109, 23);
            this.btn_update.TabIndex = 21;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_updateqty
            // 
            this.txt_updateqty.Location = new System.Drawing.Point(276, 22);
            this.txt_updateqty.Name = "txt_updateqty";
            this.txt_updateqty.Size = new System.Drawing.Size(100, 20);
            this.txt_updateqty.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Quantity";
            // 
            // btn_delete
            // 
            this.btn_delete.AutoSize = true;
            this.btn_delete.Location = new System.Drawing.Point(33, 52);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(109, 23);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "StockID";
            // 
            // txt_deleteID
            // 
            this.txt_deleteID.Location = new System.Drawing.Point(70, 22);
            this.txt_deleteID.Name = "txt_deleteID";
            this.txt_deleteID.Size = new System.Drawing.Size(100, 20);
            this.txt_deleteID.TabIndex = 12;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_addItem);
            this.groupBox5.Controls.Add(this.btn_addSale);
            this.groupBox5.Controls.Add(this.txt_receiptqty);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.txt_receiptID);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.txt_receiptsell);
            this.groupBox5.Location = new System.Drawing.Point(16, 309);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(440, 119);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add Receipt";
            // 
            // btn_addItem
            // 
            this.btn_addItem.AutoSize = true;
            this.btn_addItem.Location = new System.Drawing.Point(264, 48);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(120, 23);
            this.btn_addItem.TabIndex = 19;
            this.btn_addItem.Text = "Add New Item to Sale";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // btn_addSale
            // 
            this.btn_addSale.AutoSize = true;
            this.btn_addSale.Location = new System.Drawing.Point(266, 77);
            this.btn_addSale.Name = "btn_addSale";
            this.btn_addSale.Size = new System.Drawing.Size(109, 23);
            this.btn_addSale.TabIndex = 9;
            this.btn_addSale.Text = "Add Sale";
            this.btn_addSale.UseVisualStyleBackColor = true;
            this.btn_addSale.Click += new System.EventHandler(this.btn_addSale_Click);
            // 
            // txt_receiptqty
            // 
            this.txt_receiptqty.Location = new System.Drawing.Point(69, 54);
            this.txt_receiptqty.Name = "txt_receiptqty";
            this.txt_receiptqty.Size = new System.Drawing.Size(100, 20);
            this.txt_receiptqty.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Quantity";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "StockID";
            // 
            // txt_receiptID
            // 
            this.txt_receiptID.Location = new System.Drawing.Point(70, 22);
            this.txt_receiptID.Name = "txt_receiptID";
            this.txt_receiptID.Size = new System.Drawing.Size(100, 20);
            this.txt_receiptID.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(193, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "SalePrice";
            // 
            // txt_receiptsell
            // 
            this.txt_receiptsell.Location = new System.Drawing.Point(275, 22);
            this.txt_receiptsell.Name = "txt_receiptsell";
            this.txt_receiptsell.Size = new System.Drawing.Size(100, 20);
            this.txt_receiptsell.TabIndex = 14;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_requestReceiptNext);
            this.groupBox6.Controls.Add(this.txt_requestReceiptName);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.txt_receiptRequestBox);
            this.groupBox6.Controls.Add(this.btn_requestReceipt);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.txt_requestReceiptQty);
            this.groupBox6.Controls.Add(this.txt_requestReceiptID);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.txt_requestReceiptSell);
            this.groupBox6.Controls.Add(this.txt_requestReceiptDate);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.txt_requestReceiptNo);
            this.groupBox6.Location = new System.Drawing.Point(473, 309);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(396, 158);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Record Info";
            // 
            // btn_requestReceiptNext
            // 
            this.btn_requestReceiptNext.Location = new System.Drawing.Point(183, 84);
            this.btn_requestReceiptNext.Name = "btn_requestReceiptNext";
            this.btn_requestReceiptNext.Size = new System.Drawing.Size(75, 23);
            this.btn_requestReceiptNext.TabIndex = 21;
            this.btn_requestReceiptNext.Text = "NextItem";
            this.btn_requestReceiptNext.UseVisualStyleBackColor = true;
            this.btn_requestReceiptNext.Click += new System.EventHandler(this.btn_requestReceiptNext_Click);
            // 
            // txt_requestReceiptName
            // 
            this.txt_requestReceiptName.Enabled = false;
            this.txt_requestReceiptName.Location = new System.Drawing.Point(70, 117);
            this.txt_requestReceiptName.Name = "txt_requestReceiptName";
            this.txt_requestReceiptName.Size = new System.Drawing.Size(100, 20);
            this.txt_requestReceiptName.TabIndex = 20;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 120);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 13);
            this.label22.TabIndex = 19;
            this.label22.Text = "Item Name";
            // 
            // txt_receiptRequestBox
            // 
            this.txt_receiptRequestBox.Location = new System.Drawing.Point(275, 86);
            this.txt_receiptRequestBox.Name = "txt_receiptRequestBox";
            this.txt_receiptRequestBox.Size = new System.Drawing.Size(48, 20);
            this.txt_receiptRequestBox.TabIndex = 9;
            // 
            // btn_requestReceipt
            // 
            this.btn_requestReceipt.AutoSize = true;
            this.btn_requestReceipt.Location = new System.Drawing.Point(248, 114);
            this.btn_requestReceipt.Name = "btn_requestReceipt";
            this.btn_requestReceipt.Size = new System.Drawing.Size(118, 23);
            this.btn_requestReceipt.TabIndex = 9;
            this.btn_requestReceipt.Text = "Request Receipt Info";
            this.btn_requestReceipt.UseVisualStyleBackColor = true;
            this.btn_requestReceipt.Click += new System.EventHandler(this.btn_requestReceipt_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "ReceiptID";
            // 
            // txt_requestReceiptQty
            // 
            this.txt_requestReceiptQty.Enabled = false;
            this.txt_requestReceiptQty.Location = new System.Drawing.Point(69, 86);
            this.txt_requestReceiptQty.Name = "txt_requestReceiptQty";
            this.txt_requestReceiptQty.Size = new System.Drawing.Size(100, 20);
            this.txt_requestReceiptQty.TabIndex = 18;
            // 
            // txt_requestReceiptID
            // 
            this.txt_requestReceiptID.Enabled = false;
            this.txt_requestReceiptID.Location = new System.Drawing.Point(70, 22);
            this.txt_requestReceiptID.Name = "txt_requestReceiptID";
            this.txt_requestReceiptID.Size = new System.Drawing.Size(100, 20);
            this.txt_requestReceiptID.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Item Quantity";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 57);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Date";
            // 
            // txt_requestReceiptSell
            // 
            this.txt_requestReceiptSell.Enabled = false;
            this.txt_requestReceiptSell.Location = new System.Drawing.Point(275, 54);
            this.txt_requestReceiptSell.Name = "txt_requestReceiptSell";
            this.txt_requestReceiptSell.Size = new System.Drawing.Size(100, 20);
            this.txt_requestReceiptSell.TabIndex = 16;
            // 
            // txt_requestReceiptDate
            // 
            this.txt_requestReceiptDate.Enabled = false;
            this.txt_requestReceiptDate.Location = new System.Drawing.Point(70, 54);
            this.txt_requestReceiptDate.Name = "txt_requestReceiptDate";
            this.txt_requestReceiptDate.Size = new System.Drawing.Size(100, 20);
            this.txt_requestReceiptDate.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(193, 57);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 13);
            this.label20.TabIndex = 15;
            this.label20.Text = "Item Sell Price";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(193, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "Item No";
            // 
            // txt_requestReceiptNo
            // 
            this.txt_requestReceiptNo.Enabled = false;
            this.txt_requestReceiptNo.Location = new System.Drawing.Point(275, 22);
            this.txt_requestReceiptNo.Name = "txt_requestReceiptNo";
            this.txt_requestReceiptNo.Size = new System.Drawing.Size(100, 20);
            this.txt_requestReceiptNo.TabIndex = 14;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 479);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "MainScreenTest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_shutdown;
        private System.Windows.Forms.Label lbl_connectionState;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_getState;
        private System.Windows.Forms.TextBox txt_stockName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_stockID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_purchase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_requestStock;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_requestID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox txt_qtyinsert;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_sellinsert;
        private System.Windows.Forms.TextBox txt_stknameinsert;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_purchaseinsert;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_deleteID;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_updateqty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_decrement;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.Button btn_addSale;
        private System.Windows.Forms.TextBox txt_receiptqty;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_receiptID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_receiptsell;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txt_requestReceiptName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_receiptRequestBox;
        private System.Windows.Forms.Button btn_requestReceipt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_requestReceiptQty;
        private System.Windows.Forms.TextBox txt_requestReceiptID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_requestReceiptSell;
        private System.Windows.Forms.TextBox txt_requestReceiptDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_requestReceiptNo;
        private System.Windows.Forms.Button btn_requestReceiptNext;
    }
}

