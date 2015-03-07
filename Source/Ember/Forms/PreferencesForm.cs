using System;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Ember.Extension;

namespace Ember.Forms
{
    public partial class PreferencesForm : Form
    {
        private readonly ExtensionBootstrap extensionBootstrap = new ExtensionBootstrap();

        public PreferencesForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            checkBoxEnableSoundEffect.Checked       = Settings.Default.EnableSoundEffect;
            hotkeyTextBoxCaptureArea.Hotkey         = Settings.Default.CaptureAreaHotkey;
            checkBoxUploadImage.Checked             = Settings.Default.UploadImage;
            radioButtonCopyLinkToClipboard.Checked  = Settings.Default.OnUploadCopyLinkToClipboard;
            radioButtonOpenImageInBrowser.Checked   = Settings.Default.OnUploadOpenImageInBrowser;
            hotkeyTextBoxCaptureFullscreen.Hotkey   = Settings.Default.CaptureFullscreenHotkey;
            hotkeyTextBoxCaptureActiveWindow.Hotkey = Settings.Default.CaptureActiveWindowHotkey;
            checkBoxSaveImage.Checked               = Settings.Default.SaveImage;
            comboBoxSaveFormat.SelectedItem         = Settings.Default.SaveFormat.ToString();
            comboBoxUploadFormat.SelectedItem       = Settings.Default.UploadFormat.ToString();
            checkBoxStartWithWindows.Checked        = Installer.Installed;
            textBoxSaveDirectory.Text               = Settings.Default.SaveDirectory;
            comboBoxHost.DataSource                 = extensionBootstrap.ExtensionNames;
            comboBoxHost.SelectedItem               = Settings.Default.Host;
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.EnableSoundEffect           = checkBoxEnableSoundEffect.Checked;
            Settings.Default.CaptureAreaHotkey           = hotkeyTextBoxCaptureArea.Hotkey;
            Settings.Default.UploadImage                 = checkBoxUploadImage.Checked;
            Settings.Default.OnUploadCopyLinkToClipboard = radioButtonCopyLinkToClipboard.Checked;
            Settings.Default.OnUploadOpenImageInBrowser  = radioButtonOpenImageInBrowser.Checked;
            Settings.Default.CaptureFullscreenHotkey     = hotkeyTextBoxCaptureFullscreen.Hotkey;
            Settings.Default.CaptureActiveWindowHotkey   = hotkeyTextBoxCaptureActiveWindow.Hotkey;
            Settings.Default.SaveImage                   = checkBoxSaveImage.Checked;
            Settings.Default.UploadFormat                = Convert(comboBoxUploadFormat.SelectedItem);
            Settings.Default.SaveFormat                  = Convert(comboBoxSaveFormat.SelectedItem);
            Settings.Default.SaveDirectory               = textBoxSaveDirectory.Text;
            Settings.Default.Host                        = comboBoxHost.SelectedItem.ToString();

            Install();

            Settings.Default.Save();
        }

        private ImageFormat Convert(object selectedItem)
        {
            var selectedText = selectedItem.ToString();

            if (selectedText == "Png")  return ImageFormat.Png;
            if (selectedText == "Jpeg") return ImageFormat.Jpeg;
            if (selectedText == "Bmp")  return ImageFormat.Bmp;
            if (selectedText == "Gif")  return ImageFormat.Gif;

            throw new NotSupportedException();
        }

        private void Install()
        {
            if (checkBoxStartWithWindows.Checked)
            {
                Installer.Install();
            }
            else
            {
                Installer.Uninstall();
            }
        }

        private void buttonOpenDirectory_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxSaveDirectory.Text = dialog.SelectedPath;
            }
            dialog.Dispose();
        }
    }
}
