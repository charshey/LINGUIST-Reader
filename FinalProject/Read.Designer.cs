namespace FinalProject
{
    partial class frmRead
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
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("All");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("FYI");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Media");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Notice Board");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Announcements", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Internships");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Jobs");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Supports");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Careers", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode34,
            treeNode35});
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Discussions");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Queries");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Summaries");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Discussion", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38,
            treeNode39});
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Conferences");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Local Events");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Summer Schools");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Events", new System.Windows.Forms.TreeNode[] {
            treeNode41,
            treeNode42,
            treeNode43});
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Books");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Calls for Papers");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Dissertations");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Journals");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Papers");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Publishers");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Reviews");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Software");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Tables of Contents");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Publications", new System.Windows.Forms.TreeNode[] {
            treeNode45,
            treeNode46,
            treeNode47,
            treeNode48,
            treeNode49,
            treeNode50,
            treeNode51,
            treeNode52,
            treeNode53});
            this.browseWindow = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeAreaList = new System.Windows.Forms.TreeView();
            this.btnExpandAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browseWindow
            // 
            this.browseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browseWindow.Location = new System.Drawing.Point(440, 12);
            this.browseWindow.MinimumSize = new System.Drawing.Size(20, 20);
            this.browseWindow.Name = "browseWindow";
            this.browseWindow.Size = new System.Drawing.Size(658, 525);
            this.browseWindow.TabIndex = 3;
            this.browseWindow.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(214, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 525);
            this.panel1.TabIndex = 4;
            // 
            // treeAreaList
            // 
            this.treeAreaList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeAreaList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeAreaList.CheckBoxes = true;
            this.treeAreaList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeAreaList.Indent = 15;
            this.treeAreaList.Location = new System.Drawing.Point(12, 12);
            this.treeAreaList.Name = "treeAreaList";
            treeNode28.Name = "nodeAll";
            treeNode28.Text = "All";
            treeNode29.Name = "nodeFYI";
            treeNode29.Text = "FYI";
            treeNode30.Name = "nodeMedia";
            treeNode30.Text = "Media";
            treeNode31.Name = "nodeNoticeBoard";
            treeNode31.Text = "Notice Board";
            treeNode32.Name = "nodeAnnouncements";
            treeNode32.Text = "Announcements";
            treeNode33.Name = "nodeInternships";
            treeNode33.Text = "Internships";
            treeNode34.Name = "nodeJobs";
            treeNode34.Text = "Jobs";
            treeNode35.Name = "nodeSupports";
            treeNode35.Text = "Supports";
            treeNode36.Name = "nodeCareers";
            treeNode36.Text = "Careers";
            treeNode37.Name = "nodeDisccusions";
            treeNode37.Text = "Discussions";
            treeNode38.Name = "nodeQueries";
            treeNode38.Text = "Queries";
            treeNode39.Name = "nodeSummaries";
            treeNode39.Text = "Summaries";
            treeNode40.Name = "nodeDiscussion";
            treeNode40.Text = "Discussion";
            treeNode41.Name = "nodeConferences";
            treeNode41.Text = "Conferences";
            treeNode42.Name = "nodeLocalEvents";
            treeNode42.Text = "Local Events";
            treeNode43.Name = "nodeSummerSchools";
            treeNode43.Text = "Summer Schools";
            treeNode44.Name = "nodeEvents";
            treeNode44.Text = "Events";
            treeNode45.Name = "nodeBooks";
            treeNode45.Text = "Books";
            treeNode46.Name = "nodeCalls";
            treeNode46.Text = "Calls for Papers";
            treeNode47.Name = "nodeDiss";
            treeNode47.Text = "Dissertations";
            treeNode48.Name = "nodeJournals";
            treeNode48.Text = "Journals";
            treeNode49.Name = "nodePapers";
            treeNode49.Text = "Papers";
            treeNode50.Name = "nodePublishers";
            treeNode50.Text = "Publishers";
            treeNode51.Name = "nodeReviews";
            treeNode51.Text = "Reviews";
            treeNode52.Name = "nodeSoftware";
            treeNode52.Text = "Software";
            treeNode53.Name = "nodeTOCs";
            treeNode53.Text = "Tables of Contents";
            treeNode54.Name = "nodePubs";
            treeNode54.Text = "Publications";
            this.treeAreaList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode36,
            treeNode40,
            treeNode44,
            treeNode54});
            this.treeAreaList.ShowLines = false;
            this.treeAreaList.Size = new System.Drawing.Size(193, 525);
            this.treeAreaList.TabIndex = 5;
            // 
            // btnExpandAll
            // 
            this.btnExpandAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpandAll.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpandAll.Location = new System.Drawing.Point(12, 543);
            this.btnExpandAll.Name = "btnExpandAll";
            this.btnExpandAll.Size = new System.Drawing.Size(193, 31);
            this.btnExpandAll.TabIndex = 8;
            this.btnExpandAll.Text = "Expand All";
            this.btnExpandAll.UseVisualStyleBackColor = true;
            this.btnExpandAll.Click += new System.EventHandler(this.btnExpandAll_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAll.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAll.Location = new System.Drawing.Point(12, 580);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(193, 31);
            this.btnSelectAll.TabIndex = 9;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(920, 580);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 31);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save this Issue";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 623);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnExpandAll);
            this.Controls.Add(this.treeAreaList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.browseWindow);
            this.Name = "frmRead";
            this.Text = "Read";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser browseWindow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeAreaList;
        private System.Windows.Forms.Button btnExpandAll;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnSave;
    }
}