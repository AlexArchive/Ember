using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Screenshot.Windows
{
    internal static class NativeMethods
    {
        [DllImport("user32.dll")]
        internal static extern IntPtr GetDC(IntPtr windowHandle);

        [DllImport("user32.dll")]
        internal static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll")]
        internal static extern bool ReleaseDC(IntPtr windowHandle, IntPtr dcHandle);

        [DllImport("user32.dll")]
        internal static extern IntPtr GetWindowDC(IntPtr windowHandle);

        [DllImport("gdi32.dll")]
        internal static extern IntPtr CreateCompatibleDC(IntPtr dcHandle);

        [DllImport("gdi32.dll")]
        internal static extern bool DeleteDC(IntPtr dcHandle);

        [DllImport("gdi32.dll")]
        internal static extern bool DeleteObject(IntPtr objectHandle);

        [DllImport("gdi32.dll")]
        internal static extern IntPtr SelectObject(IntPtr dcHandle, IntPtr objectHandle);

        [DllImport("gdi32.dll")]
        internal static extern IntPtr CreateCompatibleBitmap(IntPtr dcHandle, int width, int height);

        [DllImport("gdi32.dll")]
        internal static extern bool BitBlt(
            IntPtr destinationDcHandle,
            int destinationX,
            int destinationY,
            int width,
            int height,
            IntPtr sourceDcHandle,
            int sourceX,
            int sourceY,
            CopyPixelOperation rasterOperation);
    }
}