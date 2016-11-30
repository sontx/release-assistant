using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ReleaseAssistant
{
    class XTextBox : TextBox
    {
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private string _hint;
        
        [Browsable(true)]
        public string Hint
        {
            get { return _hint; }
            set
            {
                _hint = value;
                SendMessage(Handle, 0x1501, 1, _hint);
            }
        }
    }
}
