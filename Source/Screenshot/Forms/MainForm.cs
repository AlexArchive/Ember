using System.Diagnostics;
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
            binder.Bind(Modifiers.Control, Keys.A).To(CaptureArea);
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

        private async void Capture(Rectangle area)
        {
            var screenshot = ScreenshotProvider.TakeScreenshot(area);

            if (Settings.Default.EnableSoundEffect) {
                // play sound effect.
            }

            var screenshotBinary = ToByteArray(screenshot, ImageFormat.Png);

            using (var client = new ImgurClient())
            {
                var imageLink = await client.UploadImageAsync(screenshotBinary);
                Process.Start(imageLink);
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

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(false);
        }

        private void preferencesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new SettingsForm().Show();
        }
    }
}
