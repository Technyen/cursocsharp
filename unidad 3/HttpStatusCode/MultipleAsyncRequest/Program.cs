using System;
using System.Text.RegularExpressions;

namespace HttpClientes7
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var urls = new string[] { "http://webcode.me", "http://example.com",
    "http://httpbin.org", "https://ifconfig.me", "http://termbin.com",
    "https://github.com"
};

            var rx = new Regex(@"<title>\s*(.+?)\s*</title>",
              RegexOptions.Compiled);

            using var client = new HttpClient();

            var tasks = new List<Task<string>>();

            foreach (var url in urls)
            {
                tasks.Add(client.GetStringAsync(url));
            }

            Task.WaitAll(tasks.ToArray());

            var data = new List<string>();

            foreach (var task in tasks)
            {
                data.Add(await task);
            }

            foreach (var content in data)
            {
                var matches = rx.Matches(content);

                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }
            }

        }
    }
}
