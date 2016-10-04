namespace DP2PHPClient.screens
{
    partial class SalesAdd
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
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_name = new System.Windows.Forms.ComboBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clm_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_remove = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.clm_price,
            this.btn_remove});
            this.dg_data.Location = new System.Drawing.Point(41, 209);
            this.dg_data.Name = "dg_data";
            this.dg_data.Size = new System.Drawing.Size(679, 187);
            this.dg_data.TabIndex = 27;
            this.dg_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_data_CellContentClick);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(339, 118);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(278, 37);
            this.txt_quantity.TabIndex = 33;
            this.txt_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(127, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 39);
            this.label3.TabIndex = 32;
            this.label3.Text = "Quantity";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_name
            // 
            this.cmb_name.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_name.FormattingEnabled = true;
            this.cmb_name.Location = new System.Drawing.Point(339, 66);
            this.cmb_name.Name = "cmb_name";
            this.cmb_name.Size = new System.Drawing.Size(278, 37);
            this.cmb_name.TabIndex = 31;
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_name.Location = new System.Drawing.Point(127, 66);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(162, 39);
            this.lbl_name.TabIndex = 30;
            this.lbl_name.Text = "Product Name";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(246, 167);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(264, 36);
            this.btn_add.TabIndex = 29;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(198, 402);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(368, 36);
            this.btn_edit.TabIndex = 28;
            this.btn_edit.Text = "Save";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(735, 54);
            this.label1.TabIndex = 26;
            this.label1.Text = "New Sale";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // btn_remove
            // 
            this.btn_remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btn_remove.HeaderText = "";
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Width = 5;
            // 
            // SalesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(756, 458);
            this.Controls.Add(this.dg_data);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label1);
            this.Name = "SalesAdd";
            this.Text = "SalesAdd";
            ((System.ComponentModel.ISupportInitialize)(this.dg_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_data;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_price;
        private System.Windows.Forms.DataGridViewButtonColumn btn_remove;
    }
}