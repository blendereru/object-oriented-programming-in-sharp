using System.Net.Http.Headers;

namespace Abstraction;
public class CloudStorage : IFileStorage
{
    public async Task Save(params FileInfo[] files)
    {
        using (var client = new HttpClient())
        {
            using (var multipartContent = new MultipartFormDataContent())
            {
                foreach (var file in files)
                {
                    using (var fileStream = file.OpenRead())
                    {
                        var fileContent = new StreamContent(fileStream);
                        fileContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                        multipartContent.Add(fileContent, "files", file.Name);
                    }
                }
                var response = await client.PostAsync("https://your-cloud-storage-endpoint.com/upload", multipartContent);
                response.EnsureSuccessStatusCode();
            }
        }
        Console.WriteLine("Files are saved to the cloud storage");
    }
}