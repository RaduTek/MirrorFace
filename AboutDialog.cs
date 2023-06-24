using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MirrorFakePerson
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/RaduTek/MirrorFakePerson");
        }

        private void AboutDialog_Load(object sender, EventArgs e)
        {
            string versionString = Application.ProductVersion;

            // Remove the ".0" chain from the end of the version string
            while(versionString.EndsWith(".0"))
            {
                versionString = versionString.Substring(0, versionString.Length - 2);
            }

            versionLabel.Text = "Version " + versionString;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
