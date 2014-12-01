using System;
using System.Drawing;
using Ember.Windows;

namespace Ember
{
    public static class ScreenshotProvider
    {
        public static Bitmap TakeScreenshot(Rectangle area)
        {
            // Use the Windows API here instead of the managed equivalent because the
            // managed equivalent has a number of bugs.

            IntPtr handleDesktopWindow = NativeMethods.GetDesktopWindow();
            IntPtr handleSource = NativeMethods.GetWindowDC(handleDesktopWindow);
            IntPtr handleDestination = NativeMethods.CreateCompatibleDC(handleSource);
            IntPtr handleBitmap = NativeMethods.CreateCompatibleBitmap(handleSource, area.Width, area.Height);
            IntPtr handleOldBitmap = NativeMethods.SelectObject(handleDestination, handleBitmap);

            NativeMethods.BitBlt(
                handleDestination,
                0,
                0,
                area.Width,
                area.Height,
                handleSource,
                area.X,
                area.Y,
                CopyPixelOperation.SourceCopy | CopyPixelOperation.CaptureBlt);

            Bitmap screenshot = Image.FromHbitmap(handleBitmap);
            NativeMethods.SelectObject(handleDestination, handleOldBitmap);
            NativeMethods.DeleteObject(handleBitmap);
            NativeMethods.DeleteDC(handleDestination);
            NativeMethods.ReleaseDC(handleDesktopWindow, handleSource);

            return screenshot;
        }
    }
}