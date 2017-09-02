namespace ViewNxHelper
{
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        private enum State
        {
            Inactive,
            Ready,
            Busy,
        }

        private Timer startTimer;
        private Timer updateTimer;
        private PerformanceCounter processCpu;

        public MainForm()
        {
            this.InitializeComponent();

            this.updateTimer = new Timer();
            this.updateTimer.Interval = this.Settings.UpdateInterval;
            this.updateTimer.Tick += this.UpdateTimer_Tick;

            this.startTimer = new Timer();
            this.startTimer.Interval = this.Settings.UpdateInterval;
            this.startTimer.Tick += this.StartTimer_Tick;
            this.startTimer.Start();

            if (Process.GetProcessesByName(this.Settings.TargetProcName).Length < 1)
            {
                this.StartProgram();
            }

            this.SetState(State.Ready);
            this.TryStartUpdate();
        }

        private Properties.Settings Settings
        {
            get
            {
                return Properties.Settings.Default;
            }
        }

        private void SetState(State s)
        {
            Bitmap bmp = null;
            switch (s)
            {
                case State.Inactive:
                    bmp = Properties.Resources.status_icon_inactive;
                    break;
                case State.Ready:
                    bmp = Properties.Resources.status_icon_ready;
                    break;
                case State.Busy:
                    bmp = Properties.Resources.status_icon_busy;
                    break;
            }
            this.notifyIcon.Icon = Icon.FromHandle(bmp.GetHicon());
        }

        private void StopUpdate()
        {
            this.updateTimer.Stop();
            this.startTimer.Start();
        }

        private void TryStartUpdate()
        {
            try
            {
                this.processCpu = new PerformanceCounter("Process", "% Processor Time", this.Settings.TargetProcName);
                this.processCpu.NextValue();
            }
            catch
            {
                return;
            }

            this.startTimer.Stop();
            this.updateTimer.Start();

            this.TryUpdate();
        }

        private void HideWindow()
        {
            this.Location = new Point(short.MinValue, short.MinValue);
        }

        private void RepositionWindow()
        {
            var proc = Process.GetProcessesByName(this.Settings.TargetProcName)[0];
            var handle = proc.MainWindowHandle;

            var focus = GetForegroundWindow();
            if (handle == focus)
            {
                RECT r;
                GetWindowRect(handle, out r);
                int x = r.Right - this.Width;
                int y = r.Top;
                x -= 8;
                y += 31;
                x += 1;
                y -= 1;
                this.Location = new Point(x, y);
            }
            else
            {
                this.HideWindow();
            }
        }

        private void TryUpdate()
        {
            try
            {
                var value = this.processCpu.NextValue() / Environment.ProcessorCount;
                if (value > this.Settings.LoadTreshold)
                {
                    this.BackgroundImage = Properties.Resources.busy_icon;
                    this.SetState(State.Busy);
                }
                else
                {
                    this.BackgroundImage = null;
                    this.SetState(State.Ready);
                }

                this.RepositionWindow();
            }
            catch
            {
                this.SetState(State.Inactive);
                this.HideWindow();
                this.StopUpdate();
            }
        }

        private void StartProgram()
        {
            try
            {
                Process.Start(this.Settings.TargetProgramPath);
            }
            catch (Exception ex)
            {
                string text = $"Error starting \"{this.Settings.TargetProgramPath}\":\n\n";
                text += ex.Message;
                MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartTimer_Tick(object sender, EventArgs e)
        {
            this.TryStartUpdate();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            this.TryUpdate();
        }

        private void startViewNXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.StartProgram();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm.ShowSingleton();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
