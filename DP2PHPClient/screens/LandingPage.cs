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
    public partial class LandingPage : Form
    {
        Model _model;

        public LandingPage(Model model)
        {
            InitializeComponent();

            _model = model;

            _model.ConnectToServer();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            _model.UpdateScreen(new screens.Sales(_model));
        }

    }
}
