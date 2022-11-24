using System.Net.Http.Headers;
using System.Text;


namespace BasicAuthent

{
internal class Program
{
    static async Task Main(string[] args)
    {

        var userName = "user7";
        var passwd = "passwd";
        var url = "https://httpbin.org/basic-auth/user7/passwd";

        using var client = new HttpClient();

        var authToken = Encoding.ASCII.GetBytes($"{userName}:{passwd}");
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(authToken));

        var result = await client.GetAsync(url);

        var content = await result.Content.ReadAsStringAsync();
        Console.WriteLine(content);

    }
}

}