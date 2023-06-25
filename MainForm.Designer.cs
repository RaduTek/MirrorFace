
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.layoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.copyMirrorRightBtn = new System.Windows.Forms.Button();
            this.saveMirrorRightBtn = new System.Windows.Forms.Button();
            this.mirrorRightImage = new System.Windows.Forms.PictureBox();
            this.mirrorLeftImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sourceImage = new System.Windows.Forms.PictureBox();
            this.commandPanel = new System.Windows.Forms.Panel();
            this.editImageMenuButton = new System.Windows.Forms.Button();
            this.loadImageMenuButton = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.centerPosTrack = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.saveMirrorLeftBtn = new System.Windows.Forms.Button();
            this.copyMirrorLeftBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadImageMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyOriginalToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOriginalAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.generatedByAIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromLocalImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editImageMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rotateClockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateCounterclockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.flipHorizontallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipVerticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.layoutTable.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mirrorRightImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mirrorLeftImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImage)).BeginInit();
            this.commandPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centerPosTrack)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.loadImageMenu.SuspendLayout();
            this.editImageMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutTable
            // 
            this.layoutTable.ColumnCount = 3;
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.layoutTable.Controls.Add(this.tableLayoutPanel2, 2, 2);
            this.layoutTable.Controls.Add(this.mirrorRightImage, 2, 1);
            this.layoutTable.Controls.Add(this.mirrorLeftImage, 1, 1);
            this.layoutTable.Controls.Add(this.label1, 0, 0);
            this.layoutTable.Controls.Add(this.label2, 1, 0);
            this.layoutTable.Controls.Add(this.label3, 2, 0);
            this.layoutTable.Controls.Add(this.sourceImage, 0, 1);
            this.layoutTable.Controls.Add(this.commandPanel, 0, 3);
            this.layoutTable.Controls.Add(this.centerPosTrack, 0, 2);
            this.layoutTable.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.layoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutTable.Location = new System.Drawing.Point(20, 15);
            this.layoutTable.Name = "layoutTable";
            this.layoutTable.RowCount = 4;
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layoutTable.Size = new System.Drawing.Size(1415, 608);
            this.layoutTable.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.copyMirrorRightBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.saveMirrorRightBtn, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(945, 500);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(467, 45);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // copyMirrorRightBtn
            // 
            this.copyMirrorRightBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.copyMirrorRightBtn.Location = new System.Drawing.Point(80, 3);
            this.copyMirrorRightBtn.Name = "copyMirrorRightBtn";
            this.copyMirrorRightBtn.Size = new System.Drawing.Size(150, 39);
            this.copyMirrorRightBtn.TabIndex = 11;
            this.copyMirrorRightBtn.Text = "📄 Copy Image";
            this.copyMirrorRightBtn.UseVisualStyleBackColor = true;
            this.copyMirrorRightBtn.Click += new System.EventHandler(this.copyMirrorRightBtn_Click);
            // 
            // saveMirrorRightBtn
            // 
            this.saveMirrorRightBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.saveMirrorRightBtn.Location = new System.Drawing.Point(236, 3);
            this.saveMirrorRightBtn.Name = "saveMirrorRightBtn";
            this.saveMirrorRightBtn.Size = new System.Drawing.Size(150, 39);
            this.saveMirrorRightBtn.TabIndex = 11;
            this.saveMirrorRightBtn.Text = "💾 Save as...";
            this.saveMirrorRightBtn.UseVisualStyleBackColor = true;
            this.saveMirrorRightBtn.Click += new System.EventHandler(this.saveMirrorRightBtn_Click);
            // 
            // mirrorRightImage
            // 
            this.mirrorRightImage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mirrorRightImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mirrorRightImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mirrorRightImage.Location = new System.Drawing.Point(957, 42);
            this.mirrorRightImage.Margin = new System.Windows.Forms.Padding(15, 12, 15, 12);
            this.mirrorRightImage.Name = "mirrorRightImage";
            this.mirrorRightImage.Size = new System.Drawing.Size(443, 443);
            this.mirrorRightImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mirrorRightImage.TabIndex = 6;
            this.mirrorRightImage.TabStop = false;
            // 
            // mirrorLeftImage
            // 
            this.mirrorLeftImage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mirrorLeftImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mirrorLeftImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mirrorLeftImage.Location = new System.Drawing.Point(486, 42);
            this.mirrorLeftImage.Margin = new System.Windows.Forms.Padding(15, 12, 15, 12);
            this.mirrorLeftImage.Name = "mirrorLeftImage";
            this.mirrorLeftImage.Size = new System.Drawing.Size(441, 443);
            this.mirrorLeftImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mirrorLeftImage.TabIndex = 5;
            this.mirrorLeftImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Image";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(644, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mirrored Left";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1109, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mirrored Right";
            // 
            // sourceImage
            // 
            this.sourceImage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sourceImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sourceImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceImage.Location = new System.Drawing.Point(15, 42);
            this.sourceImage.Margin = new System.Windows.Forms.Padding(15, 12, 15, 12);
            this.sourceImage.Name = "sourceImage";
            this.sourceImage.Size = new System.Drawing.Size(441, 443);
            this.sourceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sourceImage.TabIndex = 4;
            this.sourceImage.TabStop = false;
            this.sourceImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.sourceImage_DragDrop);
            this.sourceImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.sourceImage_DragEnter);
            this.sourceImage.Paint += new System.Windows.Forms.PaintEventHandler(this.sourceImage_Paint);
            // 
            // commandPanel
            // 
            this.layoutTable.SetColumnSpan(this.commandPanel, 3);
            this.commandPanel.Controls.Add(this.editImageMenuButton);
            this.commandPanel.Controls.Add(this.loadImageMenuButton);
            this.commandPanel.Controls.Add(this.aboutBtn);
            this.commandPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandPanel.Location = new System.Drawing.Point(3, 551);
            this.commandPanel.Name = "commandPanel";
            this.commandPanel.Size = new System.Drawing.Size(1409, 54);
            this.commandPanel.TabIndex = 8;
            // 
            // editImageMenuButton
            // 
            this.editImageMenuButton.Location = new System.Drawing.Point(236, 8);
            this.editImageMenuButton.Name = "editImageMenuButton";
            this.editImageMenuButton.Size = new System.Drawing.Size(210, 39);
            this.editImageMenuButton.TabIndex = 11;
            this.editImageMenuButton.Text = "✏️ Edit Image...";
            this.editImageMenuButton.UseVisualStyleBackColor = true;
            this.editImageMenuButton.Click += new System.EventHandler(this.editImageMenuButton_Click);
            // 
            // loadImageMenuButton
            // 
            this.loadImageMenuButton.Location = new System.Drawing.Point(20, 8);
            this.loadImageMenuButton.Name = "loadImageMenuButton";
            this.loadImageMenuButton.Size = new System.Drawing.Size(210, 39);
            this.loadImageMenuButton.TabIndex = 10;
            this.loadImageMenuButton.Text = "📂 Load Image...";
            this.loadImageMenuButton.UseVisualStyleBackColor = true;
            this.loadImageMenuButton.Click += new System.EventHandler(this.loadImageMenuButton_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.aboutBtn.Location = new System.Drawing.Point(1249, 8);
            this.aboutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(150, 39);
            this.aboutBtn.TabIndex = 9;
            this.aboutBtn.Text = "ℹ️ About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // centerPosTrack
            // 
            this.centerPosTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPosTrack.Location = new System.Drawing.Point(4, 501);
            this.centerPosTrack.Margin = new System.Windows.Forms.Padding(4);
            this.centerPosTrack.Maximum = 9;
            this.centerPosTrack.Minimum = 1;
            this.centerPosTrack.Name = "centerPosTrack";
            this.centerPosTrack.Size = new System.Drawing.Size(463, 43);
            this.centerPosTrack.TabIndex = 9;
            this.centerPosTrack.TickFrequency = 10;
            this.centerPosTrack.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.centerPosTrack.Value = 5;
            this.centerPosTrack.Scroll += new System.EventHandler(this.centerPosTrack_Scroll);
            this.centerPosTrack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.centerPosTrack_MouseDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.saveMirrorLeftBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.copyMirrorLeftBtn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(474, 500);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(465, 45);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // saveMirrorLeftBtn
            // 
            this.saveMirrorLeftBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.saveMirrorLeftBtn.Location = new System.Drawing.Point(235, 3);
            this.saveMirrorLeftBtn.Name = "saveMirrorLeftBtn";
            this.saveMirrorLeftBtn.Size = new System.Drawing.Size(150, 39);
            this.saveMirrorLeftBtn.TabIndex = 11;
            this.saveMirrorLeftBtn.Text = "💾 Save as...";
            this.saveMirrorLeftBtn.UseVisualStyleBackColor = true;
            this.saveMirrorLeftBtn.Click += new System.EventHandler(this.saveMirrorLeftBtn_Click);
            // 
            // copyMirrorLeftBtn
            // 
            this.copyMirrorLeftBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.copyMirrorLeftBtn.Location = new System.Drawing.Point(79, 3);
            this.copyMirrorLeftBtn.Name = "copyMirrorLeftBtn";
            this.copyMirrorLeftBtn.Size = new System.Drawing.Size(150, 39);
            this.copyMirrorLeftBtn.TabIndex = 10;
            this.copyMirrorLeftBtn.Text = "📄 Copy Image";
            this.copyMirrorLeftBtn.UseVisualStyleBackColor = true;
            this.copyMirrorLeftBtn.Click += new System.EventHandler(this.copyMirrorLeftBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image Files|*.png;*.jpeg;*.jpg;*.gif;*.bmp";
            this.openFileDialog.Title = "Open image";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // loadImageMenu
            // 
            this.loadImageMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.loadImageMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyOriginalToClipboardToolStripMenuItem,
            this.saveOriginalAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.generatedByAIToolStripMenuItem,
            this.fromLocalImageToolStripMenuItem,
            this.fromClipboardToolStripMenuItem});
            this.loadImageMenu.Name = "loadImageMenu";
            this.loadImageMenu.ShowImageMargin = false;
            this.loadImageMenu.Size = new System.Drawing.Size(304, 170);
            // 
            // copyOriginalToClipboardToolStripMenuItem
            // 
            this.copyOriginalToClipboardToolStripMenuItem.Name = "copyOriginalToClipboardToolStripMenuItem";
            this.copyOriginalToClipboardToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.copyOriginalToClipboardToolStripMenuItem.Text = "📄 Copy Original to Clipboard";
            this.copyOriginalToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyOriginalToClipboardToolStripMenuItem_Click);
            // 
            // saveOriginalAsToolStripMenuItem
            // 
            this.saveOriginalAsToolStripMenuItem.Name = "saveOriginalAsToolStripMenuItem";
            this.saveOriginalAsToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.saveOriginalAsToolStripMenuItem.Text = "💾 Save Original as...";
            this.saveOriginalAsToolStripMenuItem.Click += new System.EventHandler(this.saveOriginalAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(300, 6);
            // 
            // generatedByAIToolStripMenuItem
            // 
            this.generatedByAIToolStripMenuItem.Name = "generatedByAIToolStripMenuItem";
            this.generatedByAIToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.generatedByAIToolStripMenuItem.Text = "🤖 Load Generated by AI";
            this.generatedByAIToolStripMenuItem.Click += new System.EventHandler(this.generatedByAIToolStripMenuItem_Click);
            // 
            // fromLocalImageToolStripMenuItem
            // 
            this.fromLocalImageToolStripMenuItem.Name = "fromLocalImageToolStripMenuItem";
            this.fromLocalImageToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.fromLocalImageToolStripMenuItem.Text = "📂 From Local Image";
            this.fromLocalImageToolStripMenuItem.Click += new System.EventHandler(this.fromLocalImageToolStripMenuItem_Click);
            // 
            // fromClipboardToolStripMenuItem
            // 
            this.fromClipboardToolStripMenuItem.Name = "fromClipboardToolStripMenuItem";
            this.fromClipboardToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.fromClipboardToolStripMenuItem.Text = "📋 From Clipboard";
            this.fromClipboardToolStripMenuItem.Click += new System.EventHandler(this.fromClipboardToolStripMenuItem_Click);
            // 
            // editImageMenu
            // 
            this.editImageMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.editImageMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateClockwiseToolStripMenuItem,
            this.rotateCounterclockwiseToolStripMenuItem,
            this.toolStripSeparator1,
            this.flipHorizontallyToolStripMenuItem,
            this.flipVerticallyToolStripMenuItem});
            this.editImageMenu.Name = "editImageMenu";
            this.editImageMenu.ShowImageMargin = false;
            this.editImageMenu.Size = new System.Drawing.Size(268, 138);
            // 
            // rotateClockwiseToolStripMenuItem
            // 
            this.rotateClockwiseToolStripMenuItem.Name = "rotateClockwiseToolStripMenuItem";
            this.rotateClockwiseToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.rotateClockwiseToolStripMenuItem.Text = "⤵️ Rotate clockwise";
            this.rotateClockwiseToolStripMenuItem.Click += new System.EventHandler(this.rotateClockwiseToolStripMenuItem_Click);
            // 
            // rotateCounterclockwiseToolStripMenuItem
            // 
            this.rotateCounterclockwiseToolStripMenuItem.Name = "rotateCounterclockwiseToolStripMenuItem";
            this.rotateCounterclockwiseToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.rotateCounterclockwiseToolStripMenuItem.Text = "⤴️ Rotate counterclockwise";
            this.rotateCounterclockwiseToolStripMenuItem.Click += new System.EventHandler(this.rotateCounterclockwiseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(264, 6);
            // 
            // flipHorizontallyToolStripMenuItem
            // 
            this.flipHorizontallyToolStripMenuItem.Name = "flipHorizontallyToolStripMenuItem";
            this.flipHorizontallyToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.flipHorizontallyToolStripMenuItem.Text = "↔️ Flip horizontally";
            this.flipHorizontallyToolStripMenuItem.Click += new System.EventHandler(this.flipHorizontallyToolStripMenuItem_Click);
            // 
            // flipVerticallyToolStripMenuItem
            // 
            this.flipVerticallyToolStripMenuItem.Name = "flipVerticallyToolStripMenuItem";
            this.flipVerticallyToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.flipVerticallyToolStripMenuItem.Text = " ↕️ Flip vertically";
            this.flipVerticallyToolStripMenuItem.Click += new System.EventHandler(this.flipVerticallyToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap|*.bmp";
            this.saveFileDialog.Title = "Save image as";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1455, 638);
            this.Controls.Add(this.layoutTable);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mirror Fake Person";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.BackColorChanged += new System.EventHandler(this.MainForm_BackColorChanged);
            this.layoutTable.ResumeLayout(false);
            this.layoutTable.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mirrorRightImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mirrorLeftImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImage)).EndInit();
            this.commandPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.centerPosTrack)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.loadImageMenu.ResumeLayout(false);
            this.editImageMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox mirrorRightImage;
        private System.Windows.Forms.PictureBox mirrorLeftImage;
        private System.Windows.Forms.PictureBox sourceImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel commandPanel;
        private System.Windows.Forms.TrackBar centerPosTrack;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button copyMirrorRightBtn;
        private System.Windows.Forms.Button copyMirrorLeftBtn;
        private System.Windows.Forms.Button editImageMenuButton;
        private System.Windows.Forms.Button loadImageMenuButton;
        private System.Windows.Forms.ContextMenuStrip loadImageMenu;
        private System.Windows.Forms.ToolStripMenuItem generatedByAIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromLocalImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromClipboardToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip editImageMenu;
        private System.Windows.Forms.ToolStripMenuItem rotateClockwiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateCounterclockwiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem flipHorizontallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipVerticallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyOriginalToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button saveMirrorRightBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button saveMirrorLeftBtn;
        private System.Windows.Forms.ToolStripMenuItem saveOriginalAsToolStripMenuItem;
    }
}

