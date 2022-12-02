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
            var myLat = countryResults[0].Latlng[0];
            var myLog = countryResults[0].Latlng[1];

            Console.WriteLine($"your country Latitude :{myLat} \n Longitude: {myLog}");

            var temperature = await client.GetStringAsync($"http://api.weatherapi.com/v1/current.json?key=f4f2b4ef63ef4faa907200629220112&q={myLat},{myLog}");
          
            var tempResult = JsonConvert.DeserializeObject<TempResult>(temperature);
            Console.WriteLine($"the weather is  { tempResult.Current.Temp_c} C");

        }
        
}
    public class CountryResult
    {
    
        public List <double> Latlng { get; set; }
    }
    class TempResult
    {
        public Current Current { get; set; }
    }
    public class Current
    {
        public double Temp_c { get; set; }

        public double Cloud { get; set; }
    }

}