using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            pictureBox1.Load("https://thispersondoesnotexist.com/image");

            FlipImages();
        }

        private void FlipImages()
        {
            pictureBox2.Image = (Image)pictureBox1.Image.Clone();
            pictureBox3.Image = (Image)pictureBox1.Image.Clone();

            flip1(pictureBox2.Image);
            flip2(pictureBox3.Image);
        }

        private void flip1(Image i)
        {
            Graphics g = Graphics.FromImage(i);

            Bitmap b1 = new Bitmap(i);

            Rectangle source = new Rectangle(0, 0, i.Width / 2, i.Height);
            Rectangle dest = new Rectangle(i.Width / 2, 0, i.Width / 2, i.Height);

            Bitmap b2 = b1.Clone(source, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            b2.RotateFlip(RotateFlipType.RotateNoneFlipX);

            g.DrawImage(b2, dest);
        }

        private void flip2(Image i)
        {
            Graphics g = Graphics.FromImage(i);

            Bitmap b1 = new Bitmap(i);

            Rectangle source = new Rectangle(i.Width / 2, 0, i.Width / 2, i.Height);
            Rectangle dest = new Rectangle(0, 0, i.Width / 2, i.Height);

            Bitmap b2 = b1.Clone(source, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            b2.RotateFlip(RotateFlipType.RotateNoneFlipX);

            g.DrawImage(b2, dest);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

            FlipImages();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                pictureBox1.Image = Clipboard.GetImage();

                FlipImages();
            } else
            {
                MessageBox.Show(this, "Clipboard data is not an image.", "Error pasting image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
