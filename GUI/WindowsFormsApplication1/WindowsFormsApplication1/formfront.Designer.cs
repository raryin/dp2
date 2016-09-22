namespace WindowsFormsApplication1
{
    partial class frmfront
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
            this.labelphp = new System.Windows.Forms.Label();
            this.getstarted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelphp
            // 
            this.labelphp.AutoSize = true;
            this.labelphp.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold);
            this.labelphp.Location = new System.Drawing.Point(327, 202);
            this.labelphp.Name = "labelphp";
            this.labelphp.Size = new System.Drawing.Size(376, 42);
            this.labelphp.TabIndex = 0;
            this.labelphp.Text = "People Health Pharmacy";
            this.labelphp.Click += new System.EventHandler(this.label1_Click);
            // 
            // getstarted
            // 
            this.getstarted.BackColor = System.Drawing.SystemColors.HotTrack;
            this.getstarted.FlatAppearance.BorderSize = 3;
            this.getstarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getstarted.Font = new System.Drawing.Font("Calibri", 16F);
            this.getstarted.Location = new System.Drawing.Point(427, 284);
            this.getstarted.Name = "getstarted";
            this.getstarted.Size = new System.Drawing.Size(134, 46);
            this.getstarted.TabIndex = 1;
            this.getstarted.Text = "Get Started";
            this.getstarted.UseVisualStyleBackColor = false;
            this.getstarted.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmfront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.getstarted);
            this.Controls.Add(this.labelphp);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmfront";
            this.Text = "People Health Pharmacy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelphp;
        private System.Windows.Forms.Button getstarted;
    }
}

