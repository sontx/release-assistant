using ReleaseUtils;
using System;
using System.IO;
using System.Windows.Forms;

namespace ReleaseAssistant
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                string solutionDir = args[0];
                string metaFile = Path.Combine(solutionDir, "Release.config");
                var releaseInformation = ReleaseInformationHelper.Load(metaFile);
                Application.Run(new MainForm(releaseInformation, metaFile));
            }
        }
    }
}
