using System;
using System.Drawing.Imaging;
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
    }
}
