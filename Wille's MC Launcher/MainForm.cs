using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.Installer;
using CmlLib.Core.Files;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CmlLib.Core.Downloader;
using CmlLibWinFormSample;

namespace Wille_s_MC_Launcher
{
    public partial class MainForm : Form
    {
        public MainForm(MSession session)
        {
            this.session = session;
            InitializeComponent();
        }

        CMLauncher launcher;
        readonly MSession session;
        MinecraftPath gamePath;

        bool useMJava = true;
        string javaPath = "java.exe";

        GameLog logForm;
        private int uiThreadId = Thread.CurrentThread.ManagedThreadId;

        private async void MainForm_Shown(object sender, EventArgs e)
        {
            // Initialize launcher
            this.Refresh();

            var defaultPath = new MinecraftPath(MinecraftPath.GetOSDefaultPath());
            await initializeLauncher(defaultPath);
        }

        private async Task initializeLauncher(MinecraftPath path)
        {
            txtPath.Text = path.BasePath;
            this.gamePath = path;

            if (useMJava)
                lbJavaPath.Text = path.Runtime;

            launcher = new CMLauncher(path);
            launcher.FileChanged += Launcher_FileChanged;
            launcher.ProgressChanged += Launcher_ProgressChanged;
            await refreshVersions(null);
        }

        private void Launcher_FileChanged(DownloadFileChangedEventArgs e)
        {
            if (Thread.CurrentThread.ManagedThreadId != uiThreadId)
            {
                Debug.WriteLine(e);
            }
            Pb_File.Maximum = e.TotalFileCount;
            Pb_File.Value = e.ProgressedFileCount;
            Lv_Status.Text = $"{e.FileKind} : {e.FileName} ({e.ProgressedFileCount}/{e.TotalFileCount})";
        }

        private void Launcher_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (Thread.CurrentThread.ManagedThreadId != uiThreadId)
            {
                Debug.WriteLine(e);
            }
            Pb_Progress.Maximum = 100;
            Pb_Progress.Value = e.ProgressPercentage;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void Btn_Launch_Click(object sender, EventArgs e)
        {
            if (session == null)
            {
                MessageBox.Show("Oops, we could not verify your session.");
                return;
            }

            if (cbVersion.Text == "")
            {
                MessageBox.Show("You need to select a version first.");
                return;
            }

            // disable ui
            setUIEnabled(false);

            try
            {
                // create LaunchOption
                var launchOption = new MLaunchOption()
                {
                    MaximumRamMb = int.Parse(TxtXmx.Text),
                    Session = this.session,
                };

                if (!useMJava)
                    launchOption.JavaPath = javaPath;

                if (!string.IsNullOrEmpty(txtXms.Text))
                    launchOption.MinimumRamMb = int.Parse(txtXms.Text);

                if (rbParallelDownload.Checked)
                {
                    System.Net.ServicePointManager.DefaultConnectionLimit = 256;
                    launcher.FileDownloader = new AsyncParallelDownloader();
                }
                else
                    launcher.FileDownloader = new SequenceDownloader();

                // check file hash or don't check
                launcher.GameFileCheckers.AssetFileChecker.CheckHash = cbSkipHashCheck.Checked;
                launcher.GameFileCheckers.ClientFileChecker.CheckHash = cbSkipHashCheck.Checked;
                launcher.GameFileCheckers.LibraryFileChecker.CheckHash = cbSkipHashCheck.Checked;

                if (cbSkipAssets.Checked)
                    launcher.GameFileCheckers.AssetFileChecker = null;

                var process = await launcher.CreateProcessAsync(cbVersion.Text, launchOption); // Create Arguments and Process

                // process.Start(); // Just start game, or
                StartProcess(process); // Start Process with debug options
            }
            catch (FormatException fex) // int.Parse exception
            {
                MessageBox.Show("Failed to create MLaunchOption\n\n" + fex);
            }
            catch (MDownloadFileException mex) // download exception
            {
                MessageBox.Show(
                    $"FileName : {mex.ExceptionFile.Name}\n" +
                    $"FilePath : {mex.ExceptionFile.Path}\n" +
                    $"FileUrl : {mex.ExceptionFile.Url}\n" +
                    $"FileType : {mex.ExceptionFile.Type}\n\n" +
                    mex.ToString());
            }
            catch (Win32Exception wex) // java exception
            {
                MessageBox.Show(wex + "\n\nOops, we found a problem in your Java.");
            }
            catch (Exception ex) // all exception
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // re open log form
                if (logForm != null)
                    logForm.Close();

                logForm = new GameLog();
                logForm.Show();

                // enable ui
                setUIEnabled(true);
            }
        }

        private void setUIEnabled(bool value)
        {
            gMojangLogin.Enabled = value;
            guna2GroupBox1.Enabled = value;
            guna2GroupBox2.Enabled = value;
        }

        private void StartProcess(Process process)
        {
            File.WriteAllText("launcher.txt", process.StartInfo.Arguments);
            output(process.StartInfo.Arguments);

            // process options to display game log

            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.EnableRaisingEvents = true;
            process.ErrorDataReceived += Process_ErrorDataReceived;
            process.OutputDataReceived += Process_OutputDataReceived;

            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            output(e.Data);
        }

        private void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            output(e.Data);
        }

        void output(string msg)
        {
            GameLog.AddLog(msg);
        }

        private void btnSetLastVersion_Click(object sender, EventArgs e)
        {
            cbVersion.Text = launcher.Versions.LatestReleaseVersion?.Name;
        }

        private async void btnRefreshVersion_Click(object sender, EventArgs e)
        {
            await refreshVersions(null);
        }

        private async Task refreshVersions(string showVersion)
        {
            cbVersion.Items.Clear();

            var versions = await launcher.GetAllVersionsAsync();

            bool showVersionExist = false;
            foreach (var item in versions)
            {
                if (showVersion != null && item.Name == showVersion)
                    showVersionExist = true;
                cbVersion.Items.Add(item.Name);
            }

            if (showVersion == null || !showVersionExist)
                btnSetLastVersion_Click(null, null);
            else
                cbVersion.Text = showVersion;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            /*
            setUIEnabled(false);
            new Thread(() =>
            {
                var forgeJava = "";

                if (useMJava)
                {
                    var java = new MJava();
                    java.ProgressChanged += Launcher_ProgressChanged;
                    forgeJava = java.CheckJava();
                }
                else
                    forgeJava = javaPath;

                Invoke(new Action(async () =>
                {
                    var forgeForm = new ForgeInstall(gamePath, forgeJava);
                    forgeForm.ShowDialog();
                    setUIEnabled(true);
                    await refreshVersions(forgeForm.LastInstalledVersion);
                }));
            }).Start();
            */
        }
    }
}
