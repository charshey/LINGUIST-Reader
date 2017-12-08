using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmBrowse : Form
    {
        private bool selectedAll;
        private Database issuesDB;
        private List<CheckBox> checkBoxes;
        private List<CheckBox> checkedBoxes;
        private Issue focus;

        public frmBrowse(Database db)
        {
            InitializeComponent();
            selectedAll = false;

            checkBoxes = new List<CheckBox>();
            foreach(Control control in areaPanel.Controls)
            {
                if(control is CheckBox) { checkBoxes.Add((CheckBox)control); }
            }

            checkedBoxes = new List<CheckBox>();
            browseWindow.ScriptErrorsSuppressed = true;
            btnSave.Enabled = false;
            issuesDB = db;

        }

        private void anyBox_Checked(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Write("in areaPanel_AfterCheck method");
            this.getCheckedBoxes();
            DrawingControl.SuspendDrawing(panelPreview);
            panelPreview_Update();
            DrawingControl.ResumeDrawing(panelPreview);
            panelPreview.Refresh();

        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {

            if (!selectedAll)
            {
                foreach (Control control in areaPanel.Controls)
                {
                    if(control is CheckBox)
                    {
                        CheckBox box = (CheckBox)control;
                        box.Checked = true;
                    }   
                }

                btnSelectAll.Text = "Clear All";

            }

            if(selectedAll)
            {
                foreach (Control control in areaPanel.Controls)
                {
                    if (control is CheckBox)
                    {
                        CheckBox box = (CheckBox)control;
                        box.Checked = false;
                    }
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
            System.Diagnostics.Debug.Write("panelPreview_Update is happening\n");

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

                foreach(CheckBox box in checkedBoxes)
                {
                System.Diagnostics.Debug.Write(box.Name);
                    foreach(Issue issue in issuesDB.getIssues(box.Text, box.Name))
                    {
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
                 
                        panelPreview.Controls.Add(b);

                        Label line = new Label();
                        line.Text = String.Empty;
                        line.BorderStyle = BorderStyle.Fixed3D;
                        line.BackColor = System.Drawing.SystemColors.ActiveBorder;
                        line.AutoSize = false;
                        line.Height = 2;
                        line.Width = 260;

                        panelPreview.Controls.Add(line);
                    }
                }
        }

        private void B_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            foreach(Control control in panelPreview.Controls)
            {
                control.BackColor = System.Drawing.SystemColors.Window;
            }

            b.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            focus = (Issue)b.Tag;
            this.loadIssue(focus);
            btnSave.Enabled = true;
        }

        private void loadIssue(Issue issue)
        {
            this.browseWindow.Navigate(issue.getURI());
        }

        private void getCheckedBoxes()
        {
            System.Diagnostics.Debug.Write("In getCheckedBoxes function");
            checkedBoxes.Clear();
            System.Diagnostics.Debug.Write("Starting to loop through controls");
            foreach(CheckBox box in checkBoxes)
            {
                System.Diagnostics.Debug.Write(box);
                if (box.Checked) { checkedBoxes.Add(box); }
                
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmSaveIssue saveWindow = new frmSaveIssue(focus);
            saveWindow.ShowDialog();
        }

        private void panelPreview_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
