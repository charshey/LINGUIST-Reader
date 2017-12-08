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
    public partial class frmSaveIssue : Form
    {
        private Issue thisIssue;

        public frmSaveIssue(Issue focus)
        {
            InitializeComponent();
            thisIssue = focus;
            commentBox.Text = thisIssue.getComment();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            thisIssue.setComment(this.commentBox.Text);
            this.label1.Visible = true;



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
