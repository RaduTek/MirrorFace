﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace MirrorFace
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Mica = new SimulatedMica(this);

            sourceImage.AllowDrop = true;

            Text = Application.ProductName;

            // Disable controls that don't work with no image loaded
            copyOriginalToClipboardToolStripMenuItem.Enabled = saveOriginalAsToolStripMenuItem.Enabled = copyMirrorLeftBtn.Enabled = saveMirrorLeftBtn.Enabled = copyMirrorRightBtn.Enabled = saveMirrorRightBtn.Enabled = editImageMenuButton.Enabled = centerPosTrack.Enabled = false;

        }

        #region "Core functions"

        private void LoadFromAI()
        {
            try
            {
                sourceImage.Load("https://thispersondoesnotexist.com/");
                LoadImages();
            } catch (Exception ex)
            {
                MessageBox.Show("Failed to load generated image.\nReason: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFromLocal()
        {
            openFileDialog.ShowDialog();
        }
        
        private void LoadFromClipboard()
        {
            if (Clipboard.ContainsImage())
            {
                sourceImage.Image = Clipboard.GetImage();

                LoadImages();
            } else
            {
                MessageBox.Show(this, "Error pasting image: Clipboard data is not an image.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            sourceImage.Image = Image.FromFile(openFileDialog.FileName);

            LoadImages();
        }

        private void FlipImageVertically(bool sideToFlip)
        {
            int sliceWidth = sideToFlip ? centerPosTrack.Value : (sourceImage.Image.Width - centerPosTrack.Value);
            int sourceHeight = sourceImage.Image.Height;

            Bitmap b = new Bitmap(sliceWidth * 2, sourceHeight, sourceImage.Image.PixelFormat);

            if (sideToFlip)
                mirrorLeftImage.Image = b;
            else
                mirrorRightImage.Image = b;

            Graphics g = Graphics.FromImage(sideToFlip ? mirrorLeftImage.Image : mirrorRightImage.Image);

            Bitmap b1 = new Bitmap(sourceImage.Image);
            if (!sideToFlip)
            {
                b1.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }

            Rectangle source = new Rectangle(0, 0, sliceWidth, sourceHeight);
            Rectangle dest = new Rectangle(sliceWidth, 0, sliceWidth, sourceHeight);

            Bitmap b2 = b1.Clone(source, sourceImage.Image.PixelFormat);
            b2.RotateFlip(RotateFlipType.RotateNoneFlipX);

            g.DrawImage(b1, source, source, GraphicsUnit.Pixel);
            g.DrawImage(b2, dest, source, GraphicsUnit.Pixel);

            b1.Dispose();
            b2.Dispose();
        }

        private void FlipImages()
        {
            FlipImageVertically(true);
            FlipImageVertically(false);
        }

        private void LoadImages()
        {
            copyOriginalToClipboardToolStripMenuItem.Enabled = saveOriginalAsToolStripMenuItem.Enabled = copyMirrorLeftBtn.Enabled = saveMirrorLeftBtn.Enabled = copyMirrorRightBtn.Enabled = saveMirrorRightBtn.Enabled = editImageMenuButton.Enabled = centerPosTrack.Enabled = true;

            centerPosTrack.Maximum = sourceImage.Image.Width - 1;
            centerPosTrack.Value = centerPosTrack.Maximum / 2;

            FlipImages();
        }

        private int fileCounter = 1;

        private void SaveImageAs(Image imageToSave)
        {
            saveFileDialog.FileName = $"Image {fileCounter}";

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                fileCounter += 1;
                ImageFormat saveFormat = ImageFormat.Bmp;
                string fileName = saveFileDialog.FileName;
                string fileExt = Path.GetExtension(fileName).ToLower();
                if (fileExt == ".png")
                    saveFormat = ImageFormat.Png;
                else if (fileExt == ".jpg" || fileExt == ".jpeg")
                    saveFormat = ImageFormat.Jpeg;
                else if (fileExt == ".bmp")
                    saveFormat = ImageFormat.Bmp;

                imageToSave.Save(fileName, saveFormat);
            }
        }

        #endregion

        #region "Position Track Bar"

        private void centerPosTrack_Scroll(object sender, EventArgs e)
        {
            sourceImage.Invalidate();
            FlipImages();
        }

        private void centerPosTrack_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                centerPosTrack.Value = centerPosTrack.Maximum / 2;

                FlipImages();
            }
        }

        private void sourceImage_Paint(object sender, PaintEventArgs e)
        {
            if (sourceImage.Image != null)
            {
                int lineX = (centerPosTrack.Value * sourceImage.Width) / sourceImage.Image.Width;

                Point lineStart = new Point(lineX, 0);
                Point lineEnd = new Point(lineX, sourceImage.Height);

                Pen linePen = new Pen(Color.FromArgb(128, 255, 0, 0), 2);

                e.Graphics.DrawLine(linePen, lineStart, lineEnd);
            }
        }

        #endregion

        #region "Button Events"
        private void aboutBtn_Click(object sender, EventArgs e)
        {
            AboutDialog aboutDialog = new AboutDialog();
            aboutDialog.ShowDialog();
        }

        #region "Left mirror"

        private void copyMirrorLeftBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(mirrorLeftImage.Image);
        }

        private void saveMirrorLeftBtn_Click(object sender, EventArgs e)
        {
            SaveImageAs(mirrorLeftImage.Image);
        }

        #endregion

        #region "Right mirror"

        private void copyMirrorRightBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(mirrorRightImage.Image);
        }
        private void saveMirrorRightBtn_Click(object sender, EventArgs e)
        {
            SaveImageAs(mirrorRightImage.Image);
        }

        #endregion


        #region "Menu open buttons"
        private void loadImageMenuButton_Click(object sender, EventArgs e)
        {
            loadImageMenu.Show(loadImageMenuButton, new Point(0, 0), ToolStripDropDownDirection.AboveRight);
        }

        private void editImageMenuButton_Click(object sender, EventArgs e)
        {
            editImageMenu.Show(editImageMenuButton, new Point(0,0), ToolStripDropDownDirection.AboveRight);
        }

        #endregion

        #region "Load menu"
        private void copyOriginalToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(sourceImage.Image);
        }

        private void saveOriginalAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveImageAs(sourceImage.Image);
        }

        private void generatedByAIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFromAI();
        }

        private void fromLocalImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFromLocal();
        }

        private void fromClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFromClipboard();
        }

        #endregion

        #region "Edit menu"

        private void rotateClockwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(sourceImage.Image);
            
            b.RotateFlip(RotateFlipType.Rotate90FlipNone);
            sourceImage.Image = b;

            LoadImages();
        }

        private void rotateCounterclockwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(sourceImage.Image);
            
            b.RotateFlip(RotateFlipType.Rotate270FlipNone);
            sourceImage.Image = b;

            LoadImages();
        }
        private void flipHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(sourceImage.Image);

            b.RotateFlip(RotateFlipType.RotateNoneFlipX);
            sourceImage.Image = b;

            LoadImages();
        }

        private void flipVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(sourceImage.Image);

            b.RotateFlip(RotateFlipType.RotateNoneFlipY);
            sourceImage.Image = b;

            LoadImages();
        }

        #endregion

        #endregion

        #region "Simulated Mica effect"

        SimulatedMica Mica;

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Mica.CaptureSetColor(true);
        }
        private void MainForm_Activated(object sender, EventArgs e)
        {
            Mica.CaptureSetColor(true);
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            Mica.CaptureSetColor(true);
        }
        private void MainForm_BackColorChanged(object sender, EventArgs e)
        {
            // Set background color to menus
            loadImageMenu.BackColor = editImageMenu.BackColor = BackColor;
        }

        #endregion

        #region "Drag and drop to load image"

        private bool IsImageFile(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();
            return extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".gif" || extension == ".bmp";
        }

        private void sourceImage_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string file in droppedFiles)
                {
                    if (IsImageFile(file))
                    {
                        try
                        {
                            Image i = Image.FromFile(file);
                            sourceImage.Image = i;
                            LoadImages();
                        } catch { }
                    }
                }
            }
        }

        private void sourceImage_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        #endregion

    }
}
