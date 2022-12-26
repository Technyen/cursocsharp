


using Newtonsoft.Json;
using System.IO;
using System.Xml.Linq;

namespace WeatherAp
{
    internal class Program
    {
       

        static async Task Main(string[] args)
        {
            using var client = new HttpClient();
           
            string folderPath = "C:\\Countries";
            string[] filePaths = Directory.GetFiles(folderPath);
            var tasks = new List<Task<KeyValuePair<string, double>?>>();

            foreach (string filePath in filePaths)
            {
               
                var gettingResult = GetResults(client, filePath);
                tasks.Add(gettingResult);
            }

            var temperatures = await Task.WhenAll(tasks);
            foreach ( var item in temperatures)
            {
                if(item.HasValue)
                {
                    Console.WriteLine($"{item.Value.Key} the weather is {item.Value.Value}");
                }
               
            }

            

        }
        

        private static async Task<KeyValuePair<string, double>?> GetResults(HttpClient client,string filePath)
        {
            

            try
            {
                var stream = await File.ReadAllTextAsync(filePath);
                var country = JsonConvert.DeserializeObject<Country>(stream);

                var locationResponse = await client.GetAsync($"https://restcountries.com/v3.1/name/{country.Name}");
                var locationContent = await locationResponse.Content.ReadAsStringAsync();
                var locationResult = JsonConvert.DeserializeObject<List<CountryResult>>(locationContent);
                var myLat = locationResult[0].Latlng[0];
                var myLog = locationResult[0].Latlng[1];
                var tempResponse = await client.GetAsync($"http://api.weatherapi.com/v1/current.json?key=48a5dc532084458aaed180348221612&q={myLat},{myLog}");
                var tempContent = await tempResponse.Content.ReadAsStringAsync();
                var tempResult = JsonConvert.DeserializeObject<TempResult>(tempContent);
                var myTemp = tempResult.Current.Temp_c;
                var element = new KeyValuePair<string, double>(country.Name, myTemp);
                return element;

            }
            catch (JsonSerializationException)
            {
                var stream = await File.ReadAllTextAsync(filePath);
                var country = JsonConvert.DeserializeObject<Country>(stream);
                Console.WriteLine($"el pais que se intento ejecutar fallo es {country.Name} y el archivo es {filePath} ");
                return null;
            }
            catch(JsonReaderException)
            {
                Console.WriteLine($"el archivo no es la extension correcta {filePath}");
                    return null;
            }
           catch(Exception ex)
            {
                Console.WriteLine("se encontro un error");
            }

            return null;




        }
    }

   

    public class Country
    {
        public string Name { get; set; }
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