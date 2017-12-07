using System;
using System.IO;
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
    public partial class frmBrowse : Form
    {
        private bool expanded;
        private bool selectedAll;
        private Database issues;

        public frmBrowse()
        {
            InitializeComponent();
            expanded = false;
            selectedAll = false;
            string path = Path.GetFullPath(Path.Combine(System.IO.Directory.GetCurrentDirectory(),@"..\..\..\")) + @"\Issues";
            issues = new Database(path);
        }

        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach(TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if(node.Nodes.Count > 0)
                {
                    this.CheckAllChildNodes(node, nodeChecked);
                }
                
            }
        }

        private void treeAreaList_AfterCheck(object sender, TreeViewEventArgs e)
        {
                if (e.Action != TreeViewAction.Unknown)
                {
                    if (e.Node.Nodes.Count > 0)
                    {
                        this.CheckAllChildNodes(e.Node, e.Node.Checked);
                    }
                }

        }

        private void btnExpandAll_Click(object sender, EventArgs e)
        {
            if (!expanded)
            {
                treeAreaList.ExpandAll();
                btnExpandAll.Text = "Collapse All";
            }
            if(expanded)
            {
                treeAreaList.CollapseAll();
                btnExpandAll.Text = "Expand All";
            }

            expanded = !expanded;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {

            if (!selectedAll)
            {
                foreach (TreeNode node in treeAreaList.Nodes)
                {
                    node.Checked = true;
                    this.CheckAllChildNodes(node, true);
                }

                btnSelectAll.Text = "Clear All";

            }

            if(selectedAll)
            {
                foreach (TreeNode node in treeAreaList.Nodes)
                {
                    node.Checked = false;
                    this.CheckAllChildNodes(node, false);
                }

                btnSelectAll.Text = "Select All";

            }

            selectedAll = !selectedAll;

        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelPreview_Paint(object sender, PaintEventArgs e)
        {
            foreach(TreeNode node in treeAreaList.Nodes)
            {
                if(node.Checked)
                {
                    foreach(Issue issue in issues.getIssues(node.Text))
                    {
                        Button b = new Button();
                        b.Text = issue.getTitle();
                        panelPreview.Controls.Add(b);
                    }
                }
            }
        }
    }
}
