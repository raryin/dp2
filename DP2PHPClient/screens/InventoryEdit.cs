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
    public partial class InventoryEdit : Form
    {
        Model _model;

        public InventoryEdit(Model model)
        {
            InitializeComponent();

            _model = model;

            _model.PopulateComboBox(cmb_name);
        }

        public InventoryEdit(Model model, int selected)
        {
            InitializeComponent();

            _model = model;

            _model.PopulateComboBox(cmb_name);

            cmb_name.Enabled = false;

            if ((selected >= 0) && (selected < cmb_name.Items.Count))
                cmb_name.SelectedIndex = selected;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            _model.RefreshStockList(cmb_name.SelectedIndex, int.Parse(txt_qty.Text));

            this.Close();
        }
    }
}
