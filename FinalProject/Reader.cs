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
    /// <summary>
    /// Class Reader is the main form for the LINGUIST List reader application.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Reader : Form
    {
        /// <summary>
        /// The issues database being manipulated.
        /// </summary>
        private Database issuesDB;

        /// <summary>
        /// Initializes a new instance of the <see cref="Reader"/> class.
        /// </summary>
        /// <param name="db">The database being manipulated.</param>
        public Reader(Database db)
        {
            // initialize and set the database.
            InitializeComponent();
            issuesDB = db;
        }

        /// <summary>
        /// Handles the Click event of the Quit button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            // close window gracefully.
            Close();
        }

        /// <summary>
        /// Handles the Click event of the About button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            // create a new about window and show it.
            frmAbout aboutWindow = new frmAbout();
            aboutWindow.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the Browse button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // create a new browse window and show it.
            frmBrowse browseWindow = new frmBrowse(issuesDB);
            browseWindow.Show();
        }

    }
}
