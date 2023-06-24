using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MirrorFakePerson
{
    public class SimulatedMica
    {

        public SimulatedMica(Form form)
        {
            Form = form;
        }

        public Form Form { get; set; }

        private Timer BgCaptureTimer;

        private Bitmap ScreenshotForm()
        {
            Rectangle bounds = Form.Bounds;
            Bitmap bmp = new Bitmap(Form.Width, Form.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
            }

            return bmp;
        }

        public void CaptureSetColor(bool delayed = false)
        {
            // Take a screenshot of the form and set a sampled pixel of the titlebar as the form background color
            if (delayed)
            {
                BgCaptureTimer = new Timer();

                BgCaptureTimer.Tick += new EventHandler(BgCaptureTimerTick);
                BgCaptureTimer.Interval = 50;

                BgCaptureTimer.Start();
            } else
            {
                BgCaptureTimerTick(null, null);
            }
        }

        private void BgCaptureTimerTick(object sender, EventArgs e)
        {
            Bitmap formScreenshot = ScreenshotForm();

            Color titleBarColor = formScreenshot.GetPixel(formScreenshot.Width / 2, 9);

            if (titleBarColor.R + titleBarColor.G + titleBarColor.B >= 720)
            {
                Form.BackColor = titleBarColor;

                if (BgCaptureTimer != null)
                {
                    BgCaptureTimer.Stop();
                    BgCaptureTimer.Dispose();
                }
            }
        }
    }
}
