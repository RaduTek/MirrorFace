using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace MirrorFakePerson
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sourceImage.Load("https://thispersondoesnotexist.com/");
                LoadImages();
            } catch (Exception ex)
            {
                MessageBox.Show("Failed to load generated image.\nReason: " + ex.Message, "MirrorFakePerson", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            sourceImage.Image = Image.FromFile(openFileDialog.FileName);

            LoadImages();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                sourceImage.Image = Clipboard.GetImage();

                LoadImages();
            }
            else
            {
                MessageBox.Show(this, "Error pasting image: Clipboard data is not an image.", "MirrorFakePerson", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void centerPosTrack_Scroll(object sender, EventArgs e)
        {
            FlipImages();
        }

        private void centerPosTrack_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                centerPosTrack.Maximum = sourceImage.Image.Width;
                centerPosTrack.Value = centerPosTrack.Maximum / 2;

                FlipImages();
            }
        }

        private void LoadImages()
        {
            centerPosTrack.Enabled = true;
            centerPosTrack.Maximum = sourceImage.Image.Width;
            centerPosTrack.Value = centerPosTrack.Maximum / 2;

            FlipImages();
        }

        private void FlipImages()
        {
            mirrorLeftImage.Image = (Image)sourceImage.Image.Clone();
            mirrorRightImage.Image = (Image)sourceImage.Image.Clone();

            flip1();
            flip2();
        }

        private void flip1()
        {
            int sliceWidth = centerPosTrack.Value;
            int sourceHeight = sourceImage.Image.Height;

            Bitmap b = new Bitmap(sliceWidth * 2, sourceHeight, PixelFormat.Format32bppArgb);
            mirrorLeftImage.Image = b;

            Graphics g = Graphics.FromImage(mirrorLeftImage.Image);

            Bitmap b1 = new Bitmap(sourceImage.Image);

            Rectangle source = new Rectangle(0, 0, sliceWidth, sourceHeight);
            Rectangle dest = new Rectangle(sliceWidth, 0, sliceWidth, sourceHeight);

            Bitmap b2 = b1.Clone(source, PixelFormat.Format32bppArgb);
            b2.RotateFlip(RotateFlipType.RotateNoneFlipX);

            g.DrawImage(b1, source, source, GraphicsUnit.Pixel);
            g.DrawImage(b2, dest, source, GraphicsUnit.Pixel);
        }

        private void flip2()
        {
            int sliceWidth = sourceImage.Image.Width - centerPosTrack.Value;
            int sourceHeight = sourceImage.Image.Height;

            Bitmap b = new Bitmap(sliceWidth * 2, sourceHeight, PixelFormat.Format32bppArgb);
            mirrorRightImage.Image = b;

            Graphics g = Graphics.FromImage(mirrorRightImage.Image);

            Bitmap b1 = new Bitmap(sourceImage.Image);
            b1.RotateFlip(RotateFlipType.RotateNoneFlipX);

            Rectangle source = new Rectangle(0, 0, sliceWidth, sourceHeight);
            Rectangle dest = new Rectangle(sliceWidth, 0, sliceWidth, sourceHeight);

            Bitmap b2 = b1.Clone(source, PixelFormat.Format32bppArgb);
            b2.RotateFlip(RotateFlipType.RotateNoneFlipX);

            g.DrawImage(b1, source, source, GraphicsUnit.Pixel);
            g.DrawImage(b2, dest, source, GraphicsUnit.Pixel);
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            AboutDialog aboutDialog = new AboutDialog();
            aboutDialog.ShowDialog();
        }

        private void copyMirrorLeftBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(mirrorLeftImage.Image);
        }

        private void copyMirrorRightBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(mirrorRightImage.Image);
        }
    }
}
