namespace WindowsFormsApplication1
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
            this.saleslabel = new System.Windows.Forms.Label();
            this.labelsearch = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.gobtn = new System.Windows.Forms.Button();
            this.sortlabel = new System.Windows.Forms.Label();
            this.listbox = new System.Windows.Forms.ComboBox();
            this.salesgrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.salesgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // saleslabel
            // 
            this.saleslabel.AutoSize = true;
            this.saleslabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleslabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.saleslabel.Location = new System.Drawing.Point(468, 118);
            this.saleslabel.Name = "saleslabel";
            this.saleslabel.Size = new System.Drawing.Size(73, 33);
            this.saleslabel.TabIndex = 0;
            this.saleslabel.Text = "Sales";
            // 
            // labelsearch
            // 
            this.labelsearch.AutoSize = true;
            this.labelsearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelsearch.Location = new System.Drawing.Point(207, 198);
            this.labelsearch.Name = "labelsearch";
            this.labelsearch.Size = new System.Drawing.Size(52, 19);
            this.labelsearch.TabIndex = 1;
            this.labelsearch.Text = "Search";
            this.labelsearch.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(265, 198);
            this.searchbox.MaxLength = 4;
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(100, 20);
            this.searchbox.TabIndex = 2;
            // 
            // gobtn
            // 
            this.gobtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.gobtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.gobtn.FlatAppearance.BorderSize = 3;
            this.gobtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gobtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gobtn.Location = new System.Drawing.Point(371, 198);
            this.gobtn.Name = "gobtn";
            this.gobtn.Size = new System.Drawing.Size(43, 20);
            this.gobtn.TabIndex = 3;
            this.gobtn.Text = "GO";
            this.gobtn.UseVisualStyleBackColor = false;
            // 
            // sortlabel
            // 
            this.sortlabel.AutoSize = true;
            this.sortlabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortlabel.ForeColor = System.Drawing.Color.Snow;
            this.sortlabel.Location = new System.Drawing.Point(602, 201);
            this.sortlabel.Name = "sortlabel";
            this.sortlabel.Size = new System.Drawing.Size(53, 19);
            this.sortlabel.TabIndex = 4;
            this.sortlabel.Text = "Sort by";
            // 
            // listbox
            // 
            this.listbox.BackColor = System.Drawing.SystemColors.InfoText;
            this.listbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listbox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox.FormattingEnabled = true;
            this.listbox.Items.AddRange(new object[] {
            "Latest",
            "Oldest"});
            this.listbox.Location = new System.Drawing.Point(679, 197);
            this.listbox.MaxDropDownItems = 3;
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(121, 23);
            this.listbox.TabIndex = 5;
            // 
            // salesgrid
            // 
            this.salesgrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.salesgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesgrid.Location = new System.Drawing.Point(211, 262);
            this.salesgrid.Name = "salesgrid";
            this.salesgrid.Size = new System.Drawing.Size(589, 228);
            this.salesgrid.TabIndex = 6;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.ControlBox = false;
            this.Controls.Add(this.salesgrid);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.sortlabel);
            this.Controls.Add(this.gobtn);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.labelsearch);
            this.Controls.Add(this.saleslabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Sales";
            this.Text = "Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saleslabel;
        private System.Windows.Forms.Label labelsearch;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button gobtn;
        private System.Windows.Forms.Label sortlabel;
        private System.Windows.Forms.ComboBox listbox;
        private System.Windows.Forms.DataGridView salesgrid;
    }
}