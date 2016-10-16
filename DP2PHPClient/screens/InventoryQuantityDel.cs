using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP2PHPClient.screens
{
    public partial class InventoryQuantityDel : Form
    {
        Model _model;

        public InventoryQuantityDel(Model model, int selected)
        {
            InitializeComponent();

            _model = model;

            cmb_name.Enabled = false;

            _model.PopulateComboBox(cmb_name);

            if ((selected >= 0) && (selected < cmb_name.Items.Count))
                cmb_name.SelectedIndex = selected;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            _model.DecrementStock(cmb_name.SelectedIndex, int.Parse(txt_qty.Text));
            this.Close();
        }
    }
}
