using System.Net;

namespace HttpProxy
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            var port = 7302;
            var proxy = "example.com";
            var url = "http://webcode.me";

            var handler = new HttpClientHandler()
            {
                Proxy = new WebProxy(new Uri($"socks5://{proxy}:{port}")),
                UseProxy = true,
            };

            using var client = new HttpClient(handler);

            var res = await client.GetAsync(url);
            var content = await res.Content.ReadAsStringAsync();

            Console.WriteLine(content);


        }
    }

}