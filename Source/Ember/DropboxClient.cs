using System.Threading.Tasks;
using System.Windows.Forms;
using Ember.Extension;

namespace Ember
{
    // This is temporary.
    [Extension(HostName = "Dropbox")]
    public class DropboxClient : IImageUploader
    {
        public async Task<string> UploadImageAsync(byte[] imageData)
        {
            return "http://www.dropbox.com";
        }
    }
}