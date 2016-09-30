namespace DP2PHPClient.screens
{
    partial class Inventory
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
            this.clm_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clm_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
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
            this.label1.Text = "Inventory";
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
            // 
            // tb_sales
            // 
            this.tb_sales.Name = "tb_sales";
            this.tb_sales.Size = new System.Drawing.Size(100, 25);
            this.tb_sales.Text = "Sales";
            this.tb_sales.Click += new System.EventHandler(this.tb_sales_Click);
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
            this.clm_name,
            this.clm_cost,
            this.clm_sale,
            this.clm_qty,
            this.clm_add,
            this.clm_delete});
            this.dg_data.Location = new System.Drawing.Point(79, 172);
            this.dg_data.Name = "dg_data";
            this.dg_data.Size = new System.Drawing.Size(777, 428);
            this.dg_data.TabIndex = 3;
            this.dg_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_data_CellContentClick_1);
            // 
            // clm_id
            // 
            this.clm_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clm_id.HeaderText = "ID";
            this.clm_id.Name = "clm_id";
            this.clm_id.ReadOnly = true;
            this.clm_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clm_id.Width = 43;
            // 
            // clm_name
            // 
            this.clm_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clm_name.HeaderText = "Product Name";
            this.clm_name.Name = "clm_name";
            this.clm_name.ReadOnly = true;
            this.clm_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clm_cost
            // 
            this.clm_cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clm_cost.HeaderText = "Cost Price";
            this.clm_cost.Name = "clm_cost";
            this.clm_cost.ReadOnly = true;
            this.clm_cost.Width = 80;
            // 
            // clm_sale
            // 
            this.clm_sale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clm_sale.HeaderText = "Sale Price";
            this.clm_sale.Name = "clm_sale";
            this.clm_sale.ReadOnly = true;
            this.clm_sale.Width = 80;
            // 
            // clm_qty
            // 
            this.clm_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clm_qty.HeaderText = "QTY";
            this.clm_qty.Name = "clm_qty";
            this.clm_qty.ReadOnly = true;
            this.clm_qty.Width = 54;
            // 
            // clm_add
            // 
            this.clm_add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clm_add.HeaderText = "";
            this.clm_add.Name = "clm_add";
            this.clm_add.ReadOnly = true;
            this.clm_add.Width = 5;
            // 
            // clm_delete
            // 
            this.clm_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clm_delete.HeaderText = "";
            this.clm_delete.Name = "clm_delete";
            this.clm_delete.ReadOnly = true;
            this.clm_delete.Width = 5;
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(207, 113);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(114, 38);
            this.btn_new.TabIndex = 4;
            this.btn_new.Text = "New Item";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(344, 113);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(114, 38);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Edit Item";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(479, 113);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(114, 38);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete Item";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(619, 113);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(114, 38);
            this.btn_refresh.TabIndex = 7;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.dg_data);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Name = "Inventory";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_qty;
        private System.Windows.Forms.DataGridViewButtonColumn clm_add;
        private System.Windows.Forms.DataGridViewButtonColumn clm_delete;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_refresh;
    }
}