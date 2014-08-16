using System;
using System.Diagnostics;
using System.Media;
using Screenshot.Properties;
using Screenshot.Windows;
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
            binder.Bind(Settings.Default.CaptureAreaHotkey).To(CaptureArea);
            binder.Bind(Settings.Default.CaptureFullscreenHotkey).To(CaptureFullscreen);
            binder.Bind(Settings.Default.CaptureActiveWindowHotkey).To(CaptureActiveWindow);
        }

        private static void CaptureArea()
        {
            var dialog = new SelectAreaDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Capture(dialog.SelectedArea);
            }

            dialog.Dispose();
        }

        private static void CaptureFullscreen()
        {
            Capture(SystemInformation.VirtualScreen);
        }

        private static void CaptureActiveWindow()
        {
            var handle = NativeMethods.GetForegroundWindow();
            NativeRectangle rectangle;
            NativeMethods.GetWindowRect(handle, out rectangle);
            var area = rectangle.ToRectangle();
            Capture(area);
        }

        private static async void Capture(Rectangle area)
        {
            var screenshot = ScreenshotProvider.TakeScreenshot(area);

            if (Settings.Default.EnableSoundEffect)
            {
                PlaySound(Resources.ShutterSound);
            }

            if (Settings.Default.UploadImage)
            {
                var screenshotBinary = ToByteArray(screenshot, Settings.Default.UploadFormat);

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

            if (Settings.Default.SaveImage)
            {
                var directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                for (int number = 0; ; number++)
                {
                    var name = string.Concat("screenshot ", number, ".png");
                    var path = Path.Combine(directory, name);
                   
                    if (File.Exists(path)) continue;

                    screenshot.Save(path, Settings.Default.SaveFormat);
                    break;
                }
            }
        }

        public static byte[] ToByteArray(Image image, ImageFormat format)
        {
            using (var memoryStream = new MemoryStream())
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
            binder.Unbind(Settings.Default.CaptureAreaHotkey);
            binder.Unbind(Settings.Default.CaptureFullscreenHotkey);
            binder.Unbind(Settings.Default.CaptureActiveWindowHotkey);

            var dialog = new SettingsForm();
            dialog.ShowDialog();
            dialog.Dispose();

            InitializeHotkeyBinder();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
