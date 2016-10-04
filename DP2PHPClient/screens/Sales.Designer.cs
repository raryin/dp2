namespace DP2PHPClient.screens
{
    partial class Sales
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tb_inventory = new System.Windows.Forms.ToolStripTextBox();
            this.tb_sales = new System.Windows.Forms.ToolStripTextBox();
            this.tb_report = new System.Windows.Forms.ToolStripTextBox();
            this.tb_help = new System.Windows.Forms.ToolStripTextBox();
            this.dg_data = new System.Windows.Forms.DataGridView();
            this.clm_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_view = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clm_edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clm_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_debug = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(934, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tb_inventory,
            this.tb_sales,
            this.tb_report,
            this.tb_help});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(934, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tb_inventory
            // 
            this.tb_inventory.Name = "tb_inventory";
            this.tb_inventory.Size = new System.Drawing.Size(100, 25);
            this.tb_inventory.Text = "Inventory";
            this.tb_inventory.Click += new System.EventHandler(this.tb_inventory_Click);
            // 
            // tb_sales
            // 
            this.tb_sales.Name = "tb_sales";
            this.tb_sales.Size = new System.Drawing.Size(100, 25);
            this.tb_sales.Text = "Sales";
            // 
            // tb_report
            // 
            this.tb_report.Enabled = false;
            this.tb_report.Name = "tb_report";
            this.tb_report.Size = new System.Drawing.Size(100, 25);
            this.tb_report.Text = "Reports";
            // 
            // tb_help
            // 
            this.tb_help.Enabled = false;
            this.tb_help.Name = "tb_help";
            this.tb_help.Size = new System.Drawing.Size(100, 25);
            this.tb_help.Text = "Help";
            // 
            // dg_data
            // 
            this.dg_data.AllowUserToAddRows = false;
            this.dg_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_id,
            this.clm_date,
            this.clm_view,
            this.clm_edit,
            this.clm_delete});
            this.dg_data.Location = new System.Drawing.Point(77, 155);
            this.dg_data.Name = "dg_data";
            this.dg_data.Size = new System.Drawing.Size(777, 446);
            this.dg_data.TabIndex = 3;
            this.dg_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_data_CellContentClick_1);
            // 
            // clm_id
            // 
            this.clm_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clm_id.HeaderText = "Invoice ID";
            this.clm_id.Name = "clm_id";
            this.clm_id.ReadOnly = true;
            this.clm_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clm_date
            // 
            this.clm_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clm_date.HeaderText = "Date";
            this.clm_date.Name = "clm_date";
            this.clm_date.ReadOnly = true;
            this.clm_date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clm_view
            // 
            this.clm_view.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clm_view.HeaderText = "";
            this.clm_view.Name = "clm_view";
            this.clm_view.ReadOnly = true;
            this.clm_view.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clm_edit
            // 
            this.clm_edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clm_edit.HeaderText = "";
            this.clm_edit.Name = "clm_edit";
            this.clm_edit.ReadOnly = true;
            this.clm_edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clm_delete
            // 
            this.clm_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clm_delete.HeaderText = "";
            this.clm_delete.Name = "clm_delete";
            this.clm_delete.ReadOnly = true;
            this.clm_delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(733, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 4;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.White;
            this.txt_search.Location = new System.Drawing.Point(135, 108);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 27);
            this.txt_search.TabIndex = 5;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(241, 108);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(38, 31);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Go";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(670, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sort by:";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(364, 105);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(74, 31);
            this.btn_refresh.TabIndex = 9;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_debug
            // 
            this.btn_debug.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_debug.Location = new System.Drawing.Point(502, 105);
            this.btn_debug.Name = "btn_debug";
            this.btn_debug.Size = new System.Drawing.Size(137, 31);
            this.btn_debug.TabIndex = 10;
            this.btn_debug.Text = "Add new sale";
            this.btn_debug.UseVisualStyleBackColor = true;
            this.btn_debug.Click += new System.EventHandler(this.btn_debug_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.btn_debug);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dg_data);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Name = "Sales";
            this.Text = "Sales";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox tb_inventory;
        private System.Windows.Forms.ToolStripTextBox tb_sales;
        private System.Windows.Forms.ToolStripTextBox tb_report;
        private System.Windows.Forms.ToolStripTextBox tb_help;
        private System.Windows.Forms.DataGridView dg_data;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_date;
        private System.Windows.Forms.DataGridViewButtonColumn clm_view;
        private System.Windows.Forms.DataGridViewButtonColumn clm_edit;
        private System.Windows.Forms.DataGridViewButtonColumn clm_delete;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_debug;
    }
}