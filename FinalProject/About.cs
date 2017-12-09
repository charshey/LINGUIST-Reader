using System;
using System.Diagnostics;
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
    /// <summary>
    /// This box displays some information about this program and has a mailto link to the creator.
    /// </summary>
    public partial class frmAbout : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmAbout"/> class.
        /// </summary>
        public frmAbout()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the btnClose control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Handles the LinkClicked event of the linkEmail control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void linkEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string command = "mailto:clare[at]linguistlist.org?subject=LINGUIST List Reader";
            Process.Start(command);
        }
    }
}
