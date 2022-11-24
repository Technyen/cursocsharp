using System;

namespace HttpClientes3
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var url = "http://webcode.me";

            using var client = new HttpClient();

            var result = await client.SendAsync(new HttpRequestMessage(HttpMethod.Head, url));

            Console.WriteLine(result);
        }
    }
}