using System.Diagnostics;
using System.IO.Compression;
using System.Net;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace iiMenu.Injector
{
    public partial class iisStupidMenu : Form
    {
        public iisStupidMenu()
        {
            InitializeComponent();
            StartRotation();
            IconBob();
            _ = GetLatest();
        }

        private void closeApplication(object? sender = null, EventArgs? e = null)
        {
            this.Close();
        }

        private void onHover(object sender, EventArgs e)
        {
            if (!IsGorillaTagRunning())
                Inject.Text = "Open Gorilla Tag First!";
        }

        private void onLeave(object sender, EventArgs e)
        {
            Inject.Text = "Inject";
        }

        private async Task InjectMenuAsync()
        {
            if (!IsGorillaTagRunning())
                return;

            try
            {
                Inject.Visible = false;
                DescriptionBox.Visible = false;
                InjectStatus.Visible = true;
                VersionText.Font = new Font(VersionText.Font.FontFamily, 36, FontStyle.Italic | FontStyle.Bold);

                LoadingImage.Visible = true;
                LoadingBarBackground.Visible = true;
                LoadingBarText.Visible = true;
                LoadingBarText.BringToFront();

                SetLoadingStatus(0, "Starting injection process");

                await Task.Delay(100);

                string tempPath = Path.GetTempPath();
                string zipPath = Path.Combine(tempPath, "smi.zip");
                string extractPath = Path.Combine(tempPath, "SharpMonoInjector.Console");

                if (Directory.Exists(extractPath))
                    Directory.Delete(extractPath, true);

                SetLoadingStatus(0.2f, "Downloading SharpMonoInjector");

                using (WebClient client = new())
                {
                    await client.DownloadFileTaskAsync("https://github.com/warbler/SharpMonoInjector/releases/download/v2.2/SharpMonoInjector.Console.zip", zipPath);
                }

                SetLoadingStatus(0.4f, "Extracting ZIP");

                ZipFile.ExtractToDirectory(zipPath, extractPath);

                string smiFolder = Path.Combine(extractPath, "SharpMonoInjector.Console");
                string smiPath = Path.Combine(smiFolder, "smi.exe");

                string menuPath = Path.Combine(smiFolder, "iis_Stupid_Menu.dll");
                using (WebClient client = new())
                {
                    SetLoadingStatus(0.6f, "Downloading latest release");
                    await client.DownloadFileTaskAsync("https://github.com/iiDk-the-actual/iis.Stupid.Menu/releases/latest/download/iis_Stupid_Menu.dll", menuPath); 
                }

                if (!File.Exists(menuPath))
                {
                    MessageBox.Show("Menu could not be found. Please create an issue on the repository.");
                    closeApplication();
                    return;
                }

                SetLoadingStatus(0.8f, "Injecting with SharpMonoInjector");

                Process process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = smiPath,

                        Arguments = $"inject -p \"Gorilla Tag\" -a \"{menuPath}\" -n iiMenu -c Plugin -m Inject",
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true
                    }
                };

                process.Start();

                await process.WaitForExitAsync();

                //string output = process.StandardOutput.ReadToEnd();
                //string error = process.StandardError.ReadToEnd();

                //MessageBox.Show("OUTPUT:\n" + output);
                //MessageBox.Show("ERROR:\n" + error);

                SetLoadingStatus(1f, "Successfully injected");
                await closeWithDelay();
            } catch {
                MessageBox.Show("An error occurred while trying to inject the menu. Please try again, and if this keeps occuring, report this to the GitHub issues page.");
                closeApplication();
                return;
            }
        }

        public async Task closeWithDelay()
        {
            rotationTimer.Stop();
            LoadingImage.Visible = true;
            LoadingImage.BackgroundImage = Properties.Resources.success;
            LoadingImage.Location = new Point(133, 100);
            await Task.Delay(3000);
            closeApplication();
        }

        private bool hasClickedInject;
        private void onClickInject(object sender, MouseEventArgs e)
        {
            if (!hasClickedInject)
            {
                hasClickedInject = true;
                _ = InjectMenuAsync();
            }
        }

        private void SetLoadingStatus(float percent, string status)
        {
            VersionText.Text = percent == 1 ? "Injected!" : "Injecting...";
            InjectStatus.Text = status;
            InjectStatus.Visible = percent != 1;
            LoadingBarText.Size = new Size((int)(410 * percent), 23);
            LoadingBarText.Text = $"{MathF.Ceiling(percent*100)}%";
        }
    }
}
