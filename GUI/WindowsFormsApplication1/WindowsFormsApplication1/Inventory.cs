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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        NewItem N;
        private void button1_Click(object sender, EventArgs e)
        {
            if (N == null)
            {
                N = new NewItem();
                N.FormClosed += new FormClosedEventHandler(N_FormClosed);
                N.Show();

            }
            else
                N.Activate();
        }
        void N_FormClosed(object sender, FormClosedEventArgs e)
        {
            N = null;

        }

        edititem E;
        private void editbtn_Click(object sender, EventArgs e)
        {
            if (E == null)
            {
                E = new edititem();
                E.FormClosed += new FormClosedEventHandler(E_FormClosed);
                E.Show();

            }
            else
                E.Activate();
        }
        void E_FormClosed(object sender, FormClosedEventArgs e)
        {
            E = null;

        }

        deleteitem D;
        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (D == null)
            {
                D = new deleteitem();
                D.FormClosed += new FormClosedEventHandler(D_FormClosed);
                D.Show();

            }
            else
                D.Activate();
        }
        void D_FormClosed(object sender, FormClosedEventArgs e)
        {
            D = null;

        }
    }
}
