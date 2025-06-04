using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAccounting
{
    public partial class GreetingForm : Form
    {
        public GreetingForm()
        {
            InitializeComponent();
            // Center the label text if it's not done in Designer
            this.lblWelcome.Location = new System.Drawing.Point((this.ClientSize.Width - lblWelcome.Width) / 2, 30);
        }

        private void BtnOpenApp_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.FormClosed += (s, args) => this.Close(); // Close greeting form when main form closes
            mainForm.Show();
            this.Hide(); // Hide greeting form instead of closing, so app doesn't exit if main form is opened then closed.
        }

        private void BtnDocumentation_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(".\\Руководство.html");
        }

        private void BtnCloseMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
