using System.Windows.Forms;

namespace ReleaseAssistant
{
    public partial class XMessageBox : Form
    {
        public XMessageBox()
        {
            InitializeComponent();
        }

        public static void Show(string message, string text)
        {
            XMessageBox box = new XMessageBox();
            box.labMessage.Text = message;
            box.Text = text;
            box.ShowDialog();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
