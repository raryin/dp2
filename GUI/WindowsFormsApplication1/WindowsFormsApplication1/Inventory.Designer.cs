namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.inventorygrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.inventorygrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(464, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(232, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "New Item";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.deletebtn.FlatAppearance.BorderSize = 3;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deletebtn.Location = new System.Drawing.Point(737, 210);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(84, 37);
            this.deletebtn.TabIndex = 2;
            this.deletebtn.Text = "Delete Item";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.editbtn.FlatAppearance.BorderSize = 3;
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editbtn.Location = new System.Drawing.Point(482, 210);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(84, 37);
            this.editbtn.TabIndex = 3;
            this.editbtn.Text = "Edit Item";
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // inventorygrid
            // 
            this.inventorygrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventorygrid.Location = new System.Drawing.Point(232, 284);
            this.inventorygrid.Name = "inventorygrid";
            this.inventorygrid.Size = new System.Drawing.Size(589, 228);
            this.inventorygrid.TabIndex = 4;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1060, 677);
            this.ControlBox = false;
            this.Controls.Add(this.inventorygrid);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.inventorygrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.DataGridView inventorygrid;
    }
}