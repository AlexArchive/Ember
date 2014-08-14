using System;
using System.Threading.Tasks;

namespace Screenshot
{
    public interface IScreenshotUploader : IDisposable
    {
        Task<string> Upload(byte[] screenshot);
    }
}