using System.Collections.Generic;
using System.Drawing;

namespace Screenshot
{
    public class ScreenshotHandler : IScreenshotHandler
    {
        private readonly List<IScreenshotHandler> handlers;

        public ScreenshotHandler()
        {
            handlers = new List<IScreenshotHandler>();
            handlers.Add(new ScreenshotUploader());
            handlers.Add(new ScreenshotStore());
        }

        public void Handle(Image screenshot)
        {
            foreach (var handler in handlers)
                handler.Handle(screenshot);
        }
    }
}
