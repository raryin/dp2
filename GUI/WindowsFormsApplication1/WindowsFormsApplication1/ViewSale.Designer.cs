namespace WindowsFormsApplication1
{
    partial class ViewSale
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
            this.ReceiptTable = new System.Windows.Forms.DataGridView();
            this.viewsalelabel = new System.Windows.Forms.Label();
            this.receiptlabel = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.receiptbox = new System.Windows.Forms.TextBox();
            this.datebox = new System.Windows.Forms.TextBox();
            this.btnedit = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ReceiptTable
            // 
            this.ReceiptTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReceiptTable.Location = new System.Drawing.Point(32, 136);
            this.ReceiptTable.Name = "ReceiptTable";
            this.ReceiptTable.Size = new System.Drawing.Size(320, 165);
            this.ReceiptTable.TabIndex = 0;
            // 
            // viewsalelabel
            // 
            this.viewsalelabel.AutoSize = true;
            this.viewsalelabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewsalelabel.ForeColor = System.Drawing.Color.White;
            this.viewsalelabel.Location = new System.Drawing.Point(128, 58);
            this.viewsalelabel.Name = "viewsalelabel";
            this.viewsalelabel.Size = new System.Drawing.Size(125, 33);
            this.viewsalelabel.TabIndex = 1;
            this.viewsalelabel.Text = "View Sale";
            // 
            // receiptlabel
            // 
            this.receiptlabel.AutoSize = true;
            this.receiptlabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptlabel.ForeColor = System.Drawing.Color.White;
            this.receiptlabel.Location = new System.Drawing.Point(29, 111);
            this.receiptlabel.Name = "receiptlabel";
            this.receiptlabel.Size = new System.Drawing.Size(80, 19);
            this.receiptlabel.TabIndex = 2;
            this.receiptlabel.Text = "Receipt No";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelbl.ForeColor = System.Drawing.Color.Snow;
            this.datelbl.Location = new System.Drawing.Point(213, 111);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(40, 19);
            this.datelbl.TabIndex = 3;
            this.datelbl.Text = "Date";
            // 
            // receiptbox
            // 
            this.receiptbox.Location = new System.Drawing.Point(116, 110);
            this.receiptbox.MaxLength = 0;
            this.receiptbox.Name = "receiptbox";
            this.receiptbox.Size = new System.Drawing.Size(91, 20);
            this.receiptbox.TabIndex = 4;
            // 
            // datebox
            // 
            this.datebox.Location = new System.Drawing.Point(252, 110);
            this.datebox.MaxLength = 0;
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(100, 20);
            this.datebox.TabIndex = 5;
            // 
            // btnedit
            // 
            this.btnedit.FlatAppearance.BorderSize = 3;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.ForeColor = System.Drawing.Color.Snow;
            this.btnedit.Location = new System.Drawing.Point(101, 316);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 33);
            this.btnedit.TabIndex = 6;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // deletebtn
            // 
            this.deletebtn.FlatAppearance.BorderSize = 3;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.ForeColor = System.Drawing.Color.Snow;
            this.deletebtn.Location = new System.Drawing.Point(208, 316);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 33);
            this.deletebtn.TabIndex = 7;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            // 
            // ViewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.datebox);
            this.Controls.Add(this.receiptbox);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.receiptlabel);
            this.Controls.Add(this.viewsalelabel);
            this.Controls.Add(this.ReceiptTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ViewSale";
            this.Text = "View Sale";
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ReceiptTable;
        private System.Windows.Forms.Label viewsalelabel;
        private System.Windows.Forms.Label receiptlabel;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.TextBox receiptbox;
        private System.Windows.Forms.TextBox datebox;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button deletebtn;
    }
}