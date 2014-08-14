using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Screenshot
{
    public class ScreenshotUploader : IScreenshotHandler
    {
        public async void Handle(Image screenshot)
        {
            if (Settings.Default.UploadImage)
            {
                var screenshotBinary = ToByteArray(screenshot, ImageFormat.Png);

                using (var client = new ImgurScreenshotUploader())
                {
                    var imageLink = await client.Upload(screenshotBinary);

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
            using (var memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, format);
                return memoryStream.ToArray();
            }
        }
    }
}
