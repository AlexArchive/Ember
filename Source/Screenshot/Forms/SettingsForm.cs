using System;
using System.Windows.Forms;

namespace Screenshot.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            checkBoxEnableSoundEffect.Checked = checkBoxEnableSoundEffect.Enabled;
            hotkeyTextBoxRegion.Hotkey = Settings.Default.RegionHotkey;
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.EnableSoundEffect = checkBoxEnableSoundEffect.Checked;
            Settings.Default.RegionHotkey = hotkeyTextBoxRegion.Hotkey;
            Settings.Default.Save();
        }
    }
}
