namespace WindowsFormsApplication1
{
    partial class DeleteQuantity
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
            this.qtylabel = new System.Windows.Forms.Label();
            this.qtynum = new System.Windows.Forms.NumericUpDown();
            this.deletebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qtynum)).BeginInit();
            this.SuspendLayout();
            // 
            // qtylabel
            // 
            this.qtylabel.AutoSize = true;
            this.qtylabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtylabel.Location = new System.Drawing.Point(30, 111);
            this.qtylabel.Name = "qtylabel";
            this.qtylabel.Size = new System.Drawing.Size(65, 19);
            this.qtylabel.TabIndex = 0;
            this.qtylabel.Text = "Quantity";
            // 
            // qtynum
            // 
            this.qtynum.Location = new System.Drawing.Point(126, 109);
            this.qtynum.Name = "qtynum";
            this.qtynum.Size = new System.Drawing.Size(81, 20);
            this.qtynum.TabIndex = 1;
            // 
            // deletebtn
            // 
            this.deletebtn.FlatAppearance.BorderSize = 3;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Location = new System.Drawing.Point(101, 162);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(81, 30);
            this.deletebtn.TabIndex = 2;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            // 
            // DeleteQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.qtynum);
            this.Controls.Add(this.qtylabel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DeleteQuantity";
            this.Text = "Delete Quantity";
            ((System.ComponentModel.ISupportInitialize)(this.qtynum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label qtylabel;
        private System.Windows.Forms.NumericUpDown qtynum;
        private System.Windows.Forms.Button deletebtn;
    }
}