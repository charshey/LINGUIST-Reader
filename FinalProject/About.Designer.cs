namespace FinalProject
{
    // This is the designer file: I have not commented this personally
    // because it's automatically generated, self-explanatory background information

    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lblAbout = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.linkEmail = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Arial", 11F);
            this.lblAbout.Location = new System.Drawing.Point(21, 18);
            this.lblAbout.MaximumSize = new System.Drawing.Size(193, 119);
            this.lblAbout.MinimumSize = new System.Drawing.Size(193, 119);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(193, 119);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.Text = "This program was created \r\nby Clare Harshey as a final \r\nproject for CSCI-A590 at" +
    " \r\nIndiana University.\r\n\r\nQuestions or comments? \r\nEmail                        " +
    "            .";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Window;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(146, 156);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // linkEmail
            // 
            this.linkEmail.AutoSize = true;
            this.linkEmail.Font = new System.Drawing.Font("Arial", 10F);
            this.linkEmail.Location = new System.Drawing.Point(66, 121);
            this.linkEmail.Name = "linkEmail";
            this.linkEmail.Size = new System.Drawing.Size(139, 16);
            this.linkEmail.TabIndex = 2;
            this.linkEmail.TabStop = true;
            this.linkEmail.Text = "clare@linguistlist.org";
            this.linkEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEmail_LinkClicked);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(233, 196);
            this.Controls.Add(this.linkEmail);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAbout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(249, 235);
            this.MinimumSize = new System.Drawing.Size(249, 235);
            this.Name = "frmAbout";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel linkEmail;
    }
}