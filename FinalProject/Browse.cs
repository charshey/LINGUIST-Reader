using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
    /// <summary>
    /// Issue browsing window includes area options, preview pane and issue view/save options.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class frmBrowse : Form
    {
        /// <summary>
        /// Boolean value indicating whether all areas are currently selected.
        /// </summary>
        private bool selectedAll;
        /// <summary>
        /// Issues database being manipulated by the current instance of the Reader.
        /// </summary>
        private Database issuesDB;
        /// <summary>
        /// List of all checkboxes in the area panel.
        /// </summary>
        private List<CheckBox> checkBoxes;
        /// <summary>
        /// List of all checked checkboxes in the area panel.
        /// </summary>
        private List<CheckBox> checkedBoxes;
        /// <summary>
        /// The issue that is currently being displayed and manipulated (if any).
        /// </summary>
        private Issue focus;
        /// <summary>
        /// Boolean indicating whether the preview panel is showing bookmarked issues or not.
        /// </summary>
        private bool showingBookmarks;

        /// <summary>
        /// Initializes a new instance of the <see cref="frmBrowse"/> class.
        /// </summary>
        /// <param name="db">The database to be viewed/manipulated.</param>
        public frmBrowse(Database db)
        {
            // initialize and set all initial values for instance fields.
            InitializeComponent();
            issuesDB = db;
            selectedAll = false;
            checkBoxes = new List<CheckBox>();
            foreach(Control control in areaPanel.Controls)
            {
                if(control is CheckBox) { checkBoxes.Add((CheckBox)control); }
            }

            checkedBoxes = new List<CheckBox>();

            // suppress script errors to avoid issues with javascript in local webpages
            browseWindow.ScriptErrorsSuppressed = true;

            // grey out all controls having to do with the focus issue, since there is no focus yet.
            btnStar.Enabled = false;
            notesBox.Enabled = false;
            btnSaveNotes.Enabled = false;
            showingBookmarks = false;

        }

        /// <summary>
        /// Handles the Checked event of any checked area box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void anyBox_Checked(object sender, EventArgs e)
        {
            // update list of all checked boxes
            this.getCheckedBoxes();
            // we're not looking at bookmarks anymore
            showingBookmarks = false;
            btnShowBookmarked.Enabled = true;
            // suspend drawing for the moment while updating panel controls (avoids undefined behavior)
            DrawingControl.SuspendDrawing(panelPreview);
            // update panel controls, specifying that we are not looking at bookmarked issues
            panelPreview_Update(false);
            // allow the panel to resume drawing
            DrawingControl.ResumeDrawing(panelPreview);
            // refresh the panel to see updated controls
            panelPreview.Refresh();

        }

        /// <summary>
        /// Handles the Click event of the btnSelectAll control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            showingBookmarks = false;
            btnShowBookmarked.Enabled = true;
            // Suspend drawing to allow the panel to update controls (avoids undefined behavior)
            DrawingControl.SuspendDrawing(panelPreview);

            // if all are not already selected, select them all and change button text to clear all
            if (!selectedAll)
            {
                // for each control in the panel, if it's a checkbox, check it
                foreach (Control control in areaPanel.Controls)
                {
                    if(control is CheckBox)
                    {
                        CheckBox box = (CheckBox)control;
                        box.Checked = true;
                    }   
                }
                // change button text to clear all
                btnSelectAll.Text = "Clear All";

            }

            // if all are already selected, this button functions as a clear button
            if(selectedAll)
            {
                // for each control, if it is a checkbox, clear it
                foreach (Control control in areaPanel.Controls)
                {
                    if (control is CheckBox)
                    {
                        CheckBox box = (CheckBox)control;
                        box.Checked = false;
                    }
                }
                // change button text to select all
                btnSelectAll.Text = "Select All";

            }

            // switch the bool value for all selected to the opposite of what it was
            selectedAll = !selectedAll;
            // reinstate drawing for the preview panel
            DrawingControl.ResumeDrawing(panelPreview);

        }

        /// <summary>
        /// Handles the Click event of the btnCloseWindow control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            // close window gracefully
            this.Close();
        }

        /// <summary>
        /// Updates the controls of the preview panel.
        /// </summary>
        /// <param name="bookmarks">Indicates whether viewing bookmarked issues or not.</param>
        private void panelPreview_Update(bool bookmarks)
        {
            // make up list of controls currently in panel
            List<Control> controls = new List<Control>();
            foreach(Control control in panelPreview.Controls)
            {
                controls.Add(control);
            }
            // clear all controls in panel and dispose of them
            panelPreview.Controls.Clear();
            foreach(Control control in controls)
            {
                control.Dispose();
            }
            // if not trying to view bookmarks, show all the issues corresponding to checked areas
            if (!bookmarks)
            {
                // set the boolean for whether we are viewing bookmarks to false
                showingBookmarks = false;

                foreach (CheckBox box in checkedBoxes)
                {
                    // for each control in the area list panel, if it is a checkbox, follow up on that
                    // for each issue in the issues that match the checked areas, do the following
                    foreach (Issue issue in issuesDB.getMatchingIssues(box.Text, box.Name))
                    {
                        // create and format new button with issue title as text
                        Button b = new Button();
                        b.Text = issue.getTitle();
                        b.BackColor = System.Drawing.SystemColors.Window;
                        b.FlatStyle = FlatStyle.Flat;
                        b.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
                        b.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        b.Size = new System.Drawing.Size(220, 128);
                        b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        b.UseVisualStyleBackColor = false;
                        b.Click += new EventHandler(this.B_Click);
                        b.Tag = issue;
                        // add new button to the panel
                        panelPreview.Controls.Add(b);
                        // add a "line" to visually separate buttons 
                        Label line = new Label();
                        line.Text = String.Empty;
                        line.BorderStyle = BorderStyle.Fixed3D;
                        line.BackColor = System.Drawing.SystemColors.ActiveBorder;
                        line.AutoSize = false;
                        line.Height = 2;
                        line.Width = 260;
                        // add the line to the panel
                        panelPreview.Controls.Add(line);
                    }
                }
            }
            // if trying to view bookmarked issues
            else
            {
                // set the boolean for showing bookmarked issues to true
                showingBookmarks = true;
                // for each issue in the issue database that is bookmarked, do the following
                foreach (Issue issue in issuesDB.getIssues().Where(issue => issue.getBookmarked()))
                {
                    // create and format new button with issue title as text
                    Button b = new Button();
                    b.Text = issue.getTitle();
                    b.BackColor = System.Drawing.SystemColors.Window;
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
                    b.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    b.Size = new System.Drawing.Size(220, 128);
                    b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    b.UseVisualStyleBackColor = false;
                    b.Click += new EventHandler(this.B_Click);
                    b.Tag = issue;
                    // add button to panel
                    panelPreview.Controls.Add(b);
                    // create new "line" to visually separate buttons
                    Label line = new Label();
                    line.Text = String.Empty;
                    line.BorderStyle = BorderStyle.Fixed3D;
                    line.BackColor = System.Drawing.SystemColors.ActiveBorder;
                    line.AutoSize = false;
                    line.Height = 2;
                    line.Width = 260;
                    // add line to panel
                    panelPreview.Controls.Add(line);
                }
            }
        }

        /// <summary>
        /// Handles the Click event of any issue button in the preview panel.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void B_Click(object sender, EventArgs e)
        {
            // cast the sending control to button variable
            Button b = (Button)sender;
            // set that button as the focus of the form
            b.Focus();
            // for each button in the preview panel, reset the color to the default
            foreach(Control control in panelPreview.Controls)
            {
                control.BackColor = System.Drawing.SystemColors.Window;
            }
            // set the background color of the selected button to the active blue color
            b.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            // get the tagged issue on the button and set it as the focus issue
            focus = (Issue)b.Tag;
            // set the notes box to contain the comment of the focus issue
            notesBox.Text = focus.getComment();
            // if the focus issue is bookmarked, set the bookmark button to "remove bookmark"
            if (focus.getBookmarked()) { btnStar.Text = "Remove Bookmark"; }
            // otherwise set the bookmark button to bookmark
            else { btnStar.Text = "Bookmark this Issue"; }
            // load the issue in the web browser
            this.loadIssue(focus);
            // enable all the buttons that have to do with manipulating a particular issue.
            btnStar.Enabled = true;
            btnSaveNotes.Enabled = true;
            notesBox.Enabled = true;
        }

        /// <summary>
        /// Loads the issue in the form's web browser.
        /// </summary>
        /// <param name="issue">The focus issue.</param>
        private void loadIssue(Issue issue)
        {
            // navigate to issue HTML page in the browser.
            this.browseWindow.Navigate(issue.getURI());
        }

        /// <summary>
        /// Gets all the checked boxes in the area panel.
        /// </summary>
        private void getCheckedBoxes()
        {
            // clear previous list
            checkedBoxes.Clear();
            // for each box in the list of all checkboxes, if it is checked, add it to the list
            foreach(CheckBox box in checkBoxes)
            {
                if (box.Checked) { checkedBoxes.Add(box); }
                
            }

        }

        /// <summary>
        /// Handles the Click event of the Bookmark/Remove Bookmark button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnStar_Click(object sender, EventArgs e)
        {
            // if the current issue being viewed is already bookmarked,
            if (focus.getBookmarked())
            {
                // set it to be not bookmarked and change text of button to say bookmark
                focus.setBookmarked(false);
                btnStar.Text = "Bookmark this Issue";

                // if currently viewing bookmarks, update the preview panel
                if (showingBookmarks)
                {
                    // suspend painting of preview panel for a moment to prevent weird behavior
                    DrawingControl.SuspendDrawing(panelPreview);
                    // update controls of the preview panel
                    panelPreview_Update(true);
                    // tell the preview panel it can resume painting
                    DrawingControl.ResumeDrawing(panelPreview);
                    // refresh the preview panel to see changes
                    panelPreview.Refresh();

                    // since bookmark has been removed for the focus issue, 
                    // remove it from the browser and set the browser to blank page
                    browseWindow.Navigate("about:blank");
                    // set focus to null since we aren't focusing on an issue now
                    focus = null;
                }
            }
            // if the current issue being viewed is not bookmarked, bookmark it and change the button
            // to remove bookmark
            else
            {
                focus.setBookmarked(true);
                btnStar.Text = "Remove Bookmark";
            }
        }

        /// <summary>
        /// Handles the Click event of the Save Notes button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnSaveNotes_Click(object sender, EventArgs e)
        {
            // save the text in the box as the comment of the issue.
            focus.setComment(notesBox.Text);
            // show the notes saved label to tell the user it was saved
            lblNotesSaved.Visible = true;
        }

        /// <summary>
        /// Handles the Enter event of the notesBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void notesBox_Enter(object sender, EventArgs e)
        {
            // when entering the box, make the notes saved label invisible,
            // so the user knows they're typing new/unsaved information 
            // (and then if they save it, the label will show them it has been saved again)
            lblNotesSaved.Visible = false;
        }

        /// <summary>
        /// Handles the Click event of the Show Bookmarked Issues button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnShowBookmarked_Click(object sender, EventArgs e)
        {
            // for each control in the area panel, if it's a checkbox, uncheck it 
            // since the form will be showing bookmarks and no selected issues
            foreach (Control control in areaPanel.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox box = (CheckBox)control;
                    box.Checked = false;
                }
            }
            
            // make sure select all button currently says select all since everything has been unchecked
            btnSelectAll.Text = "Select All";
            // disable the show bookmarks button since we're already viewing bookmarks
            btnShowBookmarked.Enabled = false;

            // suspend painting for the preview panel
            DrawingControl.SuspendDrawing(panelPreview);
            // update the controls on the preview panel
            panelPreview_Update(true);
            // let the preview panel resume painting
            DrawingControl.ResumeDrawing(panelPreview);
            // refresh the preview panel to show updates
            panelPreview.Refresh();
        }

    }
}
