using System;

namespace HttpClientes
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var client = new HttpClient();

            var result = await client.GetAsync("http://webcode.me");

            Console.WriteLine(result.StatusCode);
        }
    }
}