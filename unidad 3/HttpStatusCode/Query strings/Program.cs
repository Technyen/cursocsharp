using System;

namespace HttpClientes6
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var u = "http://webcode.me/qs.php";

            using var client = new HttpClient();

            var builder = new UriBuilder(u);
            builder.Query = "name=John Doe&occupation=gardener";
            var url = builder.ToString();

            var res = await client.GetAsync(url);

            var content = await res.Content.ReadAsStringAsync();
            Console.WriteLine(content);

        }
    }
}

