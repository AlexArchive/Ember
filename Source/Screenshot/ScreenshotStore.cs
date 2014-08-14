using System;
using System.Drawing;
using System.IO;

namespace Screenshot
{
    public class ScreenshotStore : IScreenshotHandler
    {
        public void Handle(Image screenshot)
        {
            if (Settings.Default.SaveImage)
            {
                var directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                for (int number = 0; ; number++)
                {
                    var name = string.Concat("screenshot ", number, ".png");
                    var path = Path.Combine(directory, name);

                    if (File.Exists(path)) continue;

                    screenshot.Save(path);
                    break;
                }
            }
        }
    }
}
