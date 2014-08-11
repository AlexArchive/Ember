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

        private void checkBoxEnableSoundEffect_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.EnableSoundEffect = checkBoxEnableSoundEffect.Checked;
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }
    }
}
