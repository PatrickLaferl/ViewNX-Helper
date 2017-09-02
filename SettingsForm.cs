namespace ViewNxHelper
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class SettingsForm : Form
    {
        private static SettingsForm Instance = null;

        public static void ShowSingleton()
        {
            if (Instance == null)
            {
                new SettingsForm().Show();
            }
            else
            {
                Instance.Focus();
            }
        }

        public SettingsForm()
        {
            this.InitializeComponent();
            this.MinimumSize = new Size(this.MinimumSize.Width, this.Height);
            this.ApplySettings();
        }

        private void ApplySettings()
        {
            var settings = Properties.Settings.Default;
            this.progPathText.Text = settings.TargetProgramPath;
            this.procNameText.Text = settings.TargetProcName;
            this.loadTreshSpinner.Value = settings.LoadTreshold;
            this.intervalSpinner.Value = settings.UpdateInterval;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            var settings = Properties.Settings.Default;
            settings.TargetProgramPath = this.progPathText.Text;
            settings.TargetProcName = this.procNameText.Text;
            settings.LoadTreshold = (int)this.loadTreshSpinner.Value;
            settings.UpdateInterval = (int)this.intervalSpinner.Value;
            settings.Save();
            this.Close();
        }

        protected override void OnShown(EventArgs e)
        {
            Instance = this;
            base.OnShown(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            Instance = null;
            base.OnClosed(e);
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            var d = MessageBox.Show("Discard changed settings?", "Restore settings", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (d == DialogResult.OK)
            {
                Properties.Settings.Default.Reset();
                this.ApplySettings();
            }
        }
    }
}
