using System.Threading.Tasks;

namespace Ember.Extension
{
    public interface IImageUploader
    {
        /// <summary>
        /// Uploads the given image to a specified image host asynchronously.
        /// </summary>
        /// <param name="imageData">
        /// The binary data that constitutes the image to upload.
        /// </param>
        /// <returns>The address of the uploaded image.</returns>
        Task<string> UploadImageAsync(byte[] imageData);
    }
}