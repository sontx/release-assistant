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
