

namespace Streaming
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var httpClient = new HttpClient();

            var url = "https://cdn.netbsd.org/pub/NetBSD/NetBSD-9.2/images/NetBSD-9.2-amd64-install.img.gz";

            var fname = Path.GetFileName(url);

            var resp = await httpClient.GetAsync(url,
                HttpCompletionOption.ResponseHeadersRead);
            resp.EnsureSuccessStatusCode();

            using Stream ms = await resp.Content.ReadAsStreamAsync();

            using FileStream fs = File.Create(fname);
            await ms.CopyToAsync(fs);

            Console.WriteLine("file downloaded");

        }
    }

}