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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowse));
            this.browseWindow = new System.Windows.Forms.WebBrowser();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.areaPanel = new System.Windows.Forms.Panel();
            this.Software = new System.Windows.Forms.CheckBox();
            this.Diss = new System.Windows.Forms.CheckBox();
            this.TOC = new System.Windows.Forms.CheckBox();
            this.Calls = new System.Windows.Forms.CheckBox();
            this.checkBooks = new System.Windows.Forms.CheckBox();
            this.Review = new System.Windows.Forms.CheckBox();
            this.summerSchools = new System.Windows.Forms.CheckBox();
            this.Confs = new System.Windows.Forms.CheckBox();
            this.Qs = new System.Windows.Forms.CheckBox();
            this.Disc = new System.Windows.Forms.CheckBox();
            this.Sum = new System.Windows.Forms.CheckBox();
            this.checkInternships = new System.Windows.Forms.CheckBox();
            this.checkJobs = new System.Windows.Forms.CheckBox();
            this.Support = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.FYIs = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelPubs = new System.Windows.Forms.Label();
            this.labelEvents = new System.Windows.Forms.Label();
            this.labelDiscussion = new System.Windows.Forms.Label();
            this.labelCareers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStar = new System.Windows.Forms.Button();
            this.notesBox = new System.Windows.Forms.RichTextBox();
            this.btnSaveNotes = new System.Windows.Forms.Button();
            this.lblNotesSaved = new System.Windows.Forms.Label();
            this.btnShowBookmarked = new System.Windows.Forms.Button();
            this.panelPreview = new FinalProject.DBFlowLayoutPanel();
            this.areaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseWindow
            // 
            this.browseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browseWindow.Location = new System.Drawing.Point(504, 12);
            this.browseWindow.MinimumSize = new System.Drawing.Size(20, 20);
            this.browseWindow.Name = "browseWindow";
            this.browseWindow.Size = new System.Drawing.Size(710, 593);
            this.browseWindow.TabIndex = 2;
            this.browseWindow.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectAll.BackColor = System.Drawing.SystemColors.Window;
            this.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectAll.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAll.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSelectAll.Location = new System.Drawing.Point(12, 611);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(227, 29);
            this.btnSelectAll.TabIndex = 5;
            this.btnSelectAll.Text = "Select All Areas";
            this.btnSelectAll.UseVisualStyleBackColor = false;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseWindow.BackColor = System.Drawing.SystemColors.Window;
            this.btnCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWindow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseWindow.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCloseWindow.Location = new System.Drawing.Point(1036, 646);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(178, 30);
            this.btnCloseWindow.TabIndex = 13;
            this.btnCloseWindow.Text = "Close Window";
            this.btnCloseWindow.UseVisualStyleBackColor = false;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // areaPanel
            // 
            this.areaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.areaPanel.BackColor = System.Drawing.SystemColors.Window;
            this.areaPanel.Controls.Add(this.Software);
            this.areaPanel.Controls.Add(this.Diss);
            this.areaPanel.Controls.Add(this.TOC);
            this.areaPanel.Controls.Add(this.Calls);
            this.areaPanel.Controls.Add(this.checkBooks);
            this.areaPanel.Controls.Add(this.Review);
            this.areaPanel.Controls.Add(this.summerSchools);
            this.areaPanel.Controls.Add(this.Confs);
            this.areaPanel.Controls.Add(this.Qs);
            this.areaPanel.Controls.Add(this.Disc);
            this.areaPanel.Controls.Add(this.Sum);
            this.areaPanel.Controls.Add(this.checkInternships);
            this.areaPanel.Controls.Add(this.checkJobs);
            this.areaPanel.Controls.Add(this.Support);
            this.areaPanel.Controls.Add(this.checkBox3);
            this.areaPanel.Controls.Add(this.FYIs);
            this.areaPanel.Controls.Add(this.checkBox1);
            this.areaPanel.Controls.Add(this.labelPubs);
            this.areaPanel.Controls.Add(this.labelEvents);
            this.areaPanel.Controls.Add(this.labelDiscussion);
            this.areaPanel.Controls.Add(this.labelCareers);
            this.areaPanel.Controls.Add(this.label1);
            this.areaPanel.Location = new System.Drawing.Point(12, 12);
            this.areaPanel.Name = "areaPanel";
            this.areaPanel.Size = new System.Drawing.Size(227, 593);
            this.areaPanel.TabIndex = 15;
            // 
            // Software
            // 
            this.Software.AutoSize = true;
            this.Software.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Software.Location = new System.Drawing.Point(12, 487);
            this.Software.Name = "Software";
            this.Software.Size = new System.Drawing.Size(74, 19);
            this.Software.TabIndex = 28;
            this.Software.Text = "Software";
            this.Software.UseVisualStyleBackColor = true;
            this.Software.CheckedChanged += new System.EventHandler(this.anyBox_Checked);
            // 
            // Diss
            // 
            this.Diss.AutoSize = true;
            this.Diss.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diss.Location = new System.Drawing.Point(95, 487);
            this.Diss.Name = "Diss";
            this.Diss.Size = new System.Drawing.Size(100, 19);
            this.Diss.TabIndex = 26;
            this.Diss.Text = "Dissertations";
            this.Diss.UseVisualStyleBackColor = true;
            this.Diss.CheckedChanged += new System.EventHandler(this.anyBox_Checked);
            // 
            // TOC
            // 
            this.TOC.AutoSize = true;
            this.TOC.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOC.Location = new System.Drawing.Point(12, 462);
            this.TOC.Name = "TOC";
            this.TOC.Size = new System.Drawing.Size(58, 19);
            this.TOC.TabIndex = 25;
            this.TOC.Text = "TOCs";
            this.TOC.UseVisualStyleBackColor = true;
            this.TOC.CheckedChanged += new System.EventHandler(this.anyBox_Checked);
            // 
            // Calls
            // 
            this.Calls.AutoSize = true;
            this.Calls.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calls.Location = new System.Drawing.Point(95, 462);
            this.Calls.Name = "Calls";
            this.Calls.Size = new System.Drawing.Size(115, 19);
            this.Calls.TabIndex = 24;
            this.Calls.Text = "Calls for Papers";
            this.Calls.UseVisualStyleBackColor = true;
            this.Calls.CheckedChanged += new System.EventHandler(this.anyBox_Checked);
            // 
            // checkBooks
            // 
            this.checkBooks.AutoSize = true;
            this.checkBooks.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBooks.Location = new System.Drawing.Point(12, 437);
            this.checkBooks.Name = "checkBooks";
            this.checkBooks.Size = new System.Drawing.Size(61, 19);
            this.checkBooks.TabIndex = 21;
            this.checkBooks.Text = "Books";
            this.checkBooks.UseVisualStyleBackColor = true;
            this.checkBooks.CheckedChanged += new System.EventHandler(this.anyBox_Checked);
            // 
            // Review
            // 
            this.Review.AutoSize = true;
            this.Review.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Review.Location = new System.Drawing.Point(95, 437);
            this.Review.Name = "Review";
            this.Review.Size = new System.Drawing.Size(73, 19);
            this.Review.TabIndex = 20;
            this.Review.Text = "Reviews";
            this.Review.UseVisualStyleBackColor = true;
            this.Review.CheckedChanged += new System.EventHandler(this.anyBox_Checked);
            // 
            // summerSchools
            // 
            this.summerSchools.AutoSize = true;
            this.summerSchools.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summerSchools.Location = new System.Drawing.Point(12, 362);
            this.summerSchools.Name = "summerSchools";
            this.summerSchools.Size = new System.Drawing.Size(122, 19);
            this.summerSchools.TabIndex = 19;
            this.summerSchools.Text = "Summer Schools";
            this.summerSchools.UseVisualStyleBackColor = true;
            this.summerSchools.CheckedChanged += new System.EventHandler(this.anyBox_Checked);
            // 
            // Confs
            // 
            this.Confs.AutoSize = true;
            this.Confs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confs.Location = new System.Drawing.Point(12, 337);
            this.Confs.Name = "Confs";
            this.Confs.Size = new System.Drawing.Size(97, 19);
            this.Confs.TabIndex = 17;
            this.Confs.Text = "Conferences";
            this.Confs.UseVisualStyleBackColor = true;
            this.Confs.CheckedChanged += new System.EventHandler(this.anyBox_Checked);
            // 
            // Qs
            // 
            this.Qs.AutoSize = true;
            this.Qs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qs.Location = new System.Drawing.Point(13, 241);
            this.Qs.Name = "Qs";
            this.Qs.Size = new System.Drawing.Size(70, 19);
            this.Qs.TabIndex = 14;
            this.Qs.Text = "Queries";
            this.Qs.UseVisualStyleBackColor = true;
            this.Qs.CheckedChanged += new System.EventHandler(this.anyBox_Checked);
            // 
            // Disc
            // 
            this.Disc.AutoSize = true;
            this.Disc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disc.Location = new System.Drawing.Point(13, 266);
            this.Disc.Name = "Disc";
            this.Disc.Size = new System.Drawing.Size(89, 19);
            this.Disc.TabIndex = 13;
            this.Disc.Text = "Discussion";
            this.Disc.UseVisualStyleBackColor = true;
            this.Disc.CheckedChanged += new System.EventHandler(this.anyBox_Checked);
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum.Location = new System.Drawing.Point(95, 241);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(91, 19);
            this.Sum.TabIndex = 12;
            this.Sum.Text = "Summaries";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.CheckedChanged += new System.EventHandler(this.anyBox_Checked);
            // 
            // checkInternships
            // 
            this.checkInternships.AutoSize = true;
            this.checkInternships.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInternships.Location = new System.Drawing.Point(13, 167);
            this.checkInternships.Name = "checkInternships";
            this.checkInternships.Size = new System.Drawing.Size(88, 19);
            this.checkInternships.TabIndex = 11;
            this.checkInternships.Text = "Internships";
            this.checkInternships.UseVisualStyleBackColor = true;
            this.checkInternships.CheckedChanged += new System.EventHandler(this.anyBox_Checked);
            // 
            // checkJobs
            // 
            this.checkJobs.AutoSize = true;
            this.checkJobs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkJobs.Location = new System.Drawing.Point(13, 142);
            this.checkJobs.Name = "checkJobs";
            this.checkJobs.Size = new System.Drawing.Size(53, 19);
            this.checkJobs.TabIndex = 10;
            this.checkJobs.Text = "Jobs";
            this.checkJobs.UseVisualStyleBackColor = true;
            this.checkJobs.CheckedChanged += new System.EventHandler(this.anyBox_Checked);
            // 
            // Support
            // 
            this.Support.AutoSize = true;
            this.Support.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Support.Location = new System.Drawing.Point(95, 142);
            this.Support.Name = "Support";
            this.Support.Size = new System.Drawing.Size(76, 19);
            this.Support.TabIndex = 9;
            this.Support.Text = "Supports";
            this.Support.UseVisualStyleBackColor = true;
            this.Support.CheckedChanged += new System.EventHandler(this.anyBox_Checked);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(89, 45);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(59, 19);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Media";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.anyBox_Checked);
            // 
            // FYIs
            // 
            this.FYIs.AutoSize = true;
            this.FYIs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FYIs.Location = new System.Drawing.Point(13, 70);
            this.FYIs.Name = "FYIs";
            this.FYIs.Size = new System.Drawing.Size(43, 19);
            this.FYIs.TabIndex = 7;
            this.FYIs.Text = "FYI";
            this.FYIs.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(13, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(39, 19);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "All";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.anyBox_Checked);
            // 
            // labelPubs
            // 
            this.labelPubs.AutoSize = true;
            this.labelPubs.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPubs.Location = new System.Drawing.Point(10, 409);
            this.labelPubs.Name = "labelPubs";
            this.labelPubs.Size = new System.Drawing.Size(86, 16);
            this.labelPubs.TabIndex = 4;
            this.labelPubs.Text = "Publications";
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvents.Location = new System.Drawing.Point(10, 306);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(49, 16);
            this.labelEvents.TabIndex = 3;
            this.labelEvents.Text = "Events";
            // 
            // labelDiscussion
            // 
            this.labelDiscussion.AutoSize = true;
            this.labelDiscussion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscussion.Location = new System.Drawing.Point(10, 208);
            this.labelDiscussion.Name = "labelDiscussion";
            this.labelDiscussion.Size = new System.Drawing.Size(74, 16);
            this.labelDiscussion.TabIndex = 2;
            this.labelDiscussion.Text = "Discussion";
            // 
            // labelCareers
            // 
            this.labelCareers.AutoSize = true;
            this.labelCareers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCareers.Location = new System.Drawing.Point(10, 111);
            this.labelCareers.Name = "labelCareers";
            this.labelCareers.Size = new System.Drawing.Size(57, 16);
            this.labelCareers.TabIndex = 1;
            this.labelCareers.Text = "Careers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Announcements";
            // 
            // btnStar
            // 
            this.btnStar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStar.BackColor = System.Drawing.SystemColors.Window;
            this.btnStar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnStar.Location = new System.Drawing.Point(250, 611);
            this.btnStar.Name = "btnStar";
            this.btnStar.Size = new System.Drawing.Size(243, 29);
            this.btnStar.TabIndex = 16;
            this.btnStar.Text = "Bookmark this Issue";
            this.btnStar.UseVisualStyleBackColor = false;
            this.btnStar.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // notesBox
            // 
            this.notesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.notesBox.Location = new System.Drawing.Point(504, 611);
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(270, 64);
            this.notesBox.TabIndex = 17;
            this.notesBox.Text = "";
            this.notesBox.Enter += new System.EventHandler(this.notesBox_Enter);
            // 
            // btnSaveNotes
            // 
            this.btnSaveNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveNotes.BackColor = System.Drawing.SystemColors.Window;
            this.btnSaveNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNotes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNotes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSaveNotes.Location = new System.Drawing.Point(250, 646);
            this.btnSaveNotes.Name = "btnSaveNotes";
            this.btnSaveNotes.Size = new System.Drawing.Size(243, 29);
            this.btnSaveNotes.TabIndex = 18;
            this.btnSaveNotes.Text = "Save Notes";
            this.btnSaveNotes.UseVisualStyleBackColor = false;
            this.btnSaveNotes.Click += new System.EventHandler(this.btnSaveNotes_Click);
            // 
            // lblNotesSaved
            // 
            this.lblNotesSaved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotesSaved.AutoSize = true;
            this.lblNotesSaved.BackColor = System.Drawing.SystemColors.Window;
            this.lblNotesSaved.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNotesSaved.Location = new System.Drawing.Point(695, 655);
            this.lblNotesSaved.Name = "lblNotesSaved";
            this.lblNotesSaved.Size = new System.Drawing.Size(70, 13);
            this.lblNotesSaved.TabIndex = 19;
            this.lblNotesSaved.Text = "Notes saved!";
            this.lblNotesSaved.Visible = false;
            // 
            // btnShowBookmarked
            // 
            this.btnShowBookmarked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowBookmarked.BackColor = System.Drawing.SystemColors.Window;
            this.btnShowBookmarked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowBookmarked.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBookmarked.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnShowBookmarked.Location = new System.Drawing.Point(12, 646);
            this.btnShowBookmarked.Name = "btnShowBookmarked";
            this.btnShowBookmarked.Size = new System.Drawing.Size(227, 29);
            this.btnShowBookmarked.TabIndex = 20;
            this.btnShowBookmarked.Text = "Show Bookmarked Issues";
            this.btnShowBookmarked.UseVisualStyleBackColor = false;
            this.btnShowBookmarked.Click += new System.EventHandler(this.btnShowBookmarked_Click);
            // 
            // panelPreview
            // 
            this.panelPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelPreview.AutoScroll = true;
            this.panelPreview.BackColor = System.Drawing.SystemColors.Window;
            this.panelPreview.Location = new System.Drawing.Point(250, 12);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(243, 593);
            this.panelPreview.TabIndex = 14;
            this.panelPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPreview_Paint);
            // 
            // frmBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1226, 688);
            this.Controls.Add(this.btnShowBookmarked);
            this.Controls.Add(this.lblNotesSaved);
            this.Controls.Add(this.btnSaveNotes);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.notesBox);
            this.Controls.Add(this.btnStar);
            this.Controls.Add(this.areaPanel);
            this.Controls.Add(this.panelPreview);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.browseWindow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBrowse";
            this.Text = "Browse";
            this.areaPanel.ResumeLayout(false);
            this.areaPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser browseWindow;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Panel areaPanel;
        private System.Windows.Forms.CheckBox Confs;
        private System.Windows.Forms.CheckBox Qs;
        private System.Windows.Forms.CheckBox Disc;
        private System.Windows.Forms.CheckBox Sum;
        private System.Windows.Forms.CheckBox checkInternships;
        private System.Windows.Forms.CheckBox checkJobs;
        private System.Windows.Forms.CheckBox Support;
        private System.Windows.Forms.Label labelPubs;
        private System.Windows.Forms.Label labelEvents;
        private System.Windows.Forms.Label labelDiscussion;
        private System.Windows.Forms.Label labelCareers;
        private System.Windows.Forms.CheckBox summerSchools;
        private System.Windows.Forms.CheckBox Software;
        private System.Windows.Forms.CheckBox Diss;
        private System.Windows.Forms.CheckBox TOC;
        private System.Windows.Forms.CheckBox Calls;
        private System.Windows.Forms.CheckBox checkBooks;
        private System.Windows.Forms.CheckBox Review;
        private DBFlowLayoutPanel panelPreview;
        private System.Windows.Forms.Button btnStar;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox FYIs;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox notesBox;
        private System.Windows.Forms.Button btnSaveNotes;
        private System.Windows.Forms.Label lblNotesSaved;
        private System.Windows.Forms.Button btnShowBookmarked;
    }
}