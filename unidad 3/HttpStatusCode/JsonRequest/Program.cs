using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace JSONRequest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {


            using var client = new HttpClient();

            client.BaseAddress = new Uri("https://api.github.com");
            client.DefaultRequestHeaders.Add("User-Agent", "C# console program");
            client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

            var url = "repos/symfony/symfony/contributors";
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var resp = await response.Content.ReadAsStringAsync();

            List<Contributor> contributors = JsonConvert.DeserializeObject<List<Contributor>>(resp);
            contributors.ForEach(x => Console.WriteLine(x.Login));




        }


    }
    public class Contributor
    {
        public string Login { get; set; }
    public  short Contributions { get; set; }

    }
}