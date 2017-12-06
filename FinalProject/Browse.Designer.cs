namespace FinalProject
{
    partial class frmBrowse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("All");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("FYI");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Media");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Notice Board");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Announcements", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Internships");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Jobs");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Supports");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Careers", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Discussions");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Queries");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Summaries");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Discussion", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Conferences");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Local Events");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Summer Schools");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Events", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Books");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Calls for Papers");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Dissertations");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Journals");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Papers");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Publishers");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Reviews");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Software");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Tables of Contents");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Publications", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowse));
            this.panel1 = new System.Windows.Forms.Panel();
            this.browseWindow = new System.Windows.Forms.WebBrowser();
            this.btnSave = new System.Windows.Forms.Button();
            this.treeAreaList = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(160, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 445);
            this.panel1.TabIndex = 1;
            // 
            // browseWindow
            // 
            this.browseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browseWindow.Location = new System.Drawing.Point(308, 0);
            this.browseWindow.MinimumSize = new System.Drawing.Size(20, 20);
            this.browseWindow.Name = "browseWindow";
            this.browseWindow.Size = new System.Drawing.Size(609, 398);
            this.browseWindow.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(739, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save this Issue";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // treeAreaList
            // 
            this.treeAreaList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeAreaList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeAreaList.CheckBoxes = true;
            this.treeAreaList.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeAreaList.Indent = 15;
            this.treeAreaList.Location = new System.Drawing.Point(0, 0);
            this.treeAreaList.Name = "treeAreaList";
            treeNode1.Name = "nodeAll";
            treeNode1.Text = "All";
            treeNode2.Name = "nodeFYI";
            treeNode2.Text = "FYI";
            treeNode3.Name = "nodeMedia";
            treeNode3.Text = "Media";
            treeNode4.Name = "nodeNoticeBoard";
            treeNode4.Text = "Notice Board";
            treeNode5.Name = "nodeAnnouncements";
            treeNode5.Text = "Announcements";
            treeNode6.Name = "nodeInternships";
            treeNode6.Text = "Internships";
            treeNode7.Name = "nodeJobs";
            treeNode7.Text = "Jobs";
            treeNode8.Name = "nodeSupports";
            treeNode8.Text = "Supports";
            treeNode9.Name = "nodeCareers";
            treeNode9.Text = "Careers";
            treeNode10.Name = "nodeDisccusions";
            treeNode10.Text = "Discussions";
            treeNode11.Name = "nodeQueries";
            treeNode11.Text = "Queries";
            treeNode12.Name = "nodeSummaries";
            treeNode12.Text = "Summaries";
            treeNode13.Name = "nodeDiscussion";
            treeNode13.Text = "Discussion";
            treeNode14.Name = "nodeConferences";
            treeNode14.Text = "Conferences";
            treeNode15.Name = "nodeLocalEvents";
            treeNode15.Text = "Local Events";
            treeNode16.Name = "nodeSummerSchools";
            treeNode16.Text = "Summer Schools";
            treeNode17.Name = "nodeEvents";
            treeNode17.Text = "Events";
            treeNode18.Name = "nodeBooks";
            treeNode18.Text = "Books";
            treeNode19.Name = "nodeCalls";
            treeNode19.Text = "Calls for Papers";
            treeNode20.Name = "nodeDiss";
            treeNode20.Text = "Dissertations";
            treeNode21.Name = "nodeJournals";
            treeNode21.Text = "Journals";
            treeNode22.Name = "nodePapers";
            treeNode22.Text = "Papers";
            treeNode23.Name = "nodePublishers";
            treeNode23.Text = "Publishers";
            treeNode24.Name = "nodeReviews";
            treeNode24.Text = "Reviews";
            treeNode25.Name = "nodeSoftware";
            treeNode25.Text = "Software";
            treeNode26.Name = "nodeTOCs";
            treeNode26.Text = "Tables of Contents";
            treeNode27.Name = "nodePubs";
            treeNode27.Text = "Publications";
            this.treeAreaList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode9,
            treeNode13,
            treeNode17,
            treeNode27});
            this.treeAreaList.ShowLines = false;
            this.treeAreaList.Size = new System.Drawing.Size(154, 435);
            this.treeAreaList.TabIndex = 4;
            // 
            // frmBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 438);
            this.Controls.Add(this.treeAreaList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.browseWindow);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBrowse";
            this.Text = "Browse";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser browseWindow;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TreeView treeAreaList;
    }
}