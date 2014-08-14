using System.Drawing;

namespace Screenshot
{
    public interface IScreenshotHandler
    {
        void Handle(Image screenshot);
    }
}