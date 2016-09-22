using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        Inventory i2;
        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (i2 == null)
            {
                i2 = new Inventory();
                i2.MdiParent = this;
                i2.FormClosed += new FormClosedEventHandler(i2_FormClosed);
                i2.Show();

            }
        else
            i2.Activate();
        }
        void i2_FormClosed(object sender, FormClosedEventArgs e)
        {
            i2 = null;

        }
        Sales s2;
        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (s2 == null)
            {
                s2 = new Sales();
                s2.MdiParent = this;
                s2.FormClosed += new FormClosedEventHandler(s2_FormClosed);
                s2.Show();

            }
            else
                s2.Activate();
        }
        void s2_FormClosed(object sender, FormClosedEventArgs e)
        {
            s2 = null;

        }
        
        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }
    
    
    

