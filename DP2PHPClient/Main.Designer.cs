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
            this.btn_send = new System.Windows.Forms.Button();
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
            this.btn_requestStock = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_requestID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(70, 55);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(100, 20);
            this.txt_port.TabIndex = 3;
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
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(207, 51);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_shutdown
            // 
            this.btn_shutdown.Location = new System.Drawing.Point(207, 80);
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
            this.groupBox2.Controls.Add(this.btn_send);
            this.groupBox2.Controls.Add(this.btn_shutdown);
            this.groupBox2.Location = new System.Drawing.Point(16, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 130);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection Info";
            // 
            // txt_requestID
            // 
            this.txt_requestID.Location = new System.Drawing.Point(196, 82);
            this.txt_requestID.Name = "txt_requestID";
            this.txt_requestID.Size = new System.Drawing.Size(48, 20);
            this.txt_requestID.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 292);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "MainScreenTest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_send;
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
    }
}

