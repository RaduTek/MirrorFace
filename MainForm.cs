using System;
using System.ComponentModel;
using System.Drawing;
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
            FlipImageVertically(false);
            FlipImageVertically(true);
        }

        private void FlipImageVertically(bool sideToFlip)
        {
            int sliceWidth = sideToFlip ? centerPosTrack.Value : sourceImage.Image.Width - centerPosTrack.Value;
            int sourceHeight = sourceImage.Image.Height;

            Bitmap b = new Bitmap(sliceWidth * 2, sourceHeight, sourceImage.Image.PixelFormat);

            if (sideToFlip)
                mirrorLeftImage.Image = b;
            else
                mirrorRightImage.Image = b;

            Graphics g = Graphics.FromImage(sideToFlip ? mirrorLeftImage.Image : mirrorRightImage.Image);

            Bitmap b1 = new Bitmap(sourceImage.Image);
            if (!sideToFlip) { 
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
