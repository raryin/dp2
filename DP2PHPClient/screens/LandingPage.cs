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
        bool success = false;

        public LandingPage(Model model)
        {
            InitializeComponent();

            _model = model;

            success = _model.ConnectToServer();

            UpdateButton();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (success)
                _model.UpdateScreen(new screens.Sales(_model));
            else
            {
                success = _model.ConnectToServer();
            }

            UpdateButton();

        }

        private void UpdateButton()
        {
            if (success)
                btn_start.Text = "Get Started";
            else
                btn_start.Text = "Retry connection";
        }

    }
}
