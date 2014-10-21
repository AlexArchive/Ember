using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Ember.Extension;

namespace Ember
{
    [Extension(ExtensionName = "Imgur")]
    public class ImgurClient : IDisposable, IImageUploader
    {
        private readonly HttpClient client;
        private const string ClientId = "771cb62f3057260";

        public ImgurClient()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://api.imgur.com/3/");
            client.DefaultRequestHeaders.Add(
                "Authorization", "Client-ID " + ClientId);
        }

        public async Task<string> UploadImageAsync(byte[] imageData)
        {
            var content = new ByteArrayContent(imageData);

            var response = await client.PostAsync("image", content);
            response.EnsureSuccessStatusCode();
            var responseContent = await response.Content.ReadAsStringAsync();

            var model = new JavaScriptSerializer().Deserialize<dynamic>(responseContent);
            var imageLink = model["data"]["link"];

            return imageLink;
        }

        public void Dispose()
        {
            client.Dispose();
        }
    }
}