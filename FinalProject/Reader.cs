using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Reader : Form
    {
        public Reader()
        {
            InitializeComponent();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout aboutWindow = new frmAbout();
            aboutWindow.Show();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            frmBrowse browseWindow = new frmBrowse();
            browseWindow.Show();
        }

        private void btnMyIssues_Click(object sender, EventArgs e)
        {
            
        }
    }
}
