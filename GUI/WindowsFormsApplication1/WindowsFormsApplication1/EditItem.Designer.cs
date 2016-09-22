namespace WindowsFormsApplication1
{
    partial class edititem
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
            this.productlabel = new System.Windows.Forms.Label();
            this.labelqty = new System.Windows.Forms.Label();
            this.labelsp = new System.Windows.Forms.Label();
            this.labelcp = new System.Windows.Forms.Label();
            this.desclabel = new System.Windows.Forms.Label();
            this.productlist = new System.Windows.Forms.ComboBox();
            this.descbox = new System.Windows.Forms.TextBox();
            this.cpbox = new System.Windows.Forms.TextBox();
            this.spbox = new System.Windows.Forms.TextBox();
            this.qtybox = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productlabel
            // 
            this.productlabel.AutoSize = true;
            this.productlabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productlabel.Location = new System.Drawing.Point(29, 38);
            this.productlabel.Name = "productlabel";
            this.productlabel.Size = new System.Drawing.Size(100, 19);
            this.productlabel.TabIndex = 0;
            this.productlabel.Text = "Product Name";
            // 
            // labelqty
            // 
            this.labelqty.AutoSize = true;
            this.labelqty.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelqty.Location = new System.Drawing.Point(29, 263);
            this.labelqty.Name = "labelqty";
            this.labelqty.Size = new System.Drawing.Size(65, 19);
            this.labelqty.TabIndex = 2;
            this.labelqty.Text = "Quantity";
            // 
            // labelsp
            // 
            this.labelsp.AutoSize = true;
            this.labelsp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsp.Location = new System.Drawing.Point(29, 217);
            this.labelsp.Name = "labelsp";
            this.labelsp.Size = new System.Drawing.Size(72, 19);
            this.labelsp.TabIndex = 3;
            this.labelsp.Text = "Sale Price";
            // 
            // labelcp
            // 
            this.labelcp.AutoSize = true;
            this.labelcp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcp.Location = new System.Drawing.Point(29, 167);
            this.labelcp.Name = "labelcp";
            this.labelcp.Size = new System.Drawing.Size(74, 19);
            this.labelcp.TabIndex = 4;
            this.labelcp.Text = "Cost Price";
            // 
            // desclabel
            // 
            this.desclabel.AutoSize = true;
            this.desclabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desclabel.Location = new System.Drawing.Point(29, 66);
            this.desclabel.Name = "desclabel";
            this.desclabel.Size = new System.Drawing.Size(83, 19);
            this.desclabel.TabIndex = 5;
            this.desclabel.Text = "Description";
            // 
            // productlist
            // 
            this.productlist.BackColor = System.Drawing.Color.White;
            this.productlist.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productlist.FormattingEnabled = true;
            this.productlist.Location = new System.Drawing.Point(160, 35);
            this.productlist.MaxDropDownItems = 20;
            this.productlist.Name = "productlist";
            this.productlist.Size = new System.Drawing.Size(179, 27);
            this.productlist.TabIndex = 6;
            // 
            // descbox
            // 
            this.descbox.Location = new System.Drawing.Point(160, 69);
            this.descbox.Multiline = true;
            this.descbox.Name = "descbox";
            this.descbox.Size = new System.Drawing.Size(179, 83);
            this.descbox.TabIndex = 7;
            // 
            // cpbox
            // 
            this.cpbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbox.Location = new System.Drawing.Point(160, 165);
            this.cpbox.MaxLength = 5;
            this.cpbox.Name = "cpbox";
            this.cpbox.Size = new System.Drawing.Size(100, 27);
            this.cpbox.TabIndex = 8;
            // 
            // spbox
            // 
            this.spbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spbox.Location = new System.Drawing.Point(160, 209);
            this.spbox.MaxLength = 5;
            this.spbox.Name = "spbox";
            this.spbox.Size = new System.Drawing.Size(100, 27);
            this.spbox.TabIndex = 9;
            // 
            // qtybox
            // 
            this.qtybox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtybox.Location = new System.Drawing.Point(160, 255);
            this.qtybox.MaxLength = 5;
            this.qtybox.Name = "qtybox";
            this.qtybox.Size = new System.Drawing.Size(100, 27);
            this.qtybox.TabIndex = 10;
            // 
            // btnsubmit
            // 
            this.btnsubmit.FlatAppearance.BorderSize = 3;
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubmit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Location = new System.Drawing.Point(160, 306);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(100, 35);
            this.btnsubmit.TabIndex = 11;
            this.btnsubmit.Text = "SUBMIT";
            this.btnsubmit.UseVisualStyleBackColor = true;
            // 
            // edititem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.qtybox);
            this.Controls.Add(this.spbox);
            this.Controls.Add(this.cpbox);
            this.Controls.Add(this.descbox);
            this.Controls.Add(this.productlist);
            this.Controls.Add(this.desclabel);
            this.Controls.Add(this.labelcp);
            this.Controls.Add(this.labelsp);
            this.Controls.Add(this.labelqty);
            this.Controls.Add(this.productlabel);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "edititem";
            this.Text = "Edit Item";
            this.Load += new System.EventHandler(this.edititem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productlabel;
        private System.Windows.Forms.Label labelqty;
        private System.Windows.Forms.Label labelsp;
        private System.Windows.Forms.Label labelcp;
        private System.Windows.Forms.Label desclabel;
        private System.Windows.Forms.ComboBox productlist;
        private System.Windows.Forms.TextBox descbox;
        private System.Windows.Forms.TextBox cpbox;
        private System.Windows.Forms.TextBox spbox;
        private System.Windows.Forms.TextBox qtybox;
        private System.Windows.Forms.Button btnsubmit;
    }
}