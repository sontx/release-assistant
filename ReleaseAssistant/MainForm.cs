using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReleaseAssistant
{
    public partial class MainForm : Form
    {
        public ReleaseInformation ReleaseInformation { get; private set; }

        public MainForm(ReleaseInformation _releaseInformation)
        {
            InitializeComponent();
            this.ReleaseInformation = _releaseInformation;
            LoadToUI(_releaseInformation);
        }

        private void LoadToUI(ReleaseInformation _releaseInformation)
        {
            btnMajor.Value = _releaseInformation.Version.Major;
            btnMinor.Value = _releaseInformation.Version.Minor;
            btnBuild.Value = _releaseInformation.Version.Build;
            btnRevision.Value = _releaseInformation.Version.Revision;

            txtFriendlyVersion.Text = _releaseInformation.FriendlyVersion;
            txtReleaseNotes.Text = _releaseInformation.ReleaseNotes;
        }

        private void btnMajor_Click(object sender, EventArgs e)
        {

        }

        private void btnMinor_Click(object sender, EventArgs e)
        {

        }

        private void btnBuild_Click(object sender, EventArgs e)
        {

        }

        private void btnRevision_Click(object sender, EventArgs e)
        {

        }

        private void btnQuicklyMajor_Click(object sender, EventArgs e)
        {

        }

        private void btnQuicklyMinor_Click(object sender, EventArgs e)
        {

        }

        private void btnQuicklyBuild_Click(object sender, EventArgs e)
        {

        }

        private void btnQuicklyRevision_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}
