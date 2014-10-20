using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Media;
using System.Windows.Forms;
using Ember.Extension;
using Ember.Properties;
using Ember.Windows;
using Shortcut;

namespace Ember.Forms
{
    public partial class MainForm : Form
    {
        private readonly HotkeyBinder binder = new HotkeyBinder();
        private readonly ExtensionBootstrap extensionBootstrap = new ExtensionBootstrap();

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

        private void CaptureArea()
        {
            var dialog = new SelectAreaDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Capture(dialog.SelectedArea);
            }

            dialog.Dispose();
        }

        private void CaptureFullscreen()
        {
            Capture(SystemInformation.VirtualScreen);
        }

        private void CaptureActiveWindow()
        {
            var handle = NativeMethods.GetForegroundWindow();
            NativeRectangle rectangle;
            NativeMethods.GetWindowRect(handle, out rectangle);
            var area = rectangle.ToRectangle();
            Capture(area);
        }

        private new async void Capture(Rectangle area)
        {
            var screenshot = ScreenshotProvider.TakeScreenshot(area);

            if (Settings.Default.EnableSoundEffect)
            {
                PlaySound(Resources.ShutterSound);
            }

            if (Settings.Default.UploadImage)
            {
                var screenshotBinary = ConvertToByteArray(screenshot, Settings.Default.UploadFormat);
                var uploader = extensionBootstrap.ResolveExtension(Settings.Default.Host);
                var imageLink = await uploader.UploadImageAsync(screenshotBinary);

                if (Settings.Default.OnUploadCopyLinkToClipboard)
                {
                    Clipboard.SetText(imageLink);
                }
                else if (Settings.Default.OnUploadOpenImageInBrowser)
                {
                    Process.Start(imageLink);
                }
            }

            if (Settings.Default.SaveImage)
            {
                var directory = Settings.Default.SaveDirectory;

                for (int number = 0; ; number++)
                {
                    var name = string.Concat("screenshot ", number, ".png");
                    var path = Path.Combine(directory, name);

                    if (File.Exists(path) == false)
                    {
                        screenshot.Save(path, Settings.Default.SaveFormat);
                        break;
                    }
                }
            }
        }

        public static byte[] ConvertToByteArray(Image image, ImageFormat format)
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
