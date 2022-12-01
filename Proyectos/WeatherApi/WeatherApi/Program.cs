using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;
using Newtonsoft.Json;



namespace WeatherAp
{
    internal class Program
    {
        
        static async Task Main(string[] args)
        {
            Console.WriteLine("Input the country name");

            var name = Console.ReadLine();

            using var client = new HttpClient();
            var response = await client.GetAsync($"https://restcountries.com/v3.1/name/{name}");

            var content = await response.Content.ReadAsStringAsync();

            var countryResults = JsonConvert.DeserializeObject<List<CountryResult>>(content);

           
            foreach (var item in countryResults[0].Latlng)
            {
                Console.WriteLine(item);
            }
            var myLat = countryResults[0].Latlng[0];
            var myLog = countryResults[0].Latlng[1];
        }
        
}
    public class CountryResult
    {
    
        public List <double> Latlng { get; set; }
    }

}