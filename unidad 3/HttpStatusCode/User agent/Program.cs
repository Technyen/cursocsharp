using System;

namespace HttpClientes4
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var url = "http://webcode.me/ua.php";

            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "C# program");

            var res = await client.GetStringAsync(url);
            Console.WriteLine(res);

        }
    }
}
