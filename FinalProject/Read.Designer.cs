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
            System.Windows.Forms.TreeNode treeNode163 = new System.Windows.Forms.TreeNode("All");
            System.Windows.Forms.TreeNode treeNode164 = new System.Windows.Forms.TreeNode("FYI");
            System.Windows.Forms.TreeNode treeNode165 = new System.Windows.Forms.TreeNode("Media");
            System.Windows.Forms.TreeNode treeNode166 = new System.Windows.Forms.TreeNode("Notice Board");
            System.Windows.Forms.TreeNode treeNode167 = new System.Windows.Forms.TreeNode("Announcements", new System.Windows.Forms.TreeNode[] {
            treeNode163,
            treeNode164,
            treeNode165,
            treeNode166});
            System.Windows.Forms.TreeNode treeNode168 = new System.Windows.Forms.TreeNode("Internships");
            System.Windows.Forms.TreeNode treeNode169 = new System.Windows.Forms.TreeNode("Jobs");
            System.Windows.Forms.TreeNode treeNode170 = new System.Windows.Forms.TreeNode("Supports");
            System.Windows.Forms.TreeNode treeNode171 = new System.Windows.Forms.TreeNode("Careers", new System.Windows.Forms.TreeNode[] {
            treeNode168,
            treeNode169,
            treeNode170});
            System.Windows.Forms.TreeNode treeNode172 = new System.Windows.Forms.TreeNode("Discussions");
            System.Windows.Forms.TreeNode treeNode173 = new System.Windows.Forms.TreeNode("Queries");
            System.Windows.Forms.TreeNode treeNode174 = new System.Windows.Forms.TreeNode("Summaries");
            System.Windows.Forms.TreeNode treeNode175 = new System.Windows.Forms.TreeNode("Discussion", new System.Windows.Forms.TreeNode[] {
            treeNode172,
            treeNode173,
            treeNode174});
            System.Windows.Forms.TreeNode treeNode176 = new System.Windows.Forms.TreeNode("Conferences");
            System.Windows.Forms.TreeNode treeNode177 = new System.Windows.Forms.TreeNode("Local Events");
            System.Windows.Forms.TreeNode treeNode178 = new System.Windows.Forms.TreeNode("Summer Schools");
            System.Windows.Forms.TreeNode treeNode179 = new System.Windows.Forms.TreeNode("Events", new System.Windows.Forms.TreeNode[] {
            treeNode176,
            treeNode177,
            treeNode178});
            System.Windows.Forms.TreeNode treeNode180 = new System.Windows.Forms.TreeNode("Books");
            System.Windows.Forms.TreeNode treeNode181 = new System.Windows.Forms.TreeNode("Calls for Papers");
            System.Windows.Forms.TreeNode treeNode182 = new System.Windows.Forms.TreeNode("Dissertations");
            System.Windows.Forms.TreeNode treeNode183 = new System.Windows.Forms.TreeNode("Journals");
            System.Windows.Forms.TreeNode treeNode184 = new System.Windows.Forms.TreeNode("Papers");
            System.Windows.Forms.TreeNode treeNode185 = new System.Windows.Forms.TreeNode("Publishers");
            System.Windows.Forms.TreeNode treeNode186 = new System.Windows.Forms.TreeNode("Reviews");
            System.Windows.Forms.TreeNode treeNode187 = new System.Windows.Forms.TreeNode("Software");
            System.Windows.Forms.TreeNode treeNode188 = new System.Windows.Forms.TreeNode("Tables of Contents");
            System.Windows.Forms.TreeNode treeNode189 = new System.Windows.Forms.TreeNode("Publications", new System.Windows.Forms.TreeNode[] {
            treeNode180,
            treeNode181,
            treeNode182,
            treeNode183,
            treeNode184,
            treeNode185,
            treeNode186,
            treeNode187,
            treeNode188});
            this.browseWindow = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeAreaList = new System.Windows.Forms.TreeView();
            this.btnExpandAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browseWindow
            // 
            this.browseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browseWindow.Location = new System.Drawing.Point(425, -1);
            this.browseWindow.MinimumSize = new System.Drawing.Size(20, 20);
            this.browseWindow.Name = "browseWindow";
            this.browseWindow.Size = new System.Drawing.Size(673, 504);
            this.browseWindow.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(199, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 504);
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
            this.treeAreaList.Location = new System.Drawing.Point(0, -1);
            this.treeAreaList.Name = "treeAreaList";
            treeNode163.Name = "nodeAll";
            treeNode163.Text = "All";
            treeNode164.Name = "nodeFYI";
            treeNode164.Text = "FYI";
            treeNode165.Name = "nodeMedia";
            treeNode165.Text = "Media";
            treeNode166.Name = "nodeNoticeBoard";
            treeNode166.Text = "Notice Board";
            treeNode167.Name = "nodeAnnouncements";
            treeNode167.Text = "Announcements";
            treeNode168.Name = "nodeInternships";
            treeNode168.Text = "Internships";
            treeNode169.Name = "nodeJobs";
            treeNode169.Text = "Jobs";
            treeNode170.Name = "nodeSupports";
            treeNode170.Text = "Supports";
            treeNode171.Name = "nodeCareers";
            treeNode171.Text = "Careers";
            treeNode172.Name = "nodeDisccusions";
            treeNode172.Text = "Discussions";
            treeNode173.Name = "nodeQueries";
            treeNode173.Text = "Queries";
            treeNode174.Name = "nodeSummaries";
            treeNode174.Text = "Summaries";
            treeNode175.Name = "nodeDiscussion";
            treeNode175.Text = "Discussion";
            treeNode176.Name = "nodeConferences";
            treeNode176.Text = "Conferences";
            treeNode177.Name = "nodeLocalEvents";
            treeNode177.Text = "Local Events";
            treeNode178.Name = "nodeSummerSchools";
            treeNode178.Text = "Summer Schools";
            treeNode179.Name = "nodeEvents";
            treeNode179.Text = "Events";
            treeNode180.Name = "nodeBooks";
            treeNode180.Text = "Books";
            treeNode181.Name = "nodeCalls";
            treeNode181.Text = "Calls for Papers";
            treeNode182.Name = "nodeDiss";
            treeNode182.Text = "Dissertations";
            treeNode183.Name = "nodeJournals";
            treeNode183.Text = "Journals";
            treeNode184.Name = "nodePapers";
            treeNode184.Text = "Papers";
            treeNode185.Name = "nodePublishers";
            treeNode185.Text = "Publishers";
            treeNode186.Name = "nodeReviews";
            treeNode186.Text = "Reviews";
            treeNode187.Name = "nodeSoftware";
            treeNode187.Text = "Software";
            treeNode188.Name = "nodeTOCs";
            treeNode188.Text = "Tables of Contents";
            treeNode189.Name = "nodePubs";
            treeNode189.Text = "Publications";
            this.treeAreaList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode167,
            treeNode171,
            treeNode175,
            treeNode179,
            treeNode189});
            this.treeAreaList.ShowLines = false;
            this.treeAreaList.Size = new System.Drawing.Size(193, 504);
            this.treeAreaList.TabIndex = 5;
            // 
            // btnExpandAll
            // 
            this.btnExpandAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpandAll.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpandAll.Location = new System.Drawing.Point(0, 509);
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
            this.btnSelectAll.Location = new System.Drawing.Point(0, 546);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(193, 31);
            this.btnSelectAll.TabIndex = 9;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(0, 583);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(193, 31);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
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
            // Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 623);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnExpandAll);
            this.Controls.Add(this.treeAreaList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.browseWindow);
            this.Name = "Read";
            this.Text = "Read";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser browseWindow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeAreaList;
        private System.Windows.Forms.Button btnExpandAll;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
    }
}