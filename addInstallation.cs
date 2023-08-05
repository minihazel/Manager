using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class addInstallation : Form
    {
        public string currentDir = Environment.CurrentDirectory;
        public string installPath { get; set; }

        public addInstallation()
        {
            InitializeComponent();
        }

        private void addInstallation_Load(object sender, EventArgs e)
        {

        }

        private void btnAddInstallation_Click(object sender, EventArgs e)
        {
            string installation = txtURL.Text;
            bool countNon = bool.Parse(cmbCountNonSPT.Text.ToLower());


        }
    }
}
