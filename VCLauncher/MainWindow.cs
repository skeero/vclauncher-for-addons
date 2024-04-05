using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace VCLauncher
{
    public partial class MainWindow : Form
    {
        private string selectedAddon;

        /// <summary>
        /// MainWindow constructor.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Exit the application when you click the "Exit" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitApp_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Launches the game with specified addon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LaunchTheGame_Click(object sender, EventArgs e)
        {
            if (selectedAddon.Contains("Classic"))
            {
                Runner.Run("", "vietcong.exe");
            }
            else
            {
                Runner.Run(selectedAddon, "vietcong.exe");
            }

            Environment.Exit(0);
        }

        /// <summary>
        /// Fix the hosts file and checks for vietcong.exe file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            string hostsFile = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\system32\\drivers\\etc\\hosts";

            try
            {
                string content = IO.ReadFile(hostsFile);

                if (!content.Contains("master.gamespy.com") && !content.Contains("46.28.109.117"))
                {
                    IO.WriteFile(hostsFile, content + "\n\n46.28.109.117 master.gamespy.com         # master server vietcong1.eu");
                    Networking.FlushDnsCache();
                }
            }
            catch { }

            if (File.Exists("vietcong.exe"))
            {
                if (Directory.Exists("addons"))
                {
                    foreach (var addon in Directory.GetDirectories(Environment.CurrentDirectory + "\\addons"))
                    {
                        AddonsList.Items.Add(addon);
                    }
                }

                AddonsList.Items.Add("Classic");
            }
            else
            {
                MessageBox.Show("File vietcong.exe not found. Abort!", "VCLauncher - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Save the addon name to the variable to run.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddonSelect(object sender, EventArgs e)
        {
            try
            {
                selectedAddon = AddonsList.SelectedItem.ToString();
                LaunchTheGame.Enabled = true;
            }
            catch { }
        }

        /// <summary>
        /// Open creator's github page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLinkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/skeero/vclauncher-for-addons");
        }
    }
}
