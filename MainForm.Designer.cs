
namespace MirrorFakePerson
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.mirrorRightImage = new System.Windows.Forms.PictureBox();
            this.mirrorLeftImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sourceImage = new System.Windows.Forms.PictureBox();
            this.commandPanel = new System.Windows.Forms.Panel();
            this.pasteBtn = new System.Windows.Forms.Button();
            this.loadLocalBtn = new System.Windows.Forms.Button();
            this.loadGeneratedBtn = new System.Windows.Forms.Button();
            this.centerPosTrack = new System.Windows.Forms.TrackBar();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.layoutTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mirrorRightImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mirrorLeftImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImage)).BeginInit();
            this.commandPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centerPosTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutTable
            // 
            this.layoutTable.ColumnCount = 3;
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.layoutTable.Controls.Add(this.mirrorRightImage, 2, 1);
            this.layoutTable.Controls.Add(this.mirrorLeftImage, 1, 1);
            this.layoutTable.Controls.Add(this.label1, 0, 0);
            this.layoutTable.Controls.Add(this.label2, 1, 0);
            this.layoutTable.Controls.Add(this.label3, 2, 0);
            this.layoutTable.Controls.Add(this.sourceImage, 0, 1);
            this.layoutTable.Controls.Add(this.commandPanel, 0, 3);
            this.layoutTable.Controls.Add(this.centerPosTrack, 0, 2);
            this.layoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutTable.Location = new System.Drawing.Point(13, 10);
            this.layoutTable.Margin = new System.Windows.Forms.Padding(2);
            this.layoutTable.Name = "layoutTable";
            this.layoutTable.RowCount = 4;
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutTable.Size = new System.Drawing.Size(1006, 425);
            this.layoutTable.TabIndex = 0;
            // 
            // mirrorRightImage
            // 
            this.mirrorRightImage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mirrorRightImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mirrorRightImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mirrorRightImage.Location = new System.Drawing.Point(680, 28);
            this.mirrorRightImage.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.mirrorRightImage.Name = "mirrorRightImage";
            this.mirrorRightImage.Size = new System.Drawing.Size(316, 315);
            this.mirrorRightImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mirrorRightImage.TabIndex = 6;
            this.mirrorRightImage.TabStop = false;
            // 
            // mirrorLeftImage
            // 
            this.mirrorLeftImage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mirrorLeftImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mirrorLeftImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mirrorLeftImage.Location = new System.Drawing.Point(345, 28);
            this.mirrorLeftImage.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.mirrorLeftImage.Name = "mirrorLeftImage";
            this.mirrorLeftImage.Size = new System.Drawing.Size(315, 315);
            this.mirrorLeftImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mirrorLeftImage.TabIndex = 5;
            this.mirrorLeftImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Image";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mirrored Left";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(796, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mirrored Right";
            // 
            // sourceImage
            // 
            this.sourceImage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sourceImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sourceImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceImage.Location = new System.Drawing.Point(10, 28);
            this.sourceImage.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.sourceImage.Name = "sourceImage";
            this.sourceImage.Size = new System.Drawing.Size(315, 315);
            this.sourceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sourceImage.TabIndex = 4;
            this.sourceImage.TabStop = false;
            // 
            // commandPanel
            // 
            this.layoutTable.SetColumnSpan(this.commandPanel, 3);
            this.commandPanel.Controls.Add(this.aboutBtn);
            this.commandPanel.Controls.Add(this.pasteBtn);
            this.commandPanel.Controls.Add(this.loadLocalBtn);
            this.commandPanel.Controls.Add(this.loadGeneratedBtn);
            this.commandPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandPanel.Location = new System.Drawing.Point(2, 387);
            this.commandPanel.Margin = new System.Windows.Forms.Padding(2);
            this.commandPanel.Name = "commandPanel";
            this.commandPanel.Size = new System.Drawing.Size(1002, 36);
            this.commandPanel.TabIndex = 8;
            // 
            // pasteBtn
            // 
            this.pasteBtn.Location = new System.Drawing.Point(295, 5);
            this.pasteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.Size = new System.Drawing.Size(140, 26);
            this.pasteBtn.TabIndex = 8;
            this.pasteBtn.Text = "Paste Image";
            this.pasteBtn.UseVisualStyleBackColor = true;
            this.pasteBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // loadLocalBtn
            // 
            this.loadLocalBtn.Location = new System.Drawing.Point(151, 5);
            this.loadLocalBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loadLocalBtn.Name = "loadLocalBtn";
            this.loadLocalBtn.Size = new System.Drawing.Size(140, 26);
            this.loadLocalBtn.TabIndex = 7;
            this.loadLocalBtn.Text = "Load Local Image ";
            this.loadLocalBtn.UseVisualStyleBackColor = true;
            this.loadLocalBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // loadGeneratedBtn
            // 
            this.loadGeneratedBtn.Location = new System.Drawing.Point(7, 5);
            this.loadGeneratedBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loadGeneratedBtn.Name = "loadGeneratedBtn";
            this.loadGeneratedBtn.Size = new System.Drawing.Size(140, 26);
            this.loadGeneratedBtn.TabIndex = 0;
            this.loadGeneratedBtn.Text = "Load Generated Image ";
            this.loadGeneratedBtn.UseVisualStyleBackColor = true;
            this.loadGeneratedBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // centerPosTrack
            // 
            this.centerPosTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPosTrack.Enabled = false;
            this.centerPosTrack.Location = new System.Drawing.Point(3, 354);
            this.centerPosTrack.Maximum = 9;
            this.centerPosTrack.Minimum = 1;
            this.centerPosTrack.Name = "centerPosTrack";
            this.centerPosTrack.Size = new System.Drawing.Size(329, 28);
            this.centerPosTrack.TabIndex = 9;
            this.centerPosTrack.TickFrequency = 10;
            this.centerPosTrack.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.centerPosTrack.Value = 5;
            this.centerPosTrack.Scroll += new System.EventHandler(this.centerPosTrack_Scroll);
            this.centerPosTrack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.centerPosTrack_MouseDown);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image Files|*.png;*.jpeg;*.jpg;*.gif;*.bmp";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.aboutBtn.Location = new System.Drawing.Point(894, 5);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(100, 26);
            this.aboutBtn.TabIndex = 9;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1032, 445);
            this.Controls.Add(this.layoutTable);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mirror Fake Person";
            this.layoutTable.ResumeLayout(false);
            this.layoutTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mirrorRightImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mirrorLeftImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImage)).EndInit();
            this.commandPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.centerPosTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutTable;
        private System.Windows.Forms.Button loadGeneratedBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox mirrorRightImage;
        private System.Windows.Forms.PictureBox mirrorLeftImage;
        private System.Windows.Forms.PictureBox sourceImage;
        private System.Windows.Forms.Button loadLocalBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel commandPanel;
        private System.Windows.Forms.Button pasteBtn;
        private System.Windows.Forms.TrackBar centerPosTrack;
        private System.Windows.Forms.Button aboutBtn;
    }
}

