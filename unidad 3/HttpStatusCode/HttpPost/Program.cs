using Newtonsoft.Json;
using System.Text;
using System;

namespace HttpClientes8
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            var person = new Person("John Doe", "gardener");

            var json = JsonConvert.SerializeObject(person);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "https://httpbin.org/post";
            using var client = new HttpClient();

            var response = await client.PostAsync(url, data);

            var result = await response.Content.ReadAsStringAsync();
            Console.WriteLine(result);

         

        }
    }

    public class Person
    {
        public string Name { get; set; }

        public Person(string Name,string Occupation)
        {

        }
    }
}
