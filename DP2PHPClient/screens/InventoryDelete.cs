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
    public partial class InventoryDelete : Form
    {
        Model _model;

        public InventoryDelete(Model model)
        {
            InitializeComponent();

            _model = model;

            _model.PopulateComboBox(cmb_name);
        }
        
        public InventoryDelete(Model model, int selected)
        {
            InitializeComponent();

            _model = model;

            _model.PopulateComboBox(cmb_name);

            if ((selected >= 0) && (selected < cmb_name.Items.Count))
                cmb_name.SelectedItem = selected;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            _model.DeleteStock(cmb_name.SelectedIndex);
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
