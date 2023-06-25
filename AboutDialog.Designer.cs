
namespace MirrorFace
{
    partial class AboutDialog
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
            this.closeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.noteLabel = new System.Windows.Forms.Label();
            this.AppIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(462, 180);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(120, 39);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.titleLabel.Location = new System.Drawing.Point(99, 18);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(482, 42);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Application Name";
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.versionLabel.Location = new System.Drawing.Point(105, 63);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(476, 27);
            this.versionLabel.TabIndex = 3;
            this.versionLabel.Text = "Version";
            // 
            // githubLink
            // 
            this.githubLink.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.githubLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.githubLink.AutoSize = true;
            this.githubLink.DisabledLinkColor = System.Drawing.SystemColors.GrayText;
            this.githubLink.LinkColor = System.Drawing.SystemColors.Highlight;
            this.githubLink.Location = new System.Drawing.Point(18, 189);
            this.githubLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(158, 25);
            this.githubLink.TabIndex = 5;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "GitHub Repository";
            this.githubLink.VisitedLinkColor = System.Drawing.SystemColors.Highlight;
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // noteLabel
            // 
            this.noteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteLabel.Location = new System.Drawing.Point(18, 106);
            this.noteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(560, 69);
            this.noteLabel.TabIndex = 6;
            this.noteLabel.Text = "Mirror images vertically, preferably AI generated faces.\r\nAI generated faces sour" +
    "ced from https://thispersondoesnotexist.com";
            // 
            // AppIcon
            // 
            this.AppIcon.Image = global::MirrorFace.Properties.Resources._96;
            this.AppIcon.Location = new System.Drawing.Point(18, 18);
            this.AppIcon.Margin = new System.Windows.Forms.Padding(4);
            this.AppIcon.Name = "AppIcon";
            this.AppIcon.Size = new System.Drawing.Size(72, 72);
            this.AppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AppIcon.TabIndex = 7;
            this.AppIcon.TabStop = false;
            // 
            // AboutDialog
            // 
            this.AcceptButton = this.closeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(600, 237);
            this.Controls.Add(this.AppIcon);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.closeButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Activated += new System.EventHandler(this.AboutDialog_Activated);
            this.Deactivate += new System.EventHandler(this.AboutDialog_Deactivate);
            this.Load += new System.EventHandler(this.AboutDialog_Load);
            this.Shown += new System.EventHandler(this.AboutDialog_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.AppIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.LinkLabel githubLink;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.PictureBox AppIcon;
    }
}