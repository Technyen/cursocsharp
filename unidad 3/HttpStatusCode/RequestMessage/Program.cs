using System;

namespace HttpClientes5
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var url = "http://webcode.me";

            using var client = new HttpClient();

            var msg = new HttpRequestMessage(HttpMethod.Get, url);
            msg.Headers.Add("User-Agent", "C# Program");
            var res = await client.SendAsync(msg);

            var content = await res.Content.ReadAsStringAsync();

            Console.WriteLine(content);

        }
    }
}
