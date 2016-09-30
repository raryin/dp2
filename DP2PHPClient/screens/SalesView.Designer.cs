namespace DP2PHPClient.screens
{
    partial class SalesView
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
            this.dg_data = new System.Windows.Forms.DataGridView();
            this.clm_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_data)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_data
            // 
            this.dg_data.AllowUserToAddRows = false;
            this.dg_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_no,
            this.clm_id,
            this.clm_name,
            this.clm_qty,
            this.clm_price});
            this.dg_data.Location = new System.Drawing.Point(25, 87);
            this.dg_data.Name = "dg_data";
            this.dg_data.Size = new System.Drawing.Size(679, 275);
            this.dg_data.TabIndex = 5;
            // 
            // clm_no
            // 
            this.clm_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clm_no.HeaderText = "Number";
            this.clm_no.Name = "clm_no";
            this.clm_no.ReadOnly = true;
            this.clm_no.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clm_no.Width = 69;
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
            // clm_qty
            // 
            this.clm_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clm_qty.HeaderText = "QTY";
            this.clm_qty.Name = "clm_qty";
            this.clm_qty.ReadOnly = true;
            this.clm_qty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clm_qty.Width = 54;
            // 
            // clm_price
            // 
            this.clm_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clm_price.HeaderText = "Price";
            this.clm_price.Name = "clm_price";
            this.clm_price.ReadOnly = true;
            this.clm_price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clm_price.Width = 56;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(735, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "View Sale";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(201, 385);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(91, 36);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(417, 385);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(91, 36);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // SalesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.dg_data);
            this.Controls.Add(this.label1);
            this.Name = "SalesView";
            this.Text = "SalesView";
            ((System.ComponentModel.ISupportInitialize)(this.dg_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
    }
}