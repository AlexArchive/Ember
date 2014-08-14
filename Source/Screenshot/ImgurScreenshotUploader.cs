using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Screenshot
{
    public class ImgurScreenshotUploader : IScreenshotUploader
    {
        private readonly HttpClient client;
        private const string ClientId = "771cb62f3057260";

        public ImgurScreenshotUploader()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://api.imgur.com/3/");
            client.DefaultRequestHeaders.Add(
                "Authorization", "Client-ID " + ClientId);
        }

        public async Task<string> Upload(byte[] screenshot)
        {
            var content = new ByteArrayContent(screenshot);

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