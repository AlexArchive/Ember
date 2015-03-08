using Ember.Extension;
using Ember.Properties;
using Ember.Windows;
using Shortcut;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Windows.Forms;

namespace Ember.Forms
{
    public partial class MainForm : Form
    {
        private readonly HotkeyBinder hotkeyBinder = new HotkeyBinder();
        private readonly ExtensionBootstrap extensionBootstrap = new ExtensionBootstrap();

        public MainForm()
        {
            InitializeComponent();
            InitializeHotkeyBinder();
            InitializeExtensions();
        }

        private void InitializeHotkeyBinder()
        {
            hotkeyBinder.Bind(Settings.Default.CaptureAreaHotkey).To(CaptureArea);
            hotkeyBinder.Bind(Settings.Default.CaptureFullscreenHotkey).To(CaptureFullscreen);
            hotkeyBinder.Bind(Settings.Default.CaptureActiveWindowHotkey).To(CaptureActiveWindow);
        }

        private void InitializeExtensions()
        {
            if (!extensionBootstrap.ExtensionExists(
                extensionName: Settings.Default.Host))
            {
                string fallbackHost = extensionBootstrap.ExtensionCache.First().Key;

                Settings.Default.Host = fallbackHost;
                Settings.Default.Save();

                ShowBalloonTip(
                    string.Format(
                        "Ember could not resolve the {0} extension. Ember will default to {1} for your default image host.",
                        Settings.Default.Host, fallbackHost),
                    "Whops",
                    ToolTipIcon.Warning);
            }
        }

        private void ShowBalloonTip(
            string message,
            string title = "",
            ToolTipIcon icon = ToolTipIcon.None)
        {
            notifyIcon.BalloonTipIcon = icon;
            notifyIcon.BalloonTipText = message;
            notifyIcon.BalloonTipTitle = title;
            notifyIcon.ShowBalloonTip(1000);
        }

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(false);
        }

        private void CaptureArea()
        {
            var screenshot = ScreenshotProvider.TakeScreenshot(SystemInformation.VirtualScreen);
            var dialog = new SelectAreaDialog(screenshot);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap croppedScreenshot = screenshot.Clone(
                    dialog.SelectedArea,
                    screenshot.PixelFormat);
                ProcessScreenshot(croppedScreenshot);
            }
            dialog.Dispose();
        }

        private void CaptureFullscreen()
        {
            Bitmap screenshot = ScreenshotProvider.TakeScreenshot(SystemInformation.VirtualScreen);
            ProcessScreenshot(screenshot);
        }

        private void CaptureActiveWindow()
        {
            IntPtr winHandle = NativeMethods.GetForegroundWindow();
            NativeRectangle winRectangle;
            NativeMethods.GetWindowRect(winHandle, out winRectangle);
            Rectangle area = winRectangle.ToRectangle();

            Bitmap screenshot = ScreenshotProvider.TakeScreenshot(area);
            ProcessScreenshot(screenshot);
        }

        private async void ProcessScreenshot(Bitmap screenshot)
        {

            if (Settings.Default.EnableSoundEffect)
            {
                PlaySound(Resources.ShutterSound);
            }

            if (Settings.Default.UploadImage)
            {
                try
                {
                    byte[] screenshotBinary = SerializeScreenshot(screenshot, Settings.Default.UploadFormat);
                    IImageUploader uploader = extensionBootstrap.ResolveExtension(Settings.Default.Host);
                    string imageLink = await uploader.UploadImageAsync(screenshotBinary);

                    if (Settings.Default.OnUploadCopyLinkToClipboard)
                    {
                        Clipboard.SetText(imageLink);
                    }
                    else if (Settings.Default.OnUploadOpenImageInBrowser)
                    {
                        Process.Start(imageLink);
                    }
                }
                catch (HttpRequestException)
                {
                    ShowBalloonTip(
                        string.Format(
                            "Ember failed to upload your image to {0}. It could be that {0} is temporarily offline. You should try again in a few moments.",
                            Settings.Default.Host),
                        "Whops",
                        ToolTipIcon.Error);
                }
            }

            if (Settings.Default.SaveImage)
            {
                if (!Directory.Exists(Settings.Default.SaveDirectory))
                {
                    Directory.CreateDirectory(Settings.Default.SaveDirectory);
                }

                for (int number = 0; ; number++)
                {
                    string name = string.Concat("screenshot ", number, ".png");
                    string path = Path.Combine(Settings.Default.SaveDirectory, name);

                    if (File.Exists(path) == false)
                    {
                        screenshot.Save(path, Settings.Default.SaveFormat);
                        break;
                    }
                }
            }
        }

        public static byte[] SerializeScreenshot(Image screenshot, ImageFormat format)
        {
            using (var stream = new MemoryStream())
            {
                screenshot.Save(stream, format);
                return stream.ToArray();
            }
        }

        public static void PlaySound(Stream soundStream)
        {
            using (var player = new SoundPlayer(soundStream))
                player.Play();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hotkeyBinder.Unbind(Settings.Default.CaptureAreaHotkey);
            hotkeyBinder.Unbind(Settings.Default.CaptureFullscreenHotkey);
            hotkeyBinder.Unbind(Settings.Default.CaptureActiveWindowHotkey);

            var preferencesForm = new PreferencesForm();
            preferencesForm.ShowDialog();
            preferencesForm.Dispose();

            InitializeHotkeyBinder();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}