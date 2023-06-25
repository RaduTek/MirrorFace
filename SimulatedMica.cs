using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MirrorFace
{
    public class SimulatedMica
    {

        public SimulatedMica(Form form)
        {
            Form = form;
        }

        public Form Form { get; set; }

        private Timer BgCaptureTimer;

        private int AttemptCounter = 0;

        private bool IsWindows11()
        {
            return Environment.OSVersion.Version.Build >= 22000;
        }

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
            if (!IsWindows11())
                return;

            // Take a screenshot of the form and set a sampled pixel of the titlebar as the form background color
            if (delayed)
            {
                if (BgCaptureTimer != null)
                {
                    BgCaptureTimer.Stop();
                    BgCaptureTimer.Dispose();
                }

                BgCaptureTimer = new Timer();
                AttemptCounter = 0;

                BgCaptureTimer.Tick += new EventHandler(BgCaptureTimerTick);
                BgCaptureTimer.Interval = 150;

                BgCaptureTimer.Start();
            } else
            {
                BgCaptureTimerTick(null, null);
            }
        }

        private void BgCaptureTimerTick(object sender, EventArgs e)
        {
            if (!IsWindows11())
                return;

            if (BgCaptureTimer != null)
            {
                BgCaptureTimer.Interval = 50;
            }

            Bitmap formScreenshot = ScreenshotForm();

            Color titleBarColor = formScreenshot.GetPixel(formScreenshot.Width / 2, 9);

            // Only capture light colors
            if (titleBarColor.R + titleBarColor.G + titleBarColor.B >= 700)
            {
                Form.BackColor = titleBarColor;

                if (BgCaptureTimer != null)
                {
                    BgCaptureTimer.Stop();
                    BgCaptureTimer.Dispose();
                }
            }

            // Prevent an infinite loop where no valid color is sampled
            if (AttemptCounter >= 50)
            {
                if (BgCaptureTimer != null)
                {
                    BgCaptureTimer.Stop();
                    BgCaptureTimer.Dispose();
                }
            }

            AttemptCounter += 1;
        }
    }
}
