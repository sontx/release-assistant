using ReleaseUtils;
using System;
using System.Windows.Forms;

namespace ReleaseAssistant
{
    public partial class MainForm : Form
    {
        public ReleaseInformation ReleaseInformation { get; private set; }
        public string MetaFile { get; private set; }

        public MainForm(ReleaseInformation _releaseInformation, string metaFile)
        {
            InitializeComponent();
            this.ReleaseInformation = _releaseInformation;
            this.MetaFile = metaFile;
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

        private void btnQuicklyMajor_Click(object sender, EventArgs e)
        {
            btnMajor.Increase();
        }

        private void btnQuicklyMinor_Click(object sender, EventArgs e)
        {
            btnMinor.Increase();
        }

        private void btnQuicklyBuild_Click(object sender, EventArgs e)
        {
            btnBuild.Increase();
        }

        private void btnQuicklyRevision_Click(object sender, EventArgs e)
        {
            btnRevision.Increase();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var newReleaseInformation = new ReleaseInformation();
            newReleaseInformation.Version = new Version(btnMajor.Value, btnMinor.Value, btnBuild.Value, btnRevision.Value);
            newReleaseInformation.FriendlyVersion = txtFriendlyVersion.Text.Trim();
            newReleaseInformation.ReleaseDate = ReleaseInformation.ReleaseDate;
            newReleaseInformation.ReleaseNotes = txtReleaseNotes.Text;
            if (newReleaseInformation.Version.CompareTo(ReleaseInformation.Version) <= 0)
            {
                if (MessageBox.Show(this, "You should increase the version number for this release.",
                    Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    return;
                }
            }
            ReleaseInformationHelper.Save(newReleaseInformation, MetaFile);
            Close();
        }
    }
}
