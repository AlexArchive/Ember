using System;
using System.Diagnostics;
using System.Media;
using Screenshot.Properties;
using Shortcut;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Screenshot.Forms
{
    public partial class MainForm : Form
    {
        private readonly HotkeyBinder binder = new HotkeyBinder();

        public MainForm()
        {
            InitializeComponent();
            InitializeHotkeyBinder();
        }

        private void InitializeHotkeyBinder()
        {
            binder.Bind(Settings.Default.RegionHotkey).To(CaptureArea);
        }

        private void CaptureArea()
        {
            var dialog = new SelectAreaDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Capture(dialog.SelectedArea);
            }

            dialog.Dispose();
        }

        private static async void Capture(Rectangle area)
        {
            var screenshot = ScreenshotProvider.TakeScreenshot(area);

            if (Settings.Default.EnableSoundEffect) 
            {
                PlaySound(Resources.ShutterSound);
            }

            if (Settings.Default.UploadAfterCapture)
            {
                var screenshotBinary = ToByteArray(screenshot, ImageFormat.Png);

                using (var client = new ImgurClient())
                {
                    var imageLink = await client.UploadImageAsync(screenshotBinary);

                    if (Settings.Default.OnUploadCopyLinkToClipboard)
                    {
                        Clipboard.SetText(imageLink);
                    }
                    else if (Settings.Default.OnUploadOpenImageInBrowser)
                    {
                        Process.Start(imageLink);
                    }
                }
            }
        }

        public static byte[] ToByteArray(Image image, ImageFormat format)
        {
            using(var memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, format);
                return memoryStream.ToArray();
            }
        }

        public static void PlaySound(Stream soundStream)
        {
            using (var soundPlayer = new SoundPlayer(soundStream))
                soundPlayer.Play();
        }

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(false);
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            binder.Unbind(Settings.Default.RegionHotkey);

            var dialog = new SettingsForm();
            dialog.ShowDialog();
            dialog.Dispose();

            binder.Bind(Settings.Default.RegionHotkey).To(CaptureArea);
        }
    }
}
