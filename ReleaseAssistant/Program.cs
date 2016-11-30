using ReleaseUtils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReleaseAssistant
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new ArgumentsHandler().Handle();
        }

        class ArgumentsHandler
        {
            private string mainProject = null;
            private string assemblyInfoFile = null;
            private string solution = null;
            private string metaFile = null;
            private Mege merge = Mege.None;

            internal ArgumentsHandler()
            {
                var configuration = new Configuration(Environment.GetCommandLineArgs());
                configuration.Register("mproject", ConfigMainProject);
                configuration.Register("solution", ConfigSolution);
                configuration.Register("merge", ConfigMerge);
                configuration.RunConfig();
            }

            private void ConfigMerge(string[] args)
            {
                if (args[0] == "assembly")
                    merge = Mege.PreferAssembly;
                else if (args[0] == "metadata")
                    merge = Mege.PreferMetadata;
            }

            private void ConfigMainProject(string[] args)
            {
                mainProject = args[0];
                assemblyInfoFile = Path.Combine(mainProject, "My Project", "AssemblyInfo.vb");
                if (!File.Exists(assemblyInfoFile))
                    assemblyInfoFile = Path.Combine(mainProject, "Properties", "AssemblyInfo.cs");
            }

            private void ConfigSolution(string[] args)
            {
                solution = args[0];
                metaFile = Path.Combine(solution, "Release.xml");
            }

            internal void Handle()
            {

                ReleaseInformation releaseInformation = null;
                if (!string.IsNullOrEmpty(metaFile))
                {
                    if (metaFile != null && assemblyInfoFile != null)
                        releaseInformation = ReleaseInformationHelper.Load(metaFile, assemblyInfoFile, merge);
                    else if (metaFile != null)
                        releaseInformation = ReleaseInformationHelper.LoadFromMeta(metaFile);
                    else if (assemblyInfoFile != null)
                        releaseInformation = ReleaseInformationHelper.LoadFromAssembly(assemblyInfoFile);
                }
                if (releaseInformation == null)
                    ShowHelp();
                else
                    ShowEditor(releaseInformation);
            }

            private void ShowEditor(ReleaseInformation releaseInformation)
            {
                MainForm mainForm = new MainForm(releaseInformation);
                Application.Run(mainForm);
            }

            private void ShowHelp()
            {
                StringBuilder builder = new StringBuilder();
                builder.AppendFormat("{0} v{1}\r\n", Application.ProductName, Application.ProductVersion);
                builder.AppendFormat("Author: {0}\r\n", Application.CompanyName);
                builder.AppendLine();
                builder.AppendFormat("Usage: {0} -solution solution-dir [-mproject project-dir] [-merge merge]\r\n", Application.ProductName);
                builder.AppendLine();
                builder.AppendFormat("  solution-dir    Specifies a solution directory path.\r\n");
                builder.AppendFormat("  project-dir     Specifies a main project path of the solution.\r\n");
                builder.AppendFormat("  -solution       .Net Solution that will be released.\r\n");
                builder.AppendFormat("  -mproject       .Net Project that is main project to retrieve version information.\r\n");
                builder.AppendFormat("  -merge          Merge options when both -solution and -mproject is defined.\r\n");
                builder.AppendFormat("                  assembly    Prefer assembly info file\r\n");
                builder.AppendFormat("                  metadata    Prefer exists meta file");
                string message = builder.ToString();
                XMessageBox.Show(message, string.Format("{0}::Help", Application.ProductName));
            }

        }
    }
}
