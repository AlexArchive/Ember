using System.Threading.Tasks;

namespace Ember
{
    public interface IImageUploader
    {
        Task<string> UploadImageAsync(byte[] imageData);
    }
}