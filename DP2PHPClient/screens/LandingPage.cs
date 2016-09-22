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
        ClientConnectionManager _connection;

        public LandingPage()
        {
            InitializeComponent();

            btn_start.Enabled = false;

            Connect();
        }

        private void Connect()
        {
            _connection = new ClientConnectionManager("127.0.0.1", 25565);

            if (_connection.ConnectToServer())
            {
                lbl_connect.Text = "Connection successful.";
                btn_start.Enabled = true;
            }
            else
            {
                lbl_connect.Text = "Connection failed.";
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            this.Hide();
            new screens.Sales(_connection).Show();
        }

    }
}
