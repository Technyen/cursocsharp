

namespace HttpClientes9
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            var url = "https://httpbin.org/post";

            using var client = new HttpClient();

            var data = new Dictionary<string, string>
            {
                {"name", "John Doe"},
                {"occupation", "gardener"}
            };

            var res = await client.PostAsync(url, new FormUrlEncodedContent(data));

            var content = await res.Content.ReadAsStringAsync();
            Console.WriteLine(content);


        }
    }

}