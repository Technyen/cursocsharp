using System;

namespace HttpClientes2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var client = new HttpClient();

            var content = await client.GetStringAsync("http://webcode.me");

            Console.WriteLine(content);
        }
    }
}