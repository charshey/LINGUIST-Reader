using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmBrowse : Form
    {
        private bool expanded;
        private bool selectedAll;
        private List<TreeNode> checkedNodes;
        private Database issuesDB;

        private Issue focus;

        public frmBrowse(Database db)
        {
            InitializeComponent();
            expanded = false;
            selectedAll = false;
            checkedNodes = new List<TreeNode>();
            browseWindow.ScriptErrorsSuppressed = true;
            btnSave.Enabled = false;
            issuesDB = db;

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

            panelPreview_Update();

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

        private void panelPreview_Update()
        {
            List<Control> controls = new List<Control>();
            foreach(Control control in panelPreview.Controls)
            {
                controls.Add(control);
            }
            panelPreview.Controls.Clear();
            foreach(Control control in controls)
            {
                control.Dispose();
            }

            this.getCheckedNodes(treeAreaList);

                foreach(TreeNode node in this.checkedNodes)
                {
                    foreach(Issue issue in issuesDB.getIssues(node.Text))
                    {
                        Button b = new Button();
                        b.Text = issue.getTitle();

                        b.BackColor = System.Drawing.SystemColors.Window;
                        b.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        b.Size = new System.Drawing.Size(220, 128);
                        b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        b.UseVisualStyleBackColor = false;
                        b.Click += new EventHandler(this.B_Click);
                        b.Tag = issue;
                    

                        panelPreview.Controls.Add(b);
                    }
                }
        }

        private void B_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = System.Drawing.SystemColors.ButtonFace;
            focus = (Issue)b.Tag;
            this.loadIssue(focus);
            btnSave.Enabled = true;
        }

        private void loadIssue(Issue issue)
        {
            this.browseWindow.Navigate(issue.getURI());
        }

        private void getCheckedNodes(TreeView tree)
        {
            foreach(TreeNode node in tree.Nodes)
            {
                if (node.Nodes.Count > 0)
                {
                    foreach(TreeNode childNode in node.Nodes)
                    {
                        if(childNode.Checked)
                        {
                            checkedNodes.Add(childNode);
                        }
                    }
                }

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmSaveIssue saveWindow = new frmSaveIssue(focus);
            saveWindow.ShowDialog();
        }
    }
}
