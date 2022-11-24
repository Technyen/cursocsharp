using System;
using System.Text.RegularExpressions;
namespace HttpClientStatus;

class Program
{
 static async Task Main(string[] args)
    {
        //Status code
        using var client = new HttpClient();

        var result = await client.GetAsync("http://webcode.me");

            Console.WriteLine(result.StatusCode);

        //Get request

        var content2 = await client.GetStringAsync("http://webcode.me");

        Console.WriteLine(content2);

        //Head request

        var url = "http://webcode.me";

        var result2 = await client.SendAsync(new HttpRequestMessage(HttpMethod.Head, url));

        Console.WriteLine(result2);

        //User Agent
        client.DefaultRequestHeaders.Add("User - Agent", "C# program");

        var res = await client.GetStringAsync(url);
        Console.WriteLine(res);


        //HttpRequestMessage

        var msg = new HttpRequestMessage(HttpMethod.Get, url);

        msg.Headers.Add("user-agent", "C# Program");

        var res2 = await client.SendAsync(msg);

        var content = await res.Content.ReadAsStringAsync();



    }

}

